#### [Jcd.Units](index.md 'index')

## Jcd.Units Namespace

Provides a quantity type ([Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')) and various simple [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')  
implementations to facilitate relatively type and unit of measure safe arithmetic.

### Remarks
NOTE: This system does not automatically create quantities with derived units during  
multiplication and division. You must take care to change units and unit types  
as necessary during computations.

| Classes | |
| :--- | :--- |
| [BitwiseDoubleComparer](Jcd.Units.BitwiseDoubleComparer.md 'Jcd.Units.BitwiseDoubleComparer') | Performs standard, compiler provided, comparison operations against two doubles. |
| [DoubleComparer](Jcd.Units.DoubleComparer.md 'Jcd.Units.DoubleComparer') | Provides both default and registrable ways of comparing doubles used within this subsystem. |
| [Enumeration&lt;TEnumeration,T&gt;](Jcd.Units.Enumeration_TEnumeration,T_.md 'Jcd.Units.Enumeration<TEnumeration,T>') | The base of all DDD-style enumerations in this library. |
| [NumericExtensions](Jcd.Units.NumericExtensions.md 'Jcd.Units.NumericExtensions') | Some extension methods to make creating quantities using units of measures,<br/>and converting among units of measure easier. |
| [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') | Base type to simplify creating a unit of measure. This type provides relational and equivalence operations. |

| Structs | |
| :--- | :--- |
| [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') | Represents a quantity with an associated unit of measure. |

| Interfaces | |
| :--- | :--- |
| [IUnitOfMeasure&lt;TUnit&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>') | The interface defining what every unit of measure must support. |
| [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') | Defines the interface needed to perform value comparisons within a quantity type. |
