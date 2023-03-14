#region

using System.Collections.Immutable;

using UnitGen.Models;

#endregion

// ReSharper disable ArrangeRedundantParentheses

namespace UnitGen.Repositories;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
   private IReadOnlyList<UnitDefinition>? _allItems;

   private IImmutableDictionary<string, UnitType> _unitTypesByName;
   private readonly Prefix _noPrefix = new ("", "", false, "", "", "1.0", 0, 0);

   public IReadOnlyList<UnitDefinition> GetAll()
   {
      if (_allItems is not null) return _allItems;

      var systems   = SystemRepo.GetAll();
      var unitTypes = UnitTypeRepo.GetAll();
      _unitTypesByName = unitTypes.ToImmutableDictionary(x => x.Name);
      var prefixes = PrefixRepo.GetAll();
      var units    = UnitRepo.GetAll();

      var unitsWithPrefixes =
               from unit in units
               join prefix in prefixes on unit.PrefixScale equals prefix.Scale
               join system in systems on unit.System equals system.Name
               join unitType in unitTypes on unit.UnitType equals unitType.Name
               where unit.UsesPrefixes
                  && (
                              unit.PrefixExponentsToInclude.ToLower() == "all" // all explicitly listed
                           || unit.PrefixExponentsToInclude.ToLower() == "any" // any explicitly listed
                           || string.IsNullOrWhiteSpace(
                                                        unit.PrefixExponentsToInclude
                                                       ) // no value is the same as all or any
                           || prefix.IsBasePrefix
                           || (unit.PrefixExponentsToInclude.ToLower() == "positive" && prefix.IsPositiveExponent)
                           || (unit.PrefixExponentsToInclude.ToLower() == "negative" && prefix.IsNegativeExponent)
                     )
               select new UnitDefinition(system, unitType, prefix, unit);

      var unitsWithoutSiPrefixes =
               from unit in units
               join system in systems on unit.System equals system.Name
               join unitType in unitTypes on unit.UnitType equals unitType.Name
               where !unit.UsesPrefixes
               select new UnitDefinition(system, unitType, _noPrefix, unit);

      var definedUnits = unitsWithPrefixes
                        .Concat(unitsWithoutSiPrefixes)
                        .ToImmutableList();

      var generatedUnits = GenerateUnits(definedUnits);

      return _allItems = definedUnits
                        .Concat(generatedUnits)
                        .Distinct()
                        .OrderBy(u => u.System.Name)
                        .ThenByDescending(u => u.IsBaseUnit)
                        .ThenBy(u => u.Unit.SortIndex)
                        .ThenBy(u => u.Prefix.SortIndex)
                        .ThenBy(u => u.UnitType.Name)
                        .ToImmutableList();
   }

   private IReadOnlyList<UnitDefinition> GenerateUnits(ImmutableList<UnitDefinition> definedUnits)
   {
      var lengths = definedUnits.Where(
                                       u => u.UnitType.Name == "Length"
                                         && !u.UnitName.ToLower()
                                              .Contains("light-")
                                         && !u.UnitName.ToLower()
                                              .Contains("jovian")
                                         && !u.UnitName.ToLower()
                                              .Contains("solar")
                                         && !u.UnitName.ToLower()
                                              .Contains("parsec")
                                      )
                                .ToImmutableList();

      var areas = GenerateAreas(lengths)
              .ToImmutableList();

      var volumes = GenerateVolumes(lengths)
              .ToImmutableList();

      return areas.Concat(volumes)
                  .ToImmutableList();
   }

   private IReadOnlyList<UnitDefinition> GenerateAreas(IEnumerable<UnitDefinition> lengths)
   {
      var area = _unitTypesByName["Area"];

      var areas =
               from length in lengths
               select length with
                      {
                               Prefix = _noPrefix, UnitType = area, Unit = new Unit(
                                   length.System.Name
                                 , area.Name
                                 , $"square {length.UnitName}"
                                 , $"{length.Symbol}^2"
                                 , length.Unit.PrefixScale
                                 , length.Unit.PrefixExponentsToInclude
                                 , length.Unit.BaseUnitSystem
                                 , $"square {length.BaseUnitName}"
                                 , $"({length.Coefficient})*({length.Coefficient})"
                                 , "0"
                                 , // TODO: Find a way to convert this.
                                   length.Unit.SortIndex
                                  )
                      };

      return areas.ToImmutableList();
   }

   private IReadOnlyList<UnitDefinition> GenerateVolumes(IEnumerable<UnitDefinition> lengths)
   {
      var volume = _unitTypesByName["Volume"];

      var volumes =
               from length in lengths
               select length with
                      {
                               Prefix = _noPrefix, UnitType = volume, Unit = new Unit(
                                   length.System.Name
                                 , volume.Name
                                 , $"cubic {length.UnitName}"
                                 , $"{length.Symbol}^3"
                                 , length.Unit.PrefixScale
                                 , length.Unit.PrefixExponentsToInclude
                                 , length.Unit.BaseUnitSystem
                                 , $"cubic {length.BaseUnitName}"
                                 , $"({length.Coefficient})*({length.Coefficient})"
                                 , "0"
                                 , // TODO: Find a way to convert this.
                                   length.Unit.SortIndex
                                  )
                      };

      return volumes.ToImmutableList();
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
