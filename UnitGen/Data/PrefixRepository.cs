namespace UnitGen.Data;

public class PrefixRepository : ReadOnlyCsvRepository<Prefix>
{
    public override IList<Prefix> GetAll()
    {
        return ReadFromEmbeddedResource("Prefixes.csv");
    }
}