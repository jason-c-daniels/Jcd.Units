using UnitGen.Models;

namespace UnitGen.Repositories;

public class UnitRepository : ReadOnlyCsvRepository<Unit>
{
    protected override IReadOnlyList<Unit> ReadAll()
    {
        return ReadFromEmbeddedResource("Units.csv");
    }
}