#region

using System.Diagnostics.Contracts;

#endregion

namespace Jcd.Units.UnitSelection;

/// <summary>
/// Selects the left hand side of two units of measure.
/// </summary>
public sealed class SelectLeftUnit : IUnitSelectionStrategy
{
   /// <summary>
   /// The default (and only) instance of this <see cref="IUnitSelectionStrategy" />.
   /// </summary>
   public static readonly SelectLeftUnit Instance = new ();

   /// <summary>
   /// Prevent others from instantiating it because I'm mean. (Forces the use of <see cref="Instance" /> enforcing GC
   /// friendliness.)
   /// </summary>
   private SelectLeftUnit() { }

   /// <summary>
   /// Selects the left hand side of two units of measure.
   /// </summary>
   /// <param name="left">The first unit to consider</param>
   /// <param name="right">The second unit to consider.</param>
   /// <typeparam name="TUnit">The unit of measure type.</typeparam>
   /// <returns>The larger unit of measure.</returns>
   [Pure]
   public TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
            where TUnit : IUnitOfMeasure<TUnit>
      => left;
}
