namespace UnitGen.Data;

public class PrefixRepository : ReadOnlyCsvRepository<PrefixDefinition>
{
    public override IList<PrefixDefinition> GetAll()
    {
        return ReadFromEmbeddedResource("Prefixes.csv");
    }
}