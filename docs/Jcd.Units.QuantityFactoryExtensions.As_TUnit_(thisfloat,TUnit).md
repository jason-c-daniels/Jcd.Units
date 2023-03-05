#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](Jcd.Units.QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this float, TUnit) Method

Converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this float rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).rawValue'></a>

`rawValue` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')

The [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this float, TUnit).TUnit')

The unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisfloat,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this float, TUnit).TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.