#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Force Struct

Constructs a unit measuring a specified `Force`

```csharp
public struct Force :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Force>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Force(string, string, double, double)](Jcd.Units.UnitTypes.Force.Force(string,string,double,double).md 'Jcd.Units.UnitTypes.Force.Force(string, string, double, double)') | Constructs a unit measuring a specified `Force` |
| [Force(string, string, Force, double, double)](Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).md 'Jcd.Units.UnitTypes.Force.Force(string, string, Jcd.Units.UnitTypes.Force, double, double)') | Constructs a unit measuring a specified `Force` using another Force as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Force.Coefficient.md 'Jcd.Units.UnitTypes.Force.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Force.Name.md 'Jcd.Units.UnitTypes.Force.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Force.Offset.md 'Jcd.Units.UnitTypes.Force.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Force.Symbol.md 'Jcd.Units.UnitTypes.Force.Symbol') | The symbol or abbreviation to represent the `Force` |

| Methods | |
| :--- | :--- |
| [CompareTo(Force)](Jcd.Units.UnitTypes.Force.CompareTo(Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.CompareTo(Jcd.Units.UnitTypes.Force)') | Performs a relative comparison between this `Force` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Force.CompareTo(object).md 'Jcd.Units.UnitTypes.Force.CompareTo(object)') | Performs a relative comparison between this `Force` and another one. |
| [Equals(Force)](Jcd.Units.UnitTypes.Force.Equals(Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.Equals(Jcd.Units.UnitTypes.Force)') | Compares this `Force` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Force.GetHashCode().md 'Jcd.Units.UnitTypes.Force.GetHashCode()') | Computes the hash code for this `Force` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Force, Force)](Jcd.Units.UnitTypes.Force.op_GreaterThan(Jcd.Units.UnitTypes.Force,Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.op_GreaterThan(Jcd.Units.UnitTypes.Force, Jcd.Units.UnitTypes.Force)') | Compares two `Force` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Force, Force)](Jcd.Units.UnitTypes.Force.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Force,Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Force, Jcd.Units.UnitTypes.Force)') | Compares two `Force` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Force, Force)](Jcd.Units.UnitTypes.Force.op_LessThan(Jcd.Units.UnitTypes.Force,Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.op_LessThan(Jcd.Units.UnitTypes.Force, Jcd.Units.UnitTypes.Force)') | Compares two `Force` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Force, Force)](Jcd.Units.UnitTypes.Force.op_LessThanOrEqual(Jcd.Units.UnitTypes.Force,Jcd.Units.UnitTypes.Force).md 'Jcd.Units.UnitTypes.Force.op_LessThanOrEqual(Jcd.Units.UnitTypes.Force, Jcd.Units.UnitTypes.Force)') | Compares two `Force` instances to determine if the left one is less than or equal to the right one. |
