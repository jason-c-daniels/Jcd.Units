using UnitGen.Models;

namespace UnitGen.Repositories;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
    public SystemRepository SystemRepo { get; } = new SystemRepository();
    public UnitTypeRepository UnitTypeRepo { get; } = new UnitTypeRepository();
    public PrefixRepository PrefixRepo { get; } = new PrefixRepository();
    public UnitRepository UnitRepo { get; } = new UnitRepository();
    private IReadOnlyList<UnitDefinition>? _unitDefs = null;

    
    public IReadOnlyList<UnitDefinition> GetAll()
    {
        if (_unitDefs != null) return _unitDefs;
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

        return _unitDefs=unitsWithSIPrefixes
            .Concat(unitsWithouSIPrefixes)
            .Distinct()
            .OrderBy(u=>u.System.Name)
            .ThenByDescending(u=>u.IsBaseUnit)
            .ThenBy(u=>u.Unit.SortIndex)
            .ThenBy(u=>u.Prefix.SortIndex)
            .ThenBy(u=>u.UnitType.Name)
            .ToList();
    }

    public IReadOnlyList<UnitType> GetUsedUnitTypes() =>
         (from unitDef in GetAll() select unitDef.UnitType).Distinct().ToList();

    public IEnumerable<IGrouping<string, IGrouping<string, UnitDefinition>>> 
        GetSystemToUnitTypeToUnitDefinitionGroupings() =>
            from unit in GetAll()
            group unit by unit.System.Name
            into systemGroup
            from unitType in (
                from unit in systemGroup
                group unit by unit.UnitType.Name
            )
            group unitType by systemGroup.Key;
}