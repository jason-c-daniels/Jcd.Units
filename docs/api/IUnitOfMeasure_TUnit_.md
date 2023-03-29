#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IUnitOfMeasure<TUnit> Interface

The interface defining what every unit of measure must support.

```csharp
public interface IUnitOfMeasure<TUnit>
    where TUnit : Jcd.Units.IUnitOfMeasure<TUnit>
```
#### Type parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.TUnit'></a>

`TUnit`

The type deriving from [IUnitOfMeasure&lt;TUnit&gt;](IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

Derived  
&#8627; [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.

| Properties | |
| :--- | :--- |
| [BaseUnit](IUnitOfMeasure_TUnit_.BaseUnit.md 'Jcd.Units.IUnitOfMeasure<TUnit>.BaseUnit') | The unit of measure this one was defined in terms of. |
| [Coefficient](IUnitOfMeasure_TUnit_.Coefficient.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Coefficient') | The Coefficient relative to the fundamental unit for derived units.<br/>This is 1.0 for fundamental units. This should never be 0.<br/>(divide by zero errors will occur.) |
| [FundamentalUnit](IUnitOfMeasure_TUnit_.FundamentalUnit.md 'Jcd.Units.IUnitOfMeasure<TUnit>.FundamentalUnit') | The unit of measure all others are represented in terms of. |
| [IsFundamentalUnit](IUnitOfMeasure_TUnit_.IsFundamentalUnit.md 'Jcd.Units.IUnitOfMeasure<TUnit>.IsFundamentalUnit') | Indicates if this unit of measure is the fundamental unit. (i.e. Coefficient 1, Offset 0) |
| [Name](IUnitOfMeasure_TUnit_.Name.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Name') | The friendly name of the unit of measure. (e.g. millisecond) |
| [Offset](IUnitOfMeasure_TUnit_.Offset.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Offset') | This is the offset from the fundamental unit. |
| [Symbol](IUnitOfMeasure_TUnit_.Symbol.md 'Jcd.Units.IUnitOfMeasure<TUnit>.Symbol') | The symbolic short representation. |

| Methods | |
| :--- | :--- |
| [ComputeFundamentalCoefficient(double)](IUnitOfMeasure_TUnit_.ComputeFundamentalCoefficient.tl0ngZGU2W+hcEjMFC0Ucw.md 'Jcd.Units.IUnitOfMeasure<TUnit>.ComputeFundamentalCoefficient(double)') | Given a coefficient, calculate the equivalent coefficient for the<br/>fundamental unit of measure. (i.e. the one with Coeff. = 1 and Offset = 0) |
| [ComputeFundamentalOffset(double, double)](IUnitOfMeasure_TUnit_.ComputeFundamentalOffset.dHShegAVwvw43wIz21vDUw.md 'Jcd.Units.IUnitOfMeasure<TUnit>.ComputeFundamentalOffset(double, double)') | Given an offset and the coefficient for converting to the fundamental unit<br/>of measure, calculate the equivalent offset for the fundamental unit of measure.<br/>(i.e. the one with Coeff = 1 and Offset = 0) |
| [FromFundamentalUnitValue(double)](IUnitOfMeasure_TUnit_.FromFundamentalUnitValue.HjMaJtc3CT4c+JTAgOGaqg.md 'Jcd.Units.IUnitOfMeasure<TUnit>.FromFundamentalUnitValue(double)') | Given a raw value, convert FROM the fundamental (normalized) base unit representation<br/>TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base<br/>unit and 0.1m is 100mm ) |
| [ToFundamentalUnitValue(double)](IUnitOfMeasure_TUnit_.ToFundamentalUnitValue.9rxgmUYTNn0R4fvkmnqVIA.md 'Jcd.Units.IUnitOfMeasure<TUnit>.ToFundamentalUnitValue(double)') | Given a raw value, convert TO the fundamental base unit representation<br/>FROM the non-base unit representation of  the value. (e.g. 100mm becomes<br/>0.1 as meters are the base unit) |
