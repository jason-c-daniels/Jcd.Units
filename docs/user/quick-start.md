# Quick Start

## Installing
- dotnet CLI
  ```ps
  dotnet add package Jcd.Units --version <version number goes here>
  ```
- Package Manager Console
  ```csharp
  NuGet\Install-Package Jcd.Units -Version <version number goes here>
  ```
- csproj PackageReference
  ```xml
  <PackageReference Include="Jcd.Units" Version="<version number goes here>" />
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

- Globally register a unit of measure selection strategy for arthmetic.
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

## Namespace Aliasing

As it turns out, the nested namespaces don't resolve just by using `Jcd.Units.UnitsOfMeasure`. So you can't reference a centimeter with: `SI.Lengths.Centimeter` without first aliasing the namespace.

To aid you, here's a full list of usings and aliases I like to use in order to mitigate this limitation of C#:

```csharp
using Jcd.Units.UnitsOfMeasure;
using Astronomical = Jcd.Units.UnitsOfMeasure.Astronomical;
using Data = Jcd.Units.UnitsOfMeasure.Data;
using Imperial = Jcd.Units.UnitsOfMeasure.Imperial;
using SI = Jcd.Units.UnitsOfMeasure.SI;
using TheoreticalPhysics = Jcd.Units.UnitsOfMeasure.TheoreticalPhysics;
using USCustomary = Jcd.Units.UnitsOfMeasure.USCustomary;
using USSurvey = Jcd.Units.UnitsOfMeasure.USSurvey;
```
