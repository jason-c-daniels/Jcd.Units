namespace Jcd.Units;

/// <summary>
/// Provides both default and registrable ways of comparing doubles used within this subsystem.
/// </summary>
public static class DoubleComparer
{
    /// <summary>
    /// The registered double comparer used by Quantities, by default. 
    /// </summary>
    public static IValueComparer<double> Quantity      { get; set; } = new BitwiseDoubleComparer();
    
    /// <summary>
    /// The registered double comparer used by UnitOfMeasure instances, by default.
    /// </summary>
    public static IValueComparer<double> UnitOfMeasure { get; set; } = new BitwiseDoubleComparer();
}