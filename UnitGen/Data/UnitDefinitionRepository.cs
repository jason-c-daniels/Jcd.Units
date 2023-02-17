namespace UnitGen.Data;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
    private SystemRepository _systemRepo=new SystemRepository();
    private UnitTypeRepository _unitTypeRepo=new UnitTypeRepository();
    private PrefixRepository _prefixRepo=new PrefixRepository();
    private UnitRepository _unitRepo=new UnitRepository();
    public UnitDefinitionRepository()
    {
    }
    public IList<UnitDefinition> GetAll()
    {
        var systems = _systemRepo.GetAll();
        var unitTypes = _unitTypeRepo.GetAll();
        var prefixes = _prefixRepo.GetAll();
        var units = _unitRepo.GetAll();

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
            .ThenBy(u=>u.UnitType.Name)
            .ThenBy(u=>u.IsBaseUnit)
            .ThenBy(u=>u.Unit.SortIndex)
            .ThenBy(u=>u.Prefix.SortIndex)
            .ToList();
    }
}