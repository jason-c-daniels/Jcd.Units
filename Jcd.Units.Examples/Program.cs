// See https://aka.ms/new-console-template for more information

using System;
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.Astronomical;
using Jcd.Units.UnitTypes;
using SI=Jcd.Units.UnitsOfMeasure.SI;
using USCustomary=Jcd.Units.UnitsOfMeasure.USCustomary;
using USSurvey=Jcd.Units.UnitsOfMeasure.USSurvey;
using Imperial=Jcd.Units.UnitsOfMeasure.Imperial;

var Kilokelvin = new Temperature("Kilokelvin", "°kK", SI.Temperatures.DegreesKelvin, 1000.0);//SI.Temperatures.DegreesCelcius,1000,SI.Temperatures.DegreesKelvin.Offset);
var Millikelvin = new Temperature("millikelvin", "°mK", SI.Temperatures.DegreesKelvin, 1.0 / 1000.0);//,SI.Temperatures.DegreesKelvin.Offset);
var OneMillikelvinT = 1.As(Millikelvin);
var OneKilokelvinT = 1.As(Kilokelvin);
var OneThousandKelvinT = OneKilokelvinT.To(SI.Temperatures.DegreesKelvin);
var OneThousandKelvinAndOneMillikelvinT = OneThousandKelvinT + OneMillikelvinT;
var R2 = new Temperature("R2", "°Rø",SI.Temperatures.DegreesCelcius,21.0/40.0,-7.5);
var zeroC = 0d.As(SI.Temperatures.DegreesCelcius);
var zcinR2 = zeroC.To(R2);



var allDurations = Durations.GetAll().ToList();
Console.WriteLine("Hello, World!");
var oneSec = 1d.As(Durations.Second);
var oneSecInMs = oneSec.To(Durations.Millisecond);

var meterQuantity = 1d.As(SI.Lengths.Meter);
var kmQuantity=meterQuantity.To(SI.Lengths.Kilometer);
var twoM= (meterQuantity + kmQuantity);
var twoMInInches = twoM.To(Imperial.Lengths.Inch); // two meters in inches.
var oneInch = 1.As(Imperial.Lengths.Inch);
var oneInchInTwips = oneInch.To(Imperial.Lengths.Twip);
var oneParsec = 1.As(Lengths.Parsec);
var oneParsecInKm = oneParsec.To(SI.Lengths.Kilometer);
var oneLy = 1.As(Lengths.LightYear);
var oneParsecInLy = oneParsec.To(Lengths.LightYear);
var oneLyInKm = oneLy.To(SI.Lengths.Kilometer);
var oneLyInM = oneLy.To(SI.Lengths.Meter);
var oneLyInKm2 = oneLyInM.To(SI.Lengths.Kilometer);
var oneLyInMm = oneLy.To(SI.Lengths.Millimeter);
var oneUSInch = 1.As(USCustomary.Lengths.Inch);
var oneInchInPt = oneUSInch.To(USCustomary.Lengths.Point);
var oneLink = 1.As(USSurvey.Lengths.Link);
var oneLinkAsInches = oneLink.To(USCustomary.Lengths.Inch);
var oneLinkAsCm = oneLink.To(SI.Lengths.Centimeter);
//var oneSurveyFoot = 1.As(Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Foot);
//var oneSurveyFootAsCm = oneSurveyFoot.To(SI.Lengths.Centimeter);
//var oneSurveyFootAsFoot = oneSurveyFoot.To(Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.Foot);
var oneRod = 1.As(USSurvey.Lengths.Rod);
var oneRodInLinks = oneRod.To(USSurvey.Lengths.Link);

var meqkm= meterQuantity == kmQuantity;
var twoMGtMq = twoM > meterQuantity;
var tempC = 0d.As(SI.Temperatures.DegreesCelcius);
var tempC1 = 1d.As(SI.Temperatures.DegreesCelcius);
var tempC5 = 5d.As(SI.Temperatures.DegreesCelcius);
var tempF = tempC.To(USCustomary.Temperatures.DegreesFahrenheit);
var tempF1 = tempC1.To(USCustomary.Temperatures.DegreesFahrenheit);
var tempF5 = tempC5.To(USCustomary.Temperatures.DegreesFahrenheit);
var tempC_2 = tempF.To(SI.Temperatures.DegreesCelcius);
var tempK = tempF.To(SI.Temperatures.DegreesKelvin);
var tempK1 = tempF1.To(SI.Temperatures.DegreesKelvin);
var tempK5 = tempF5.To(SI.Temperatures.DegreesKelvin);
var tempR = tempF.To(Temperatures.DegreesRankine);
var tempR1 = tempF1.To(Temperatures.DegreesRankine);
var tempR5 = tempF5.To(Temperatures.DegreesRankine);
var tempN = tempF.To(Temperatures.DegreesNewton);
var tempN1 = tempF1.To(Temperatures.DegreesNewton);
var tempN5 = tempF5.To(Temperatures.DegreesNewton);
var tempRe = tempF.To(Temperatures.DegreesRéaumur);
var tempRe1 = tempF1.To(Temperatures.DegreesRéaumur);
var tempRe5 = tempF5.To(Temperatures.DegreesRéaumur);
var tempRo = tempC.To(Temperatures.DegreesRømer);
var tempRo1 = tempC1.To(Temperatures.DegreesRømer);
var tempRo5 = tempC5.To(Temperatures.DegreesRømer);
var tempDe = tempF.To(Temperatures.DegreesDelisle);
var tempDe1 = tempF1.To(Temperatures.DegreesDelisle);
var tempDe5 = tempF5.To(Temperatures.DegreesDelisle);

int j = 0;
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

var T1 = new Temperature("degrees Celcius*","deg. C*",1,0);
var T2 = new Temperature("degrees Fahrenheit*","deg. F*",T1,5.0/9.0,-32);
var x = -T2.Offset;
var T3 = new Temperature("degrees C+32", "C+32", T2, 1.0/T2.Coefficient, -((x-x*T2.Coefficient)/T2.Coefficient));
var T4 = new Temperature("degrees Celcius (also)", "C*", T3, 1.0,32);
var qt1 = 1d.As(T1);
var qt2 = qt1.To(T2);
var qt3_1 = qt2.To(T3);
var qt3_2 = qt1.To(T3);

Console.WriteLine();
Console.WriteLine("Unit of Measure comparisons with the default (Bitwise) double comparer");
Console.WriteLine($"{T1} < {T2} : {T1 < T2}");
Console.WriteLine($"{T1} > {T2} : {T1 > T2}");
Console.WriteLine($"{T1} < {T3} : {T1 < T3}");
Console.WriteLine($"{T1} > {T3} : {T1 > T3}");
Console.WriteLine($"{T1} == {T4} : {T1 == T4}");


int xx = 99;
// now try overriding unit of measure comparers.
Temperature.DefaultDoubleComparer = new Int64ConversionComparer(100); // preserve 2 decimal digits.
Console.WriteLine();
Console.WriteLine("Unit of Measure comparisons after : Temperature.DefaultDoubleComparer = new Int64ConversionComparer(100);");
Console.WriteLine($"{T1} < {T2} : {T1 < T2}");
Console.WriteLine($"{T1} > {T2} : {T1 > T2}");
Console.WriteLine($"{T1} < {T3} : {T1 < T3}");
Console.WriteLine($"{T1} > {T3} : {T1 > T3}");
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
Console.WriteLine($"{OneKilokelvinT} == {OneThousandKelvinT} : {OneKilokelvinT == OneThousandKelvinT}");
Console.WriteLine($"{OneThousandKelvinT} == {OneThousandKelvinAndOneMillikelvinT} : {OneThousandKelvinT == OneThousandKelvinAndOneMillikelvinT}");
Console.WriteLine($"{OneKilokelvinT} == {OneThousandKelvinAndOneMillikelvinT} : {OneKilokelvinT == OneThousandKelvinAndOneMillikelvinT}");

Quantity<Temperature>.DefaultDoubleComparer = new Int64ConversionComparer(100);

Console.WriteLine();
Console.WriteLine("Compare temp quantities after Quantity<Temperature>.DefaultDoubleComparer = new Int64ConversionComparer(100);");
Console.WriteLine($"{OneKilokelvinT} == {OneThousandKelvinT} : {OneKilokelvinT == OneThousandKelvinT}");
Console.WriteLine($"{OneThousandKelvinT} == {OneThousandKelvinAndOneMillikelvinT} : {OneThousandKelvinT == OneThousandKelvinAndOneMillikelvinT}");
Console.WriteLine($"{OneKilokelvinT} == {OneThousandKelvinAndOneMillikelvinT} : {OneKilokelvinT == OneThousandKelvinAndOneMillikelvinT}");


i = 100;

class Int64ConversionComparer : IValueComparer<double>
{
    /// <summary>
    /// The amount to multiple the doubles by before conversion and comparison.
    /// </summary>
    public int Factor { get; }
    public Int64ConversionComparer(int factor=1)
    {
        Factor = factor;
    }
    
    public int Compare(double x, double y)
    {
        var xi64 = ToInt64(x);
        var yi64 = ToInt64(y);
        return xi64.CompareTo(yi64);
    }

    public bool Equals(double x, double y)
    {
        return Compare(x, y) == 0;
    }

    long ToInt64(double dbl) => Convert.ToInt64(dbl*Factor);
    
    public int GetHashCode(double val)
    {
        var vi64 = ToInt64(val);
        return vi64.GetHashCode();
    }
}