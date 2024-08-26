#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitRegistry<TUnit> Class

Provides unit registration, discovery, and lookup facilities.

```csharp
public class UnitRegistry<TUnit>
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, System.IEquatable<TUnit>
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry_TUnit_.TUnit'></a>

`TUnit`

The type of unit

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnitRegistry<TUnit>

| Fields | |
| :--- | :--- |
| [Default](UnitRegistry_TUnit_.Default.md 'Jcd.Units.UnitRegistry<TUnit>.Default') | The default unit registry instance. |

| Properties | |
| :--- | :--- |
| [All](UnitRegistry_TUnit_.All.md 'Jcd.Units.UnitRegistry<TUnit>.All') | All registered or discovered instances of the type of unit. |
| [NameLookup](UnitRegistry_TUnit_.NameLookup.md 'Jcd.Units.UnitRegistry<TUnit>.NameLookup') | Returns a lookup of the named unit to the unit(s) with matching names. |
| [SymbolLookup](UnitRegistry_TUnit_.SymbolLookup.md 'Jcd.Units.UnitRegistry<TUnit>.SymbolLookup') | Returns a lookup of the unit(s) with matching symbols. |
| [SystemLookup](UnitRegistry_TUnit_.SystemLookup.md 'Jcd.Units.UnitRegistry<TUnit>.SystemLookup') | Returns a lookup of the unit(s) with matching symbols. |

| Methods | |
| :--- | :--- |
| [AutoregisterFrom(Assembly)](UnitRegistry_TUnit_.AutoregisterFrom.r7PAk7WsghBRW3QQw0Viow.md 'Jcd.Units.UnitRegistry<TUnit>.AutoregisterFrom(System.Reflection.Assembly)') | Searches the specified assembly and registers matching unit types from fields and/or properties. |
| [AutoregisterFromAllAssemblies()](UnitRegistry_TUnit_.AutoregisterFromAllAssemblies().md 'Jcd.Units.UnitRegistry<TUnit>.AutoregisterFromAllAssemblies()') | Searches all loaded assemblies and registers matching unit types from fields and/or properties. |
| [Register(TUnit)](UnitRegistry_TUnit_.Register.0P89l8yEDFFWnoeFBgUPmQ.md 'Jcd.Units.UnitRegistry<TUnit>.Register(TUnit)') | Registers a single unit of measure. |
