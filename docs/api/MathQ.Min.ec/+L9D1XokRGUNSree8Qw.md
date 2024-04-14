#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Min<TUnit>(Quantity<TUnit>, Quantity<TUnit>) Method

Returns the smaller of two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances.

```csharp
public static Jcd.Units.Quantity<TUnit> Min<TUnit>(Jcd.Units.Quantity<TUnit> value1, Jcd.Units.Quantity<TUnit> value2)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).value1'></a>

`value1` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Min.ec/+L9D1XokRGUNSree8Qw.md#Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Min<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The first value to compare.

<a name='Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).value2'></a>

`value2` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Min.ec/+L9D1XokRGUNSree8Qw.md#Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Min<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The second value to compare.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Min.ec/+L9D1XokRGUNSree8Qw.md#Jcd.Units.MathQ.Min_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Min<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The smaller of two specified [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances.