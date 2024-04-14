#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Truncate<TUnit>(Quantity<TUnit>) Method

Calculates the integral part of a quantity's numeric component.

```csharp
public static Jcd.Units.Quantity<TUnit> Truncate<TUnit>(Jcd.Units.Quantity<TUnit> quantity)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.MathQ.Truncate_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)

#### Parameters

<a name='Jcd.Units.MathQ.Truncate_TUnit_(Jcd.Units.Quantity_TUnit_).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Truncate.QYJjWw3TPMeOYO4h1Gavfw.md#Jcd.Units.MathQ.Truncate_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Truncate<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The quantity

#### Returns

[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Truncate.QYJjWw3TPMeOYO4h1Gavfw.md#Jcd.Units.MathQ.Truncate_TUnit_(Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Truncate<TUnit>(Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
The [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') rounded to the specified number of digits.