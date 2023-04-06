# Jcd.Units

A *dotnet 6* library that provides a set of utility classes and compile time safety
for managing unit of measure bound quantities.

For example, you cannot meaningfully compare a `Duration` and an `Length`. The types
in this library prevents direct comparisons on this sort.

## Feature Overview

### Core Types

The two core classes provided are `UnitOfMeasure<TDerived>` and `Quantity<TUnit>`.
In both cases `TUnit` is the type derived off of `UnitOfMeasure`.
This idiomatic method of coding, in part, provides the foundation for the arithmetic
and relational type safety. The rest is defined in `Quantity<TUnit>`, which can perform
arithmetic operations on itself and against `doubles`. A `Quantity<TUnit>` is always the result.

### Ease of Use Methods and Extensions

A number of extension methods have been provided to easily convert integral data
and common types into instances of `Quantity<TUnit>`. With the exception of `ToTimeStamp`
(Which only operates on a `Duration`) they are all called `As`.

As well, `Quantity<TUnit>` provides a unit of measure conversion called `To`
which converts units within the same domain (e.g. Durations).

For example, the code below creates a `Duration` quantity of 1 second.

```csharp
using Jcd.Units.UnitsOfMeasure;

// capture the units for readability
var second = Durations.Second;
var ms = Durations.Millisecond;
var min = Durations.Minute;

var oneSecond = 1.As(second); // oneSecond is of type Quantity<Duration> with a RawValue of 1.00d, and a Unit of Second 
var oneSInMs = oneSecond.To(ms); // oneSInMs is of type Quantity<Duration> with a RawValue of 1,000.00d and a Unit of Millisecond

var ts = oneSInMs.ToTimeStamp(); // convert the milliseconds to a TimeStamp
var minDur = ts.As(min); // convert the TimeStamp to its minutes representation.

```

## Feature Limitations

1. This library does not auto-select equivalent derived units from multiplication or
   division at runtime. So dividing a `Length` by a `Duration` does not yield a velocity.
2. In fact, without explicitly casting one of the operands to a `double`
   you cannot perform arithmetic operations on quantities of disparate unit
   of measure types.
   - The first reason is that not all units have defined conversions of that sort.
   - The second is that for **complex** and compound units, an algebraic solver would
     be required. If you need that to happen automatically, without writing any code,
     use MathCAD or Wolfram. This library only supports **simple** unit of measure
     handling. You will still have to put _some_ effort in to get the desired results.
     However, my hope is that in using this library, it's a lower effort versus standard
     `doubles`.
3. Given the nature of the global hooks used to perform configurable unit of measure
   selection and double comparisons, the performance is anywhere from 1 to 2 orders
   of magnitude slower than using plain doubles. _(Plain `double` arithmetic sees a throughput
   of effectively 0.8-1.1 CPU cycles per operation on _,-, and *. Quantity<TUnit> sees a
   throughput of 10 to 115 CPU cycles per operation depending on data types, operators
   and configuration.)_ NOTE: On a CPU running at 3.54GHz dividing one `Quantity<TUnit>` by another,
   the slowest operation, is roughly 40ns. _This is still suitable for many applications,
   just **not** high-throughput number crunching._
4. **The types used for globally registering, and using, unit selectors and double comparers
   are not thread safe. Do not change these settings while calculations are running. The
   behavior is undefined and unpredictable. This is true regardless if changed from
   a background thread, or the current thread (via an async Task, or mid algorithm)**

## Examples

### Basic Conversions, No Comparisons.

In the simplest use case you may not want to do more
than convert among existing units. The following example
demonstrates that.

```csharp
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using SI=Jcd.Units.UnitsOfMeasure.SI;
using US=Jcd.Units.UnitsOfMeasure.USCustomary;

// for brevity sake we capture the unit of measures in variables
// and use those instead of referring to the entire namespace and
// containing enumeration-like class.
var C = SI.Temperatures.DegreesCelsius;
var F = US.Temperatures.DegreesFahrenheit;

var tF = 32.As(F);
var tC = tF.To(C);

Console.WriteLine($"{tF:n2} is {tC:n2}"); // outputs: 32.00 °F is 0.00 °C

var K   = SI.Temperatures.DegreesKelvin;
var tF2 = tF + 75;
var tK  = (tF + 75).To(K);

Console.WriteLine($"{tF2:n3} is {tK:n3}"); // outputs: 107.000 °F is 314.817 °K

var pT = Durations.PlanckTime;
var ms = Durations.Millisecond;

var oneMs            = 1.As(ms);
var oneMsInPlankTime = oneMs.To(pT);

Console.WriteLine($"{oneMs:n2} is {oneMsInPlankTime:e5}"); // outputs: 1.00 ms is 1.85487e+040 tP

var twip = US.Lengths.Twip;
var mm   = SI.Lengths.Millimeter;

var twentyTwips     = 20.As(twip);
var twentyTwipsInMm = twentyTwips.To(mm);

Console.WriteLine($"{twentyTwips:n2} is {twentyTwipsInMm:n2}"); // outputs: 20.00 twip is 0.35 mm

// The following line will not compile.
// if (twentyTwips == oneMs) { /* that's just weird. */ }
```

### Comparisons.

By default, this library uses the compiler provided IEEE754 double comparison.
It's wrapped in a class that implements an interface that allows us to replace
the comparison strategy at run time.

**NOTE: As mentioned above you are responsible for ensuring your code
doesn't replace comparison strategies while quantity an unit of measure
comparisons and calculations are underway. Those methods are not
thread safe.**

For example the following code will execute and give the standard (sometimes unexpected results)
from built-in double comparison.

```csharp
var exactLength = (111.1).As(Lengths.Meter);
var userProvidedLength = GetValueFromUser(Lengths.Meter); // fake method.

// do some math on it. Increase by 1/3rd.
var mutatedLength = userProvidedLength * (1+1d/3d);

if (mutatedLength == exactLength)
{
    // This will not be reached even if the user input 83.325 (the magic number, you must use a different comparison)
}
```

However, if during application startup we registered a better comparison strategy,
such as a rounding comparer, it will work as intended.

```csharp
using Jcd.Units.DoubleComparison;

// adding this one line and the using statement above, now fixes the comparison issue.
GlobalDoubleComparisonStrategy.Quantity = BuiltInRoundingComparer.FifteenDecimalPlaces;

var exactLength = (111.1).As(Lengths.Meter);
var userProvidedLength = GetValueFromUser(Lengths.Meter); // fake method.

// do some math on it. Increase by 1/3rd.
var mutatedLength = userProvidedLength * (1+1d/3d);

if (mutatedLength == exactLength)
{
    // Because of the registered comparer, this code will be reached when the user inputs 83.325 (the magic number)
}
```

### Conversion Among Unit Types

Given the limitations and context sensitivity of when one discards or changes the unit of measure
applied to a number, four are three things to be aware of.

1. Changing unit of measure is the same as `.RawValue.As(NewUnit)`.
2. No reference to the old unit of measure is maintained.
3. Derive units of measure still abide by the `Coeffifient` + `Offset` conversions with the same unit type.
4. When calculating something like Area, ensure the quantities are in the requisite units of measure
   as needed by the destination unit of measure. So for calculating a rate as m/s, first convert the
   Length quantity to meters, and the Duration quantity to seconds, then perform the division, then
   apply the new unit of measure with a call to `.ReplaceUnit(unit)` or cast to `double` then a call to `.As()`.

#### Example: Computing Area, Volume, and Rate

```csharp
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.SI;

/// capture the units for readability.
var m = Lengths.Meter;
var dm = Lengths.Decimeter;
var cm = Lengths.Centimeter;
var ms = Durations.Millisecond;
var s = Durations.Second;

var l1 = 10.As(cm);
var l2 = 20.As(dm);
var l3 = 30.As(m);

// DON'T do this if you need to convert to area.
var area = (l1*l2).ReplaceUnit(Areas.SquareCentimeter); // Which unit was actually selected? The default is the larger unit!

// Convert l2 to cm instead.
var area2 = (l1 * l2.To(cm)).ReplaceUnit(Areas.SquareCentimeter); 


```

## Badges

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Units)](https://github.com/jason-c-daniels/Jcd.Units/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-units)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Units)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.Units)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Units?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Units)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Units?logo=nuget)](https://www.nuget.org/packages/Jcd.Units)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](docs/api/Jcd.Units.md)
[![API Docs](https://img.shields.io/badge/Read-The%20User%20Manual-green?style=for-the-badge)](docs/user/index.md)