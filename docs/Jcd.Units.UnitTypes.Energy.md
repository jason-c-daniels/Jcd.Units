#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Energy Struct

Constructs a unit measuring a specified `Energy`

```csharp
public struct Energy :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Energy>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Energy(string, string, double, double)](Jcd.Units.UnitTypes.Energy.Energy(string,string,double,double).md 'Jcd.Units.UnitTypes.Energy.Energy(string, string, double, double)') | Constructs a unit measuring a specified `Energy` |
| [Energy(string, string, Energy, double, double)](Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).md 'Jcd.Units.UnitTypes.Energy.Energy(string, string, Jcd.Units.UnitTypes.Energy, double, double)') | Constructs a unit measuring a specified `Energy` using another Energy as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Energy.Coefficient.md 'Jcd.Units.UnitTypes.Energy.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Energy.Name.md 'Jcd.Units.UnitTypes.Energy.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Energy.Offset.md 'Jcd.Units.UnitTypes.Energy.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Energy.Symbol.md 'Jcd.Units.UnitTypes.Energy.Symbol') | The symbol or abbreviation to represent the `Energy` |

| Methods | |
| :--- | :--- |
| [CompareTo(Energy)](Jcd.Units.UnitTypes.Energy.CompareTo(Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.CompareTo(Jcd.Units.UnitTypes.Energy)') | Performs a relative comparison between this `Energy` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Energy.CompareTo(object).md 'Jcd.Units.UnitTypes.Energy.CompareTo(object)') | Performs a relative comparison between this `Energy` and another one. |
| [Equals(Energy)](Jcd.Units.UnitTypes.Energy.Equals(Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.Equals(Jcd.Units.UnitTypes.Energy)') | Compares this `Energy` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Energy.GetHashCode().md 'Jcd.Units.UnitTypes.Energy.GetHashCode()') | Computes the hash code for this `Energy` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Energy, Energy)](Jcd.Units.UnitTypes.Energy.op_GreaterThan(Jcd.Units.UnitTypes.Energy,Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.op_GreaterThan(Jcd.Units.UnitTypes.Energy, Jcd.Units.UnitTypes.Energy)') | Compares two `Energy` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Energy, Energy)](Jcd.Units.UnitTypes.Energy.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Energy,Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Energy, Jcd.Units.UnitTypes.Energy)') | Compares two `Energy` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Energy, Energy)](Jcd.Units.UnitTypes.Energy.op_LessThan(Jcd.Units.UnitTypes.Energy,Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.op_LessThan(Jcd.Units.UnitTypes.Energy, Jcd.Units.UnitTypes.Energy)') | Compares two `Energy` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Energy, Energy)](Jcd.Units.UnitTypes.Energy.op_LessThanOrEqual(Jcd.Units.UnitTypes.Energy,Jcd.Units.UnitTypes.Energy).md 'Jcd.Units.UnitTypes.Energy.op_LessThanOrEqual(Jcd.Units.UnitTypes.Energy, Jcd.Units.UnitTypes.Energy)') | Compares two `Energy` instances to determine if the left one is less than or equal to the right one. |
