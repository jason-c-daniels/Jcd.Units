# Quick Start

## Installing

- dotnet CLI
  ```text
  dotnet add package Jcd.Units --version <version number goes here>
  ```
- Package Manager Console
  ```powershell
  NuGet\Install-Package Jcd.Units -Version <version number goes here>
  ```
- csproj PackageReference
  ```xml
  <PackageReference Include="Jcd.Units" Version="<version number goes here>" />
  ```

## Using The Correct Namespaces

- Use one of the `Jcd.Units.UnitsOfMeasure` namespaces to use predefined units of measure.

  ```csharp
  // Use just SI units.
  using Jcd.Units;
  using Jcd.Units.UnitsOfMeasure.SI;

  ```

- Alias namespaces to use more than one system of measure.

  Nested namespaces don't resolve just by using `Jcd.Units.UnitsOfMeasure`. So, for example,
  you can't reference a centimeter with: `SI.Lengths.Centimeter` by only using the `Jcd.Units.UnitsOfMeasure`.
  You need to either alias the SI subnamespace or use it directly and only reference the `Lengths` class.

  To aid in this task, here's a list of usings with example aliases you can use:

  ```csharp
  using Jcd.Units;
  using Jcd.Units.UnitsOfMeasure;
  using Astronomical = Jcd.Units.UnitsOfMeasure.Astronomical;
  using Data = Jcd.Units.UnitsOfMeasure.Data;
  using Imperial = Jcd.Units.UnitsOfMeasure.Imperial;
  using SI = Jcd.Units.UnitsOfMeasure.SI;
  using TheoreticalPhysics = Jcd.Units.UnitsOfMeasure.TheoreticalPhysics;
  using USCustomary = Jcd.Units.UnitsOfMeasure.USCustomary;
  using USSurvey = Jcd.Units.UnitsOfMeasure.USSurvey;

  // use them in code
  var meter=1.As(SI.Lengths.Meter);
  var foot=1.As(USCustomary.Lengths.Foot);
  ```

## Specific Usages

- Create a quantity from a specific pre-defined unit of measure:
  ```csharp
  var tenMeters = 10.As(Lengths.Meter)
  ```
- Create an area from multiplying two lengths in different units:

  ```csharp
  var inch = USCustomary.Lengths.Inch;
  var cm = SI.Lengths.Centimeter;
  var m = SI.Lengths.Meter;
  var sqm = SI.Areas.SquareMeter;
  var inches = 1000.As(inch);
  var centimeters= inches.To(cm);

  // All three of the below methods are identical and correct.

  // Call ReplaceUnit
  var area = (inches*centimeters).To(m).ReplaceUnit(sqm);

  // via a cast.
  var area = ((double)(inches*centimeters).To(m)).As(sqm);

  // via a .RawValue.
  var area = (inches*centimeters).To(m).RawValue.As(sqm);
  ```

- Automaticaly register all units defined as static fields or properties across all assemblies:
  ```csharp
  UnitRegistry.Default.AutoregisterAllUnits();
  ```
- Automatically register all units from a specific assembly:
  ```csharp
  UnitRegistry.Default.AutoregisterAllUnitsFrom(typeof(CustomUnitType).Assembly);
  ```
- Manually register a single custom Length unit (picoInch) with the global registry:
  ```csharp
  UnitRegistry.Register(picoInch);
  ```
- Use a unit from the unit registry
  ```csharp
  var inch=UnitRegistry<Length>.BySymbol["in"];
  var inches = 3.As(inch);
  ```
- Globally register a `DoubleComparer` set to ten decimal places for all `Quantity` comparisons.
  ```csharp
  GlobalDoubleComparisonStrategy.Quantity = BuiltInRoundingComparer.TenDecimalPlaces;
  ```
- Globally register a unit of measure selection strategy for comparisons

  ```csharp
  // use a predefined singleton that always returns the left unit. The right side is converted to these units before comparison. This affects all units types.
  GlobalUnitSelectionStrategy.ForComparison = SelectLeftUnit.Instance;
  ```

- Globally register a unit of measure selection strategy for arthimetic operations.
  ```csharp
  // use a predefined singleton that always returns the left unit. The right side is converted to these units before an arithmetic operation is performed. This affects all units types.
  GlobalUnitSelectionStrategy.ForComparison = SelectLeftUnit.Instance;
  ```
- Create a custom unit of measure type

  ```csharp
  public record MyUnitOfMeasure : UnitOfMeasure<MyUnitOfMeasure>
  {
     public MyUnitOfMeasure
        (
        string name
        , string symbol
        , MyUnitOfMeasure? baseUnit = null
        , double coefficient = 1.0
        , double offset = 0
        , IValueComparer<double>? comparer = null
        , string system = ""
        )
        : base(name, symbol, baseUnit, coefficient, offset, comparer, system) { }
  }
  ```

- Create discoverable instances of a custom unit of measure.

  ```csharp
  public static class MyUnitOfMeasureSpecificUnits
  {
    public static MyUnitOfMeasure Unit1 = new ("Unit1", "u1");

    // ten times larger than Unit1
    public static MyUnitOfMeasure Unit2 = new ("Unit2", "u2",Unit1,10);

    // Definitionally this is a synonym for Unit1
    public static MyUnitOfMeasure OneTenthOfUnit2 = new ("OneTenthOfUnit2", "u2/10",Unit2,0.1);
  }
  ```
