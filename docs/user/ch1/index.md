# Chapter 1 - Getting Started

This chapter is for the absolute beginner. If you're brand new to the library, but not to dotnet development skip the
first part.

## Part 1: Installing the Library

Before you can use the library you need to install the _NuGet_ package as a dependency of the project where it will be
used. If you're using an IDE like `JetBrains Rider` or `Visual Studio`, you can install it directly through your IDE.
Alternately you can use one of the three following methods.

**Reminder:** Since this library's version numbering adheres to [Semantic Versioning 2.0](https://semver.org/), Pre-1.0
releases, and versions with a pre-release suffix (-alpha...etc.) have an unstable public API. Expect changes from build
to build and be prepared to have to rework your code when upgrading major versions.

### Using the `dotnet` CLI

1. First ensure the `dotnet` CLI is in your PATH.
2. Then launch your favorite shell such as `powershell` or `bash`.
3. Then execute the following command in the directory containing your project.

```text
dotnet add package Jcd.Units --version <version number goes here>
```

### Using the Package Manager Console

1. Within `Visual Studio`, open the `Package Manager Console`.
2. This can be done from the top menu: `Tools > NuGet Package Manager > Package Manager Console`.
3. Then type the following command into the console.

```powershell
NuGet\Install-Package Jcd.Units -Version <version number goes here>
```

### Directly Editing the `csproj` File

1. First ensure the `dotnet` CLI is in your PATH.
2. In the appropriate `<ItemGroup>` element within your `csproj` file add the following line.

```xml

<PackageReference Include="Jcd.Units" Version="<version number goes here>"/>
```

3. Save your changes to the file.
4. Run a `dotnet restore` from the command prompt in the project or solution directory.

## Part 2: Using the Correct Namespaces

Before you can begin using the various units of measure you need to reference the correct namespaces. Each source code
file that will use `Quantity<TUnit>`, or the global usings file must, at a minimum, contain `Jcd.Units` in the usings
statements block.

For most basic usage scenarios you will probably also need to add one of the subnamespaces in `Jcd.Units.UnitsOfMeasure`
to the usings block.

If you plan on creating your own units of measure based on the built-in unit of measure types provided with this library
you will need to use the `Jcd.Units.UnitTypes` namespace.

There are other subnamespaces within `Jcd.Units` and their use will be discussed
in [Chapter 3 - Advanced Usage](../ch3/index).

### Example 1: Using Only Predefined SI Units of Measure

```csharp
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure.SI;
```

### Example 2: Using Predefined SI Units to Create Custom Units

```csharp
using Jcd.Units;
using Jcd.Units.UnitTypes;
using Jcd.Units.UnitsOfMeasure.SI;
```

Refer to the [API Documentation](../../api/Jcd.Units), which also gives namespace,
or [Index 1 - Built-In Units of Measure](../index1/index) for a list of the built in units.

## Part 3: Using More Than One System of Measure

Nested namespaces don't resolve just by using `Jcd.Units.UnitsOfMeasure`. So, for example, you cannot reference a
centimeter with: `SI.Lengths.Centimeter` by only using the `Jcd.Units.UnitsOfMeasure`. You need to either alias the SI
subnamespace or use it directly and only reference the `Lengths` class.

In some cases using more than one of the subnamespaces will be necessary. For example, converting between SI lengths and
US Customary lengths. However, the naming convention followed for the generated code causes class name clashes. To work
around this you will need to alias the referenced namespace.

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

## Part 4: Using an Existing Unit of Measure

The simplest way to use a unit of measure is to reference it directly from the used namespace(s). The namespaces are
created from system of measure names. And within each namespace exists "enumeration" classes of a sort, where each unit
of measure is defined as a static field.

For example to access and use the definition for a meter you could do the following:

```csharp
using SI = Jcd.Units.UnitsOfMeasure.SI;
var meter = SI.Lengths.Meter; // SI is the system of measure namespace. Lengths is the "enumeration" type. Meter is the unit of measure field.

// ... do something with the meter definition ...
```

## Part 5: Using Units Via the `UnitRegistry` (tightly bound)

At this point all we've done is picked one or two units of measure at a time to use for applications with a very limited
of units of measure being used, this is perfectly acceptable. But What if you need to access the entire catalogue of all
instances of `Length` units, across all systems of measure? Enter the `UnitRegistry`.

The `UnitRegistry` is actually a pair of classes which share a name, one is the generic form which has all operations
bound to a specific unit of measure type. It can only register and provide access to units of a specific type: for
example `Length` units.

The other is not tightly bound to one and only one unit of measure type and allows access to multiple types of units of
measure. They're intimately related and the tightly bound form is used by the loosely bound form in order to both
perform automatically register as well as provide access to the desired unit types. The following two sections cover the
usage of each.

### Accessing Units Via the Tightly Bound `UnitRegistry<TUnit>`

This is the tightly bound form of `UnitRegistry` alluded to above. When using either form you must first ensure that the
units of measure you're interested in have been registered with the registry. This can be done manually with a call
to `Register` or automatically through one of the `AutoRegister` methods. For these examples we'll assume this has
already been done. [Chapter 2](../ch2/index) covers using these methods.

As well it's good to note that both versions of `UnitRegistry` will have access to the unit of measure no matter how
it's registered.

There are two methods of getting to a specific unit of measure.

1. Lookup by name.
2. Lookup by symbol.

In both cases an `ILookup<string,TUnit>` is returned. As you know a lookup returns an enumerable based on the lookup
key. This was chosen due to a very pernicious behavior of people: naming units with different definitions, identically.
For example: US Quart and Imperial quart are different mL.

#### Lookup By Name

The following shows how to look up a unit by name:

```csharp
// The registry is a singleton exposed via a "Default" static field.
// assign it to a variable to keep references to it short.
var reg = UnitRegistry<Length>.Default;

// assign the lookup to a variable to keep references to it short.
var lookup = reg.NameLookup;

// acquire the unit of measure
var m = lookup["meter"].First();
```

#### Lookup By Symbol

The following shows how to look up a unit by symbol:

```csharp
// The registry is a singleton exposed via a "Default" static field.
// assign it to a variable to keep references to it short.
var reg = UnitRegistry<Length>.Default;

// assign the lookup to a variable to keep references to it short.
var lookup = reg.SymbolLookup;

// acquire the unit of measure
var m = lookup["m"].First();
```

### Accessing Units Via the Loosely Bound `UnitRegistry`

This is the loosely bound form of `UnitRegistry` alluded to above. As above when using either form you must first ensure
that the units of measure you're interested in have been registered with the registry. This can be done manually with a
call to `Register` or automatically through one of the `AutoRegister` methods. For these examples we'll assume this has
already been done. [Chapter 2](../ch2/index) covers using these methods.

As well it's good to note that both versions of `UnitRegistry` will have access to the unit of measure no matter how
it's registered.

There are two methods of getting to a specific unit of measure.

1. Lookup by name.
2. Lookup by symbol.

In both cases an `ILookup<string,TUnit>` is returned.<sup>1</sup>

#### Lookup By Name

The following shows how to look up a unit by name:

```csharp
// The registry is a singleton exposed via a "Default" static field.
// assign it to a variable to keep references to it short.
var reg = UnitRegistry.Default;

// assign the lookup to a variable to keep references to it short.
var lookup = reg.GetNameLookup<Length>();

// acquire the unit of measure
var m = lookup["meter"].First();
```

#### Lookup By Symbol

The following shows how to look up a unit by symbol:

```csharp
// The registry is a singleton exposed via a "Default" static field.
// assign it to a variable to keep references to it short.
var reg = UnitRegistry.Default;

// assign the lookup to a variable to keep references to it short.
var lookup = reg.GetSymbolLookup<Length>();

// acquire the unit of measure
var m = lookup["m"].First();
```

## Choosing Your Method of Accessing Builtin Units of Measure

Choosing how you structure your code and access external libraries is an important consideration. Since this library
provides three ways to access units of measure some rules of thumb are in order:

1. Direct namespace-enumeration-field access is suitable for codebases which will use a handful of units of measure,
   most residing in one or two systems of measure.
2. The tightly bound unit of measure registry ()

## End Notes

1. `ILookup<TKey,TValue>` returns an enumerable based on the lookup key. This was chosen due to a very pernicious
   behavior of people: naming units with different definitions, identically. For example: US Quart and Imperial quart
   are different mL.