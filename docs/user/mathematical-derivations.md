# Mathematical Derivations

Within this file you'll find the mathematical derivations used to transform various unit of measure transformations into the library's standard form.

## The Unit Conversion Formula

The library's formula for unit conversions is essentially:
`BaseUnitValue = (DerivedUnit + Offset) × Coefficient`

In strictly mathematical terms this is:

`f(x) = (x + c) ⋅ a` <sup>1</sup>

Where:
- `f(x)` is the base unit. (This is the function that converts **to** the base unit from the derived unit.)
- `x` is the derived unit value.
- `a` is the coefficient.
- `c` is the offset.

Both `a` and `c` are constants.

Functions which don't already match this representation must be reworked so that an appropriate `a` and `c` can be selected to yield an equivalent function.

### Remember!

When reading below keep the following substitutions in mind:

- `f(x)` is the same as `BaseUnit` above.
- `x` is the same as `DerivedUnit` above.
- `c` is the same as `Offset` above.
- `a` is the same as `Coefficient` above.

## Simple Coefficient Formulas

Formulas only using coefficient are already in a compatible form. They're typically written as follows:

`f(x) = a ⋅ x`

This is the same as:

`f(x) = a ⋅ (x + 0)`

This makes `0` the offset (`c`) and the formula's original coefficient is used for `a`.

## Simple Offset Formulas

Formulas only using an offset are already in a compatible form. They're typically written as follows:

`f(x) = x + c` 

This is the same as: 

`f(x) = 1 ⋅ (x + c)`

This makes `1` the coefficient (`a`) and the original formula's offset is `c`.

### With Subtraction Instead of Addition

Alternately these formulas may be written as: 

`f(x) = x - c₀` 

This is identical to:

`f(x) x + -c₀`

This makes `-c₀` the offset(`c`), and `1` the coefficient (`a`).

## Fahrenheit Style Formulas

The formula for converting from Fahrenheit to Celcius is:

`°C = (°F - 32) × 5/9`

In generic terms this is:

`f(x) = (x - c₀) ⋅ a`

This is already remarkably close to the desired formula:

`f(x) = (x + c) ⋅ a`

All we need to do is define `c = -c₀` and we have the necessary constants.

## Delisle Type Formulas

The typical formula for converting from Delisle to Celcius is:

`°C =  100 - °De ⋅ 2/3`

The generic form for this formula is: 

`f(x) = c₀ - x ⋅ a₀`

The constants in this formula clearly cannot be directly used, and due to that fact, they've been given a subscript of zero. <sup>2</sup>

As a reminder the library's conversions formula looks like:

`f(x) = (x - c) ⋅ a`

To derive the new constants we have to rearrange the formula such that it more closely resembles the target formula.

1. First move the negative sign to `a₀`:
  
   `f(x) = c₀ + x ⋅ -a₀`

2. Reorder the terms slighly:

   `f(x) = x ⋅ -a₀ + c₀`

3. Create an equivalent function that divides by the negated coefficient:

   `f(x) = ((x ⋅ -a₀ + c₀) ÷ -a₀) ⋅ -a₀`

4. Distribute the negated coefficient division:

   `f(x) = (x ⋅ -a₀ ÷ -a₀ + c₀ ÷ -a₀) ⋅ -a₀`

5. Remove the canceled term:

   `f(x) = (x + c₀ ÷ -a₀) ⋅ -a₀`

6. The above looks similar to the target formula:

   `f(x) = (x + c) ⋅ a`

7. To get the correct values for `a` and `c` we define them as follows:
   - `a = -a₀`
   - `c = c₀ ÷ -a₀`
   
## A Delisle Type Variant

A variation of the Delisle style conversions may also appear as:

`f(x) = -a₀ ⋅ x + c₀`

In this case we have a negative coefficient of: `-a₀`. We extract `a₀` and `c₀` directly from the formula and use the calculations at the end of the prior section to compute `a` and `c`.

## End Note

1. The dot operator used instead of cross operator to denote multiplication. This is to prevent readers confusing the `×` operator with the variable `x`. 
2. The subscript of zero is intended to preserve the conceptual relationship between the destination constants and the source constants.