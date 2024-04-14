#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.operator /(Quantity<TUnit>, Quantity<TUnit>) Operator

Performs division on two quantities, converting to the larger of the two units of measure.

```csharp
public static Jcd.Units.Quantity<TUnit> operator /(Jcd.Units.Quantity<TUnit> x, Jcd.Units.Quantity<TUnit> y);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnit_.op_Division(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).x'></a>

`x` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The left hand operand

<a name='Jcd.Units.Quantity_TUnit_.op_Division(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).y'></a>

`y` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The right hand operand.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The result of the division.

#### Exceptions

[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
When [y](Quantity_TUnit_.op_Division.1LIGwu7yWD11Wm19tN9QFg.md#Jcd.Units.Quantity_TUnit_.op_Division(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).y 'Jcd.Units.Quantity<TUnit>.op_Division(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).y') is zero.