#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## Quantity<TUnits> Struct

Represents a quantity with an associated unit of measure.

```csharp
public readonly struct Quantity<TUnits>
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>
```
#### Type parameters

<a name='Jcd.Units.Quantity_TUnits_.TUnits'></a>

`TUnits`

The data type of the unit of measure.

| Constructors | |
| :--- | :--- |
| [Quantity(double, TUnits)](Jcd.Units.Quantity_TUnits_.Quantity(double,TUnits).md 'Jcd.Units.Quantity<TUnits>.Quantity(double, TUnits)') | Represents a quantity with an associated unit of measure. |

| Properties | |
| :--- | :--- |
| [RawValue](Jcd.Units.Quantity_TUnits_.RawValue.md 'Jcd.Units.Quantity<TUnits>.RawValue') | The numeric portion, without associated unit of measure |
| [Units](Jcd.Units.Quantity_TUnits_.Units.md 'Jcd.Units.Quantity<TUnits>.Units') | The unit of measure. |

| Methods | |
| :--- | :--- |
| [CompareTo(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.CompareTo(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.CompareTo(Jcd.Units.Quantity<TUnits>)') | Compares this instance to another [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance for relative value. |
| [CompareTo(object)](Jcd.Units.Quantity_TUnits_.CompareTo(object).md 'Jcd.Units.Quantity<TUnits>.CompareTo(object)') | Compares this instance to another [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance for relative value. |
| [Equals(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.Equals(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.Equals(Jcd.Units.Quantity<TUnits>)') | Compares this instance to another [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance for equality. |
| [GetHashCode()](Jcd.Units.Quantity_TUnits_.GetHashCode().md 'Jcd.Units.Quantity<TUnits>.GetHashCode()') | Computes a hashcode for the quantity. So that numeric equivalence is maintained<br/>regardless of precise unit of measure is used, the hashcode is calculated on<br/>the base unit representation. TUnits is included in the hashcode to ensure<br/>that differing units do not compare the same. |
| [To(TUnits)](Jcd.Units.Quantity_TUnits_.To(TUnits).md 'Jcd.Units.Quantity<TUnits>.To(TUnits)') | Converts the quantity from its current unit of measure to the target unit of measure. |
| [ToString()](Jcd.Units.Quantity_TUnits_.ToString().md 'Jcd.Units.Quantity<TUnits>.ToString()') | Formats a string with the quantity value followed by the symbol. |

| Operators | |
| :--- | :--- |
| [operator +(double, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Addition(double,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Addition(double, Jcd.Units.Quantity<TUnits>)') | Performs addition on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator +(Quantity&lt;TUnits&gt;, double)](Jcd.Units.Quantity_TUnits_.op_Addition(Jcd.Units.Quantity_TUnits_,double).md 'Jcd.Units.Quantity<TUnits>.op_Addition(Jcd.Units.Quantity<TUnits>, double)') | Performs addition on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator +(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Addition(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Addition(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Adds two quantities, selecting the larger unit of measure as the common representation. |
| [operator --(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Decrement(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Decrement(Jcd.Units.Quantity<TUnits>)') | Performs a unary decrement operation. |
| [operator /(double, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Division(double,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Division(double, Jcd.Units.Quantity<TUnits>)') | Performs division on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator /(Quantity&lt;TUnits&gt;, double)](Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,double).md 'Jcd.Units.Quantity<TUnits>.op_Division(Jcd.Units.Quantity<TUnits>, double)') | Performs division on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator /(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Division(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs division on two quantities, converting to the larger of the two units of measure. |
| [operator &gt;(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_GreaterThan(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_GreaterThan(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs a greater than comparison between two [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instances. |
| [operator &gt;=(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_GreaterThanOrEqual(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_GreaterThanOrEqual(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs a greater than or equals comparison between two [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instances. |
| [operator ++(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Increment(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Increment(Jcd.Units.Quantity<TUnits>)') | Performs a unary increment operation. |
| [operator &lt;(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_LessThan(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_LessThan(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs a less than comparison between two [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instances. |
| [operator &lt;=(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_LessThanOrEqual(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_LessThanOrEqual(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs a less than or equals comparison between two [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instances. |
| [operator *(double, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Multiply(double,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Multiply(double, Jcd.Units.Quantity<TUnits>)') | Performs multiplication on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator *(Quantity&lt;TUnits&gt;, double)](Jcd.Units.Quantity_TUnits_.op_Multiply(Jcd.Units.Quantity_TUnits_,double).md 'Jcd.Units.Quantity<TUnits>.op_Multiply(Jcd.Units.Quantity<TUnits>, double)') | Performs multiplication on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator *(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Multiply(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Multiply(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs multiplication on two quantities, converting to the larger of the two units of measure. |
| [operator -(double, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Subtraction(double,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Subtraction(double, Jcd.Units.Quantity<TUnits>)') | Performs subtraction on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator -(Quantity&lt;TUnits&gt;, double)](Jcd.Units.Quantity_TUnits_.op_Subtraction(Jcd.Units.Quantity_TUnits_,double).md 'Jcd.Units.Quantity<TUnits>.op_Subtraction(Jcd.Units.Quantity<TUnits>, double)') | Performs subtraction on a double and a [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator -(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_Subtraction(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_Subtraction(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>)') | Performs subtraction on two quantities, converting to the larger of the two units of measure. |
| [operator -(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_UnaryNegation(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_UnaryNegation(Jcd.Units.Quantity<TUnits>)') | Performs unary negation on the [RawValue](Jcd.Units.Quantity_TUnits_.RawValue.md 'Jcd.Units.Quantity<TUnits>.RawValue') component and<br/>returns a new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>'). |
| [operator +(Quantity&lt;TUnits&gt;)](Jcd.Units.Quantity_TUnits_.op_UnaryPlus(Jcd.Units.Quantity_TUnits_).md 'Jcd.Units.Quantity<TUnits>.op_UnaryPlus(Jcd.Units.Quantity<TUnits>)') | Performs a standard unary "+" operation. |
