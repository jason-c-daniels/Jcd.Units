#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](Jcd.Units.QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.As(this TimeSpan, Duration) Method

Converts a [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to a [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') represented as the specified unit of time.

```csharp
public static Jcd.Units.Quantity<Jcd.Units.UnitTypes.Duration> As(this TimeSpan timeSpan, Jcd.Units.UnitTypes.Duration timeUnit);
```
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.As(thisTimeSpan,Jcd.Units.UnitTypes.Duration).timeSpan'></a>

`timeSpan` [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.As(thisTimeSpan,Jcd.Units.UnitTypes.Duration).timeUnit'></a>

`timeUnit` [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')

The [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') unit of measure to convert to.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')