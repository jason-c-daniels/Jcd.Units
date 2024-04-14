#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## Enumeration<TEnumeration,T> Class

The base of all unit of measure enumerations in this library.

```csharp
public abstract class Enumeration<TEnumeration,T>
    where T : IEquatable<T>
```
#### Type parameters

<a name='Jcd.Units.Enumeration_TEnumeration,T_.TEnumeration'></a>

`TEnumeration`

The enumeration type.

<a name='Jcd.Units.Enumeration_TEnumeration,T_.T'></a>

`T`

The type of the enumerated members.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Enumeration<TEnumeration,T>

Derived
&#8627; [UnitOfMeasureEnumeration&lt;TEnumeration,T&gt;](UnitOfMeasureEnumeration_TEnumeration,T_.md 'Jcd.Units.UnitOfMeasureEnumeration<TEnumeration,T>')

| Fields | |
| :--- | :--- |
| [All](Enumeration_TEnumeration,T_.All.md 'Jcd.Units.Enumeration<TEnumeration,T>.All') | All enumerated elements. Populated in static constructor. |

| Methods | |
| :--- | :--- |
| [GetAll()](Enumeration_TEnumeration,T_.GetAll().md 'Jcd.Units.Enumeration<TEnumeration,T>.GetAll()') | Retrieves all public static properties of type [T](Enumeration_TEnumeration,T_.md#Jcd.Units.Enumeration_TEnumeration,T_.T 'Jcd.Units.Enumeration<TEnumeration,T>.T') on the derived enumeration [TEnumeration](Enumeration_TEnumeration,T_.md#Jcd.Units.Enumeration_TEnumeration,T_.TEnumeration 'Jcd.Units.Enumeration<TEnumeration,T>.TEnumeration') |
