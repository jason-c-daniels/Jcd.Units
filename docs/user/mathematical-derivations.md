# Mathematical Derivations

Within this file you'll find the mathematical derivations used to transform various unit of measure transformations into the library's standard form.

The intended audience for this document is a software engineer needing to accomodate a new unit conversion. The reader must be familiar with basic arithmetic and algebraic concepts.

## The Unit Conversion Formula

This library's formula for converting to the base unit from the source unit is defined as:
`BaseUnit = (DerivedUnit + Offset) × Coefficient`

As a math function this is expressed as follows:

`f(x) = (x + c) ⋅ a` <sup>1</sup>

Where:
- `f(x)` is the function that converts **to** the base unit from the derived unit.
- `x` is the value represented in the derived unit of measure.
- `a` is the coefficient, a constant.
- `c` is the offset, a constant.

Functions which don't already match this representation must be reworked so that an appropriate `a` and `c` can be selected to yield an equivalent function. The following sections provide guidance for how to select an appropriate `a` and `c` for some well known conversion formulas.

The following sections largely build on each other and are intended to be read in order.

### Reminder

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

## Fahrenheit Style Conversion Formulas

The formula for converting from Fahrenheit to Celsius is:

`°C = (°F - 32) × 5/9`

In generic terms this is:

`f(x) = (x - c₀) ⋅ a`

This is remarkably close to the desired formula:

`f(x) = (x + c) ⋅ a`

All we need to do is define `c = -c₀` and we have the necessary constants.

## Coefficient With Offset Applied After Multiplication

As the header suggest this function is as follows:

`f(x) = a ⋅ x + c₀`

We use the following steps to determine the correct value for `c`. The value of `a` in the original formula is already compatible.

1. Create an equivalent function that divides all terms by `a`.

   `f(x) = ((a ⋅ x + c₀) ÷ a) ⋅ a`

2. Distribute the division.

   `f(x) = (a ⋅ x ÷ a + c₀ ÷ a) ⋅ a`

3. Remove the canceled term.

   `f(x) = (x + c₀ ÷ a) ⋅ a`

4. From the above we see that `a` remains unchange and 

   `c = c₀ ÷ a`

## Delisle to Celsius Type Formula

The typical formula for converting from Delisle to Celsius is:

`°C =  100 - °De ⋅ 2/3`

The generic form for this formula is: 

`f(x) = c₀ - x ⋅ a₀`

To get the values needed we first rearrange the terms a little and we'll see a familiar formula, not quite the target one, but it gets us where we need to go.

1. Turn subtraction into addition.
   
   `f(x) = c₀ + -x ⋅ a₀` 

2. Attach the minus sign to the coefficient `a₀` giving `-a₀`

   `f(x) = c₀ + x ⋅ -a₀`

3. Reorder the multiplication so that it resembles the starting formula from the prior section _Coefficient With Offset Applied After Multiplication_.

   `f(x) = -a₀ ⋅ x + c₀`

4. Define `a` to be `-a₀` and we have the exact same formula as in _Coefficient With Offset Applied After Multiplication_. 

   `f(x) = a ⋅ x + c₀`

The rest of the steps, and therefore the result are same as using the method laid out in _Coefficient With Offset Applied After Multiplication_.

From this we know that:

- `a = -a₀`
- `c = c₀ ÷ a`

## The Input Unit is Subtracted From a Constant

These conversions look like the following:

`f(x) = c₀ - x`

These are a minor variation of the Delisle conversions where `a₀ = 1`:

`f(x) = c₀ - x ⋅ 1`

From the Delisle type conversion we know:

- `a = -a₀`
- `c = c₀ ÷ a`

Substituting values this gives us:

- `a = -1`
- `c = c₀ ÷ -1` which is also `c = -c₀`

## End Notes

1. The dot operator is used instead of cross operator to denote multiplication in order to prevent confusing `×` with the variable `x`.
2. The subscript of zero is intended to preserve the conceptual relationship between the destination constants (no subscript) and the source constants (with subscript).