#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Round<TUnit>(Quantity<TUnit>, int, MidpointRounding) Method

Rounds a quantity's numeric component to a specified number of digits using the specified rounding mode.

```csharp
public static Jcd.Units.Quantity<TUnit> Round<TUnit>(Jcd.Units.Quantity<TUnit> quantity, int digits=0, MidpointRounding mode=0)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)
#### Parameters

<a name='Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Round.IopzLA/KBp5OtAg2cUzdnA.md#Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).TUnit 'Jcd.Units.MathQ.Round<TUnit>(Jcd.Units.Quantity<TUnit>, int, MidpointRounding).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The quantity

<a name='Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).digits'></a>

`digits` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of decimal places to round to. (Default is zero.)

<a name='Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).mode'></a>

`mode` [System.MidpointRounding](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding 'System.MidpointRounding')

The rounding mode to use (default is ToEven)

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Round.IopzLA/KBp5OtAg2cUzdnA.md#Jcd.Units.MathQ.Round_TUnit_(Jcd.Units.Quantity_TUnit_,int,MidpointRounding).TUnit 'Jcd.Units.MathQ.Round<TUnit>(Jcd.Units.Quantity<TUnit>, int, MidpointRounding).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
The [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') rounded to the specified number of digits.