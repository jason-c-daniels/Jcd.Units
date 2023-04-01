#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Pow<TUnit>(Quantity<TUnit>, double) Method

Returns the [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') raised to the specified power.

```csharp
public static Jcd.Units.Quantity<TUnit> Pow<TUnit>(Jcd.Units.Quantity<TUnit> quantity, double exponent)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Pow.hcoeYokIqZIPXFJOLkT24Q.md#Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit 'Jcd.Units.MathQ.Pow<TUnit>(Jcd.Units.Quantity<TUnit>, double).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The value to raise to the power specified by [exponent](MathQ.Pow.hcoeYokIqZIPXFJOLkT24Q.md#Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).exponent 'Jcd.Units.MathQ.Pow<TUnit>(Jcd.Units.Quantity<TUnit>, double).exponent')

<a name='Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).exponent'></a>

`exponent` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

A number specifying the power.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Pow.hcoeYokIqZIPXFJOLkT24Q.md#Jcd.Units.MathQ.Pow_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit 'Jcd.Units.MathQ.Pow<TUnit>(Jcd.Units.Quantity<TUnit>, double).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') raised to the specified power.