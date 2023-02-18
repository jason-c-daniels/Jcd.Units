#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this int, TUnits) Method

Converts an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this int rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).rawValue'></a>

`rawValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this int, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisint,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this int, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.