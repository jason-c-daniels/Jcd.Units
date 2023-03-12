#region

using Hardware.Info;

using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units.Examples.Perf;

public class SystemInfo
{
   private readonly Frequency GHz = Frequencies.Gigahertz;
   private readonly IHardwareInfo HardwareInfo;
   private readonly Frequency MHz = Frequencies.Megahertz;

   private SystemInfo()
   {
      HardwareInfo = new HardwareInfo(false);
      HardwareInfo.RefreshCPUList(false);
      CPU = HardwareInfo.CpuList.First();

      MaximumCPUFrequency = CPU.MaxClockSpeed.As(MHz)
                               .To(GHz);

      RefreshInfo();
   }

   public static SystemInfo Instance { get; } = new ();

   // ReSharper disable once InconsistentNaming
   public CPU CPU { get; private set; }

   // ReSharper disable once InconsistentNaming
   public Quantity<Frequency> MaximumCPUFrequency { get; }

   // ReSharper disable once InconsistentNaming
   public Quantity<Frequency> CurrentCPUFrequency { get; private set; }

   public void RefreshInfo(bool refreshHardwareInfo = false)
   {
      HardwareInfo.RefreshCPUList(false);
      CPU                 = HardwareInfo.CpuList.First();
      CurrentCPUFrequency = GetCurrentClockSpeed(CPU);
   }

   private Quantity<Frequency> GetCurrentClockSpeed(CPU cpu)
      => cpu.CurrentClockSpeed.As(cpu.CurrentClockSpeed > 1000 ? Frequencies.Gigahertz : Frequencies.Hertz);
}
