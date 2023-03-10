#region

using System.Diagnostics;

using Jcd.Units;
using Jcd.Units.DoubleComparison;
using Jcd.Units.Examples;
using Jcd.Units.UnitSelection;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

using Temperatures = Jcd.Units.UnitsOfMeasure.SI.Temperatures;
using US = Jcd.Units.UnitsOfMeasure.USCustomary;

// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable RedundantAssignment
// ReSharper disable SuggestBaseTypeForParameter

// ReSharper disable CommentTypo

// ReSharper disable UnusedVariable
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
// ReSharper disable HeuristicUnreachableCode  
#pragma warning disable CS0162
#pragma warning disable CS0219

#endregion

var foo = Math.Round(5555.0d, 0, MidpointRounding.ToEven);

// define/reference the units in use in this program
var GHz = Frequencies.Gigahertz;
var Hz  = Frequencies.Hertz;

// NB: replace this with the correct GHz for your system.
var CPU_FREQ       = 3.4.As(GHz);
var CPU_FREQ_IN_HZ = CPU_FREQ.To(Hz);

const int ITERATIONS =
#if DEBUG
                  50_000
#else
                  1_000_000
#endif
         ;

var siTemps = Temperatures.BySymbol;
var temps   = Jcd.Units.UnitsOfMeasure.Temperatures.BySymbol;

var K     = siTemps["°K"];
var C     = Temperatures.DegreesCelcius;
var F     = US.Temperatures.DegreesFahrenheit;
var degRa = temps["°R"];
var degN  = temps["°N"];
var ré    = temps["°Ré"];
var rø    = temps["°Rø"];
var de    = temps["°De"];

RunPerformanceTests(false);
RunPerformanceTests();

//TimeConversions(ITERATIONS);
//TimeQuantityComparisonOnSameUnits(ITERATIONS);
return 0;

var km     = Lengths.Kilometer;
var m      = Lengths.Meter;
var cm     = Lengths.Centimeter;
var biInch = Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Inch;
var usInch = US.Lengths.Inch;
var usPt   = US.Lengths.Point;

var durs = Durations.GetAll()
                    .ToDictionary(x => x.Symbol);

var ms          = durs["ms"];
var oneTick     = 1.As(Durations.Tick);
var oneTickInNs = oneTick.To(Durations.Nanosecond);

var timeOfDay = DateTime.UtcNow.TimeOfDay.As(Durations.PlanckTime);
var s         = timeOfDay.ToString("E5");
var durr      = 1.As(Durations.SeptillionYears);

var sdurr = durr.To(Durations.PlanckTime)
                .ToString("e3");

var tP  = Durations.PlanckTime;
var sec = Durations.Second;

// create a duration of 1 second and express in planck-time units.
var tP1s = 1.As(sec)
            .To(tP);

var tPs_string = $"{tP1s:n0}";

var l1 = 1.As(Lengths.Kilometer);
var l2 = l1 * 2;

// Create an area from two lengths.
// var sqkm=Areas.SquareKilometer;
// var A  = (l1.To(km) * l2.To(km)).RawValue.As(sqkm);
var twip       = Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Twip;
var parsec     = Jcd.Units.UnitsOfMeasure.Astronomical.Lengths.Parsec;
var ly         = Jcd.Units.UnitsOfMeasure.Astronomical.Lengths.LightYear;
var mm         = Lengths.Millimeter;
var surveyLink = Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Link;
var surveyRod  = Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Rod;

var Kilokelvin                          = new Temperature("Kilokelvin", "°kK", K, 1000.0);
var Millikelvin                         = new Temperature("millikelvin", "°mK", K, 1.0 / 1000.0);
var OneMillikelvinT                     = 1.As(Millikelvin);
var OneKilokelvinT                      = 1.As(Kilokelvin);
var OneThousandKelvinT                  = OneKilokelvinT.To(K);
var OneThousandKelvinAndOneMillikelvinT = OneThousandKelvinT + OneMillikelvinT;
var R2                                  = new Temperature("R2", "°Rø", C, 0.525, -7.5);
var zeroC                               = 0d.As(C);
var zcinR2                              = zeroC.To(R2);

var dnc = R2.FromBaseUnitValue(K.Offset);

var allDurations = Durations.GetAll()
                            .ToList();

Console.WriteLine("Hello, World!");
var answer = usInch == biInch ? "Yes!" : "Nope!?!";
Console.WriteLine($"Is one US {usInch} the same as one British Imperial {biInch}? {answer}");

var oneSec     = 1d.As(sec);
var oneSecInMs = oneSec.To(ms);

var meterQuantity   = 1d.As(m);
var kmQuantity      = meterQuantity.To(km);
var twoM            = meterQuantity + kmQuantity;
var twoMInInches    = twoM.To(biInch); // two meters in inches.
var oneInch         = 1.As(biInch);
var oneInchInTwips  = oneInch.To(twip);
var oneParsec       = 1.As(parsec);
var oneParsecInKm   = oneParsec.To(km);
var oneLy           = 1.As(ly);
var oneParsecInLy   = oneParsec.To(ly);
var oneLyInKm       = oneLy.To(km);
var oneLyInM        = oneLy.To(m);
var oneLyInKm2      = oneLyInM.To(km);
var oneLyInMm       = oneLy.To(mm);
var oneUSInch       = 1.As(biInch);
var oneInchInPt     = oneUSInch.To(usPt);
var oneLink         = 1.As(surveyLink);
var oneLinkAsInches = oneLink.To(biInch);
var oneLinkAsCm     = oneLink.To(cm);

//var oneSurveyFoot = 1.As(USSurvey.Lengths.Foot);
//var oneSurveyFootAsCm = oneSurveyFoot.To(SI.Lengths.Centimeter);
//var oneSurveyFootAsFoot = oneSurveyFoot.To(US.Lengths.Foot);

var oneRod        = 1.As(surveyRod);
var oneRodInLinks = oneRod.To(surveyLink);

var meqkm    = meterQuantity == kmQuantity;
var twoMGtMq = twoM          > meterQuantity;
var tempC    = 0d.As(C);
var tempC1   = 1d.As(C);
var tempC5   = 5d.As(C);
var tempF    = tempC.To(F);
var tempF1   = tempC1.To(F);
var tempF5   = tempC5.To(F);
var tempC_2  = tempF.To(C);
var tempK    = tempF.To(K);
var tempK1   = tempF1.To(K);
var tempK5   = tempF5.To(K);

var tempR   = tempF.To(degRa);
var tempR1  = tempF1.To(degRa);
var tempR5  = tempF5.To(degRa);
var tempN   = tempF.To(degN);
var tempN1  = tempF1.To(degN);
var tempN5  = tempF5.To(degN);
var tempRe  = tempF.To(ré);
var tempRe1 = tempF1.To(ré);
var tempRe5 = tempF5.To(ré);
var tempRo  = tempC.To(rø);
var tempRo1 = tempC1.To(rø);
var tempRo5 = tempC5.To(rø);
var tempDe  = tempF.To(de);
var tempDe1 = tempF1.To(de);
var tempDe5 = tempF5.To(de);

var j = 0;
/*
var tempDe = 0d.As(Temperatures.DegreesRømer);
var tempC2 = tempDe.To(Temperatures.DegreesCelcius);
var tempC3 = (1+tempDe).To(Temperatures.DegreesCelcius);
var tempC4 = (2+tempDe).To(Temperatures.DegreesCelcius);
var tempC5 = (3+tempDe).To(Temperatures.DegreesCelcius);
*/
// The following won't compile. You can't add differing unit of measure types.
// var fpFMeter = meterQuantity + tempF;

// This is because we restrict arithmetic on quantities to like units of measure (Length to Length...etc.)
// To convert to another unit type, convert the raw value to the target type.
// for example creating a velocity from a Duration and a distance might look like:
// var length=10d.As(SI.Lengths.Meter);
// var duration=1d.As(Duration.Second);
// var velocity=(length.RawValue*duration.RawValue).As(Velocity.MetersPerSecond);
// while multiplying two quantities of the same unit type will work it yields another quantity with the same
// unit type, scaled to the larger unit of measure.
// To convert the result to another type of unit, such as length to an area 
// you will need to convert the resulting raw value to the desired unit of measure.
// an area might look like:
// var areaSqM=(length*length).RawValue.As(Area.SI.SquareMeter);
// NOTE: You're responsible for selecting the correct unit of measure.
// if, in the example case of the length, you wanted square feet you'd first convert to feet, then multiply, then convert to square feet
var i = 0;

var T1 = new Temperature("degrees Celcius*", "deg. C*");
var T2 = new Temperature("degrees Fahrenheit*", "deg. F*", T1, 5.0 / 9.0, -32);
var x  = -T2.Offset;

var T3 = new Temperature(
                         "degrees C+32"
                       , "C+32"
                       , T2
                       , 1.0 / T2.Coefficient
                       , -((x - x * T2.Coefficient) / T2.Coefficient)
                        );

var T4    = new Temperature("degrees Celcius (also)", "C*", T3, 1.0, 32);
var qt1   = 1d.As(T1);
var qt2   = qt1.To(T2);
var qt3_1 = qt2.To(T3);
var qt3_2 = qt1.To(T3);

Console.WriteLine();
Console.WriteLine("Unit of Measure comparisons with the default (Bitwise) double comparer");
Console.WriteLine($"{T1} < {T2} : {T1  < T2}");
Console.WriteLine($"{T1} > {T2} : {T1  > T2}");
Console.WriteLine($"{T1} < {T3} : {T1  < T3}");
Console.WriteLine($"{T1} > {T3} : {T1  > T3}");
Console.WriteLine($"{T1} == {T4} : {T1 == T4}");

var xx = 99;

// now try overriding unit of measure comparers.
Temperature.DefaultDoubleComparer = new Int64ConversionComparer(100); // preserve 2 decimal digits.
Console.WriteLine();

Console.WriteLine(
                  "Unit of Measure comparisons after : Temperature.DefaultDoubleComparer = new Int64ConversionComparer(100);"
                 );

Console.WriteLine($"{T1} < {T2} : {T1  < T2}");
Console.WriteLine($"{T1} > {T2} : {T1  > T2}");
Console.WriteLine($"{T1} < {T3} : {T1  < T3}");
Console.WriteLine($"{T1} > {T3} : {T1  > T3}");
Console.WriteLine($"{T1} == {T4} : {T1 == T4}");
/*
var Kilokelvin = new Temperature("Kilokelvin", "°kK", SI.Temperatures.DegreesKelvin, 1000.0);//SI.Temperatures.DegreesCelcius,1000,SI.Temperatures.DegreesKelvin.Offset);
var Millikelvin = new Temperature("millikelvin", "°mK", SI.Temperatures.DegreesCelcius, 1.0 / 1000.0);//,SI.Temperatures.DegreesKelvin.Offset);
var OneMillikelvinT = 1.As(Millikelvin);
var OneKilokelvinT = 1.As(Kilokelvin);
var OneThousandKelvinT = OneKilokelvinT.To(SI.Temperatures.DegreesKelvin);
var OneThousandKelvinAndOneMillikelvinT = OneThousandKelvinT + OneMillikelvinT;
*/

Console.WriteLine();
Console.WriteLine("Compare temp quantities with default comparer");
Console.WriteLine($"{OneKilokelvinT:n3} == {OneThousandKelvinT:n3} : {OneKilokelvinT == OneThousandKelvinT}");

Console.WriteLine(
                  $"{OneThousandKelvinT:n3} == {OneThousandKelvinAndOneMillikelvinT:n3} : {OneThousandKelvinT == OneThousandKelvinAndOneMillikelvinT}"
                 );

Console.WriteLine(
                  $"{OneKilokelvinT:n3} == {OneThousandKelvinAndOneMillikelvinT:n3} : {OneKilokelvinT == OneThousandKelvinAndOneMillikelvinT}"
                 );

Quantity<Temperature>.DefaultDoubleComparer =
         new Int64ConversionComparer(100); // compare equivalence up to two digits after the decimal point.

Console.WriteLine();

Console.WriteLine(
                  "Compare temp quantities after Quantity<Temperature>.DefaultDoubleComparer = new Int64ConversionComparer(100); (equal to 2 decimal places once in a common unit representation)"
                 );

Console.WriteLine($"{OneKilokelvinT:n3} == {OneThousandKelvinT:n3} : {OneKilokelvinT == OneThousandKelvinT}");

Console.WriteLine(
                  $"{OneThousandKelvinT:n3} == {OneThousandKelvinAndOneMillikelvinT:n3} : {OneThousandKelvinT == OneThousandKelvinAndOneMillikelvinT}"
                 );

Console.WriteLine(
                  $"{OneKilokelvinT:n3} == {OneThousandKelvinAndOneMillikelvinT:n3} : {OneKilokelvinT == OneThousandKelvinAndOneMillikelvinT}"
                 );

return 0;

i = 100;

void TimeConversions(int iterations, bool report = true)
{
   var          q1    = 100.As(C);
   var          q2    = q1.To(F);
   var          q3    = q2.To(degRa);
   var          sw    = new Stopwatch();
   const double coeff = 2.0;
   sw.Start();

   // ReSharper disable once VariableHidesOuterVariable
   for (var i = 0; i < iterations; i++)
   {
      q1 = i.As(C);
      q2 = q1.To(F);
      q3 = q2.To(degRa);
   }

   sw.Stop();

   var count  = coeff * iterations;
   var dur    = sw.Elapsed.As(Durations.Microsecond);
   var durPer = (dur / count).To(Durations.Nanosecond);

   var totalCpuCycles = CPU_FREQ_IN_HZ.RawValue
                      * dur.To(Durations.Second)
                           .RawValue;

   var cpuCyclesPer = totalCpuCycles / count;

   if (!report) return;

   Console.WriteLine($"{count:n0} conversions took {dur:n3} total time on a {CPU_FREQ} processor.");
   Console.WriteLine($"{durPer:n3} elapsed per conversion.");
   Console.WriteLine($"{totalCpuCycles:n1} total CPU cycles.");
   Console.WriteLine($"{cpuCyclesPer:n1} CPU cycles per conversion.");
   var q4 = q3.To(ré); // this prevents the compiler from optimizing away the second assignment
}

void TimeQuantityMath(int iterations, bool report = true)
{
   var          q1    = 100.As(C);
   var          q2    = q1.To(F);
   var          q3    = q2.To(degRa);
   var          sw    = new Stopwatch();
   const double coeff = 2.0;
   sw.Start();

   // ReSharper disable once VariableHidesOuterVariable
   for (var i = 0; i < iterations; i++)
   {
      q1 = i.As(C);
      q2 = 3   * q1 - 7;
      q3 = 4.0 / q2 + 111;
   }

   sw.Stop();

   var count  = coeff * iterations;
   var dur    = sw.Elapsed.As(Durations.Microsecond);
   var durPer = (dur / count).To(Durations.Nanosecond);

   var totalCpuCycles = CPU_FREQ_IN_HZ.RawValue
                      * dur.To(Durations.Second)
                           .RawValue;

   var cpuCyclesPer = totalCpuCycles / count;

   if (!report) return;

   Console.WriteLine($"{count:n0} simple Quantity<T> equations took {dur:n3} total time on a {CPU_FREQ} processor.");
   Console.WriteLine($"{durPer:n3} elapsed per equation.");
   Console.WriteLine($"{totalCpuCycles:n1} total CPU cycles.");
   Console.WriteLine($"{cpuCyclesPer:n1} CPU cycles per equation.");
   var q4 = q3.To(ré); // this prevents the compiler from optimizing away the second equation
}

void TimeQuantityComparisonOnDifferentUnits(int iterations, bool report = true)
{
   var q1 = 100.As(C);
   var q2 = q1.To(F);
   var q3 = q2.To(degRa) + 1;
   var r1 = false;
   var r2 = false;

   var          sw    = new Stopwatch();
   const double coeff = 2.0;
   sw.Start();

   // ReSharper disable once VariableHidesOuterVariable
   for (var i = 0; i < iterations; i++)
   {
      r1 = q1 == q2;
      r2 = q2 == q3;
   }

   sw.Stop();
   var count  = coeff * iterations;
   var dur    = sw.Elapsed.As(Durations.Microsecond);
   var durPer = (dur / count).To(Durations.Nanosecond);

   var totalCpuCycles = CPU_FREQ_IN_HZ.RawValue
                      * dur.To(Durations.Second)
                           .RawValue;

   var cpuCyclesPer = totalCpuCycles / count;

   if (!report) return;

   Console.WriteLine(
                     $"{count:n0} simple Quantity<T> comparison on different units took {dur:n3} total time on a {CPU_FREQ} processor."
                    );

   Console.WriteLine($"{durPer:n3} elapsed per comparison on different units.");
   Console.WriteLine($"{totalCpuCycles:n1} total CPU cycles.");
   Console.WriteLine($"{cpuCyclesPer:n1} CPU cycles per comparison on different units.");
   var q4 = q3.To(ré); // this prevents the compiler from optimizing away the second equation
   var r3 = r2 ^ r1;
}

void TimeQuantityComparisonOnSameUnits(int iterations, bool report = true)
{
   var q1 = 100.As(C);
   var q2 = q1 + 0;
   var q3 = q2 + 1;
   var r1 = false;
   var r2 = false;

   var          sw    = new Stopwatch();
   const double coeff = 2.0;
   sw.Start();

   // ReSharper disable once VariableHidesOuterVariable
   for (var i = 0; i < iterations; i++)
   {
      r1 = q1 == q2;
      r2 = q2 == q3;
   }

   sw.Stop();
   var count  = coeff * iterations;
   var dur    = sw.Elapsed.As(Durations.Microsecond);
   var durPer = (dur / count).To(Durations.Nanosecond);

   var totalCpuCycles = CPU_FREQ_IN_HZ.RawValue
                      * dur.To(Durations.Second)
                           .RawValue;

   var cpuCyclesPer = totalCpuCycles / count;

   if (!report) return;

   Console.WriteLine(
                     $"{count:n0} simple Quantity<T> comparison on like units took {dur:n3} total time on a {CPU_FREQ} processor."
                    );

   Console.WriteLine($"{durPer:n3} elapsed per comparison on like units.");
   Console.WriteLine($"{totalCpuCycles:n1} total CPU cycles.");
   Console.WriteLine($"{cpuCyclesPer:n1} CPU cycles per comparison on like units.");
   var q4 = q3.To(ré); // this prevents the compiler from optimizing away the second equation
   var r3 = r2 ^ r1;
}

void ConfigureSettings
         (
         IValueComparer<double>? globalUnitofMeasureComparer = null
       , IValueComparer<double>? globalQuantityComparer = null
       , IUnitSelectionStrategy? globalMathUnitSelectionStrategy = null
       , IUnitSelectionStrategy? globalComparisonUnitSelectionStrategy = null
       , IValueComparer<double>? quantityDoubleComparer = null
       , SelectLargerUnit? quantityMathUnitSelector = null
       , SelectLargerUnit? quantityComparisonUnitSelector = null
         )
{
   GlobalDoubleComparisonStrategy.UnitOfMeasure = globalUnitofMeasureComparer ?? GlobalDoubleComparisonStrategy.Default;
   GlobalDoubleComparisonStrategy.Quantity = globalQuantityComparer ?? GlobalDoubleComparisonStrategy.Default;
   GlobalUnitSelectionStrategy.ForArithmetic = globalMathUnitSelectionStrategy ?? GlobalUnitSelectionStrategy.Default;

   GlobalUnitSelectionStrategy.ForComparison =
            globalComparisonUnitSelectionStrategy ?? GlobalUnitSelectionStrategy.Default;

   Quantity<Temperature>.DefaultDoubleComparer  = quantityDoubleComparer;
   Quantity<Temperature>.ArithmeticUnitSelector = quantityMathUnitSelector;
   Quantity<Temperature>.ComparisonUnitSelector = quantityComparisonUnitSelector;
}

void RunPerfSet(string message, bool report = true)
{
   if (report)
   {
      Console.WriteLine();
      Console.WriteLine("--------------------------------------------------------------------------");
      Console.WriteLine($"{message}");
      Console.WriteLine("--------------------------------------------------------------------------");
      Console.WriteLine();
   }

   TimeConversions(ITERATIONS, report);
   if (report) Console.WriteLine();
   TimeQuantityMath(ITERATIONS, report);
   if (report) Console.WriteLine();
   TimeQuantityComparisonOnDifferentUnits(ITERATIONS, report);
   if (report) Console.WriteLine();
   TimeQuantityComparisonOnSameUnits(ITERATIONS, report);
}

void RunPerformanceTests(bool report = true)
{
   ConfigureSettings();
   RunPerfSet("Performance with default comparers and unit selection strategies", report);

   ConfigureSettings(BuiltInRoundingComparer.FifteenDecimalPlaces, BuiltInRoundingComparer.FifteenDecimalPlaces);
   RunPerfSet("Performance with rounding comparer to 15 decimal places and default unit selection strategies", report);

   ConfigureSettings(BuiltInRoundingComparer.FiveDecimalPlaces, BuiltInRoundingComparer.FiveDecimalPlaces);
   RunPerfSet("Performance with rounding comparer to 5 decimal places and default unit selection strategies", report);

   ConfigureSettings(
                     BuiltInRoundingComparer.FiveDecimalPlaces
                   , BuiltInRoundingComparer.FiveDecimalPlaces
                   , SelectLeftUnit.Instance
                   , SelectLeftUnit.Instance
                    );

   RunPerfSet(
              "Performance with rounding comparer to 5 decimal places and select left unit selection strategies"
            , report
             );

   ConfigureSettings(
                     BuiltInRoundingComparer.FifteenDecimalPlaces
                   , BuiltInRoundingComparer.FifteenDecimalPlaces
                   , SelectLeftUnit.Instance
                   , SelectLeftUnit.Instance
                    );

   RunPerfSet(
              "Performance with rounding comparer to 15 decimal places and select left unit selection strategies"
            , report
             );

   ConfigureSettings(null, null, SelectLeftUnit.Instance, SelectLeftUnit.Instance);
   RunPerfSet("Performance with binary comparer and select left unit selection strategies", report);
}
