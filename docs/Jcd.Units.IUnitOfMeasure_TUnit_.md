#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IUnitOfMeasure<TUnit> Interface

The interface defining what every unit of measure must support.

```csharp
public interface IUnitOfMeasure<in TUnit>
```
#### Type parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.TUnit'></a>

`TUnit`

The type deriving from [IUnitOfMeasure&lt;TUnit&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

Derived  
&#8627; [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.IUnitOfMeasure_TUnit_.Coefficient.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Coefficient') | The Coefficient relative to the fundamental unit for derived units.<br/>This is 1.0 for fundamental units. This should never be 0.<br/>(divide by zero errors will occur.) |
| [Name](Jcd.Units.IUnitOfMeasure_TUnit_.Name.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Name') | The friendly name of the unit of measure. (e.g. millisecond) |
| [Offset](Jcd.Units.IUnitOfMeasure_TUnit_.Offset.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Offset') | This is the offset from the fundamental unit. |
| [Symbol](Jcd.Units.IUnitOfMeasure_TUnit_.Symbol.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Symbol') | The symbolic short representation. |
