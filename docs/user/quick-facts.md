# Quick Facts

- `dotnet` version 6+ required.
- The library is coded in C#.
- The conversions are performed and represented in code according to the following
  formula: `BaseUnit = (DerivedUnit + Offset) × Coefficient`.
   - **Rationale:** This representation allowed for easier implementation and validation compared to other forms.
   - **Relevance:** Most unit of measure conversion formulas are transformable into this representation. Those which are
     not cannot be handled by this library.
   - **Notation Usage:** While not the typical representation for some unit conversions, this documentation will use
     this notation as a matter of consistency, when giving specific examples.
      - As well, when certain terms have no impact (e.g. Offset = 0 or Coefficient = 1.0) they are removed from
        documentation.
      - So a formula for converting among SI lengths could look like the following: `Meter = 1000 × Kilometer`.
      - While degrees Delisle would resemble `°C = (°De + -150) × -2/3`, which is typically written `100 - °De × 2/3`. (
        See [Mathematical Derivations](mathematical-derivations) as to why these are equivalent functions.)
- This library only supports **simple** unit of measure handling. It doesn't synthesize new units, nor does it perform
  certain well known unit type transformations (e.g. Area = Length1 \* Length2).
   - Basically the context of the operation cannot be known.
      - Consider the following: when multiplying `10m` by `0.1m` do we have `1m²` or just `1.0`?
      - After all, multiplying by `0.1` is the same as dividing by `10`. Was the caller leveraging the fact that
        multiplication is faster than division? Was the caller trying to get an area? Did the caller have something else
        in mind?
      - The library cannot know any of that. Only the person writing the code knows their own intent.
      - Also, for even more complex unit of measure relationships the problem gets even more difficult.
   - A more detailed explanation is given in [Chapter 4](index).
- The data is stored in memory as an IEEE754 double precision floating point number. These come with some concerns
  relative to comparisons and arithmetic. These are discussed in [Chapter 4](ch4/index).
- **Do not** use the quantity type instances within algorithms requiring extremely high performance. This library is an
  ease of use enhancement, and is not as fast as pure double comparisons and arithmetic.
- **Do not** use the quantity type instances within algorithms requiring extremely high precision. In addition to using
  the IEEE754 double, which has precision issues of its own, these are compounded by having to, in the worst case,
  perform one each of addition, subtraction, multiplication and division, BEFORE being able to operate on two numbers.
  This creates cumulative error. This is unavoidable. I will eventually look into reducing the number of actual
  operations for certain edge cases, however, the fact that a conversion must take place before the operation (
  comparison or arithmetic) is unavoidable.
- This library takes no opinion on quantity parsing or string localization. Both of these are up to the consuming
  application to implement.
   - For parsing, this is twofold:
      - Depending on the type of unit of measure, there are symbol clashes among different unit types.
      - When looking at Imperial versus US Customary units, there are conflicting definitions with the same name and
        symbol or abbreviation. (e.g. US Quart vs Imperial Quart, they're both called a "quart" in English and both are
        denoted "qt." for an abbreviation.)
      - The only way around any of this is to have a parseable way of indicating which it is. At this point we start
        overlapping unit parsing with localization, which is an unruly problem to wrangle, unless one strictly limited
        parsing to a specific langauge.
   - For localization this mainly motivated by how I spend my time.
      - There are thousands of individual units of measure defined within this library.
      - Most are programmatically generated from one or more base units.
      - It is _very_ unlikely any one application will use all of these.
      - As well even "proper English" is being eschewed by the default formatting due to both the inconsistencies in how
        English handles pluralization as well as how SI's correct terminology eschews pluralizing the terms. All of the
        preceeding combine pose a significant problem beyond simply localizing or parsing the individual words.
      - Plus, and most importantly, proper localization requires more than word for word translation. For example: in
        Persian quart is written کوارت and is still equally ambiguous (Is it a US or Imperial quart? How does one
        indicate this in a grammatically correct way in Persian?). So the only way to correctly add clarity involves
        having to know something about the grammar of the target language as well as having the individually localized
        terms (thousands of them!).

        I'm never going to do that with this library. **That is by definition a concern for an application displaying
        information to an end user.** It is not a matter to be handled by an ease of use enhancement library such as
        this.
