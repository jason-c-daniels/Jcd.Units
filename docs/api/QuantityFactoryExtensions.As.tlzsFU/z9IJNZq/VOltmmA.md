#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this uint, TUnit) Method

Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this uint rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisuint,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisuint,TUnit).rawValue'></a>

`rawValue` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisuint,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.tlzsFU/z9IJNZq/VOltmmA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisuint,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this uint, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.tlzsFU/z9IJNZq/VOltmmA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisuint,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this uint, TUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.