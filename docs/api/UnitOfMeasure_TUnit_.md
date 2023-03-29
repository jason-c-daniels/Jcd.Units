#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitOfMeasure<TUnit> Class

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
public abstract class UnitOfMeasure<TUnit> :
Jcd.Units.IUnitOfMeasure<TUnit>
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.TUnit'></a>

`TUnit`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IComparable](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable 'System.IComparable') &#129106; [System.IEquatable](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable 'System.IEquatable') &#129106; UnitOfMeasure<TUnit>

Derived  
&#8627; [Acceleration](Acceleration.md 'Jcd.Units.UnitTypes.Acceleration')  
&#8627; [Amount](Amount.md 'Jcd.Units.UnitTypes.Amount')  
&#8627; [Angle](Angle.md 'Jcd.Units.UnitTypes.Angle')  
&#8627; [Area](Area.md 'Jcd.Units.UnitTypes.Area')  
&#8627; [Capacitance](Capacitance.md 'Jcd.Units.UnitTypes.Capacitance')  
&#8627; [CatalyticActivity](CatalyticActivity.md 'Jcd.Units.UnitTypes.CatalyticActivity')  
&#8627; [Density](Density.md 'Jcd.Units.UnitTypes.Density')  
&#8627; [Duration](Duration.md 'Jcd.Units.UnitTypes.Duration')  
&#8627; [ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge')  
&#8627; [ElectricalConductance](ElectricalConductance.md 'Jcd.Units.UnitTypes.ElectricalConductance')  
&#8627; [ElectricalCurrent](ElectricalCurrent.md 'Jcd.Units.UnitTypes.ElectricalCurrent')  
&#8627; [ElectricalPotential](ElectricalPotential.md 'Jcd.Units.UnitTypes.ElectricalPotential')  
&#8627; [Energy](Energy.md 'Jcd.Units.UnitTypes.Energy')  
&#8627; [Force](Force.md 'Jcd.Units.UnitTypes.Force')  
&#8627; [Frequency](Frequency.md 'Jcd.Units.UnitTypes.Frequency')  
&#8627; [Illuminance](Illuminance.md 'Jcd.Units.UnitTypes.Illuminance')  
&#8627; [Inductance](Inductance.md 'Jcd.Units.UnitTypes.Inductance')  
&#8627; [Length](Length.md 'Jcd.Units.UnitTypes.Length')  
&#8627; [LuminousFlux](LuminousFlux.md 'Jcd.Units.UnitTypes.LuminousFlux')  
&#8627; [LuminousIntensity](LuminousIntensity.md 'Jcd.Units.UnitTypes.LuminousIntensity')  
&#8627; [MagneticFlux](MagneticFlux.md 'Jcd.Units.UnitTypes.MagneticFlux')  
&#8627; [MagneticFluxDensity](MagneticFluxDensity.md 'Jcd.Units.UnitTypes.MagneticFluxDensity')  
&#8627; [Mass](Mass.md 'Jcd.Units.UnitTypes.Mass')  
&#8627; [Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum')  
&#8627; [Power](Power.md 'Jcd.Units.UnitTypes.Power')  
&#8627; [Pressure](Pressure.md 'Jcd.Units.UnitTypes.Pressure')  
&#8627; [RadiationAbsorbedDose](RadiationAbsorbedDose.md 'Jcd.Units.UnitTypes.RadiationAbsorbedDose')  
&#8627; [RadiationEquivalentDose](RadiationEquivalentDose.md 'Jcd.Units.UnitTypes.RadiationEquivalentDose')  
&#8627; [RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')  
&#8627; [Resistance](Resistance.md 'Jcd.Units.UnitTypes.Resistance')  
&#8627; [Storage](Storage.md 'Jcd.Units.UnitTypes.Storage')  
&#8627; [Temperature](Temperature.md 'Jcd.Units.UnitTypes.Temperature')  
&#8627; [TransferRate](TransferRate.md 'Jcd.Units.UnitTypes.TransferRate')  
&#8627; [Velocity](Velocity.md 'Jcd.Units.UnitTypes.Velocity')  
&#8627; [Volume](Volume.md 'Jcd.Units.UnitTypes.Volume')

Implements [Jcd.Units.IUnitOfMeasure&lt;](IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')[TUnit](UnitOfMeasure_TUnit_.md#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')[&gt;](IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

| Constructors | |
| :--- | :--- |
| [UnitOfMeasure(string, string, double, double)](UnitOfMeasure_TUnit_..ctor.aU4nMhZJNb9NUazBdx3PKw.md 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, double, double)') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |
| [UnitOfMeasure(string, string, TUnit, double, double, IValueComparer&lt;double&gt;)](UnitOfMeasure_TUnit_..ctor.01UOiqFui+c2Pc5xHWgOLg.md 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, TUnit, double, double, Jcd.Units.IValueComparer<double>)') | Constructs a unit of measure using another [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') as a base. |

| Properties | |
| :--- | :--- |
| [BaseUnit](UnitOfMeasure_TUnit_.BaseUnit.md 'Jcd.Units.UnitOfMeasure<TUnit>.BaseUnit') | The unit of measure this one was defined in terms of. |
| [Coefficient](UnitOfMeasure_TUnit_.Coefficient.md 'Jcd.Units.UnitOfMeasure<TUnit>.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Comparer](UnitOfMeasure_TUnit_.Comparer.md 'Jcd.Units.UnitOfMeasure<TUnit>.Comparer') | The [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons: where `T` is a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [DefaultDoubleComparer](UnitOfMeasure_TUnit_.DefaultDoubleComparer.md 'Jcd.Units.UnitOfMeasure<TUnit>.DefaultDoubleComparer') | Sets the [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used by units of measure for this particular unit of<br/>measure type. (e.g. lengths.) |
| [FundamentalUnit](UnitOfMeasure_TUnit_.FundamentalUnit.md 'Jcd.Units.UnitOfMeasure<TUnit>.FundamentalUnit') | The unit of measure all others are represented in terms of. |
| [IsFundamentalUnit](UnitOfMeasure_TUnit_.IsFundamentalUnit.md 'Jcd.Units.UnitOfMeasure<TUnit>.IsFundamentalUnit') | Indicates if this unit of measure is the fundamental unit. (i.e. Coefficient 1, Offset 0) |
| [Name](UnitOfMeasure_TUnit_.Name.md 'Jcd.Units.UnitOfMeasure<TUnit>.Name') | The name of this unit |
| [Offset](UnitOfMeasure_TUnit_.Offset.md 'Jcd.Units.UnitOfMeasure<TUnit>.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](UnitOfMeasure_TUnit_.Symbol.md 'Jcd.Units.UnitOfMeasure<TUnit>.Symbol') | The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') |

| Methods | |
| :--- | :--- |
| [CompareTo(object)](UnitOfMeasure_TUnit_.CompareTo.BDUB5PptL8B2VDvxCybhnA.md 'Jcd.Units.UnitOfMeasure<TUnit>.CompareTo(object)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') and another one. |
| [CompareTo(TUnit)](UnitOfMeasure_TUnit_.CompareTo.OPmubfQu6BLQMyNXQHI0jg.md 'Jcd.Units.UnitOfMeasure<TUnit>.CompareTo(TUnit)') | Performs a relative comparison between this [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') and another one. |
| [ComputeFundamentalCoefficient(double)](UnitOfMeasure_TUnit_.ComputeFundamentalCoefficient.i9JNe6R2i806zQq6EPKlHg.md 'Jcd.Units.UnitOfMeasure<TUnit>.ComputeFundamentalCoefficient(double)') | The interface defining what every unit of measure must support. |
| [ComputeFundamentalOffset(double, double)](UnitOfMeasure_TUnit_.ComputeFundamentalOffset.onPwvgdKY+MelX1jCfClKQ.md 'Jcd.Units.UnitOfMeasure<TUnit>.ComputeFundamentalOffset(double, double)') | The interface defining what every unit of measure must support. |
| [Equals(UnitOfMeasure&lt;TUnit&gt;)](UnitOfMeasure_TUnit_.Equals.monYQT5ijeXp2ozD2hvWHQ.md 'Jcd.Units.UnitOfMeasure<TUnit>.Equals(Jcd.Units.UnitOfMeasure<TUnit>)') | Compares this [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') to another one for equality. |
| [FromFundamentalUnitValue(double)](UnitOfMeasure_TUnit_.FromFundamentalUnitValue.ela1GaQ7m9Ds+0Gsp3NEqw.md 'Jcd.Units.UnitOfMeasure<TUnit>.FromFundamentalUnitValue(double)') | The interface defining what every unit of measure must support. |
| [GetHashCode()](UnitOfMeasure_TUnit_.GetHashCode().md 'Jcd.Units.UnitOfMeasure<TUnit>.GetHashCode()') | Computes the hash code for this [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') |
| [ToFundamentalUnitValue(double)](UnitOfMeasure_TUnit_.ToFundamentalUnitValue.c+pdNRz/zLxbsbCTxAGJcQ.md 'Jcd.Units.UnitOfMeasure<TUnit>.ToFundamentalUnitValue(double)') | The interface defining what every unit of measure must support. |

| Operators | |
| :--- | :--- |
| [operator &gt;(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](UnitOfMeasure_TUnit_.op_GreaterThan.1PaSrFoiJTo7T+c0lAAktg.md 'Jcd.Units.UnitOfMeasure<TUnit>.op_GreaterThan(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is greater than the right<br/>one. |
| [operator &gt;=(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](UnitOfMeasure_TUnit_.op_GreaterThanOrEqual.R0d08Sda2xz912fn6sSwOA.md 'Jcd.Units.UnitOfMeasure<TUnit>.op_GreaterThanOrEqual(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is greater than or equal to<br/>the right one. |
| [operator &lt;(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](UnitOfMeasure_TUnit_.op_LessThan.Ryf2wTvfKjdlLuccqhkM/Q.md 'Jcd.Units.UnitOfMeasure<TUnit>.op_LessThan(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is less than the right one. |
| [operator &lt;=(UnitOfMeasure&lt;TUnit&gt;, UnitOfMeasure&lt;TUnit&gt;)](UnitOfMeasure_TUnit_.op_LessThanOrEqual.Rl+XHHuF6mR/6riB7FSvUg.md 'Jcd.Units.UnitOfMeasure<TUnit>.op_LessThanOrEqual(Jcd.Units.UnitOfMeasure<TUnit>, Jcd.Units.UnitOfMeasure<TUnit>)') | Compares two [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') instances to determine if the left one is less than or equal to the<br/>right one. |
