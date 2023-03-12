# Jcd.Units

A *dotnet 6* library that provides a set of utility classes and compile time safety
for managing unit of measure bound quantities.

For example, you cannot meaningfully compare a Duration and an Length. The library
prevents this.

## Before you begin coding

1. If you didn't push to github as part of the project creation, you'll need to do so before setting up the AppVeyor and
   codefactor.io links
2. Setup the [AppVeyor project](https://ci.appveyor.com/projects) and replace TODO_YOUR_PROJECT_SLUG_HERE, in this file,
   with the project slug.

* The project slug can be found in the URL of the project after creation or on the Settings/General tab.
* On the Settings/General tab
   - Set your build version (typically to 0.0.{build} for a new project.)
   - Turn on AssemblyInfo patching.
   - Turn on .NET Core project files patching.
* On the Settings/Environment tab, select the Ubuntu build worker image to ensure unit tests run on Linux.
* On the Settings/Build tab
   - Set "Configuration" to "Release"
   - Turn on "Package NuGet projects."
* On the Settings/Deployment tab
   - Set up a NuGet provider pointed to MyGet: https://www.myget.org/F/jason-c-daniels/api/v2/package
   - Set your API key/personal access token. You can get it from
     your [MyGet Access Tokens](https://www.myget.org/profile/Me#!/AccessTokens)
   - Turn on "Deploy from branch" with the branch set to "main"

3. Setup the [codefactor.io project](https://www.codefactor.io/dashboard).

* Click the "+ Add" button on the [dashboard](https://www.codefactor.io/dashboard)
* Select Jcd.Units from the list.
* Click "Import" at the bottom of the screen.

4. Review various generated non-code files to ensure you have customized the content to this project's
   needs. *The list is relative to the repository root directory.*

* [.github/ISSUE_TEMPLATE/bug_report.md](.github/ISSUE_TEMPLATE/bug_report.md)
* [.github/ISSUE_TEMPLATE/feature_request.md](.github/ISSUE_TEMPLATE/feature_request.md)
* [.github/ISSUE_TEMPLATE/technical_task.md](.github/ISSUE_TEMPLATE/technical_task.md)
* [.github/ISSUE_TEMPLATE/user_story.md](.github/ISSUE_TEMPLATE/user_story.md)
* [.github/FUNDING.yml](.github/FUNDING.yml) - Remove this if you don't want to solicit funding for your works. (
  Currently only has Patreon and Ko-Fi entries)
* [LICENSE](LICENSE)
* [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md)
* [CONTRIBUTING.md](CONTRIBUTING.md)
* [PULL_REQUEST_TEMPLATE.md](PULL_REQUEST_TEMPLATE.md)

5. Delete this section of this file and replace it with something meaningful.

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
var C = SI.Temperatures.DegreesCelcius;
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
var exactLength = 111.1.As(Lengths.Meter);
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

var exactLength = 111.1.As(Lengths.Meter);
var userProvidedLength = GetValueFromUser(Lengths.Meter); // fake method.

// do some math on it. Increase by 1/3rd.
var mutatedLength = userProvidedLength * (1+1d/3d);

if (mutatedLength == exactLength)
{
    // Because of the registered comparer, this code will be reached when the user inputs 83.325 (the magic number)
}
```

## Badges

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Units)](https://github.com/jason-c-daniels/Jcd.Units/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/TODO_YOUR_PROJECT_SLUG_HERE)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Units)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.Units)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Units?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Units)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Units?logo=nuget)](https://www.nuget.org/packages/Jcd.Units)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Units/blob/main/docs/api/Jcd.Units.md)
[![API Docs](https://img.shields.io/badge/Read-The%20End%20User%20Documentation-green?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Units/blob/main/docs/index.md)