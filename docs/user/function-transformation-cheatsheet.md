# Function Transformation Cheatsheet

## Some Quick Facts

- To create a new unit of measure using this library, you need to select an appropriate
  `Coefficient` and `Offset`. These will come from an existing conversion formula.<sup>1,2</sup>
- This library the formula: $f(x) = a⋅(x + c)$; where $a$ and $c$ are the `Coefficient` and `Offset`,
  provided to this library.
- Unless the conversion formula is already expressed in that form, the correct $a$ and $c$ will need to be caluclated
  from an existing conversion formula.
- The conversion formula to calculate $a$ and $c$ from is the _starting formula_.
- Coefficients and constants from the _starting formula_ are written as $a_0$ and $c_0$,
  respectively.

## Coefficient and Constant Calculations

These are given below in the following format:

$f(x) = ... \implies a = ... ; c= ...$

The formulas listed are given in generic form. You'll need to match an existing form, or rework
the formulas you have into one of those listed below:

|              |            |                       |
|--------------|------------|-----------------------|
| $f(x) = ...$ | $\implies$ | $a = ...$   $c = ...$ |

Recall that the standard formula for this library is: $f(x) = a⋅(x + c)$; and that the values for $a$ and $c$
are used in code to define a new unit of measure.

To see mathematics supporting these calculations, please see [Mathematical Derivations](mathematical-derivations)
document.

| Starting Conversion Formula | $\implies$ | $a$ and $c$                         |
|-----------------------------|------------|-------------------------------------|
| $f(x) = a_0⋅x$              | $\implies$ | $a = a_0$   $c=0$                   |
| $f(x) = \frac{x}{a_0}$      | $\implies$ | $a = \frac{1}{a_0}$   $c = 0$       |
| $f(x) = x + c_0$            | $\implies$ | $a = 1$   $c = c_0$                 |
| $f(x) = x - c_0$            | $\implies$ | $a = 1$   $c = -c_0$                |
| $f(x) = a_0⋅(x - c_0)$      | $\implies$ | $a = a_0$   $c = -c_0$              |
| $f(x) = a_0⋅x + c_0$        | $\implies$ | $a = a_0$   $c = \frac{c_0}{a_0}$   |
| $f(x) = c_0 - a_0⋅x$        | $\implies$ | $a = -a_0$   $c = \frac{c_0}{-a_0}$ |
| $f(x) = c_0 - x$            | $\implies$ | $a = -1$   $c = -c_0$               |

## Using $a$ and $c$ In Code

In code you'll create a new `UnitOfMeasure<T>` derived instance passing $a$ in for the `coefficient`
and $c$ for the `offset` parameters.

Example:

The Delise to Celcius conversion is: $f(x) = 100 - \frac{2}{3}⋅x$; where $x$ is in °De

The extracted terms are:

- $a_0 = \frac{2}{3}$
- $c_0 = 100$

Using the table above we see that:

- $a = -a_0 = -\frac{2}{3}$
- $c = \frac{c_0}{-a_0} = \frac{100}{-\frac{2}{3}} = -\frac{100⋅3}{2} = -150$.

That gives us this code:

```csharp
/// <summary>
/// degrees delisle defined such that: SI degrees celsius = (°De + -150) × -2.0/3.0.
/// </summary>
public static readonly Temperature DegreesDelisle = new ("degrees delisle", "°De", SI.Temperatures.DegreesCelsius, coefficient: -2.0 / 3.0, offset: -150, system: "");

```

## Notes

1. The conversion in use must be a simple, single variable, linear function.
2. The function must also convert from the new unit of measure to its base unit.
   That is, the unit of measure its defined in terms of.