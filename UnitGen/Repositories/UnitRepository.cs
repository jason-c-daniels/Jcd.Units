#region

using System.Collections.Immutable;

using UnitGen.Models;

// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace UnitGen.Repositories;

public class UnitRepository : ReadOnlyCsvRepository<Unit>
{
   protected override IReadOnlyList<Unit> ReadAll()
   {
      return ReadFromEmbeddedResource("Units.csv")

             // this should place all manually entered units after generated units, in the sort order listed in the file.
            .Select(x => x with { SortIndex = x.SortIndex * 1_000_000_000 })
            .ToImmutableList();
   }
}