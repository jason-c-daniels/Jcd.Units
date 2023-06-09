﻿#region

using System.Collections.Immutable;

using UnitGen.Models;

// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable InconsistentNaming
// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable ReturnTypeCanBeEnumerable.Local

#endregion

// ReSharper disable ArrangeRedundantParentheses

namespace UnitGen.Repositories;

public class UnitDefinitionRepository : IReadOnlyRepository<UnitDefinition>
{
   #region Fields

   private readonly Prefix _noPrefix = new ("", "", false, "", "", "1.0", 0, 0);
   private IReadOnlyList<UnitDefinition>? _allItems;

   private IImmutableDictionary<string, UnitType> _unitTypesByName =
            new Dictionary<string, UnitType>().ToImmutableDictionary();

   #endregion

   #region Unit Generation Logic

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

      var unitsWithoutPrefixes =
               from unit in units
               join system in systems on unit.System equals system.Name
               join unitType in unitTypes on unit.UnitType equals unitType.Name
               where !unit.UsesPrefixes
               select new UnitDefinition(system, unitType, _noPrefix, unit);

      var definedUnits = unitsWithPrefixes
                        .Concat(unitsWithoutPrefixes)
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

   private IReadOnlyList<UnitDefinition> GenerateUnits(ImmutableList<UnitDefinition> definedUnits)
   {
      var lengths = definedUnits.Where(u => u.UnitType.Name == "Length")
                                .ToImmutableList();

      var durations = definedUnits.Where(u => u.UnitType.Name == "Duration")
                                  .ToImmutableList();

      var areas = GenerateAreas(lengths)
              .ToImmutableList();

      var volumes = GenerateVolumes(lengths)
              .ToImmutableList();

      var masses = definedUnits.Where(x => x.UnitType.Name == "Mass")
                               .ToImmutableList();

      var velocities = GenerateVelocities(lengths, durations)
              .ToImmutableList();

      var accelerations = GenerateAccelerations(lengths, durations)
              .ToImmutableList();

      var densities = GenerateDensities(masses, volumes);

      return areas.Concat(volumes)
                  .Concat(densities)
                  .Concat(velocities)
                  .Concat(accelerations)
                  .ToImmutableList();
   }

   private IReadOnlyList<UnitDefinition> GenerateVelocities
            (ImmutableList<UnitDefinition> lengths, ImmutableList<UnitDefinition> durations)
   {
      var velocity = _unitTypesByName["Velocity"];

      var velocities = (
                        from length in lengths
                        from duration in durations //on length.System equals duration.System
                        where length.System.Name != "Astronomical"
                        select length with
                               {
                                        Prefix = _noPrefix, UnitType = velocity, Unit = new Unit(
                                            length.System.Name
                                          , velocity.Name
                                          , $"{length.UnitName} per {duration.UnitName}"
                                          , $"{length.Symbol}/{duration.Symbol}"
                                          , length.Unit.PrefixScale
                                          , length.Unit.PrefixExponentsToInclude
                                          , length.Unit.BaseUnitSystem
                                          , $"{length.BaseUnitName} per {duration.BaseUnitName}"
                                          , $"({length.Coefficient})/({duration.Coefficient})"

                                            // TODO: Find a way to convert this.
                                          , "0"
                                          , (length.Unit.SortIndex   + 1)
                                          * (length.Prefix.SortIndex + 1)
                                          * (duration.Unit.SortIndex + 1)
                                          + duration.Prefix.SortIndex
                                           )
                               })
              .ToImmutableList();

      return velocities;
   }

   private IReadOnlyList<UnitDefinition> GenerateAccelerations
            (ImmutableList<UnitDefinition> lengths, ImmutableList<UnitDefinition> durations)
   {
      var acceleration = _unitTypesByName["Acceleration"];

      var accelerations = (
                        from length in lengths
                        from duration in durations //on length.System equals duration.System
                        where length.System.Name != "Astronomical"
                        select length with
                               {
                                        Prefix = _noPrefix, UnitType = acceleration, Unit = new Unit(
                                            length.System.Name
                                          , acceleration.Name
                                          , $"{length.UnitName} per square {duration.UnitName}"
                                          , $"{length.Symbol}/{duration.Symbol}²"
                                          , length.Unit.PrefixScale
                                          , length.Unit.PrefixExponentsToInclude
                                          , length.Unit.BaseUnitSystem
                                          , $"{length.BaseUnitName} per square {duration.BaseUnitName}"
                                          , $"({length.Coefficient})/(({duration.Coefficient})*({duration.Coefficient}))"

                                            // TODO: Find a way to convert this.
                                          , "0"
                                          , (length.Unit.SortIndex   + 1)
                                          * (length.Prefix.SortIndex + 1)
                                          * (duration.Unit.SortIndex + 1)
                                          + duration.Prefix.SortIndex
                                           )
                               })
              .ToImmutableList();

      return accelerations;
   }

   private IReadOnlyList<UnitDefinition> GenerateAreas(IEnumerable<UnitDefinition> lengths)
   {
      var area = _unitTypesByName["Area"];

      // ReSharper disable once HeapView.DelegateAllocation
      var areas =
               from length in lengths
               select length with
                      {
                               Prefix = _noPrefix, UnitType = area, Unit = new Unit(
                                   length.System.Name
                                 , area.Name
                                 , $"square {length.UnitName}"
                                 , $"{length.Symbol}²"
                                 , length.Unit.PrefixScale
                                 , length.Unit.PrefixExponentsToInclude
                                 , length.Prefix.IsBasePrefix ? length.Unit.BaseUnitSystem : length.System.Name
                                 , $"square {length.BaseUnitName}"
                                 , $"({length.Coefficient})*({length.Coefficient})"

                                   // TODO: Find a way to convert this.
                                 , "0"
                                 , (length.Unit.SortIndex + 1) * (length.Prefix.SortIndex + 1)
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
                                 , $"{length.Symbol}³"
                                 , length.Unit.PrefixScale
                                 , length.Unit.PrefixExponentsToInclude
                                 , length.Prefix.IsBasePrefix ? length.Unit.BaseUnitSystem : length.System.Name
                                 , $"cubic {length.BaseUnitName}"
                                 , $"({length.Coefficient})*({length.Coefficient})*({length.Coefficient})"

                                   // TODO: Find a way to convert this.
                                 , "0"
                                 , (length.Unit.SortIndex + 1) * (length.Prefix.SortIndex + 1)
                                  )
                      };

      return volumes.ToImmutableList();
   }

   private IReadOnlyList<UnitDefinition> GenerateDensities
            (IReadOnlyList<UnitDefinition> masses, IReadOnlyList<UnitDefinition> volumes)
   {
      var density = _unitTypesByName["Density"];

      var densitiesInSI = (
                        from mass in masses
                        join volume in volumes on mass.System equals volume.System
                        where mass.System.Name == "SI" && volume.System.Name == "SI"
                        select volume with
                               {
                                        Prefix = _noPrefix, UnitType = density, Unit = new Unit(
                                            volume.System.Name
                                          , density.Name
                                          , $"{mass.UnitName} per {volume.UnitName}"
                                          , $"{mass.Symbol}/{volume.Symbol}"
                                          , volume.Unit.PrefixScale
                                          , volume.Unit.PrefixExponentsToInclude
                                          , volume.Unit.BaseUnitSystem
                                          , $"{mass.BaseUnitName} per {volume.BaseUnitName}"
                                          , $"({mass.Coefficient})/({volume.Coefficient})"

                                            // TODO: Find a way to convert this.
                                          , "0"
                                          , (mass.Unit.SortIndex   + 1)
                                          * (mass.Prefix.SortIndex + 1)
                                          * (volume.Unit.SortIndex + 1)
                                          + volume.Prefix.SortIndex
                                           )
                               })
              .ToImmutableList();

      var allDensities = (
                        from mass in masses
                        from volume in volumes //.on mass.System equals volume.System
                        select volume with
                               {
                                        Prefix = _noPrefix, UnitType = density, Unit = new Unit(
                                            volume.System.Name
                                          , density.Name
                                          , $"{mass.UnitName} per {volume.UnitName}"
                                          , $"{mass.Symbol}/{volume.Symbol}"
                                          , volume.Unit.PrefixScale
                                          , volume.Unit.PrefixExponentsToInclude
                                          , volume.Unit.BaseUnitSystem
                                          , $"{mass.BaseUnitName} per {volume.BaseUnitName}"
                                          , $"({mass.Coefficient})/({volume.Coefficient})"

                                            // TODO: Find a way to convert this.
                                          , "0"
                                          , (mass.Unit.SortIndex   + 1)
                                          * (mass.Prefix.SortIndex + 1)
                                          * (volume.Unit.SortIndex + 1)
                                          + volume.Prefix.SortIndex
                                           )
                               })
              .ToImmutableList();

      // ReSharper disable once UnusedVariable
      var baseDensities =
               from baseDensity in allDensities
               join derivedDensity in allDensities
                        on baseDensity.UnitName equals derivedDensity.BaseUnitName
               select baseDensity;

      var densities = densitiesInSI

               //.Concat(baseDensities)
               //.DistinctBy(x => x.UnitName.GetHashCode() ^ x.System.GetHashCode())
              .ToImmutableList();

      return densities;
   }

   #endregion

   #region Aggregate Repository instances.

   // ReSharper disable MemberCanBePrivate.Global
   public SystemRepository SystemRepo { get; } = new ();
   public UnitTypeRepository UnitTypeRepo { get; } = new ();
   public PrefixRepository PrefixRepo { get; } = new ();
   public UnitRepository UnitRepo { get; } = new ();

   // ReSharper restore MemberCanBePrivate.Global

   #endregion
}
