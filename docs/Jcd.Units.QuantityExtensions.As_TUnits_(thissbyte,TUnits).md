#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this sbyte, TUnits) Method

Converts an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this sbyte rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).rawValue'></a>

`rawValue` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this sbyte, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thissbyte,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this sbyte, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.