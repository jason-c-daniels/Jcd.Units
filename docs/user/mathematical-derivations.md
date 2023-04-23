# Mathematical Derivations For Selecting A Coefficient and Offset

Within this file you'll find the mathematical derivations<sup>4</sup> used to transform various unit of measure formulas
into the library's standard formula. This is a matter of calculating a suitable `Offset` and `Coefficient` to convert 
from the derived unit of measure, to the base unit of measure.

The intended audience for this document are software engineers needing to accomodate a new unit conversion. _The reader
*must be familiar with* algebraic concepts, creating [equivalent functions](https://www.thoughtco.com/understanding-equivalent-equations-4157661), 
and standard algebraic notation<sup>7</sup>._ 

NOTE: The symbols used in this document are all standard algebraic symbols and may have a different meaning in a 
different context. (e.g. $c$ in physics means the speed of light in a vaccuum. This is not a physics document, so 
leave that meaning behind.) 

## The Unit Conversion Formula

Using terms from the library's source code the formula used for converting to the base unit from the source unit is
effectively defined as:

`BaseUnit = Coefficient ⋅ (DerivedUnit + Offset)` <sup>1, 3, 8</sup>

As a math function this is expressed as follows<sup>9</sup>:

$f(x) = a⋅(x + c)$

FORMULA NOTES:
- This is the _standard formula_ for this library.
- $f(x)$ is the function that converts **to** the base unit from the derived unit.<sup>3</sup>
- $x$ is the value represented in the derived unit of measure.
- $a$ is the coefficient, a constant.
- $c$ is the offset, a constant.

Functions which don't already match this representation must be reworked so that an appropriate $a$ and $c$ can be
selected to yield an [equivalent function](https://www.thoughtco.com/understanding-equivalent-equations-4157661). 

To that end, the following sections:
1. Provide guidance for how to select an appropriate $a$ and $c$ for some well known 
   conversions formulas.
2. Walk the reader through, step by step, how to rearrange these formulas, to arrive at the
   calculations for $a$ and $c$ given a source formula.
3. Build on each other and are intended to be read in order.

### Notation For Starting Formulas

When walking the reader through the derivations the _starting formula_ for a type of conversion is provided. The 
following notation is used in the _starting formula_:

- When the coefficient in the starting formula will be unaltered, it's denoted as just $a$.
- When the coefficient in the starting formula will be altered to use with the standard formula it's denoted as  $a_0$.
- When the offset in the starting formula will be unaltered, it's denoted as just $c$.
- When the offset in the starting formula will be altered to use with the standard formula it's denoted as $c_0$.

### Reminder

When reading below keep the following substitutions in mind:

- $f(x)$ is the same as `BaseUnit` above.
- $x$ is the same as `DerivedUnit` above.
- $c$ is the same as `Offset` above.
- $a$ is the same as `Coefficient` above.
- $a_0$ is a coefficient in the starting formula, and will be used to compute $a$ and possibly $c$.
- $c_0$ is an offset in the starting formula, and will be used to compute $c$.

## Simple Coefficient Formulas

Formulas only using a coefficient are already in a compatible form. They're typically written as follows:

$f(x) = a⋅x$

This is the same as:

$f(x) = a⋅(x + 0)$

This gives us:

- $a$ is unaltered.
- $c = 0$

### With Division Instead of Multiplication

Alternately these functions might be written as:

$f(x) = \frac{x}{a_0}$

This is the same as writing:

$f(x) = \frac{1}{a_0}⋅x$

Which is the same as writing:

$f(x) =  \frac{1}{a_0}⋅(x + 0)$

This gives us:

- $a = \frac{1}{a_0}$
- $c = 0$

## Simple Offset Formulas

Formulas only using an offset are already in a compatible form. They're typically written as follows:

$f(x) = x + c$

This is the same as:

$f(x) = 1⋅(x + c)$

This gives us:

- $a = 1$
- $c$ is unaltered.

### With Subtraction Instead of Addition

Alternately these formulas may be written as:

$f(x) = x - c_0$

This is identical to:

$f(x) = x + -c_0$

Which is identical to:

$f(x) = 1⋅(x + -c_0)$

This gives us:

- $a = 1$
- $c = -c_0$

## Fahrenheit-Style Conversion Formulas

The formula for converting from Fahrenheit to Celsius is:

$°C = \frac{5}{9}⋅(°F - 32)$

In generic terms this is:

$f(x) = a⋅(x - c_0)$

This is remarkably close to the desired formula:

$f(x) =  a⋅(x + c)$

Once we change subtraction to adding a negative we effectively get to target formula:

$f(x) = a⋅(x + -c_0)$

This gives us:

- $a$ is unaltered.
- $c = -c_0$

## Coefficient With Offset Applied After Multiplication

As the header suggest this formula is as follows:

$f(x) = a⋅x + c_0$

We use the following steps to determine the correct value for $c$. The value of $a$ in the original formula is already
compatible.

1. Create an equivalent function which we can use to divide all terms by $a$; this is done by multiplying by $\frac{a}{a}$.

   $f(x) = \frac{a}{a}⋅(a⋅x + c_0)$

2. Distribute the division.

   $f(x) = a⋅(\frac{a⋅x}{a} + \frac{c_0}{a})$

3. Remove the canceled term.

   $f(x) = a⋅(x + \frac{c_0}{a})$

4. From the above we see that $a$ remains unchange and that:

   $c = \frac{c_0}{a}$

This gives us:

- $a$ is unaltered.
- $c = \frac{c_0}{a}$

## Delisle to Celsius Type Formula

The typical formula for converting from Delisle to Celsius is:

$°C = 100 - °De⋅\frac{2}{3}$

The generic form for this formula is:

$f(x) = c_0 - x⋅a_0$

To get the values needed we first rearrange the terms a little in order to see a familiar structure. It's not quite the
target formula, but it is one we've covered above.

1. Turn subtraction into addition.

   $f(x) = c_0 + -x⋅a_0$

2. Attach the minus sign to the coefficient $a_0$ giving $-a_0$

   $f(x) = c_0 + x⋅-a_0$

3. Reorder the multiplication so that it resembles the starting formula from the prior section _Coefficient With Offset
   Applied After Multiplication_.

   $f(x) = -a_0⋅x + c_0$

4. Define $a$ to be $-a_0$ and we have the exact same formula as in _Coefficient With Offset Applied After
   Multiplication_.

   $f(x) = a⋅x + c_0$

The rest of the steps, and therefore the result, are same as using the method laid out in _Coefficient With Offset
Applied After Multiplication_.

This gives us:

- $a = -a_0$
- $c = \frac{c_0}{a}$

## The Input Unit Is Subtracted From A Constant

These conversions look like the following:

$f(x) = c_0 - x$

These are a minor variation of the Delisle conversions where $a_0 = 1$:

$f(x) = c_0 - x⋅1$

From the Delisle type conversion we know:

- $a = -a_0$
- $c = \frac{c_0}{a}$

Substituting values, this gives us:

- $a = -1$
- $c = \frac{c_0}{-1}$ which is also $c = -c_0$

## End Notes

1. The dot operator is used instead of cross operator to denote multiplication in order to prevent confusing the
   operator $×$ with the variable $x$.
2. The subscript of zero is intended to preserve the conceptual relationship between the destination constants (no
   subscript) and the source constants (with subscript).
3. The way the code and data files are structured relies on expressing conversions in terms of converting to the base
   unit from the derived unit. This is an essential characteristic, and the motivation for structuring the mathematical
   derivations in the selected manner.
4. The definition of _derivation_ in use is the first definition given by the Wolfram website:<sup>5</sup> _"A
   derivation is a sequence of steps, logical or computational, from one result to another."_ Also the general English
   defintion applies<sup>6</sup>: _"The act of deriving something or obtaining something from a source or origin."_, in
   this case $a$ and $c$ from $a_0$ and $c_0$ respectively.
5. https://mathworld.wolfram.com/Derivation.html
6. https://www.vocabulary.com/dictionary/derivation [definition #2]
7. https://mathvault.ca/hub/higher-math/math-symbols/algebra-symbols/ Gives a list of many standard algebraic symbols.
8. This representation was selected because it simplified a couple of internal processes that allow for defining
   units of measure, nearly arbitrarilty, in terms of each other.
