# Introduction

## About This Library

As already indicated in [README.md](../../../README.md): `Jcd.Units` "is a *dotnet 6* 
library that provides a set of utility classes and compile time safety for managing 
unit of measure bound quantities." 

In practical terms, this means that this library requires _dotnet 6.0_ or later and
provides a set of tightly coupled types: `Quantity<TUnit>`, the abstract record `UnitOfMeasure<TUnit>`,
and many implementations of `UnitOfMeasure`. It also provides several extensions methods
to help with creating `Quantity` instances bound to a specific type of `UnitOfMeasure`.
It's through this type-specific binding (via generics) that compile time safety for
arithmetic and comparison operations is achieved.

This library also provides ways of registering and looking up `UnitOfMeasure` instances,
both by name and by symbol/abbreviation. Additionally, various trigonometric functions
are implemented in the `MathQ` class, which leverage these conversions and bindings.
And finally some facilities to control how comparisons occur are built in and automatically
used by calls to `Quantity<TUnit>.CompareTo`.

## Intended Audience

The intended audience for this library, and this manual, are software engineers who need or want to simplify some of the concerns surrounding unit of measure conversions, especially when dealing with non-SI/Metric units. For example converting from degrees Rankine (`°K = °R × 5/9`) to degrees Fahrenheit (`°C = (°F - 32) × 5/9`) or US Customary quarts (`946.352946 mL`) to Imperial quarts (`1136.5225 mL`).

## Assumptions About The Reader

This manual assumes that you are already familiar with units of measure,
and their basic usage. It also assumes that you have at least, on occasion,
performed a conversion by hand, be it the decimal point shifting involved in
convertic Metric lengths, or the slightly more involved matter of converting
between Fahrenheit and Celsius.

Additionally it assumes you are familiar with the basic `dotnet` command-line
usage, C#, and basic algebra. All code examples are given in C#. And as appropriate
the underlying math pertinent to the conversion will be provided. One exception
is the [Mathematical Derivations For Selecting A Coefficient and Offset](../mathematical-derivations.md) 
document. It only discusses the mathematics involved in how certain constant 
conversions were arrived at. As such, you'll need familiarity the process of
creating equivalent functions.

Finally, [Chapter 4](../ch4/index.md) assumes you understand the fundamentals
of multi-threading, software performance, and IEEE754 double precision floating
point numbers. It details various considerations and limitations of this library
with respect to those concepts.

