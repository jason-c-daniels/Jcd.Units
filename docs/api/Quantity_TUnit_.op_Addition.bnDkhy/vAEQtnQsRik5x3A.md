#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.operator +(Quantity<TUnit>, Quantity<TUnit>) Operator

Adds two quantities, selecting the larger unit of measure as the common representation.

```csharp
public static Jcd.Units.Quantity<TUnit> operator +(Jcd.Units.Quantity<TUnit> x, Jcd.Units.Quantity<TUnit> y);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnit_.op_Addition(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).x'></a>

`x` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The left hand operand

<a name='Jcd.Units.Quantity_TUnit_.op_Addition(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).y'></a>

`y` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The right hand operand

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
The sum of the two quantities in the common unit of measure.