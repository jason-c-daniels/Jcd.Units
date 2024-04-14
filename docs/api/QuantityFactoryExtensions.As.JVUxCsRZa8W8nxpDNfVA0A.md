#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this ushort, TUnit) Method

Converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this ushort rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisushort,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisushort,TUnit).rawValue'></a>

`rawValue` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisushort,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.JVUxCsRZa8W8nxpDNfVA0A#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisushort,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this ushort, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_ 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.JVUxCsRZa8W8nxpDNfVA0A#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisushort,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this ushort, TUnit).TUnit')[&gt;](Quantity_TUnit_ 'Jcd.Units.Quantity<TUnit>')
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_ 'Jcd.Units.Quantity<TUnit>') instance.