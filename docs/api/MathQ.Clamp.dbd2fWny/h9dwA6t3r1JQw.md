#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[MathQ](MathQ.md 'Jcd.Units.MathQ')

## MathQ.Clamp<TUnit>(Quantity<TUnit>, Quantity<TUnit>, Quantity<TUnit>) Method

Returns the smallest value that is greater than or equal to the numeric component of a
[Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>').

```csharp
public static Jcd.Units.Quantity<TUnit> Clamp<TUnit>(Jcd.Units.Quantity<TUnit> value, Jcd.Units.Quantity<TUnit> min, Jcd.Units.Quantity<TUnit> max)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit'></a>

`TUnit`

The type of unit of measure. (e.g. temperature)

#### Parameters

<a name='Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).value'></a>

`value` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Clamp.dbd2fWny/h9dwA6t3r1JQw.md#Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Clamp<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The quantity to clamp

<a name='Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).min'></a>

`min` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Clamp.dbd2fWny/h9dwA6t3r1JQw.md#Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Clamp<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The minimum value.

<a name='Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).max'></a>

`max` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Clamp.dbd2fWny/h9dwA6t3r1JQw.md#Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Clamp<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The maximum value.

#### Returns

[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](MathQ.Clamp.dbd2fWny/h9dwA6t3r1JQw.md#Jcd.Units.MathQ.Clamp_TUnit_(Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_,Jcd.Units.Quantity_TUnit_).TUnit 'Jcd.Units.MathQ.Clamp<TUnit>(Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>, Jcd.Units.Quantity<TUnit>).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')
the ceiling for the [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>').