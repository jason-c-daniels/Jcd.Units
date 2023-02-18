#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasure<TUnits> Class

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
public abstract class UnitOfMeasure<TUnits> :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitOfMeasure<TUnits>>
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasure_TUnits_.TUnits'></a>

`TUnits`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IEquatable](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable 'System.IEquatable') &#129106; UnitOfMeasure<TUnits>

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Jcd.Units.UnitOfMeasure&lt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')[TUnits](Jcd.Units.UnitOfMeasure_TUnits_.md#Jcd.Units.UnitOfMeasure_TUnits_.TUnits 'Jcd.Units.UnitOfMeasure<TUnits>.TUnits')[&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [UnitOfMeasure(string, string, double, double)](Jcd.Units.UnitOfMeasure_TUnits_.UnitOfMeasure(string,string,double,double).md 'Jcd.Units.UnitOfMeasure<TUnits>.UnitOfMeasure(string, string, double, double)') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitOfMeasure_TUnits_.Coefficient.md 'Jcd.Units.UnitOfMeasure<TUnits>.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitOfMeasure_TUnits_.Name.md 'Jcd.Units.UnitOfMeasure<TUnits>.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitOfMeasure_TUnits_.Offset.md 'Jcd.Units.UnitOfMeasure<TUnits>.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitOfMeasure_TUnits_.Symbol.md 'Jcd.Units.UnitOfMeasure<TUnits>.Symbol') | The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') |

| Methods | |
| :--- | :--- |
| [CompareTo(UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.CompareTo(Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.CompareTo(Jcd.Units.UnitOfMeasure<TUnits>)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') and another one. |
| [CompareTo(object)](Jcd.Units.UnitOfMeasure_TUnits_.CompareTo(object).md 'Jcd.Units.UnitOfMeasure<TUnits>.CompareTo(object)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') and another one. |
| [Equals(UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.Equals(Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.Equals(Jcd.Units.UnitOfMeasure<TUnits>)') | Compares this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitOfMeasure_TUnits_.GetHashCode().md 'Jcd.Units.UnitOfMeasure<TUnits>.GetHashCode()') | Computes the hash code for this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') |

| Operators | |
| :--- | :--- |
| [operator &gt;(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_GreaterThan(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_GreaterThan(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is greater than the right one. |
| [operator &gt;=(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_LessThan(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_LessThan(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is less than the right one. |
| [operator &lt;=(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is less than or equal to the right one. |
