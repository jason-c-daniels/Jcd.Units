#region

using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

using Jcd.Reflection;

#endregion

// ReSharper disable StaticMemberInGenericType
#pragma warning disable CS0414

namespace Jcd.Units;

/// <summary>
/// Provides unit registration, discovery, and lookup facilities.
/// </summary>
/// <typeparam name="TUnit">The type of unit</typeparam>
public class UnitRegistry<TUnit>
         where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
{
   /// <summary>
   /// The default unit registry instance.
   /// </summary>
   public static UnitRegistry<TUnit> Default = new ();

   private readonly ConcurrentBag<TUnit> _allItems = new ();
   private readonly SemaphoreSlim _bagLock = new (1, 1);

   // ReSharper disable once StaticMemberInGenericType
   private bool _inAutoregister;

   private ILookup<string, TUnit>? _nameLookup;
   private bool _needsRebuild = true;
   private ILookup<string, TUnit>? _symbolLookup;

   private UnitRegistry() { }

   /// <summary>
   /// Returns a lookup of the named unit to the unit(s) with matching names.
   /// </summary>
   public ILookup<string, TUnit> NameLookup
   {
      get
      {
         RebuildIfNeeded();

         return _nameLookup!;
      }
   }

   /// <summary>
   /// Returns a lookup of the unit(s) with matching symbols.
   /// </summary>
   public ILookup<string, TUnit> SymbolLookup
   {
      get
      {
         RebuildIfNeeded();

         return _symbolLookup!;
      }
   }

   /// <summary>
   /// All registered or discovered instances of the type of unit.
   /// </summary>
   public IReadOnlyList<TUnit> All => _allItems.ToArray();

   private void RebuildIfNeeded()
   {
      if (_needsRebuild)
      {
         _bagLock.Wait();

         _nameLookup   = _allItems.ToLookup(x => x.Name);
         _symbolLookup = _allItems.ToLookup(x => x.Symbol);
         _bagLock.Release();
      }
   }

   /// <summary>
   /// Searches the specified assembly and registers matching unit types from fields and/or properties.
   /// </summary>
   public void AutoregisterFrom(Assembly assembly)
   {
      var fieldUnits =
               from type in assembly.GetTypes()
               from field in type.GetFields(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
               where field.FieldType == typeof(TUnit)
               select field.GetValue(field.Name) as TUnit;

      var propertyUnits =
               from type in assembly.GetTypes()
               from field in type.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public)
               where field.PropertyType == typeof(TUnit)
               select field.GetValue(field.Name) as TUnit;

      _bagLock.Wait();
      _inAutoregister = true;

      foreach (var unit in fieldUnits) Register(unit);

      foreach (var unit in propertyUnits) Register(unit);

      _inAutoregister = false;
      _bagLock.Release();
   }
   
   /// <summary>
   /// Searches all loaded assemblies and registers matching unit types from fields and/or properties.
   /// </summary>
   public void AutoregisterFromAllAssemblies()
   {
      var assemblies = AppDomain.CurrentDomain.GetAssemblies();

      foreach (var assembly in assemblies)
      {
         AutoregisterFrom(assembly);
      }
   }

   /// <summary>
   /// Registers a single unit of measure.
   /// </summary>
   /// <param name="unit">The unit of measure to register.</param>
   public void Register(TUnit unit)
   {
      var locked = false;

      if (!_inAutoregister)
      {
         _bagLock.Wait();
         locked = true;
      }

      _needsRebuild = true;

      _allItems.Add(unit);
      if (locked) _bagLock.Release();
   }
}

/// <summary>
/// Provides global unit of measure registration and discovery.
/// </summary>
public class UnitRegistry
{
   /// <summary>
   /// The global registration service.
   /// </summary>
   public static UnitRegistry Default = new ();

   private UnitRegistry() { }

   /// <summary>
   /// Registers a unit of measure with the global registry.
   /// </summary>
   /// <param name="unit">The unit of measure.</param>
   /// <typeparam name="TUnit">The type of unit of measure.</typeparam>
   public void Register<TUnit>(TUnit unit)
            where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
   {
      UnitRegistry<TUnit>.Default.Register(unit);
   }

   /// <summary>
   /// Searches all loaded assemblies and registers matching unit types from fields and/or properties.
   /// </summary>
   /// <typeparam name="TUnit">The type of unit of measure to discover and register.</typeparam>
   public void Autoregister<TUnit>()
            where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
   {
      UnitRegistry<TUnit>.Default.AutoregisterFromAllAssemblies();
   }

   /// <summary>
   /// Searches all loaded assemblies and registers matching unit types from fields and/or properties.
   /// </summary>
   /// <typeparam name="TUnit">The type of unit of measure to discover and register.</typeparam>
   public void AutoregisterFrom<TUnit>(Assembly assembly)
            where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
   {
      UnitRegistry<TUnit>.Default.AutoregisterFrom(assembly);
   }
   
   /// <summary>
   /// Gets a name based <see cref="ILookup{TKey,TElement}"/> for the requested unit type.
   /// </summary>
   /// <typeparam name="TUnit">The unit of measure type.</typeparam>
   /// <returns>A name based <see cref="ILookup{TKey,TElement}"/> for the requested unit type.</returns>
   public ILookup<string, TUnit> GetNameLookup<TUnit>()
            where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
      => UnitRegistry<TUnit>.Default.NameLookup;

   /// <summary>
   /// Gets a symbol based <see cref="ILookup{TKey,TElement}"/> for the requested unit type.
   /// </summary>
   /// <typeparam name="TUnit">The unit of measure type.</typeparam>
   /// <returns>A name based <see cref="ILookup{TKey,TElement}"/> for the requested unit type.</returns>
   public ILookup<string, TUnit> GetSymbolLookup<TUnit>()
            where TUnit : UnitOfMeasure<TUnit>, IEquatable<TUnit>
      => UnitRegistry<TUnit>.Default.SymbolLookup;

   /// <summary>
   /// Searches all loaded assemblies and registers all unit of measure types from fields and/or properties.
   /// </summary>
   public void AutoregisterAllUnits()
   {
      var assemblies = AppDomain.CurrentDomain.GetAssemblies();

      foreach (var assembly in assemblies)
      {
         AutoregisterAllUnitsFrom(assembly);
      }
   }
   
   /// <summary>
   /// Searches all loaded assemblies and registers all unit of measure types from fields and/or properties.
   /// </summary>
   public void AutoregisterAllUnitsFrom(Assembly assembly)
   {
      var types = assembly
                           .FindImplementationsOf(typeof(UnitOfMeasure<>));

      foreach (var type in types)
      {
         typeof(UnitRegistry)
                 .GetMethod(nameof(Autoregister))!
                 .MakeGenericMethod(type)
                 .Invoke(this, null);
      }
   }
}
