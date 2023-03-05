#region

using UnitGen.Models;

#endregion

namespace UnitGen.Repositories;

public class UnitRepository : ReadOnlyCsvRepository<Unit>
{
   protected override IReadOnlyList<Unit> ReadAll()
      => ReadFromEmbeddedResource("Units.csv");
}
