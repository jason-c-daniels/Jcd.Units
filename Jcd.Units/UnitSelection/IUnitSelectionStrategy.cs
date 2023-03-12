// ReSharper disable UnusedMember.Global

namespace Jcd.Units.UnitSelection;

/// <summary>
/// Defines the interface for selecting between two units of measure.
/// </summary>
public interface IUnitSelectionStrategy
{
   /// <summary>
   /// Given two units of measure, return the one indicated by the strategy.
   /// </summary>
   /// <param name="left">The first unit of measure to consider.</param>
   /// <param name="right">The second unit of measure to consider.</param>
   /// <returns>The unit selected</returns>
   /// <typeparam name="TUnit">The concrete <see cref="UnitOfMeasure{TUnit}" /> type.</typeparam>
   TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
            where TUnit : IUnitOfMeasure<TUnit>;
}
