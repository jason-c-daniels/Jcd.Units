#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this uint, TUnits) Method

Converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this uint rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).rawValue'></a>

`rawValue` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this uint, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisuint,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this uint, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.