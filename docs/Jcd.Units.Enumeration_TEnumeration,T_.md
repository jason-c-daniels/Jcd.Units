#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## Enumeration<TEnumeration,T> Class

The base of all DDD-style enumerations in this library.

```csharp
public class Enumeration<TEnumeration,T>
    where T : IEquatable<T>
```
#### Type parameters

<a name='Jcd.Units.Enumeration_TEnumeration,T_.TEnumeration'></a>

`TEnumeration`

The enumeration type.

<a name='Jcd.Units.Enumeration_TEnumeration,T_.T'></a>

`T`

The type of the enumerated members.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Enumeration<TEnumeration,T>

Derived  
&#8627; [Amounts](Jcd.Units.UnitsOfMeasure.Amounts.md 'Jcd.Units.UnitsOfMeasure.Amounts')  
&#8627; [Lengths](Jcd.Units.UnitsOfMeasure.Astronomical.Lengths.md 'Jcd.Units.UnitsOfMeasure.Astronomical.Lengths')  
&#8627; [Durations](Jcd.Units.UnitsOfMeasure.Durations.md 'Jcd.Units.UnitsOfMeasure.Durations')  
&#8627; [Lengths](Jcd.Units.UnitsOfMeasure.Imperial.Lengths.md 'Jcd.Units.UnitsOfMeasure.Imperial.Lengths')  
&#8627; [Amounts](Jcd.Units.UnitsOfMeasure.SI.Amounts.md 'Jcd.Units.UnitsOfMeasure.SI.Amounts')  
&#8627; [Capacitances](Jcd.Units.UnitsOfMeasure.SI.Capacitances.md 'Jcd.Units.UnitsOfMeasure.SI.Capacitances')  
&#8627; [CatalyticActivities](Jcd.Units.UnitsOfMeasure.SI.CatalyticActivities.md 'Jcd.Units.UnitsOfMeasure.SI.CatalyticActivities')  
&#8627; [ElectricalCharges](Jcd.Units.UnitsOfMeasure.SI.ElectricalCharges.md 'Jcd.Units.UnitsOfMeasure.SI.ElectricalCharges')  
&#8627; [ElectricalConductances](Jcd.Units.UnitsOfMeasure.SI.ElectricalConductances.md 'Jcd.Units.UnitsOfMeasure.SI.ElectricalConductances')  
&#8627; [ElectricalCurrents](Jcd.Units.UnitsOfMeasure.SI.ElectricalCurrents.md 'Jcd.Units.UnitsOfMeasure.SI.ElectricalCurrents')  
&#8627; [ElectricalPotentials](Jcd.Units.UnitsOfMeasure.SI.ElectricalPotentials.md 'Jcd.Units.UnitsOfMeasure.SI.ElectricalPotentials')  
&#8627; [Energies](Jcd.Units.UnitsOfMeasure.SI.Energies.md 'Jcd.Units.UnitsOfMeasure.SI.Energies')  
&#8627; [Forces](Jcd.Units.UnitsOfMeasure.SI.Forces.md 'Jcd.Units.UnitsOfMeasure.SI.Forces')  
&#8627; [Frequencies](Jcd.Units.UnitsOfMeasure.SI.Frequencies.md 'Jcd.Units.UnitsOfMeasure.SI.Frequencies')  
&#8627; [Illuminances](Jcd.Units.UnitsOfMeasure.SI.Illuminances.md 'Jcd.Units.UnitsOfMeasure.SI.Illuminances')  
&#8627; [Inductances](Jcd.Units.UnitsOfMeasure.SI.Inductances.md 'Jcd.Units.UnitsOfMeasure.SI.Inductances')  
&#8627; [Lengths](Jcd.Units.UnitsOfMeasure.SI.Lengths.md 'Jcd.Units.UnitsOfMeasure.SI.Lengths')  
&#8627; [LuminousFluxes](Jcd.Units.UnitsOfMeasure.SI.LuminousFluxes.md 'Jcd.Units.UnitsOfMeasure.SI.LuminousFluxes')  
&#8627; [LuminousIntensities](Jcd.Units.UnitsOfMeasure.SI.LuminousIntensities.md 'Jcd.Units.UnitsOfMeasure.SI.LuminousIntensities')  
&#8627; [MagneticFluxDensities](Jcd.Units.UnitsOfMeasure.SI.MagneticFluxDensities.md 'Jcd.Units.UnitsOfMeasure.SI.MagneticFluxDensities')  
&#8627; [MagneticFluxes](Jcd.Units.UnitsOfMeasure.SI.MagneticFluxes.md 'Jcd.Units.UnitsOfMeasure.SI.MagneticFluxes')  
&#8627; [Masses](Jcd.Units.UnitsOfMeasure.SI.Masses.md 'Jcd.Units.UnitsOfMeasure.SI.Masses')  
&#8627; [Momentums](Jcd.Units.UnitsOfMeasure.SI.Momentums.md 'Jcd.Units.UnitsOfMeasure.SI.Momentums')  
&#8627; [Powers](Jcd.Units.UnitsOfMeasure.SI.Powers.md 'Jcd.Units.UnitsOfMeasure.SI.Powers')  
&#8627; [Pressures](Jcd.Units.UnitsOfMeasure.SI.Pressures.md 'Jcd.Units.UnitsOfMeasure.SI.Pressures')  
&#8627; [RadiationAbsorbedDoses](Jcd.Units.UnitsOfMeasure.SI.RadiationAbsorbedDoses.md 'Jcd.Units.UnitsOfMeasure.SI.RadiationAbsorbedDoses')  
&#8627; [RadiationEquivalentDoses](Jcd.Units.UnitsOfMeasure.SI.RadiationEquivalentDoses.md 'Jcd.Units.UnitsOfMeasure.SI.RadiationEquivalentDoses')  
&#8627; [RadioactiveDecays](Jcd.Units.UnitsOfMeasure.SI.RadioactiveDecays.md 'Jcd.Units.UnitsOfMeasure.SI.RadioactiveDecays')  
&#8627; [Resistances](Jcd.Units.UnitsOfMeasure.SI.Resistances.md 'Jcd.Units.UnitsOfMeasure.SI.Resistances')  
&#8627; [Temperatures](Jcd.Units.UnitsOfMeasure.SI.Temperatures.md 'Jcd.Units.UnitsOfMeasure.SI.Temperatures')  
&#8627; [Temperatures](Jcd.Units.UnitsOfMeasure.Temperatures.md 'Jcd.Units.UnitsOfMeasure.Temperatures')  
&#8627; [Lengths](Jcd.Units.UnitsOfMeasure.USCustomary.Lengths.md 'Jcd.Units.UnitsOfMeasure.USCustomary.Lengths')  
&#8627; [Temperatures](Jcd.Units.UnitsOfMeasure.USCustomary.Temperatures.md 'Jcd.Units.UnitsOfMeasure.USCustomary.Temperatures')  
&#8627; [Lengths](Jcd.Units.UnitsOfMeasure.USSurvey.Lengths.md 'Jcd.Units.UnitsOfMeasure.USSurvey.Lengths')

| Methods | |
| :--- | :--- |
| [GetAll()](Jcd.Units.Enumeration_TEnumeration,T_.GetAll().md 'Jcd.Units.Enumeration<TEnumeration,T>.GetAll()') | Retrieves all public static properties of type [T](Jcd.Units.Enumeration_TEnumeration,T_.md#Jcd.Units.Enumeration_TEnumeration,T_.T 'Jcd.Units.Enumeration<TEnumeration,T>.T')<br/>on the derived enumeration [TEnumeration](Jcd.Units.Enumeration_TEnumeration,T_.md#Jcd.Units.Enumeration_TEnumeration,T_.TEnumeration 'Jcd.Units.Enumeration<TEnumeration,T>.TEnumeration') |
