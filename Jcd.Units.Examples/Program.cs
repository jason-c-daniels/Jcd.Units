// See https://aka.ms/new-console-template for more information

using Jcd.Units;

using SI=Jcd.Units.SI;
using Imperial=Jcd.Units.Imperial;
using USSurvey=Jcd.Units.USSurvey;
using USCustomary=Jcd.Units.USCustomary;
using Astronomy=Jcd.Units.Astronomy;

Console.WriteLine("Hello, World!");
var oneSec = 1d.As(Durations.Second);
var oneSecInMs = oneSec.To(Durations.Millisecond);

var meterQuantity = 1d.As(SI.Lengths.Meter);
var kmQuantity=meterQuantity.To(SI.Lengths.Kilometer);
var twoM= (meterQuantity + kmQuantity);
var twoMInInches = twoM.To(Imperial.Lengths.Inch); // two meters in inches.
var oneInch = 1.As(Imperial.Lengths.Inch);
var oneInchInTwips = oneInch.To(Imperial.Lengths.Twip);
var oneParsec = 1.As(Astronomy.Lengths.Parsec);
var oneParsecInKm = oneParsec.To(SI.Lengths.Kilometer);
var oneLy = 1.As(Astronomy.Lengths.LightYear);
var oneParsecInLy = oneParsec.To(Astronomy.Lengths.LightYear);
var oneLyInKm = oneLy.To(SI.Lengths.Kilometer);
var oneLyInM = oneLy.To(SI.Lengths.Meter);
var oneLyInKm2 = oneLyInM.To(SI.Lengths.Kilometer);
var oneLyInMm = oneLy.To(SI.Lengths.Millimeter);
var oneUSInch = 1.As(USCustomary.Lengths.Inch);
var oneInchInPt = oneUSInch.To(USCustomary.Lengths.Point);
var oneLink = 1.As(USSurvey.Lengths.Link);
var oneLinkAsInches = oneLink.To(USCustomary.Lengths.Inch);
var oneLinkAsCm = oneLink.To(SI.Lengths.Centimeter);
var oneSurveyFoot = 1.As(USSurvey.Lengths.Foot);
var oneSurveyFootAsCm = oneSurveyFoot.To(SI.Lengths.Centimeter);
var oneSurveyFootAsFoot = oneSurveyFoot.To(USCustomary.Lengths.Foot);
var oneRod = 1.As(USSurvey.Lengths.Rod);
var oneRodInLinks = oneRod.To(USSurvey.Lengths.Link);

var meqkm= meterQuantity == kmQuantity;
var twoMGtMq = twoM > meterQuantity;
var tempC = 0d.As(Temperatures.Celcius);
var tempC1 = 1d.As(Temperatures.Celcius);
var tempC5 = 5d.As(Temperatures.Celcius);
var tempF = tempC.To(Temperatures.Fahrenheit);
var tempF1 = tempC1.To(Temperatures.Fahrenheit);
var tempF5 = tempC5.To(Temperatures.Fahrenheit);
var tempC_2 = tempF.To(Temperatures.Celcius);
var tempK = tempF.To(Temperatures.Kelvin);
var tempK1 = tempF1.To(Temperatures.Kelvin);
var tempK5 = tempF5.To(Temperatures.Kelvin);
var tempR = tempF.To(Temperatures.Rankine);
var tempR1 = tempF1.To(Temperatures.Rankine);
var tempR5 = tempF5.To(Temperatures.Rankine);
var tempN = tempF.To(Temperatures.Newton);
var tempN1 = tempF1.To(Temperatures.Newton);
var tempN5 = tempF5.To(Temperatures.Newton);
var tempRe = tempF.To(Temperatures.Réaumur);
var tempRe1 = tempF1.To(Temperatures.Réaumur);
var tempRe5 = tempF5.To(Temperatures.Réaumur);
var tempRo = tempC.To(Temperatures.Rømer);
var tempRo1 = tempC1.To(Temperatures.Rømer);
var tempRo5 = tempC5.To(Temperatures.Rømer);
var tempDe = tempF.To(Temperatures.Delisle);
var tempDe1 = tempF1.To(Temperatures.Delisle);
var tempDe5 = tempF5.To(Temperatures.Delisle);


int j = 0;
/*
var tempDe = 0d.As(Temperatures.Rømer);
var tempC2 = tempDe.To(Temperatures.Celcius);
var tempC3 = (1+tempDe).To(Temperatures.Celcius);
var tempC4 = (2+tempDe).To(Temperatures.Celcius);
var tempC5 = (3+tempDe).To(Temperatures.Celcius);
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
