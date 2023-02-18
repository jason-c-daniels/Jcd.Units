#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this ushort, TUnits) Method

Converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this ushort rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).rawValue'></a>

`rawValue` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this ushort, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisushort,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this ushort, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.