#region

using System.Diagnostics.Contracts;

#endregion

// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

namespace Jcd.Units.UnitSelection;

/// <summary>
/// Selects the fundamental unit of measure. This should be the same for both so unit1 is used.
/// </summary>
public sealed class SelectFundamentalUnit : IUnitSelectionStrategy
{
   /// <summary>
   /// The default (and only) instance of this <see cref="IUnitSelectionStrategy" />.
   /// </summary>
   public static readonly SelectFundamentalUnit Instance = new();

   /// <summary>
   /// Prevent others from instantiating it because I'm mean. (Forces the use of <see cref="Instance" /> enforcing GC
   /// friendliness.)
   /// </summary>
   private SelectFundamentalUnit()
   {
   }

   #region IUnitSelectionStrategy Members

   /// <summary>
   /// Selects the fundamental unit of measure. This should be the same for both so unit1 is used.
   /// </summary>
   /// <param name="left">The first unit to consider</param>
   /// <param name="right">The second unit to consider.</param>
   /// <typeparam name="TUnit">The unit of measure type.</typeparam>
   /// <returns>The larger unit of measure.</returns>
   [Pure]
   public TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
      where TUnit : IUnitOfMeasure<TUnit>
   {
      return left.FundamentalUnit;
   }

   #endregion
}