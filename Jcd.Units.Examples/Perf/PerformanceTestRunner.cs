#region

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using Jcd.Units.Examples.Perf.Tests;
using Jcd.Units.Examples.Perf.Tests.Baseline;
using Jcd.Units.Examples.Perf.Tests.TemperatureQuantity;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.Data;
using Jcd.Units.UnitsOfMeasure.SI;

// ReSharper disable HeapView.ObjectAllocation.Possible
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Jcd.Units.Examples.Perf;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class PerformanceTestRunner
{
   private const int Iterations =
#if DEBUG
                     250_000
#else
                     1_250_000
#endif
            ;

   public static readonly PerformanceTestRunner Instance = new ();

   //private List<IPerfTest> _tests = new ();

   public void RunAllTests(bool report = true)
   {
      if (report)
      {
         var sysInfo = SystemInfo.Instance;

         var cpu = sysInfo.CPU;
         Console.WriteLine("CPU Info:");
         Console.WriteLine($"  Name: {cpu.Name}");
         Console.WriteLine($"  Maximum CPU Frequency: {sysInfo.MaximumCPUFrequency:n2}");
         Console.WriteLine($"  Manufacturer: {cpu.Manufacturer}");
         Console.WriteLine($"  Description: {cpu.Description}");
         Console.WriteLine($"  ProcId: {cpu.ProcessorId}");
         Console.WriteLine($"  Socket: {cpu.SocketDesignation}");
         Console.WriteLine($"  Number of Cores: {cpu.NumberOfCores}");
         Console.WriteLine($"  Number of Logical Processors : {cpu.NumberOfLogicalProcessors}");

         Console.WriteLine(
                           $"  L2 Cache Size: {cpu.L2CacheSize.As(StorageUnits.Kilobyte).To(StorageUnits.Mebibyte):n2}"
                          );

         Console.WriteLine(
                           $"  L3 Cache Size: {cpu.L3CacheSize.As(StorageUnits.Kilobyte).To(StorageUnits.Mebibyte):n2}"
                          );

         Console.WriteLine($"  Virtualization Firmware Enabled: {cpu.VirtualizationFirmwareEnabled}");
         Console.WriteLine();
         Console.WriteLine("Scenarios:");
      }

      // TODO: provide a way to let the consumer choose which tests and scenarios to run.
      void DoNothing() { }

      var baselineScenario = new Scenario("Baseline Performance", DoNothing, DoNothing);

      RunTestsInScenario(
                         report
                       , baselineScenario
                       , BaselinePerfTests.All
                        );

      var quantityScenarios = Scenarios.All;

      var quantityTests = PerfTests.All;

      foreach (var scenario in quantityScenarios) RunTestsInScenario(report, scenario, quantityTests);
   }

   public void RunTestsInScenario(bool report, Scenario scenario, IEnumerable<IPerfTest> tests)
   {
      if (report)
      {
         Console.WriteLine($"  - Scenario: {scenario.Description}");
         Console.WriteLine("    Tests:");
      }

      scenario.Setup();

      foreach (var test in tests) RunTest(test, report);

      scenario.Teardown();
   }

   public void RunTest(IPerfTest? test, bool report)
   {
      if (test is null) return;

      if (report) SystemInfo.Instance.RefreshInfo();
      if (report) Console.WriteLine($"      - Name: {test.Description}");
      test.Setup();
      var sw             = Stopwatch.StartNew();
      var operationCount = test.Execute(Iterations);
      sw.Stop();
      var stats = report ? CalculateStats(sw, operationCount) : RunStats.Empty;
      test.Teardown();

      if (!report) return;
      if (operationCount == 0) return;

      Console.WriteLine($"        Average CPU Frequency: {stats.AverageCpuFrequency:n3}");
      Console.WriteLine($"        Iteration Count: {Iterations:n0}");
      Console.WriteLine($"        Operations Per Iteration: {stats.OperationsPerIteration:n0}");
      Console.WriteLine($"        Total Operation Count: {operationCount:n0}");
      Console.WriteLine($"        Total Time Elapsed: {stats.Elapsed:n3}");
      Console.WriteLine($"        Total CPU Cycles: {stats.TotalCpuCycles:n0}");

      Console.WriteLine(
                        $"        Time Elapsed Per Iteration: {stats.ElapsedPerOperation * stats.OperationsPerIteration:n3}"
                       );

      Console.WriteLine(
                        $"        CPU Cycles Per Iteration: {stats.CpuCyclesPerOperation * stats.OperationsPerIteration:n3}"
                       );

      Console.WriteLine($"        Time Elapsed Per Operation: {stats.ElapsedPerOperation:n3}");
      Console.WriteLine($"        CPU Cycles Per Operation: {stats.CpuCyclesPerOperation:n3}");
      Console.WriteLine();
   }

   private static RunStats CalculateStats(Stopwatch stopwatch, int operationCount)
   {
      var cpuF1 = SystemInfo.Instance.CurrentCPUFrequency;
      SystemInfo.Instance.RefreshInfo();
      var cpuF2                                    = SystemInfo.Instance.CurrentCPUFrequency;
      var freq                                     = (cpuF1 + cpuF2) / 2;
      if (freq < 1.As(Frequencies.Gigahertz)) freq = freq.To(Frequencies.Megahertz);
      var duration                                 = stopwatch.Elapsed.As(Durations.Microsecond);
      var durationPer                              = (duration / operationCount).To(Durations.Nanosecond);

      var totalCpuCycles = freq.To(Frequencies.Hertz)
                               .RawValue
                         * duration.To(Durations.Second)
                                   .RawValue;

      var cpuCyclesPer = totalCpuCycles / operationCount;

      return new RunStats(duration, durationPer, totalCpuCycles, cpuCyclesPer, freq, operationCount / Iterations);
   }
}
