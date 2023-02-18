#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasure<TUnits> Class

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
public abstract class UnitOfMeasure<TUnits> :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitOfMeasure<TUnits>>
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasure_TUnits_.TUnits'></a>

`TUnits`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IEquatable](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable 'System.IEquatable') &#129106; UnitOfMeasure<TUnits>

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
&#8627; [Momentum](Jcd.Units.UnitTypes.Momentum.md 'Jcd.Units.UnitTypes.Momentum')  
&#8627; [Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')  
&#8627; [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')  
&#8627; [RadiationAbsorbedDose](Jcd.Units.UnitTypes.RadiationAbsorbedDose.md 'Jcd.Units.UnitTypes.RadiationAbsorbedDose')  
&#8627; [RadiationEquivalentDose](Jcd.Units.UnitTypes.RadiationEquivalentDose.md 'Jcd.Units.UnitTypes.RadiationEquivalentDose')  
&#8627; [RadioactiveDecay](Jcd.Units.UnitTypes.RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')  
&#8627; [Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance')  
&#8627; [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Jcd.Units.UnitOfMeasure&lt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')[TUnits](Jcd.Units.UnitOfMeasure_TUnits_.md#Jcd.Units.UnitOfMeasure_TUnits_.TUnits 'Jcd.Units.UnitOfMeasure<TUnits>.TUnits')[&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [UnitOfMeasure(string, string, double, double)](Jcd.Units.UnitOfMeasure_TUnits_.UnitOfMeasure(string,string,double,double).md 'Jcd.Units.UnitOfMeasure<TUnits>.UnitOfMeasure(string, string, double, double)') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitOfMeasure_TUnits_.Coefficient.md 'Jcd.Units.UnitOfMeasure<TUnits>.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitOfMeasure_TUnits_.Name.md 'Jcd.Units.UnitOfMeasure<TUnits>.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitOfMeasure_TUnits_.Offset.md 'Jcd.Units.UnitOfMeasure<TUnits>.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitOfMeasure_TUnits_.Symbol.md 'Jcd.Units.UnitOfMeasure<TUnits>.Symbol') | The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') |

| Methods | |
| :--- | :--- |
| [CompareTo(UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.CompareTo(Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.CompareTo(Jcd.Units.UnitOfMeasure<TUnits>)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') and another one. |
| [CompareTo(object)](Jcd.Units.UnitOfMeasure_TUnits_.CompareTo(object).md 'Jcd.Units.UnitOfMeasure<TUnits>.CompareTo(object)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') and another one. |
| [Equals(UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.Equals(Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.Equals(Jcd.Units.UnitOfMeasure<TUnits>)') | Compares this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitOfMeasure_TUnits_.GetHashCode().md 'Jcd.Units.UnitOfMeasure<TUnits>.GetHashCode()') | Computes the hash code for this [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') |

| Operators | |
| :--- | :--- |
| [operator &gt;(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_GreaterThan(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_GreaterThan(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is greater than the right one. |
| [operator &gt;=(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_LessThan(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_LessThan(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is less than the right one. |
| [operator &lt;=(UnitOfMeasure&lt;TUnits&gt;, UnitOfMeasure&lt;TUnits&gt;)](Jcd.Units.UnitOfMeasure_TUnits_.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure_TUnits_,Jcd.Units.UnitOfMeasure_TUnits_).md 'Jcd.Units.UnitOfMeasure<TUnits>.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure<TUnits>, Jcd.Units.UnitOfMeasure<TUnits>)') | Compares two [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') instances to determine if the left one is less than or equal to the right one. |
