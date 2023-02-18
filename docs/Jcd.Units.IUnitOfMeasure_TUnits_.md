#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IUnitOfMeasure<TUnits> Interface

The interface defining what every unit of measure must support.

```csharp
public interface IUnitOfMeasure<in TUnits>
```
#### Type parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnits_.TUnits'></a>

`TUnits`

The type deriving from [IUnitOfMeasure&lt;TUnits&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

Derived  
&#8627; [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.IUnitOfMeasure_TUnits_.Coefficient.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Coefficient') | The Coefficient relative to the fundamental unit for derived units.<br/>This is 1.0 for fundamental units. This should never be 0.<br/>(divide by zero errors will occur.) |
| [Name](Jcd.Units.IUnitOfMeasure_TUnits_.Name.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Name') | The friendly name of the unit of measure. (e.g. millisecond) |
| [Offset](Jcd.Units.IUnitOfMeasure_TUnits_.Offset.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Offset') | This is the offset from the fundamental unit. |
| [Symbol](Jcd.Units.IUnitOfMeasure_TUnits_.Symbol.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Symbol') | The symbolic short representation.<br/>NOTE: THIS SHOULD BE ONLY LETTERS AND SYMBOLS, NOT AN EQUATION. |
