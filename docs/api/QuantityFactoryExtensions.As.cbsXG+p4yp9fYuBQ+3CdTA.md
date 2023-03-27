#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this byte, TUnit) Method

Converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this byte rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisbyte,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisbyte,TUnit).rawValue'></a>

`rawValue` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisbyte,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.cbsXG+p4yp9fYuBQ+3CdTA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisbyte,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this byte, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.cbsXG+p4yp9fYuBQ+3CdTA.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisbyte,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this byte, TUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.