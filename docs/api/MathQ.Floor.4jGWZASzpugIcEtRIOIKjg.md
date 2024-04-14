#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Floor<TUnit>(Quantity<TUnit>) Method

Returns the largest integral value less than or equal to the numeric component of the [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
.

```csharp
public static Jcd.Units.Quantity<TUnit> Floor<TUnit>(Jcd.Units.Quantity<TUnit> quantity)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Floor_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Floor_TUnit_(Jcd.Units.Quantity_TUnit_).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Floor.4jGWZASzpugIcEtRIOIKjg.md#Jcd.Units.MathQ.Floor_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Floor<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The quantity

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Floor.4jGWZASzpugIcEtRIOIKjg.md#Jcd.Units.MathQ.Floor_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Floor<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
the floor of the [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') expressed in the same unit of measure.