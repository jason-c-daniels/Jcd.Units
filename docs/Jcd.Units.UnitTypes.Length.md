#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Length Struct

Constructs a unit measuring a specified `Length`

```csharp
public struct Length :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Length>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')[Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')

| Constructors | |
| :--- | :--- |
| [Length(string, string, double, double)](Jcd.Units.UnitTypes.Length.Length(string,string,double,double).md 'Jcd.Units.UnitTypes.Length.Length(string, string, double, double)') | Constructs a unit measuring a specified `Length` |
| [Length(string, string, Length, double, double)](Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).md 'Jcd.Units.UnitTypes.Length.Length(string, string, Jcd.Units.UnitTypes.Length, double, double)') | Constructs a unit measuring a specified `Length` using another Length as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Length.Coefficient.md 'Jcd.Units.UnitTypes.Length.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Length.Name.md 'Jcd.Units.UnitTypes.Length.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Length.Offset.md 'Jcd.Units.UnitTypes.Length.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Length.Symbol.md 'Jcd.Units.UnitTypes.Length.Symbol') | The symbol or abbreviation to represent the `Length` |

| Methods | |
| :--- | :--- |
| [CompareTo(Length)](Jcd.Units.UnitTypes.Length.CompareTo(Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.CompareTo(Jcd.Units.UnitTypes.Length)') | Performs a relative comparison between this `Length` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Length.CompareTo(object).md 'Jcd.Units.UnitTypes.Length.CompareTo(object)') | Performs a relative comparison between this `Length` and another one. |
| [Equals(Length)](Jcd.Units.UnitTypes.Length.Equals(Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.Equals(Jcd.Units.UnitTypes.Length)') | Compares this `Length` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Length.GetHashCode().md 'Jcd.Units.UnitTypes.Length.GetHashCode()') | Computes the hash code for this `Length` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Length, Length)](Jcd.Units.UnitTypes.Length.op_GreaterThan(Jcd.Units.UnitTypes.Length,Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.op_GreaterThan(Jcd.Units.UnitTypes.Length, Jcd.Units.UnitTypes.Length)') | Compares two `Length` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Length, Length)](Jcd.Units.UnitTypes.Length.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Length,Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Length, Jcd.Units.UnitTypes.Length)') | Compares two `Length` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Length, Length)](Jcd.Units.UnitTypes.Length.op_LessThan(Jcd.Units.UnitTypes.Length,Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.op_LessThan(Jcd.Units.UnitTypes.Length, Jcd.Units.UnitTypes.Length)') | Compares two `Length` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Length, Length)](Jcd.Units.UnitTypes.Length.op_LessThanOrEqual(Jcd.Units.UnitTypes.Length,Jcd.Units.UnitTypes.Length).md 'Jcd.Units.UnitTypes.Length.op_LessThanOrEqual(Jcd.Units.UnitTypes.Length, Jcd.Units.UnitTypes.Length)') | Compares two `Length` instances to determine if the left one is less than or equal to the right one. |
