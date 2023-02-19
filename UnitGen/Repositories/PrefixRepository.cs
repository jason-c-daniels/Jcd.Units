using UnitGen.Models;

namespace UnitGen.Repositories;

public class PrefixRepository : ReadOnlyCsvRepository<Prefix>
{
    public override IReadOnlyList<Prefix> GetAll()
    {
        return ReadFromEmbeddedResource("Prefixes.csv");
    }
}