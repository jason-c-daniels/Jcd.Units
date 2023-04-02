# Mathematical Derivations

Within this file you'll find the mathematical derivations<sup>4</sup> used to transform various unit of measure formulas into the library's standard formula. This is a matter of calculating an `Offset` and `Coefficient`.

The intended audience for this document are software engineers needing to accomodate a new unit conversion. _The reader must be familiar with basic arithmetic and algebraic concepts._

## The Unit Conversion Formula

Using terms from the library's source code the formula used for converting to the base unit from the source unit is effectively defined as:

`BaseUnit = (DerivedUnit + Offset) ⋅ Coefficient` <sup>1, 3</sup>

As a math function this is expressed as follows:

`f(x) = (x + c) ⋅ a`

Where:
- `f(x)` is the function that converts **to** the base unit from the derived unit.<sup>3</sup>
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

### Notation For Original Formulas

To walk the reader through the derivations the original formula for a potential conversion is provided. The following notation will be used in the formula:

- When the coefficient in the original formula will be unaltered, it's denoted as just `a`, in the original formula. 
- When the coefficient in the original formula will be altered to use with the standard formula it's denoted as `a₀`, in the original formula.
- When the offset in the original formula will be unaltered, it's denoted as just `c`, in the original formula.
- When the offset in the original formula will be altered to use with the standard formula it's denoted as `c₀`, in the original formula.

## Simple Coefficient Formulas

Formulas only using a coefficient are already in a compatible form. They're typically written as follows:

`f(x) = a ⋅ x`

This is the same as:

`f(x) = a ⋅ (x + 0)`

This makes `0` the offset (`c`) and the formula's original coefficient is used for `a`.

### With Division Instead of Multiplication

Alternately these functions may be written as:

`f(x) = x ÷ a₀`

This is the same as writing:

`f(x) = x ⋅ (1 ÷ a₀)`

This allows us to selelct `a` as follows:

`a = 1 ÷ a₀`

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

## Fahrenheit-Style Conversion Formulas

The formula for converting from Fahrenheit to Celsius is:

`°C = (°F - 32) ⋅ 5/9`

In generic terms this is:

`f(x) = (x - c₀) ⋅ a`

This is remarkably close to the desired formula:

`f(x) = (x + c) ⋅ a`

All we need to do is define `c = -c₀` and we have the necessary constants as we already know `a`.

## Coefficient With Offset Applied After Multiplication

As the header suggest this formula is as follows:

`f(x) = a ⋅ x + c₀`

We use the following steps to determine the correct value for `c`. The value of `a` in the original formula is already compatible.

1. Create an equivalent function that divides all terms by `a`.

   `f(x) = ((a ⋅ x + c₀) ÷ a) ⋅ a`

2. Distribute the division.

   `f(x) = (a ⋅ x ÷ a + c₀ ÷ a) ⋅ a`

3. Remove the canceled term.

   `f(x) = (x + c₀ ÷ a) ⋅ a`

4. From the above we see that `a` remains unchange and that:

   `c = c₀ ÷ a`

## Delisle to Celsius Type Formula

The typical formula for converting from Delisle to Celsius is:

`°C =  100 - °De ⋅ 2/3`

The generic form for this formula is: 

`f(x) = c₀ - x ⋅ a₀`

To get the values needed we first rearrange the terms a little in order to see a familiar structure. It's not quite the target formula, but it is one we've covered above.

1. Turn subtraction into addition.

   `f(x) = c₀ + -x ⋅ a₀` 

2. Attach the minus sign to the coefficient `a₀` giving `-a₀`

   `f(x) = c₀ + x ⋅ -a₀`

3. Reorder the multiplication so that it resembles the starting formula from the prior section _Coefficient With Offset Applied After Multiplication_.

   `f(x) = -a₀ ⋅ x + c₀`

4. Define `a` to be `-a₀` and we have the exact same formula as in _Coefficient With Offset Applied After Multiplication_. 

   `f(x) = a ⋅ x + c₀`

The rest of the steps, and therefore the result, are same as using the method laid out in _Coefficient With Offset Applied After Multiplication_.

From this we know that:

- `a = -a₀`
- `c = c₀ ÷ a`

## The Input Unit Is Subtracted From A Constant

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

1. The dot operator is used instead of cross operator to denote multiplication in order to prevent confusing the operator `×` with the variable `x`.
2. The subscript of zero is intended to preserve the conceptual relationship between the destination constants (no subscript) and the source constants (with subscript).
3. The way the code and data files are structured relies on expressing conversions in terms of converting to the base unit from the derived unit. This is an essential characteristic, and the motivation for structuring the mathematical derivations in the selected manner.
4. The definition of _derivation_ in use is the first definition given by the Wolfram website:<sup>5</sup> _"A derivation is a sequence of steps, logical or computational, from one result to another."_ Also the general English defintion applies<sup>6</sup>: _"The act of deriving something or obtaining something from a source or origin."_, in this case `a` and `c` from `a₀` and `c₀` respectively.
5. https://mathworld.wolfram.com/Derivation.html
6. https://www.vocabulary.com/dictionary/derivation [definition #2]
