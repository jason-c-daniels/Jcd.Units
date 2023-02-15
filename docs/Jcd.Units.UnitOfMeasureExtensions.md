### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasureExtensions Class

```csharp
public static class UnitOfMeasureExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnitOfMeasureExtensions

| Methods | |
| :--- | :--- |
| [FromBaseUnitValue&lt;TUnits&gt;(this TUnits, double)](Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).md 'Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue<TUnits>(this TUnits, double)') | Given a raw value, convert TO the fundamental base unit representation FROM the non-base unit representation of<br/>the value. (e.g. 100mm becomes 0.1 as meters are the base unit) |
| [ToBaseUnitValue&lt;TUnits&gt;(this TUnits, double)](Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).md 'Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue<TUnits>(this TUnits, double)') | Given a raw value, convert FROM the fundamental base unit representation TO the non-base value. (e.g. 0.1<br/>becomes 100mm as meters are the base unit and 0.1m is 100mm ) |
