#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[IUnitOfMeasure&lt;TUnit&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

## IUnitOfMeasure<TUnit>.Coefficient Property

The Coefficient relative to the fundamental unit for derived units.  
This is 1.0 for fundamental units. This should never be 0.  
(divide by zero errors will occur.)

```csharp
double Coefficient { get; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')