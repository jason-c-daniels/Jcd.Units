namespace UnitGen.Data;

public class UnitRepository : ReadOnlyCsvRepository<Unit>
{
    public override IList<Unit> GetAll()
    {
        return ReadFromEmbeddedResource("Units.csv");
    }
}