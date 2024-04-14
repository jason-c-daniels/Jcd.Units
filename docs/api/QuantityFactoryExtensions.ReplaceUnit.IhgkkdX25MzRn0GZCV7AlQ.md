#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[QuantityFactoryExtensions](QuantityFactoryExtensions.md 'Jcd.Units.QuantityFactoryExtensions')

## QuantityFactoryExtensions.ReplaceUnit<TUnit,TNewUnit>(this Quantity<TUnit>, TNewUnit) Method

Converts an existing [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') into a new quantity replacing the existing units of measure with  
the the specified unit of measure, WITHOUT CONVERSION.

```csharp
public static Jcd.Units.Quantity<TNewUnit> ReplaceUnit<TUnit,TNewUnit>(this Jcd.Units.Quantity<TUnit> quantity, TNewUnit unitOfMeasure)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>
    where TNewUnit : Jcd.Units.UnitOfMeasure<TNewUnit>;
```
#### Type parameters

<a name='Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).TUnit'></a>

`TUnit`

The type of unit of measure for the source quantity.

<a name='Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).TNewUnit'></a>

`TNewUnit`

The type of the new unit of measure for the new quantity.
#### Parameters

<a name='Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).quantity'></a>

`quantity` [Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](QuantityFactoryExtensions.ReplaceUnit.IhgkkdX25MzRn0GZCV7AlQ.md#Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).TUnit 'Jcd.Units.QuantityFactoryExtensions.ReplaceUnit<TUnit,TNewUnit>(this Jcd.Units.Quantity<TUnit>, TNewUnit).TUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') to convert.

<a name='Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).unitOfMeasure'></a>

`unitOfMeasure` [TNewUnit](QuantityFactoryExtensions.ReplaceUnit.IhgkkdX25MzRn0GZCV7AlQ.md#Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).TNewUnit 'Jcd.Units.QuantityFactoryExtensions.ReplaceUnit<TUnit,TNewUnit>(this Jcd.Units.Quantity<TUnit>, TNewUnit).TNewUnit')

The new unit of measure to use.

#### Returns
[Jcd.Units.Quantity&lt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TNewUnit](QuantityFactoryExtensions.ReplaceUnit.IhgkkdX25MzRn0GZCV7AlQ.md#Jcd.Units.QuantityFactoryExtensions.ReplaceUnit_TUnit,TNewUnit_(thisJcd.Units.Quantity_TUnit_,TNewUnit).TNewUnit 'Jcd.Units.QuantityFactoryExtensions.ReplaceUnit<TUnit,TNewUnit>(this Jcd.Units.Quantity<TUnit>, TNewUnit).TNewUnit')[&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')  
A new [Quantity&lt;TUnit&gt;](Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance.