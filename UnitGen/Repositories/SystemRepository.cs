namespace UnitGen.Repositories;

public class SystemRepository : ReadOnlyCsvRepository<Models.System>
{
   protected override IReadOnlyList<Models.System> ReadAll()
      => ReadFromEmbeddedResource("Systems.csv");
}
