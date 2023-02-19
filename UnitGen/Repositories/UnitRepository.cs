using UnitGen.Models;

namespace UnitGen.Repositories;

public class UnitRepository : ReadOnlyCsvRepository<Unit>
{
    public override IReadOnlyList<Unit> GetAll()
    {
        return ReadFromEmbeddedResource("Units.csv");
    }
}