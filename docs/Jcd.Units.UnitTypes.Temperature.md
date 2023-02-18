#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Temperature Struct

Constructs a unit measuring a specified [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

```csharp
public readonly struct Temperature :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Temperature>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Temperature(string, string, double, double)](Jcd.Units.UnitTypes.Temperature.Temperature(string,string,double,double).md 'Jcd.Units.UnitTypes.Temperature.Temperature(string, string, double, double)') | Constructs a unit measuring a specified [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') |
| [Temperature(string, string, Temperature, double, double)](Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).md 'Jcd.Units.UnitTypes.Temperature.Temperature(string, string, Jcd.Units.UnitTypes.Temperature, double, double)') | Constructs a unit measuring a specified [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') using another Temperature as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Temperature.Coefficient.md 'Jcd.Units.UnitTypes.Temperature.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Temperature.Name.md 'Jcd.Units.UnitTypes.Temperature.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Temperature.Offset.md 'Jcd.Units.UnitTypes.Temperature.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Temperature.Symbol.md 'Jcd.Units.UnitTypes.Temperature.Symbol') | The symbol or abbreviation to represent the [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') |

| Methods | |
| :--- | :--- |
| [CompareTo(Temperature)](Jcd.Units.UnitTypes.Temperature.CompareTo(Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.CompareTo(Jcd.Units.UnitTypes.Temperature)') | Performs a relative comparison between this [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Temperature.CompareTo(object).md 'Jcd.Units.UnitTypes.Temperature.CompareTo(object)') | Performs a relative comparison between this [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') and another one. |
| [Equals(Temperature)](Jcd.Units.UnitTypes.Temperature.Equals(Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.Equals(Jcd.Units.UnitTypes.Temperature)') | Compares this [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Temperature.GetHashCode().md 'Jcd.Units.UnitTypes.Temperature.GetHashCode()') | Computes the hash code for this [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') |

| Operators | |
| :--- | :--- |
| [operator &gt;(Temperature, Temperature)](Jcd.Units.UnitTypes.Temperature.op_GreaterThan(Jcd.Units.UnitTypes.Temperature,Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.op_GreaterThan(Jcd.Units.UnitTypes.Temperature, Jcd.Units.UnitTypes.Temperature)') | Compares two [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Temperature, Temperature)](Jcd.Units.UnitTypes.Temperature.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Temperature,Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Temperature, Jcd.Units.UnitTypes.Temperature)') | Compares two [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Temperature, Temperature)](Jcd.Units.UnitTypes.Temperature.op_LessThan(Jcd.Units.UnitTypes.Temperature,Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.op_LessThan(Jcd.Units.UnitTypes.Temperature, Jcd.Units.UnitTypes.Temperature)') | Compares two [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') instances to determine if the left one is less than the right one. |
| [operator &lt;=(Temperature, Temperature)](Jcd.Units.UnitTypes.Temperature.op_LessThanOrEqual(Jcd.Units.UnitTypes.Temperature,Jcd.Units.UnitTypes.Temperature).md 'Jcd.Units.UnitTypes.Temperature.op_LessThanOrEqual(Jcd.Units.UnitTypes.Temperature, Jcd.Units.UnitTypes.Temperature)') | Compares two [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') instances to determine if the left one is less than or equal to the right one. |
