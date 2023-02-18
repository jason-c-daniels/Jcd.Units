// See https://aka.ms/new-console-template for more information

using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using SI=Jcd.Units.UnitsOfMeasure.SI;
using USCustomary=Jcd.Units.UnitsOfMeasure.USCustomary;
using USSurvey=Jcd.Units.UnitsOfMeasure.USSurvey;
using Jcd.Units.UnitTypes;

var allDurations = Durations.GetAll().ToList();
Console.WriteLine("Hello, World!");
var oneSec = 1d.As(Durations.Second);
var oneSecInMs = oneSec.To(Durations.Millisecond);

var meterQuantity = 1d.As(SI.Lengths.Meter);
var kmQuantity=meterQuantity.To(SI.Lengths.Kilometer);
var twoM= (meterQuantity + kmQuantity);
var twoMInInches = twoM.To(Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Inch); // two meters in inches.
var oneInch = 1.As(Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Inch);
var oneInchInTwips = oneInch.To(Jcd.Units.UnitsOfMeasure.Imperial.Lengths.Twip);
var oneParsec = 1.As(Jcd.Units.UnitsOfMeasure.Astronomy.Lengths.Parsec);
var oneParsecInKm = oneParsec.To(SI.Lengths.Kilometer);
var oneLy = 1.As(Jcd.Units.UnitsOfMeasure.Astronomy.Lengths.LightYear);
var oneParsecInLy = oneParsec.To(Jcd.Units.UnitsOfMeasure.Astronomy.Lengths.LightYear);
var oneLyInKm = oneLy.To(SI.Lengths.Kilometer);
var oneLyInM = oneLy.To(SI.Lengths.Meter);
var oneLyInKm2 = oneLyInM.To(SI.Lengths.Kilometer);
var oneLyInMm = oneLy.To(SI.Lengths.Millimeter);
var oneUSInch = 1.As(Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.Inch);
var oneInchInPt = oneUSInch.To(Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.Point);
var oneLink = 1.As(Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Link);
var oneLinkAsInches = oneLink.To(Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.Inch);
var oneLinkAsCm = oneLink.To(SI.Lengths.Centimeter);
//var oneSurveyFoot = 1.As(Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Foot);
//var oneSurveyFootAsCm = oneSurveyFoot.To(SI.Lengths.Centimeter);
//var oneSurveyFootAsFoot = oneSurveyFoot.To(Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.Foot);
var oneRod = 1.As(Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Rod);
var oneRodInLinks = oneRod.To(Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.Link);

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
