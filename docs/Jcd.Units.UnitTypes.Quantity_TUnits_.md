#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Quantity<TUnits> Struct

Represents a quantity with an associated unit of measure.

```csharp
public readonly struct Quantity<TUnits>
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>
```
#### Type parameters

<a name='Jcd.Units.UnitTypes.Quantity_TUnits_.TUnits'></a>

`TUnits`

The data type of the unit of measure.

| Constructors | |
| :--- | :--- |
| [Quantity(double, TUnits)](Jcd.Units.UnitTypes.Quantity_TUnits_.Quantity(double,TUnits).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.Quantity(double, TUnits)') | Represents a quantity with an associated unit of measure. |

| Properties | |
| :--- | :--- |
| [RawValue](Jcd.Units.UnitTypes.Quantity_TUnits_.RawValue.md 'Jcd.Units.UnitTypes.Quantity<TUnits>.RawValue') | The numeric portion, without associated unit of measure |
| [Units](Jcd.Units.UnitTypes.Quantity_TUnits_.Units.md 'Jcd.Units.UnitTypes.Quantity<TUnits>.Units') | The unit of measure. |

| Methods | |
| :--- | :--- |
| [To(TUnits)](Jcd.Units.UnitTypes.Quantity_TUnits_.To(TUnits).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.To(TUnits)') | Converts the quantity from its current unit of measure to the target unit of measure. |

| Operators | |
| :--- | :--- |
| [operator +(Quantity&lt;TUnits&gt;, double)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Addition(Jcd.Units.UnitTypes.Quantity_TUnits_,double).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Addition(Jcd.Units.UnitTypes.Quantity<TUnits>, double)') | Performs addition on a `Quantity` (left-hand operand) and a double. |
| [operator +(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Addition(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Addition(Jcd.Units.UnitTypes.Quantity<TUnits>, Jcd.Units.UnitTypes.Quantity<TUnits>)') | Adds two quantities, selecting the larger unit of measure as the common representation. |
| [operator /(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Division(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Division(Jcd.Units.UnitTypes.Quantity<TUnits>, Jcd.Units.UnitTypes.Quantity<TUnits>)') | Performs division on two quantities, converting to the larger of the two units of measure. |
| [operator *(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Multiply(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Multiply(Jcd.Units.UnitTypes.Quantity<TUnits>, Jcd.Units.UnitTypes.Quantity<TUnits>)') | Performs multiplication on two quantities, converting to the larger of the two units of measure. |
| [operator -(Quantity&lt;TUnits&gt;, double)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Subtraction(Jcd.Units.UnitTypes.Quantity_TUnits_,double).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Subtraction(Jcd.Units.UnitTypes.Quantity<TUnits>, double)') | Performs subtraction on a `Quantity` (left-hand operand) and a double. |
| [operator -(Quantity&lt;TUnits&gt;, Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_Subtraction(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_Subtraction(Jcd.Units.UnitTypes.Quantity<TUnits>, Jcd.Units.UnitTypes.Quantity<TUnits>)') | Performs subtraction on two quantities, converting to the larger of the two units of measure. |
| [operator -(Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_UnaryNegation(Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_UnaryNegation(Jcd.Units.UnitTypes.Quantity<TUnits>)') | Performs standard unary negation on the `RawValue` component and returns a new `Quantity`. |
| [operator +(Quantity&lt;TUnits&gt;)](Jcd.Units.UnitTypes.Quantity_TUnits_.op_UnaryPlus(Jcd.Units.UnitTypes.Quantity_TUnits_).md 'Jcd.Units.UnitTypes.Quantity<TUnits>.op_UnaryPlus(Jcd.Units.UnitTypes.Quantity<TUnits>)') | Performs a standard unary "+" operation. |
