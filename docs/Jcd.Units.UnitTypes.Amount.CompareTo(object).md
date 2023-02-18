#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

## Amount.CompareTo(object) Method

Performs a relative comparison between this [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount') and another one.

```csharp
public int CompareTo(object? obj);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Amount.CompareTo(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount') to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if less than; 1 if greater than; 0 if equals.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
When the passed in object is not a [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')