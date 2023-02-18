#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

## Quantity<TUnits>.operator /(Quantity<TUnits>, Quantity<TUnits>) Operator

Performs division on two quantities, converting to the larger of the two units of measure.

```csharp
public static Jcd.Units.Quantity<TUnits> operator /(Jcd.Units.Quantity<TUnits> x, Jcd.Units.Quantity<TUnits> y);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).x'></a>

`x` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.Quantity_TUnits_.md#Jcd.Units.Quantity_TUnits_.TUnits 'Jcd.Units.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

The left hand operand

<a name='Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).y'></a>

`y` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.Quantity_TUnits_.md#Jcd.Units.Quantity_TUnits_.TUnits 'Jcd.Units.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

The right hand operand.

#### Returns
[Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.Quantity_TUnits_.md#Jcd.Units.Quantity_TUnits_.TUnits 'Jcd.Units.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')  
The result of the division.

#### Exceptions

[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
When [y](Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).md#Jcd.Units.Quantity_TUnits_.op_Division(Jcd.Units.Quantity_TUnits_,Jcd.Units.Quantity_TUnits_).y 'Jcd.Units.Quantity<TUnits>.op_Division(Jcd.Units.Quantity<TUnits>, Jcd.Units.Quantity<TUnits>).y') is zero.