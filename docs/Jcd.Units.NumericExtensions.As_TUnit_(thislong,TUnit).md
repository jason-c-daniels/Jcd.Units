#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[NumericExtensions](Jcd.Units.NumericExtensions.md 'Jcd.Units.NumericExtensions')

## NumericExtensions.As<TUnit>(this long, TUnit) Method

Converts an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this long rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).rawValue'></a>

`rawValue` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to convert.

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).md#Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).TUnit 'Jcd.Units.NumericExtensions.As<TUnit>(this long, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).md#Jcd.Units.NumericExtensions.As_TUnit_(thislong,TUnit).TUnit 'Jcd.Units.NumericExtensions.As<TUnit>(this long, TUnit).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.