#region

using UnitGen.Models;

#endregion

// ReSharper disable ArrangeRedundantParentheses

namespace UnitGen.Repositories;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
   private IReadOnlyList<UnitDefinition>? _allItems;

   public IReadOnlyList<UnitDefinition> GetAll()
   {
      if (_allItems != null) return _allItems;

      var systems   = SystemRepo.GetAll();
      var unitTypes = UnitTypeRepo.GetAll();
      var prefixes  = PrefixRepo.GetAll();
      var units     = UnitRepo.GetAll();

      var unitsWithSiPrefixes =
               from prefix in prefixes
               from unit in units
               join system in systems on unit.System equals system.Name
               join unitType in unitTypes on unit.UnitType equals unitType.Name
               where unit.UsesPrefixes
               select new UnitDefinition(system, unitType, prefix, unit);

      var noPrefix = new Prefix("", "", "", "1.0", 0);

      var unitsWithoutSiPrefixes =
               from unit in units
               join system in systems on unit.System equals system.Name
               join unitType in unitTypes on unit.UnitType equals unitType.Name
               where !unit.UsesPrefixes
               select new UnitDefinition(system, unitType, noPrefix, unit);

      return _allItems = unitsWithSiPrefixes
                        .Concat(unitsWithoutSiPrefixes)
                        .Distinct()
                        .OrderBy(u => u.System.Name)
                        .ThenByDescending(u => u.IsBaseUnit)
                        .ThenBy(u => u.Unit.SortIndex)
                        .ThenBy(u => u.Prefix.SortIndex)
                        .ThenBy(u => u.UnitType.Name)
                        .ToList();
   }

   // ReSharper disable once ReturnTypeCanBeEnumerable.Global
   public IReadOnlyList<UnitType> GetUsedUnitTypes() =>
            (from unitDef in GetAll() select unitDef.UnitType).Distinct()
                                                              .ToList();

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

   // ReSharper disable MemberCanBePrivate.Global
   public SystemRepository SystemRepo { get; } = new ();
   public UnitTypeRepository UnitTypeRepo { get; } = new ();
   public PrefixRepository PrefixRepo { get; } = new ();
   public UnitRepository UnitRepo { get; } = new ();

   // ReSharper restore MemberCanBePrivate.Global
}
