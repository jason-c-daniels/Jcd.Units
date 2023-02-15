// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Text;
using Jcd.Units;


CountBits(1);
CountBits(uint.MaxValue);
CountBits(ulong.MaxValue);
CountBits(new BigInteger(5.39*Math.Pow(10,44)));

Console.WriteLine("Hello, World!");
var oneSec = 1d.As(Duration.Second);
var oneSecInMs = oneSec.To(Duration.Millisecond);

var meterQuantity = 1d.As(Length.SI.Meter);
var kmQuantity=meterQuantity.To(Length.SI.Kilometer);
var twoM= (meterQuantity + kmQuantity);
var twoMInInches = twoM.To(Length.Imperial.Inch); // two meters in inches.
var oneInch = 1.As(Length.Imperial.Inch);
var oneInchInTwips = oneInch.To(Length.Imperial.Twip);
var oneParsec = 1.As(Length.Astronomy.Parsec);
var oneParsecInKm = oneParsec.To(Length.SI.Kilometer);
var oneLy = 1.As(Length.Astronomy.LightYear);
var oneParsecInLy = oneParsec.To(Length.Astronomy.LightYear);
var oneLyInKm = oneLy.To(Length.SI.Kilometer);
var oneLyInM = oneLy.To(Length.SI.Meter);
var oneLyInKm2 = oneLyInM.To(Length.SI.Kilometer);
var oneLyInMm = oneLy.To(Length.SI.Millimeter);
var oneUSInch = 1.As(Length.USCustomary.Inch);
var oneInchInPt = oneUSInch.To(Length.USCustomary.Point);
var oneLink = 1.As(Length.USSurvey.Link);
var oneLinkAsInches = oneLink.To(Length.USCustomary.Inch);
var oneLinkAsCm = oneLink.To(Length.SI.Centimeter);
var oneSurveyFoot = 1.As(Length.USSurvey.Foot);
var oneSurveyFootAsCm = oneSurveyFoot.To(Length.SI.Centimeter);
var oneSurveyFootAsFoot = oneSurveyFoot.To(Length.USCustomary.Foot);
var oneRod = 1.As(Length.USSurvey.Rod);
var oneRodInLinks = oneRod.To(Length.USSurvey.Link);

var meqkm= meterQuantity == kmQuantity;
var twoMGtMq = twoM > meterQuantity;
var tempC = 0d.As(Temperature.Celcius);
var tempC1 = 1d.As(Temperature.Celcius);
var tempC5 = 5d.As(Temperature.Celcius);
var tempF = tempC.To(Temperature.Fahrenheit);
var tempF1 = tempC1.To(Temperature.Fahrenheit);
var tempF5 = tempC5.To(Temperature.Fahrenheit);
var tempC_2 = tempF.To(Temperature.Celcius);
var tempK = tempF.To(Temperature.Kelvin);
var tempK1 = tempF1.To(Temperature.Kelvin);
var tempK5 = tempF5.To(Temperature.Kelvin);
var tempR = tempF.To(Temperature.Rankine);
var tempR1 = tempF1.To(Temperature.Rankine);
var tempR5 = tempF5.To(Temperature.Rankine);
var tempN = tempF.To(Temperature.Newton);
var tempN1 = tempF1.To(Temperature.Newton);
var tempN5 = tempF5.To(Temperature.Newton);
var tempRe = tempF.To(Temperature.Réaumur);
var tempRe1 = tempF1.To(Temperature.Réaumur);
var tempRe5 = tempF5.To(Temperature.Réaumur);
var tempRo = tempC.To(Temperature.Rømer);
var tempRo1 = tempC1.To(Temperature.Rømer);
var tempRo5 = tempC5.To(Temperature.Rømer);
var tempDe = tempF.To(Temperature.Delisle);
var tempDe1 = tempF1.To(Temperature.Delisle);
var tempDe5 = tempF5.To(Temperature.Delisle);


int j = 0;
/*
var tempDe = 0d.As(Temperature.Rømer);
var tempC2 = tempDe.To(Temperature.Celcius);
var tempC3 = (1+tempDe).To(Temperature.Celcius);
var tempC4 = (2+tempDe).To(Temperature.Celcius);
var tempC5 = (3+tempDe).To(Temperature.Celcius);
*/
// The following won't compile. You can't add differing unit of measure types.
// var fpFMeter = meterQuantity + tempF;

// This is because we restrict arithmetic on quantities to like units of measure (Length to Length...etc.)
// To convert to another unit type, convert the raw value to the target type.
// for example creating a velocity from a Duration and a distance might look like:
// var length=10d.As(Length.SI.Meter);
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

void CountBits(BigInteger bigInteger)
{
    Console.WriteLine($"{bigInteger} is {bigInteger.GetBitLength()} bits long.");
}
