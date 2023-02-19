#### [Jcd.Units](index.md 'index')

## Jcd.Units Namespace

Provides a quantity type ([Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')) and various simple [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>')  
implementations to facilitate relatively type and unit of measure safe arithmetic.

### Remarks
NOTE: This system does not automatically create quantities with derived units during  
multiplication and division. You must take care to change units and unit types  
as necessary during computations.

| Classes | |
| :--- | :--- |
| [Enumeration&lt;TEnumeration,T&gt;](Jcd.Units.Enumeration_TEnumeration,T_.md 'Jcd.Units.Enumeration<TEnumeration,T>') | The base of all DDD-style enumerations in this library. |
| [QuantityExtensions](Jcd.Units.QuantityExtensions.md 'Jcd.Units.QuantityExtensions') | Some extension methods to make creating quantities using units of measures,<br/>and converting among units of measure easier. |
| [UnitOfMeasure&lt;TUnits&gt;](Jcd.Units.UnitOfMeasure_TUnits_.md 'Jcd.Units.UnitOfMeasure<TUnits>') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |
| [UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions') | Extension methods that convert raw values to and from fundamental<br/>(Coefficient=1, Offset=0) unit of measure representations. |

| Structs | |
| :--- | :--- |
| [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') | Represents a quantity with an associated unit of measure. |

| Interfaces | |
| :--- | :--- |
| [IUnitOfMeasure&lt;TUnits&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>') | The interface defining what every unit of measure must support. |
