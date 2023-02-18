#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions')

## QuantityExtensions.As<TUnits>(this double, TUnits) Method

Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> As<TUnits>(this double rawValue, TUnits unitOfMeasure)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).TUnits'></a>

`TUnits`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).rawValue'></a>

`rawValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to convert.

<a name='Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this double, TUnits).TUnits')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).md#Jcd.Units.QuantityExtensions.As_TUnits_(thisdouble,TUnits).TUnits 'Jcd.Units.QuantityExtensions.As<TUnits>(this double, TUnits).TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
A new [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance.