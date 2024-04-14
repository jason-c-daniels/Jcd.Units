#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As<TUnit>(this short, TUnit) Method

Converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') into a quantity using the specified unit of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> As<TUnit>(this short rawValue, TUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisshort,TUnit).TUnit'></a>

`TUnit`

The type of the unit of measure.

#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisshort,TUnit).rawValue'></a>

`rawValue` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisshort,TUnit).unitOfMeasure'></a>

`unitOfMeasure` [TUnit](QuantityFactoryExtensions.As.8cSwpKJdbTkGpiStUKbEcg.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisshort,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this short, TUnit).TUnit')

The unit of measure to use.

#### Returns

[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.As.8cSwpKJdbTkGpiStUKbEcg.md#Jcd.Units.QuantityFactoryExtensions.As_TUnit_(thisshort,TUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.As<TUnit>(this short, TUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.