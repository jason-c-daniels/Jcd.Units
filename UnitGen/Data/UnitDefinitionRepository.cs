namespace UnitGen.Data;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
    public SystemRepository SystemRepo { get; } = new SystemRepository();
    public UnitTypeRepository UnitTypeRepo { get; } = new UnitTypeRepository();
    public PrefixRepository PrefixRepo { get; } = new PrefixRepository();
    public UnitRepository UnitRepo { get; } = new UnitRepository();

    public UnitDefinitionRepository()
    {
    }
    public IList<UnitDefinition> GetAll()
    {
        var systems = SystemRepo.GetAll();
        var unitTypes = UnitTypeRepo.GetAll();
        var prefixes = PrefixRepo.GetAll();
        var units = UnitRepo.GetAll();

        var unitsWithSIPrefixes =
            from prefix in prefixes
            from unit in units
            join system in systems on unit.System equals system.Name
            join unitType in unitTypes on unit.UnitType equals unitType.Name
            where unit.UsesPrefixes
            select new UnitDefinition(system,unitType,prefix,unit);

        var noPrefix = new Prefix("", "", "", "1.0", 0);
        var unitsWithouSIPrefixes =
            from unit in units
            join system in systems on unit.System equals system.Name
            join unitType in unitTypes on unit.UnitType equals unitType.Name
            where !unit.UsesPrefixes
            select new UnitDefinition(system,unitType,noPrefix,unit);

        return unitsWithSIPrefixes
            .Concat(unitsWithouSIPrefixes)
            .Distinct()
            .OrderBy(u=>u.System.Name)
            .ThenByDescending(u=>u.IsBaseUnit)
            .ThenBy(u=>u.Unit.SortIndex)
            .ThenBy(u=>u.Prefix.SortIndex)
            .ThenBy(u=>u.UnitType.Name)
            .ToList();
    }
}