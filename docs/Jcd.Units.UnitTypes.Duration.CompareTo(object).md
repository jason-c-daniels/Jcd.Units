#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')

## Duration.CompareTo(object) Method

Performs a relative comparison between this [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') and another one.

```csharp
public int CompareTo(object? obj);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Duration.CompareTo(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if less than; 1 if greater than; 0 if equals.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the passed in object is not a [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')