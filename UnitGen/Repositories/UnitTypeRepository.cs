#region

using UnitGen.Models;

#endregion

namespace UnitGen.Repositories;

public class UnitTypeRepository : ReadOnlyCsvRepository<UnitType>
{
   protected override IReadOnlyList<UnitType> ReadAll()
      => ReadFromEmbeddedResource("UnitTypes.csv");
}
