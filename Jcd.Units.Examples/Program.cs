#region

using Jcd.Units;
using Jcd.Units.Examples;
using Jcd.Units.Examples.Perf;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

using Temperatures = Jcd.Units.UnitsOfMeasure.SI.Temperatures;
using US = Jcd.Units.UnitsOfMeasure.USCustomary;

// ReSharper disable HeapView.ObjectAllocation
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

#if DEBUG
const int ITERATIONS = 100_000;
#else
const int ITERATIONS = 1_000_000;
#endif

var tC  = new Temperature("C", "C");
var tt2 = new Temperature("T2", "T2", tC, 10, 5);
var tt3 = new Temperature("F", "F", tC, 5d / 9d, -32);
var tK  = new Temperature("K", "K", tC, 1, -273.15);
var tkK = new Temperature("kK", "kK", tK, 1000d);
var tde = new Temperature("de", "de", tC, -2d / 3d, -150);

var qtt1         = 200.As(tC);
var qtt1As2      = qtt1.To(tt2);
var qtt1As3      = qtt1.To(tt3);
var qtt1As4      = qtt1.To(tK);
var qkK          = 1.As(tkK);
var qkKInK       = qkK.To(tK);
var oneThousandC = 1000.As(tC);
var oneKCinK     = oneThousandC.To(tK);

var sysInfo = SystemInfo.Instance;

var cpuFreq   = sysInfo.CurrentCPUFrequency;
var siTemps   = Temperatures.BySymbol;
var temps     = Jcd.Units.UnitsOfMeasure.Temperatures.BySymbol;
var siMasses  = Masses.BySymbol;
var uscMasses = US.Masses.BySymbol;

var K     = siTemps["°K"];
var C     = Temperatures.DegreesCelcius;
var F     = US.Temperatures.DegreesFahrenheit;
var degRa = temps["°R"];
var degN  = temps["°N"];
var ré    = temps["°Ré"];
var rø    = temps["°Rø"];
var de    = temps["°De"];
var t1    = 10.As(C);

var tenDe    = 10.As(de);
var tenDeInR = tenDe.To(degRa);

var kg = siMasses["kg"];
var g  = siMasses["g"];
var dr = uscMasses["dr"];
var gr = uscMasses["gr"];
var oz = uscMasses["oz"];
var lb = uscMasses["lb"];

var oneKg         = 1.As(kg);
var oneKgInGrams  = oneKg.To(g);
var oneKgInPounds = oneKg.To(lb);
var skinInLb      = $"{oneKgInPounds:n10}";

var perfRunner = PerformanceTestRunner.Instance;

// var ε₀ = 1;
// execute all of the tests without reporting results to get the code JITed.
// this yield best case performance. Will need to add an option to ensure its fully JITed
for (var zx = 0; zx < 2; zx++)
   perfRunner.RunAllTests(false);

perfRunner.RunAllTests();

return 0;

var km     = Lengths.Kilometer;
var m      = Lengths.Meter;
var cm     = Lengths.Centimeter;
var biInch = Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Inch;
var usInch = US.Lengths.Inch;
var usPt   = US.Lengths.Point;

var durs = Durations.GetAll()
                    .ToDictionary(x => x.Symbol);

var ms = durs["ms"];

var onemeter = 1.As(m);
var onems    = 1.As(ms);

// var rate     = (onemeter / (double)onems.To(Durations.Second)).As(Velocities.MetersPerSecond);

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
// var A  = (l1.To(km) * l2.To(km)).As(sqkm);
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

var dnc = R2.FromFundamentalUnitValue(K.Offset);

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
