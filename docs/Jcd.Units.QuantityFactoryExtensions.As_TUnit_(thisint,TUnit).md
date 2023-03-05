#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](Jcd.Units.QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this int, TUnit) Method

Converts an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this int rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).rawValue'></a>

`rawValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this int, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisint,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this int, TUnit).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.