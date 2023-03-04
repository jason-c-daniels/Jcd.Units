#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasure<TUnit> Class

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
public abstract class UnitOfMeasure<TUnit> :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitOfMeasure<TUnit>>
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.TUnit'></a>

`TUnit`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IEquatable](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable 'System.IEquatable') &#129106; UnitOfMeasure<TUnit>

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

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')[Jcd.Units.UnitOfMeasure&lt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')[TUnit](Jcd.Units.UnitOfMeasure_TUnit_.md#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')[&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')[&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

| Constructors | |
| :--- | :--- |
| [UnitOfMeasure(string, string, double, double, IValueComparer&lt;double&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,Jcd.Units.IValueComparer_double_).md 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, double, double, Jcd.Units.IValueComparer<double>)') | Constructs a [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') with optional [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') |
| [UnitOfMeasure(string, string, double, double)](Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double).md 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, double, double)') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitOfMeasure_TUnit_.Coefficient.md 'Jcd.Units.UnitOfMeasure<TUnit>.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [DefaultDoubleComparer](Jcd.Units.UnitOfMeasure_TUnit_.DefaultDoubleComparer.md 'Jcd.Units.UnitOfMeasure<TUnit>.DefaultDoubleComparer') | Sets the [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used by units of measure for this particular unit of<br/>measure type. (e.g. lengths.) |
| [Name](Jcd.Units.UnitOfMeasure_TUnit_.Name.md 'Jcd.Units.UnitOfMeasure<TUnit>.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitOfMeasure_TUnit_.Offset.md 'Jcd.Units.UnitOfMeasure<TUnit>.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitOfMeasure_TUnit_.Symbol.md 'Jcd.Units.UnitOfMeasure<TUnit>.Symbol') | The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') |

| Methods | |
| :--- | :--- |
| [CompareTo(UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.CompareTo(Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.CompareTo(Jcd.Units.UnitOfMeasure<TUnit>)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') and another one. |
| [CompareTo(object)](Jcd.Units.UnitOfMeasure_TUnit_.CompareTo(object).md 'Jcd.Units.UnitOfMeasure<TUnit>.CompareTo(object)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') and another one. |
| [Equals(UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.Equals(Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.Equals(Jcd.Units.UnitOfMeasure<TUnit>)') | Compares this [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitOfMeasure_TUnit_.GetHashCode().md 'Jcd.Units.UnitOfMeasure<TUnit>.GetHashCode()') | Computes the hash code for this [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') |

| Operators | |
| :--- | :--- |
| [operator &gt;(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.op_GreaterThan(Jcd.Units.UnitOfMeasure_TUnit_,Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.op_GreaterThan(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is greater than the right one. |
| [operator &gt;=(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure_TUnit_,Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.op_LessThan(Jcd.Units.UnitOfMeasure_TUnit_,Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.op_LessThan(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is less than the right one. |
| [operator &lt;=(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](Jcd.Units.UnitOfMeasure_TUnit_.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure_TUnit_,Jcd.Units.UnitOfMeasure_TUnit_).md 'Jcd.Units.UnitOfMeasure<TUnit>.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is less than or equal to the right one. |
