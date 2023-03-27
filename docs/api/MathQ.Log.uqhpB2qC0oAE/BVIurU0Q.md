#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Log<TUnit>(Quantity<TUnit>, double) Method

Returns the logarithm of a the numeric component of a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') in a specified base.

```csharp
public static Jcd.Units.Quantity<TUnit> Log<TUnit>(Jcd.Units.Quantity<TUnit> quantity, double @base)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Log_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Log_TUnit_(Jcd.Units.Quantity_TUnit_,double).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Log.uqhpB2qC0oAE//BVIurU0Q.md#Jcd.Units.MathQ.Log_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit 'Jcd.Units.MathQ.Log<TUnit>(Jcd.Units.Quantity<TUnit>, double).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The number whose logarithm is to be found

<a name='Jcd.Units.MathQ.Log_TUnit_(Jcd.Units.Quantity_TUnit_,double).base'></a>

`base` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The numeric base of the logarithm.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Log.uqhpB2qC0oAE//BVIurU0Q.md#Jcd.Units.MathQ.Log_TUnit_(Jcd.Units.Quantity_TUnit_,double).TUnit 'Jcd.Units.MathQ.Log<TUnit>(Jcd.Units.Quantity<TUnit>, double).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The logarithm of a the numeric component of a [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') in a specified base.