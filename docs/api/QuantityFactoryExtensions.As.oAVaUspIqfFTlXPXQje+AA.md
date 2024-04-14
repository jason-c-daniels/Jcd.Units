#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this ulong, TUnit) Method

Converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this ulong rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisulong,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.

#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisulong,TUnit).rawValue'></a>

`rawValue` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisulong,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.oAVaUspIqfFTlXPXQje+AA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisulong,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this ulong, TUnit).TUnit')

The unit of measure to use.

#### Returns

[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.oAVaUspIqfFTlXPXQje+AA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisulong,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this ulong, TUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.