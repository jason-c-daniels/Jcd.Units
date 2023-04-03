# Chapter 1 - Getting Started

## Installing the Library

Before you can use the library you need to install the _NuGet_ package as a 
dependency of the project where it will be used. If you're using an IDE like 
`JetBrains Rider` or `Visual Studio`, you can install it directly through your
 IDE. Alternately you can use one of the three following methods.

### Using the `dotnet` CLI

1. First ensure the `dotnet` CLI is in your PATH.
2. Then launch your favorite shell such as `powershell` or `bash`.
3. Then execute the following command in the directory containing your project.

    ```bash
    dotnet add package Jcd.Units --version {version number goes here}
    ```

### Using the Package Manager Console

1. Within `Visual Studio`, open the `Package Manager Console`. 
2. This can be done from the top menu: `Tools > NuGet Package Manager > Package Manager Console`.
3. Then type the following command into the console.
   ```ps
   NuGet\Install-Package Jcd.Units -Version {version number goes here}
   ```

### Directly Editing the `csproj` File

1. First ensure the `dotnet` CLI is in your PATH.
2. In the appropriate `<ItemGroup>` element within your `csproj` file add the following line.
   ```xml
   <PackageReference Include="Jcd.Units" Version="{version number goes here}" />
   ```
3. Save your changes to the file.
4. Run a `dotnet restore` from the command prompt in the project or solution directory.

## Using the Correct Namespaces

Before you can begin using the various units of measure you need to reference the correct 
namespaces. Each source code file that will use `Quantity<TUnit>`, or the global usings file
must, at a minimum, contain `Jcd.Units` in the usings statements block.

If you plan on creating your own units of measure based on the built-in unit of measure types 
provided with this library you will need to use the `Jcd.Units.UnitTypes` namespace.

You will probably also need to add one of the `UnitsOfMeasure` subnamespaces to the usings 
block as well.

### Example 1: Using Only Predefined SI Units of Measure

```csharp
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure.SI;
```

### Example 2: Using Predefined Units of Measure for Creating Custom Units

```csharp
using Jcd.Units;
using Jcd.Units.UnitTypes;
using Jcd.Units.UnitsOfMeasure.SI;
```

Refer to the [API Documentation](../../api/Jcd.Units.md) for a list of the built in units
of measure and which namespaces they belong to.

## Using More Than One System of Measure

As it turns out, the nested namespaces don't resolve just by using `Jcd.Units.UnitsOfMeasure`. 
So, for example, you can't reference a centimeter with: `SI.Lengths.Centimeter` by only using 
the `Jcd.Units.UnitsOfMeasure`. You need to either alias the SI subnamespace or use it directly.

In some cases using more than one of the subnamespaces will be necessary. For example, converting
between SI lengths and US Customary lengths. However, the naming convention followed for the 
generated code causes class name clashes. To work around this you will need to alias the referenced
namespace.

To aid in this task, here's a full list of usings with example aliases you can use.

```csharp
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure; // includes units for uncategorized (i.e. no associated system of measure)
                                // items like degrees Rankine, Angles, and simple counts.
using Astronomical = Jcd.Units.UnitsOfMeasure.Astronomical; // Various SI derived units used in astronomy.
using Data = Jcd.Units.UnitsOfMeasure.Data;                 // Various units used in measuring data and data transfer rates.
using Imperial = Jcd.Units.UnitsOfMeasure.Imperial;         // British Imperial units.
using SI = Jcd.Units.UnitsOfMeasure.SI;                     // SI and various Metric units.
using TheoreticalPhysics = Jcd.Units.UnitsOfMeasure.TheoreticalPhysics; // Some units used used in theoretical physics
using USCustomary = Jcd.Units.UnitsOfMeasure.USCustomary;   // US Customary units (i.e. foot, mile, pound...etc.)
using USSurvey = Jcd.Units.UnitsOfMeasure.USSurvey;         // US Survey units. (e.g. Link, Rod, Chain... etc.)
```