namespace UnitGen.Repositories;

public class SystemRepository : ReadOnlyCsvRepository<Models.System>
{
    public override IReadOnlyList<Models.System> GetAll()
    {
        return ReadFromEmbeddedResource("Systems.csv");
    }
}