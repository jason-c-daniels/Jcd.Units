namespace UnitGen.Data;

public record UnitType
(
    string Name,
    string UnitTypeName,
    string EnumerationName,
    string Description
);

public class UnitTypeRepository : ReadOnlyCsvRepository<UnitType>
{
    public override IList<UnitType> GetAll()
    {
        return ReadFromEmbeddedResource("UnitTypes.csv");
    }
}