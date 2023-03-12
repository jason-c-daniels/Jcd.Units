#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QMath](Jcd.Units.QMath.md 'Jcd.Units.QMath')

## QMath.Abs<TUnit>(Quantity<TUnit>) Method

Returns the absolute value of a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') as a new Quantity with the source unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> Abs<TUnit>(Jcd.Units.Quantity<TUnit> quantity)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).md#Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.QMath.Abs<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The quantity

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).md#Jcd.Units.QMath.Abs_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.QMath.Abs<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
the absolute value of a [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') as a new Quantity with the source unit of measure.