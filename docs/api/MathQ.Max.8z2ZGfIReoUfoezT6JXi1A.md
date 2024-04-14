#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Max<TUnit>(Quantity<TUnit>, Quantity<TUnit>) Method

Returns the larger of two [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances.

```csharp
public static Jcd.Units.Quantity<TUnit> Max<TUnit>(Jcd.Units.Quantity<TUnit> value1, Jcd.Units.Quantity<TUnit> value2)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).value1'></a>

`value1` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Max.8z2ZGfIReoUfoezT6JXi1A.md#Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Max<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The first value to compare.

<a name='Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).value2'></a>

`value2` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Max.8z2ZGfIReoUfoezT6JXi1A.md#Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Max<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The second value to compare.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Max.8z2ZGfIReoUfoezT6JXi1A.md#Jcd.Units.MathQ.Max_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Max<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The larger of two specified [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instances.