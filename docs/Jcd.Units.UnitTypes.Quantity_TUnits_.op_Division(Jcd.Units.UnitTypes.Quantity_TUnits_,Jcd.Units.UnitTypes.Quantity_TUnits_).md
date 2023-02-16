#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Quantity&lt;TUnits&gt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')

## Quantity<TUnits>.operator /(Quantity<TUnits>, Quantity<TUnits>) Operator

Performs division on two quantities, converting to the larger of the two units of measure.

```csharp
public static Jcd.Units.UnitTypes.Quantity<TUnits> operator /(Jcd.Units.UnitTypes.Quantity<TUnits> x, Jcd.Units.UnitTypes.Quantity<TUnits> y);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Quantity_TUnits_.op_Division(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).x'></a>

`x` [Jcd.Units.UnitTypes.Quantity&lt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')[TUnits](Jcd.Units.UnitTypes.Quantity_TUnits_.md#Jcd.Units.UnitTypes.Quantity_TUnits_.TUnits 'Jcd.Units.UnitTypes.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')

The left hand operand

<a name='Jcd.Units.UnitTypes.Quantity_TUnits_.op_Division(Jcd.Units.UnitTypes.Quantity_TUnits_,Jcd.Units.UnitTypes.Quantity_TUnits_).y'></a>

`y` [Jcd.Units.UnitTypes.Quantity&lt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')[TUnits](Jcd.Units.UnitTypes.Quantity_TUnits_.md#Jcd.Units.UnitTypes.Quantity_TUnits_.TUnits 'Jcd.Units.UnitTypes.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')

The right hand operand.

#### Returns
[Jcd.Units.UnitTypes.Quantity&lt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')[TUnits](Jcd.Units.UnitTypes.Quantity_TUnits_.md#Jcd.Units.UnitTypes.Quantity_TUnits_.TUnits 'Jcd.Units.UnitTypes.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.UnitTypes.Quantity_TUnits_.md 'Jcd.Units.UnitTypes.Quantity<TUnits>')  
The result of the division.

#### Exceptions

[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
When `y` is zero.