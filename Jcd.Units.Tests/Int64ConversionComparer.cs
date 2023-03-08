// ReSharper disable MemberCanBePrivate.Global

namespace Jcd.Units.Tests;

/// <summary>
/// An implementation of <see cref="IValueComparer{T}"/> for doubles, which
/// first multiplies the underlying value by provided <see cref="Factor"/>,
/// then converts to an <see cref="Int64"/> before performing a comparison.
/// </summary>
/// <remarks>
/// This is a demonstration type to help guide implementation of custom comparison strategies.
/// It's remarkably limited. Only values that are convertible to an <see cref="Int64"/>, after the base value
/// is multiplied by the <see cref="Factor"/>, can be compared. An exception is thrown for values out of
/// that range. As demonstrated below a stable <see cref="GetHashCode"/> must be implemented. (i.e. values that compare
/// as equal must return the same hashcode even for values with bitwise differences.)
/// Before using this type in production code you need to guarantee that all doubles passed in are convertible to an <see cref="Int64"/>,
/// after multiplying by the <see cref="Factor"/>if this can't be guaranteed, do not use this class in production code.
/// </remarks>
public class Int64ConversionComparer : IValueComparer<double>
{
   /// <summary>
   /// The default, and particularly useless, comparer. It uses a Factor of 1.
   /// This means it's functionally identical to a binary comparison, only with
   /// more steps and CPU cycles consumed.
   /// </summary>
   public static Int64ConversionComparer Default = new ();

   /// <summary>
   /// Compares to three decimal places (base 10).
   /// </summary>
   public static Int64ConversionComparer ThreeDecimalPlaces = new (1000);

   /// <summary>
   /// Compares to six places (base 10).
   /// </summary>
   public static Int64ConversionComparer SixDecimalPlaces = new (1000 * 1000);

   /// <summary>
   /// Compares to nine decimal places (base 10).
   /// </summary>
   public static Int64ConversionComparer NineDecimalPlaces = new (1000 * 1000);

   /// <summary>
   /// Constructs an <see cref="Int64ConversionComparer"/> instance with the given multiplication factor.
   /// </summary>
   /// <param name="factor">The multiplication factor</param>
   public Int64ConversionComparer(double factor = 1.0)
   {
      Factor = factor;
   }

   /// <summary>
   /// The amount to multiply by before conversion and comparison.
   /// </summary>
   public double Factor { get; }

   /// <summary>
   /// Performs the relational comparison on the params after converting to their <see cref="Int64"/> post-multiplication representation. 
   /// </summary>
   /// <param name="x">The left hand operand to compare.</param>
   /// <param name="y">The right hand operand to compare.</param>
   /// <returns>-1 if x &lt; y; 1 if x &gt; y; 0 if equivalent.</returns>
   public int Compare(double x, double y)
   {
      var xi64 = ToInt64(x);
      var yi64 = ToInt64(y);

      return xi64.CompareTo(yi64);
   }

   /// <summary>
   /// Performs the equivalence comparison on the params after converting to their <see cref="Int64"/> post-multiplication representation. 
   /// </summary>
   /// <param name="x">The left hand operand to compare.</param>
   /// <param name="y">The right hand operand to compare.</param>
   /// <returns>-1 if x &lt; y; 1 if x &gt; y; 0 if equivalent.</returns>
   public bool Equals(double x, double y)
      => Compare(x, y) == 0;

   /// <summary>
   /// Creates a stable hash code for a value based on the <see cref="Factor"/> used for
   /// conversion and comparison.
   /// </summary>
   /// <param name="val">The value to create a hash code for.</param>
   /// <returns>The hash code.</returns>
   public int GetHashCode(double val)
   {
      var vi64 = ToInt64(val);

      return vi64.GetHashCode();
   }

   /// <summary>
   /// Multiplies a value by the factor, then converts to an <see cref="Int64"/>
   /// </summary>
   /// <param name="dbl">the value to convert.</param>
   /// <returns>The multiplied and converted value.</returns>
   public long ToInt64(double dbl) => Convert.ToInt64(dbl * Factor);
}
