namespace Jcd.Units.DoubleComparison;

/// <summary>
/// Performs standard, compiler provided, comparison operations against two doubles.
/// </summary>
public struct BitwiseDoubleComparer : IValueComparer<double>
{
   /// <summary>
   /// Compares two doubles by the compiler provided default. This carries with it all the concerns
   /// of doing raw double comparisons. This is provided as a default mechanism to kickstart
   /// operations. You should really implement and use your own comparer as per your application's needs.
   /// </summary>
   /// <remarks>
   /// <see href="https://randomascii.wordpress.com/2012/02/25/comparing-floating-point-numbers-2012-edition/">Comparing Floating Point Numbers 2012 Edition</see>
   /// by Bruce Dawson for a summary of considerations when comparing doubles and why this really isn't the class
   /// to use for production code. 
   /// </remarks>
   /// <param name="x">The left hand operand</param>
   /// <param name="y">the right hand operand</param>
   /// <returns>-1 if <paramref name="x"/> is less than <paramref name="y"/>, 0 if they're equal and 1 if <paramref name="x"/> is greater than <paramref name="y"/></returns>
   public int Compare(double x, double y)
      => x.CompareTo(y);

   /// <summary>
   /// The default instance. Use this instead of constantly creating new ones. It's easier
   /// on the garbage collector.
   /// </summary>
   public static readonly BitwiseDoubleComparer Instance = new ();

   /// <summary>
   /// Compares two doubles for equality.
   /// </summary>
   /// <param name="x">A value to compare.</param>
   /// <param name="y">A value to compare.</param>
   /// <returns>true if both are equal, false otherwise.</returns>
   public bool Equals(double x, double y)
      => x.Equals(y);

   /// <inheritdoc />
   public int GetHashCode(double obj)
      => obj.GetHashCode();
}
