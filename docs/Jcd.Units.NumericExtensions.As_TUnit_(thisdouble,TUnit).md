#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[NumericExtensions](Jcd.Units.NumericExtensions.md 'Jcd.Units.NumericExtensions')

## NumericExtensions.As<TUnit>(this double, TUnit) Method

Converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this double rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).rawValue'></a>

`rawValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to convert.

<a name='Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).md#Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).TUnit 'Jcd.Units.NumericExtensions.As<TUnit>(this double, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).md#Jcd.Units.NumericExtensions.As_TUnit_(thisdouble,TUnit).TUnit 'Jcd.Units.NumericExtensions.As<TUnit>(this double, TUnit).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.