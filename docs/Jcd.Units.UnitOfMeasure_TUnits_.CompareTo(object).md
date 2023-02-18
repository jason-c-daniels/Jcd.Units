#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')

## UnitOfMeasure<TUnits>.CompareTo(object) Method

Performs a relative comparison between this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') and another one.

```csharp
public int CompareTo(object? obj);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnits_.CompareTo(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if less than; 1 if greater than; 0 if equals.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the passed in object is not a [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')