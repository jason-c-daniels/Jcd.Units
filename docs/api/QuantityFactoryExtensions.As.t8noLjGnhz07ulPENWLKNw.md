#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As(this TimeSpan, Duration) Method

Converts a [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to a [Duration](Duration.md 'Jcd.Units.UnitTypes.Duration') represented as the specified unit of time.

```csharp
public static Jcd.Units.Quantity<Jcd.Units.UnitTypes.Duration> As(this TimeSpan timeSpan, Jcd.Units.UnitTypes.Duration timeUnit);
```
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As(thisTimeSpan,Jcd.Units.UnitTypes.Duration).timeSpan'></a>

`timeSpan` [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As(thisTimeSpan,Jcd.Units.UnitTypes.Duration).timeUnit'></a>

`timeUnit` [Duration](Duration.md 'Jcd.Units.UnitTypes.Duration')

The [Duration](Duration.md 'Jcd.Units.UnitTypes.Duration') unit of measure to convert to.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[Duration](Duration.md 'Jcd.Units.UnitTypes.Duration')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')