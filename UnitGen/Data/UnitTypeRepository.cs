namespace UnitGen.Data;

public class UnitTypeRepository : ReadOnlyCsvRepository<UnitType>
{
    public override IList<UnitType> GetAll()
    {
        return ReadFromEmbeddedResource("UnitTypes.csv");
    }
}