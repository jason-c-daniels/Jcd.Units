#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## Quantity<TUnit> Struct

Represents a quantity with an associated unit of measure.

```csharp
public readonly struct Quantity<TUnit>
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>
```
#### Type parameters

<a name='Jcd.Units.Quantity_TUnit_.TUnit'></a>

`TUnit`

The data type of the unit of measure. It must derive from [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

| Constructors | |
| :--- | :--- |
| [Quantity(double, TUnit, IValueComparer&lt;double&gt;)](Jcd.Units.Quantity_TUnit_.Quantity(double,TUnit,Jcd.Units.IValueComparer_double_).md 'Jcd.Units.Quantity<TUnit>.Quantity(double, TUnit, Jcd.Units.IValueComparer<double>)') | Represents a quantity with an associated unit of measure. |
| [Quantity(double, TUnit)](Jcd.Units.Quantity_TUnit_.Quantity(double,TUnit).md 'Jcd.Units.Quantity<TUnit>.Quantity(double, TUnit)') | Represents a quantity with an associated unit of measure. |

| Properties | |
| :--- | :--- |
| [DefaultDoubleComparer](Jcd.Units.Quantity_TUnit_.DefaultDoubleComparer.md 'Jcd.Units.Quantity<TUnit>.DefaultDoubleComparer') | Sets the [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used by quantities for the particular unit of<br/>measure type. (e.g. lengths.) |
| [RawValue](Jcd.Units.Quantity_TUnit_.RawValue.md 'Jcd.Units.Quantity<TUnit>.RawValue') | The numeric portion, without associated unit of measure |
| [Unit](Jcd.Units.Quantity_TUnit_.Unit.md 'Jcd.Units.Quantity<TUnit>.Unit') | The unit of measure. |

| Methods | |
| :--- | :--- |
| [CompareTo(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.CompareTo(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.CompareTo(Jcd.Units.Quantity<TUnit>)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for relative value. |
| [CompareTo(object)](Jcd.Units.Quantity_TUnit_.CompareTo(object).md 'Jcd.Units.Quantity<TUnit>.CompareTo(object)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for relative value. |
| [Equals(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.Equals(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.Equals(Jcd.Units.Quantity<TUnit>)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for equality. |
| [GetHashCode()](Jcd.Units.Quantity_TUnit_.GetHashCode().md 'Jcd.Units.Quantity<TUnit>.GetHashCode()') | Computes a hashcode for the quantity. So that numeric equivalence is maintained<br/>regardless of precise unit of measure is used, the hashcode is calculated on<br/>the base unit representation. TUnit is included in the hashcode to ensure<br/>that differing units do not compare the same. |
| [To(TUnit)](Jcd.Units.Quantity_TUnit_.To(TUnit).md 'Jcd.Units.Quantity<TUnit>.To(TUnit)') | Converts the quantity from its current unit of measure to the target unit of measure. |
| [ToString()](Jcd.Units.Quantity_TUnit_.ToString().md 'Jcd.Units.Quantity<TUnit>.ToString()') | Formats a string with the quantity value followed by the symbol. |

| Operators | |
| :--- | :--- |
| [operator +(double, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Addition(double,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Addition(double, Jcd.Units.Quantity<TUnit>)') | Performs addition on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;, double)](Jcd.Units.Quantity_TUnit_.op_Addition(Jcd.Units.Quantity_TUnit_,double).md 'Jcd.Units.Quantity<TUnit>.op_Addition(Jcd.Units.Quantity<TUnit>, double)') | Performs addition on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Addition(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Addition(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Adds two quantities, selecting the larger unit of measure as the common representation. |
| [operator --(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Decrement(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Decrement(Jcd.Units.Quantity<TUnit>)') | Performs a unary decrement operation. |
| [operator /(double, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Division(double,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Division(double, Jcd.Units.Quantity<TUnit>)') | Performs division on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator /(Quantity&lt;TUnit&gt;, double)](Jcd.Units.Quantity_TUnit_.op_Division(Jcd.Units.Quantity_TUnit_,double).md 'Jcd.Units.Quantity<TUnit>.op_Division(Jcd.Units.Quantity<TUnit>, double)') | Performs division on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator /(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Division(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Division(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs division on two quantities, converting to the larger of the two units of measure. |
| [operator &gt;(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_GreaterThan(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_GreaterThan(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a greater than comparison between two [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator &gt;=(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_GreaterThanOrEqual(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_GreaterThanOrEqual(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a greater than or equals comparison between two [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator ++(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Increment(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Increment(Jcd.Units.Quantity<TUnit>)') | Performs a unary increment operation. |
| [operator &lt;(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_LessThan(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_LessThan(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a less than comparison between two [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator &lt;=(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_LessThanOrEqual(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_LessThanOrEqual(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a less than or equals comparison between two [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator *(double, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Multiply(double,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Multiply(double, Jcd.Units.Quantity<TUnit>)') | Performs multiplication on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator *(Quantity&lt;TUnit&gt;, double)](Jcd.Units.Quantity_TUnit_.op_Multiply(Jcd.Units.Quantity_TUnit_,double).md 'Jcd.Units.Quantity<TUnit>.op_Multiply(Jcd.Units.Quantity<TUnit>, double)') | Performs multiplication on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator *(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Multiply(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Multiply(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs multiplication on two quantities, converting to the larger of the two units of measure. |
| [operator -(double, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Subtraction(double,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(double, Jcd.Units.Quantity<TUnit>)') | Performs subtraction on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator -(Quantity&lt;TUnit&gt;, double)](Jcd.Units.Quantity_TUnit_.op_Subtraction(Jcd.Units.Quantity_TUnit_,double).md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(Jcd.Units.Quantity<TUnit>, double)') | Performs subtraction on a double and a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator -(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_Subtraction(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs subtraction on two quantities, converting to the larger of the two units of measure. |
| [operator -(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_UnaryNegation(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_UnaryNegation(Jcd.Units.Quantity<TUnit>)') | Performs unary negation on the [RawValue](Jcd.Units.Quantity_TUnit_.RawValue.md 'Jcd.Units.Quantity<TUnit>.RawValue') component and<br/>returns a new [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;)](Jcd.Units.Quantity_TUnit_.op_UnaryPlus(Jcd.Units.Quantity_TUnit_).md 'Jcd.Units.Quantity<TUnit>.op_UnaryPlus(Jcd.Units.Quantity<TUnit>)') | Performs a standard unary "+" operation. |
