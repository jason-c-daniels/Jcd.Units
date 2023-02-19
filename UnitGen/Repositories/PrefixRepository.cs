using UnitGen.Models;

namespace UnitGen.Repositories;

public class PrefixRepository : ReadOnlyCsvRepository<Prefix>
{
    protected override IReadOnlyList<Prefix> ReadAll()
    {
        return ReadFromEmbeddedResource("Prefixes.csv");
    }
}