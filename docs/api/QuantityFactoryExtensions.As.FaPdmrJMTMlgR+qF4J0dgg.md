#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this sbyte, TUnit) Method

Converts an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this sbyte rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thissbyte,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thissbyte,TUnit).rawValue'></a>

`rawValue` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thissbyte,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.FaPdmrJMTMlgR+qF4J0dgg.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thissbyte,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this sbyte, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.FaPdmrJMTMlgR+qF4J0dgg.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thissbyte,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this sbyte, TUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.