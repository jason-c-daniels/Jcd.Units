using UnitGen.Models;

namespace UnitGen.Repositories;

public class UnitTypeRepository : ReadOnlyCsvRepository<UnitType>
{
    protected override IReadOnlyList<UnitType> ReadAll()
    {
        return ReadFromEmbeddedResource("UnitTypes.csv");
    }
}