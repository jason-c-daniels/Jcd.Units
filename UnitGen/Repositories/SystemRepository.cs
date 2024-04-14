namespace UnitGen.Repositories;

public class SystemRepository : ReadOnlyCsvRepository<Models.System>
{
   protected override IReadOnlyList<Models.System> ReadAll()
   {
      return ReadFromEmbeddedResource("Systems.csv");
   }
}