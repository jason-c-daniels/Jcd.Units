#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasureExtensions Class

Extension methods that convert raw values to and from fundamental  
(Coefficient=1, Offset=0) unit of measure representations.

```csharp
public static class UnitOfMeasureExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnitOfMeasureExtensions

| Methods | |
| :--- | :--- |
| [FromBaseUnitValue&lt;TUnitType&gt;(this TUnitType, double)](Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).md 'Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue<TUnitType>(this TUnitType, double)') | Given a raw value, convert FROM the fundamental base unit representation<br/>TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base<br/>unit and 0.1m is 100mm ) |
| [ToBaseUnitValue&lt;TUnitType&gt;(this TUnitType, double)](Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).md 'Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue<TUnitType>(this TUnitType, double)') | Given a raw value, convert TO the fundamental base unit representation<br/>FROM the non-base unit representation of  the value. (e.g. 100mm becomes<br/>0.1 as meters are the base unit) |
