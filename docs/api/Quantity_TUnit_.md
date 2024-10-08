#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## Quantity<TUnit> Struct

Represents a quantity with an associated unit of measure.

```csharp
public readonly struct Quantity<TUnit> :
System.IComparable<Jcd.Units.Quantity<TUnit>>,
System.IFormattable,
System.IComparable,
System.IEquatable<Jcd.Units.Quantity<TUnit>>
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>
```
#### Type parameters

<a name='Jcd.Units.Quantity_TUnit_.TUnit'></a>

`TUnit`

The data type of the unit of measure. It must derive from [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

Implements [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1'), [System.IFormattable](https://docs.microsoft.com/en-us/dotnet/api/System.IFormattable 'System.IFormattable'), [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [Quantity(double, TUnit, IValueComparer&lt;double&gt;)](Quantity_TUnit_..ctor.jrWlrrNvat4HkIY9e+sV2g.md 'Jcd.Units.Quantity<TUnit>.Quantity(double, TUnit, Jcd.Units.IValueComparer<double>)') | Represents a quantity with an associated unit of measure. |
| [Quantity(double, TUnit)](Quantity_TUnit_..ctor.aqxzZRe0uEujrKe63265xg.md 'Jcd.Units.Quantity<TUnit>.Quantity(double, TUnit)') | Represents a quantity with an associated unit of measure. |

| Properties | |
| :--- | :--- |
| [ArithmeticUnitSelector](Quantity_TUnit_.ArithmeticUnitSelector.md 'Jcd.Units.Quantity<TUnit>.ArithmeticUnitSelector') | The [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy') used by quantities of the particular unit of<br/>measure type (e.g. lengths) to select which unit of measure will be returned from arithmetic operations. |
| [Comparer](Quantity_TUnit_.Comparer.md 'Jcd.Units.Quantity<TUnit>.Comparer') | The [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons: where `T` is a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [ComparisonUnitSelector](Quantity_TUnit_.ComparisonUnitSelector.md 'Jcd.Units.Quantity<TUnit>.ComparisonUnitSelector') | The [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy') used by quantities of the particular unit of<br/>measure type (e.g. lengths) to select which unit of measure will be used to perform comparisons. |
| [DefaultDoubleComparer](Quantity_TUnit_.DefaultDoubleComparer.md 'Jcd.Units.Quantity<TUnit>.DefaultDoubleComparer') | Sets the default [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used by quantities for the particular unit of<br/>measure type. (e.g. lengths.) |
| [RawValue](Quantity_TUnit_.RawValue.md 'Jcd.Units.Quantity<TUnit>.RawValue') | The numeric portion, without associated unit of measure |
| [Unit](Quantity_TUnit_.Unit.md 'Jcd.Units.Quantity<TUnit>.Unit') | The unit of measure. |

| Methods | |
| :--- | :--- |
| [CompareTo(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.CompareTo.pMImC2ItEM88nAbSDTvVCQ.md 'Jcd.Units.Quantity<TUnit>.CompareTo(Jcd.Units.Quantity<TUnit>)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for relative value. |
| [CompareTo(object)](Quantity_TUnit_.CompareTo.QxVeYuJ8ABkOamq2HTYYDQ.md 'Jcd.Units.Quantity<TUnit>.CompareTo(object)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for relative value. |
| [Equals(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.Equals.SpeTE654B/g+1OTKU83fHQ.md 'Jcd.Units.Quantity<TUnit>.Equals(Jcd.Units.Quantity<TUnit>)') | Compares this instance to another [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for equality. |
| [GetHashCode()](Quantity_TUnit_.GetHashCode().md 'Jcd.Units.Quantity<TUnit>.GetHashCode()') | Computes a hashcode for the quantity, so that numeric equivalence is maintained<br/>regardless of precise unit of measure is used, the hashcode is calculated on<br/>the fundamental unit representation. TUnit is included in the hashcode to ensure<br/>that differing units do not hash the same. |
| [To(TUnit)](Quantity_TUnit_.To.J+C5qhOb5vEvPPa1sEADMQ.md 'Jcd.Units.Quantity<TUnit>.To(TUnit)') | Converts the quantity from its current unit of measure to the target unit of measure. |
| [ToString()](Quantity_TUnit_.ToString().md 'Jcd.Units.Quantity<TUnit>.ToString()') | Formats a string with the quantity value followed by the symbol. |
| [ToString(string, IFormatProvider)](Quantity_TUnit_.ToString.bCYruWJK23dcw0i/e0WJlQ.md 'Jcd.Units.Quantity<TUnit>.ToString(string, System.IFormatProvider)') | Formats the value of the current instance using the specified format. |
| [ToString(string)](Quantity_TUnit_.ToString.43NvnAptNJaCqw3omGqmKw.md 'Jcd.Units.Quantity<TUnit>.ToString(string)') | Outputs the number formatted according to the [format](Quantity_TUnit_.ToString.43NvnAptNJaCqw3omGqmKw.md#Jcd.Units.Quantity_TUnit_.ToString(string).format 'Jcd.Units.Quantity<TUnit>.ToString(string).format')<br/>with unit symbol. |

| Operators | |
| :--- | :--- |
| [operator +(double, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Addition.N275nXuNDdy1Q+uQhPjDOg.md 'Jcd.Units.Quantity<TUnit>.op_Addition(double, Jcd.Units.Quantity<TUnit>)') | Performs addition on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;, double)](Quantity_TUnit_.op_Addition.uNOoURmuYbjt8Ho2SGJNyw.md 'Jcd.Units.Quantity<TUnit>.op_Addition(Jcd.Units.Quantity<TUnit>, double)') | Performs addition on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Addition.bnDkhy/vAEQtnQsRik5x3A.md 'Jcd.Units.Quantity<TUnit>.op_Addition(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Adds two quantities, selecting the larger unit of measure as the common representation. |
| [operator --(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Decrement./KwOSm38o5TkQtrk+upr0Q.md 'Jcd.Units.Quantity<TUnit>.op_Decrement(Jcd.Units.Quantity<TUnit>)') | Performs a unary decrement operation. |
| [operator /(double, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Division.EUY6ajhABLB8LI9SjSHVVA.md 'Jcd.Units.Quantity<TUnit>.op_Division(double, Jcd.Units.Quantity<TUnit>)') | Performs division on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator /(Quantity&lt;TUnit&gt;, double)](Quantity_TUnit_.op_Division.0DEdJW268kz/Il5udWTnAw.md 'Jcd.Units.Quantity<TUnit>.op_Division(Jcd.Units.Quantity<TUnit>, double)') | Performs division on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator /(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Division.1LIGwu7yWD11Wm19tN9QFg.md 'Jcd.Units.Quantity<TUnit>.op_Division(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs division on two quantities, converting to the larger of the two units of measure. |
| [explicit operator double(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Explicit.4bxqxpoGl8k45YqXTUhqfw.md 'Jcd.Units.Quantity<TUnit>.op_Explicit double(Jcd.Units.Quantity<TUnit>)') | Explicit cast conversion to double. |
| [operator &gt;(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_GreaterThan.+UCNOM8JduTESDD8/Fw8Ag.md 'Jcd.Units.Quantity<TUnit>.op_GreaterThan(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a greater than comparison between two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator &gt;=(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_GreaterThanOrEqual.6DclENKgCdc0oNx1hKqYnA.md 'Jcd.Units.Quantity<TUnit>.op_GreaterThanOrEqual(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a greater than or equals comparison between two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator ++(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Increment.9xDvkGJ2eerjYRVAOXibUg.md 'Jcd.Units.Quantity<TUnit>.op_Increment(Jcd.Units.Quantity<TUnit>)') | Performs a unary increment operation. |
| [operator &lt;(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_LessThan.cMfVVVxjqFGaTRoqp6vsTQ.md 'Jcd.Units.Quantity<TUnit>.op_LessThan(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a less than comparison between two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator &lt;=(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_LessThanOrEqual.MNvcnbrPApSkfbmtSjdRyQ.md 'Jcd.Units.Quantity<TUnit>.op_LessThanOrEqual(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs a less than or equals comparison between two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances. |
| [operator *(double, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Multiply.J1Vl2MofBLv1qoj4ymbTuQ.md 'Jcd.Units.Quantity<TUnit>.op_Multiply(double, Jcd.Units.Quantity<TUnit>)') | Performs multiplication on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator *(Quantity&lt;TUnit&gt;, double)](Quantity_TUnit_.op_Multiply.ovAMcYKP/OzSw2duxPkVow.md 'Jcd.Units.Quantity<TUnit>.op_Multiply(Jcd.Units.Quantity<TUnit>, double)') | Performs multiplication on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator *(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Multiply.oWuB8f1BZC4hOz++6BIfEw.md 'Jcd.Units.Quantity<TUnit>.op_Multiply(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs multiplication on two quantities, converting to the larger of the two units of measure. |
| [operator -(double, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Subtraction.CkwZFrzwXQevwa/lo4YEpw.md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(double, Jcd.Units.Quantity<TUnit>)') | Performs subtraction on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator -(Quantity&lt;TUnit&gt;, double)](Quantity_TUnit_.op_Subtraction.jBzeVVWNbwRXmeQkrf59fg.md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(Jcd.Units.Quantity<TUnit>, double)') | Performs subtraction on a double and a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator -(Quantity&lt;TUnit&gt;, Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_Subtraction.L9LDBAEg1E6w4WE+Mmmuhg.md 'Jcd.Units.Quantity<TUnit>.op_Subtraction(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>)') | Performs subtraction on two quantities, converting to the larger of the two units of measure. |
| [operator -(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_UnaryNegation.yEWzRQIiOjo4+L8tTYBODA.md 'Jcd.Units.Quantity<TUnit>.op_UnaryNegation(Jcd.Units.Quantity<TUnit>)') | Performs unary negation on the [RawValue](Quantity_TUnit_.RawValue.md 'Jcd.Units.Quantity<TUnit>.RawValue') component and<br/>returns a new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>'). |
| [operator +(Quantity&lt;TUnit&gt;)](Quantity_TUnit_.op_UnaryPlus.3b7wesr2xLKpTjKB5srLHw.md 'Jcd.Units.Quantity<TUnit>.op_UnaryPlus(Jcd.Units.Quantity<TUnit>)') | Performs a standard unary "+" operation. |
