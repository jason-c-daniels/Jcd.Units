#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units')

## UnitOfMeasureEnumeration<TEnumeration,T> Class

The base of all unit of measure enumerations in this library.

```csharp
public abstract class UnitOfMeasureEnumeration<TEnumeration,T> : Jcd.Units.Enumeration<TEnumeration, T>
    where T : IEquatable<T>, Jcd.Units.IUnitOfMeasure<T>
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureEnumeration_TEnumeration,T_.TEnumeration'></a>

`TEnumeration`

The enumeration type.

<a name='Jcd.Units.UnitOfMeasureEnumeration_TEnumeration,T_.T'></a>

`T`

The type of the enumerated members.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Jcd.Units.Enumeration&lt;](Enumeration_TEnumeration,T_ 'Jcd.Units.Enumeration<TEnumeration,T>')[TEnumeration](UnitOfMeasureEnumeration_TEnumeration,T_#Jcd.Units.UnitOfMeasureEnumeration_TEnumeration,T_.TEnumeration 'Jcd.Units.UnitOfMeasureEnumeration<TEnumeration,T>.TEnumeration')[,](Enumeration_TEnumeration,T_ 'Jcd.Units.Enumeration<TEnumeration,T>')[T](UnitOfMeasureEnumeration_TEnumeration,T_#Jcd.Units.UnitOfMeasureEnumeration_TEnumeration,T_.T 'Jcd.Units.UnitOfMeasureEnumeration<TEnumeration,T>.T')[&gt;](Enumeration_TEnumeration,T_ 'Jcd.Units.Enumeration<TEnumeration,T>') &#129106; UnitOfMeasureEnumeration<TEnumeration,T>

Derived
&#8627; [Amounts](Amounts 'Jcd.Units.UnitsOfMeasure.Amounts')
&#8627; [Angles](Angles 'Jcd.Units.UnitsOfMeasure.Angles')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.Astronomical.Areas')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.Astronomical.Lengths')
&#8627; [Masses](Masses 'Jcd.Units.UnitsOfMeasure.Astronomical.Masses')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.Astronomical.Volumes')
&#8627; [StorageUnits](StorageUnits 'Jcd.Units.UnitsOfMeasure.Data.StorageUnits')
&#8627; [TransferRates](TransferRates 'Jcd.Units.UnitsOfMeasure.Data.TransferRates')
&#8627; [Durations](Durations 'Jcd.Units.UnitsOfMeasure.Durations')
&#8627; [Accelerations](Accelerations 'Jcd.Units.UnitsOfMeasure.Imperial.Accelerations')
&#8627; [Amounts](Amounts 'Jcd.Units.UnitsOfMeasure.Imperial.Amounts')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.Imperial.Areas')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.Imperial.Lengths')
&#8627; [Masses](Masses 'Jcd.Units.UnitsOfMeasure.Imperial.Masses')
&#8627; [Velocities](Velocities 'Jcd.Units.UnitsOfMeasure.Imperial.Velocities')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.Imperial.Volumes')
&#8627; [Accelerations](Accelerations 'Jcd.Units.UnitsOfMeasure.SI.Accelerations')
&#8627; [Amounts](Amounts 'Jcd.Units.UnitsOfMeasure.SI.Amounts')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.SI.Areas')
&#8627; [Capacitances](Capacitances 'Jcd.Units.UnitsOfMeasure.SI.Capacitances')
&#8627; [CatalyticActivities](CatalyticActivities 'Jcd.Units.UnitsOfMeasure.SI.CatalyticActivities')
&#8627; [Densities](Densities 'Jcd.Units.UnitsOfMeasure.SI.Densities')
&#8627; [ElectricalCharges](ElectricalCharges 'Jcd.Units.UnitsOfMeasure.SI.ElectricalCharges')
&#8627; [ElectricalConductances](ElectricalConductances 'Jcd.Units.UnitsOfMeasure.SI.ElectricalConductances')
&#8627; [ElectricalCurrents](ElectricalCurrents 'Jcd.Units.UnitsOfMeasure.SI.ElectricalCurrents')
&#8627; [ElectricalPotentials](ElectricalPotentials 'Jcd.Units.UnitsOfMeasure.SI.ElectricalPotentials')
&#8627; [Energies](Energies 'Jcd.Units.UnitsOfMeasure.SI.Energies')
&#8627; [Forces](Forces 'Jcd.Units.UnitsOfMeasure.SI.Forces')
&#8627; [Frequencies](Frequencies 'Jcd.Units.UnitsOfMeasure.SI.Frequencies')
&#8627; [Illuminances](Illuminances 'Jcd.Units.UnitsOfMeasure.SI.Illuminances')
&#8627; [Inductances](Inductances 'Jcd.Units.UnitsOfMeasure.SI.Inductances')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.SI.Lengths')
&#8627; [LuminousFluxes](LuminousFluxes 'Jcd.Units.UnitsOfMeasure.SI.LuminousFluxes')
&#8627; [LuminousIntensities](LuminousIntensities 'Jcd.Units.UnitsOfMeasure.SI.LuminousIntensities')
&#8627; [MagneticFluxDensities](MagneticFluxDensities 'Jcd.Units.UnitsOfMeasure.SI.MagneticFluxDensities')
&#8627; [MagneticFluxes](MagneticFluxes 'Jcd.Units.UnitsOfMeasure.SI.MagneticFluxes')
&#8627; [Masses](Masses 'Jcd.Units.UnitsOfMeasure.SI.Masses')
&#8627; [Momentums](Momentums 'Jcd.Units.UnitsOfMeasure.SI.Momentums')
&#8627; [Powers](Powers 'Jcd.Units.UnitsOfMeasure.SI.Powers')
&#8627; [Pressures](Pressures 'Jcd.Units.UnitsOfMeasure.SI.Pressures')
&#8627; [RadiationAbsorbedDoses](RadiationAbsorbedDoses 'Jcd.Units.UnitsOfMeasure.SI.RadiationAbsorbedDoses')
&#8627; [RadiationEquivalentDoses](RadiationEquivalentDoses 'Jcd.Units.UnitsOfMeasure.SI.RadiationEquivalentDoses')
&#8627; [RadioactiveDecays](RadioactiveDecays 'Jcd.Units.UnitsOfMeasure.SI.RadioactiveDecays')
&#8627; [Resistances](Resistances 'Jcd.Units.UnitsOfMeasure.SI.Resistances')
&#8627; [Temperatures](Temperatures 'Jcd.Units.UnitsOfMeasure.SI.Temperatures')
&#8627; [Velocities](Velocities 'Jcd.Units.UnitsOfMeasure.SI.Velocities')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.SI.Volumes')
&#8627; [Temperatures](Temperatures 'Jcd.Units.UnitsOfMeasure.Temperatures')
&#8627; [Accelerations](Accelerations 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Accelerations')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Areas')
&#8627; [Densities](Densities 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Densities')
&#8627; [Durations](Durations 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Durations')
&#8627; [Energies](Energies 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Energies')
&#8627; [Forces](Forces 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Forces')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Lengths')
&#8627; [Masses](Masses 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Masses')
&#8627; [Momentums](Momentums 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Momentums')
&#8627; [Temperatures](Temperatures 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Temperatures')
&#8627; [Velocities](Velocities 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Velocities')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.TheoreticalPhysics.Volumes')
&#8627; [Accelerations](Accelerations 'Jcd.Units.UnitsOfMeasure.USCustomary.Accelerations')
&#8627; [Amounts](Amounts 'Jcd.Units.UnitsOfMeasure.USCustomary.Amounts')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.USCustomary.Areas')
&#8627; [Forces](Forces 'Jcd.Units.UnitsOfMeasure.USCustomary.Forces')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.USCustomary.Lengths')
&#8627; [Masses](Masses 'Jcd.Units.UnitsOfMeasure.USCustomary.Masses')
&#8627; [Pressures](Pressures 'Jcd.Units.UnitsOfMeasure.USCustomary.Pressures')
&#8627; [Temperatures](Temperatures 'Jcd.Units.UnitsOfMeasure.USCustomary.Temperatures')
&#8627; [Velocities](Velocities 'Jcd.Units.UnitsOfMeasure.USCustomary.Velocities')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.USCustomary.Volumes')
&#8627; [Accelerations](Accelerations 'Jcd.Units.UnitsOfMeasure.USSurvey.Accelerations')
&#8627; [Areas](Areas 'Jcd.Units.UnitsOfMeasure.USSurvey.Areas')
&#8627; [Lengths](Lengths 'Jcd.Units.UnitsOfMeasure.USSurvey.Lengths')
&#8627; [Velocities](Velocities 'Jcd.Units.UnitsOfMeasure.USSurvey.Velocities')
&#8627; [Volumes](Volumes 'Jcd.Units.UnitsOfMeasure.USSurvey.Volumes')

| Properties | |
| :--- | :--- |
| [ByName](UnitOfMeasureEnumeration_TEnumeration,T_.ByName 'Jcd.Units.UnitOfMeasureEnumeration<TEnumeration,T>.ByName') | Looks up an enumerated unit of measure by name. |
| [BySymbol](UnitOfMeasureEnumeration_TEnumeration,T_.BySymbol 'Jcd.Units.UnitOfMeasureEnumeration<TEnumeration,T>.BySymbol') | Looks up an enumerated unit of measure by symbol. |
