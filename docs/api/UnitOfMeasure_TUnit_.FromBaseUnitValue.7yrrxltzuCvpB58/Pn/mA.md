#### [Jcd.Units](index 'index')

### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.FromBaseUnitValue(double) Method

The interface defining what every unit of measure must support.

```csharp
public double FromBaseUnitValue(double normalizedValue);
```

#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.FromBaseUnitValue(double).normalizedValue'></a>

`normalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [FromBaseUnitValue(double)](IUnitOfMeasure_TUnit_.FromBaseUnitValue.QquOkpzUZ2pTpGuVCnJHTQ 'Jcd.Units.IUnitOfMeasure<TUnit>.FromBaseUnitValue(double)')

#### Returns

[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks

By ensuring that all units of measure provide their own type to the interface
we guarantee compile time detection of certain classes of errors.