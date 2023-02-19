using UnitGen.Models;

namespace UnitGen.Repositories;

public class UnitTypeRepository : ReadOnlyCsvRepository<UnitType>
{
    public override IReadOnlyList<UnitType> GetAll()
    {
        return ReadFromEmbeddedResource("UnitTypes.csv");
    }
}