#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IUnitOfMeasure<TUnits> Interface

The interface defining what every unit of measure must support.

```csharp
public interface IUnitOfMeasure<TUnits>
```
#### Type parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnits_.TUnits'></a>

`TUnits`

The type deriving from [IUnitOfMeasure&lt;TUnits&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

Derived  
&#8627; [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')  
&#8627; [Capacitance](Jcd.Units.UnitTypes.Capacitance.md 'Jcd.Units.UnitTypes.Capacitance')  
&#8627; [CatalyticActivity](Jcd.Units.UnitTypes.CatalyticActivity.md 'Jcd.Units.UnitTypes.CatalyticActivity')  
&#8627; [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')  
&#8627; [ElectricalCharge](Jcd.Units.UnitTypes.ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge')  
&#8627; [ElectricalConductance](Jcd.Units.UnitTypes.ElectricalConductance.md 'Jcd.Units.UnitTypes.ElectricalConductance')  
&#8627; [ElectricalCurrent](Jcd.Units.UnitTypes.ElectricalCurrent.md 'Jcd.Units.UnitTypes.ElectricalCurrent')  
&#8627; [ElectricalPotential](Jcd.Units.UnitTypes.ElectricalPotential.md 'Jcd.Units.UnitTypes.ElectricalPotential')  
&#8627; [Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy')  
&#8627; [Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force')  
&#8627; [Frequency](Jcd.Units.UnitTypes.Frequency.md 'Jcd.Units.UnitTypes.Frequency')  
&#8627; [Illuminance](Jcd.Units.UnitTypes.Illuminance.md 'Jcd.Units.UnitTypes.Illuminance')  
&#8627; [Inductance](Jcd.Units.UnitTypes.Inductance.md 'Jcd.Units.UnitTypes.Inductance')  
&#8627; [Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length')  
&#8627; [LuminousFlux](Jcd.Units.UnitTypes.LuminousFlux.md 'Jcd.Units.UnitTypes.LuminousFlux')  
&#8627; [LuminousIntensity](Jcd.Units.UnitTypes.LuminousIntensity.md 'Jcd.Units.UnitTypes.LuminousIntensity')  
&#8627; [MagneticFlux](Jcd.Units.UnitTypes.MagneticFlux.md 'Jcd.Units.UnitTypes.MagneticFlux')  
&#8627; [MagneticFluxDensity](Jcd.Units.UnitTypes.MagneticFluxDensity.md 'Jcd.Units.UnitTypes.MagneticFluxDensity')  
&#8627; [Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass')  
&#8627; [Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')  
&#8627; [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')  
&#8627; [RadiationAbsorbedDose](Jcd.Units.UnitTypes.RadiationAbsorbedDose.md 'Jcd.Units.UnitTypes.RadiationAbsorbedDose')  
&#8627; [RadiationEquivalentDose](Jcd.Units.UnitTypes.RadiationEquivalentDose.md 'Jcd.Units.UnitTypes.RadiationEquivalentDose')  
&#8627; [RadioactiveDecay](Jcd.Units.UnitTypes.RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')  
&#8627; [Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance')  
&#8627; [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.IUnitOfMeasure_TUnits_.Coefficient.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Coefficient') | The Coefficient relative to the fundamental unit for derived units.<br/>This is 1.0 for fundamental units. This should never be 0.<br/>(divide by zero errors will occur.) |
| [Name](Jcd.Units.IUnitOfMeasure_TUnits_.Name.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Name') | The friendly name of the unit of measure. (e.g. Ronnasecond) |
| [Offset](Jcd.Units.IUnitOfMeasure_TUnits_.Offset.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Offset') | This is the offset from the fundamental unit. |
| [Symbol](Jcd.Units.IUnitOfMeasure_TUnits_.Symbol.md 'Jcd.Units.IUnitOfMeasure<TUnits>.Symbol') | The symbolic short representation.<br/>NOTE: THIS SHOULD BE ONLY LETTERS AND SYMBOLS, NOT AN EQUATION. |
