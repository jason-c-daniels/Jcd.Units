#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this float, TUnits) Method

Converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this float rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).rawValue'></a>

`rawValue` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this float, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisfloat,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this float, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.