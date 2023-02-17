namespace UnitGen.Data;

public class SystemRepository : ReadOnlyCsvRepository<System>
{
    public override IList<System> GetAll()
    {
        return ReadFromEmbeddedResource("Systems.csv");
    }
}