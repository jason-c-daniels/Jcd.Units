#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## EnumerationBase<TEnumeration,T> Class

The base of all unit of measure enumerations in this library.

```csharp
public class EnumerationBase<TEnumeration,T>
    where T : IEquatable<T>
```
#### Type parameters

<a name='Jcd.Units.EnumerationBase_TEnumeration,T_.TEnumeration'></a>

`TEnumeration`

The enumeration type.

<a name='Jcd.Units.EnumerationBase_TEnumeration,T_.T'></a>

`T`

The type of the enumerated members.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EnumerationBase<TEnumeration,T>

Derived  
&#8627; [Enumeration&lt;TEnumeration,T&gt;](Jcd.Units.Enumeration_TEnumeration,T_.md 'Jcd.Units.Enumeration<TEnumeration,T>')

| Fields | |
| :--- | :--- |
| [All](Jcd.Units.EnumerationBase_TEnumeration,T_.All.md 'Jcd.Units.EnumerationBase<TEnumeration,T>.All') | All enumerated elements. Populated in static constructor. |

| Methods | |
| :--- | :--- |
| [GetAll()](Jcd.Units.EnumerationBase_TEnumeration,T_.GetAll().md 'Jcd.Units.EnumerationBase<TEnumeration,T>.GetAll()') | Retrieves all public static properties of type [T](Jcd.Units.EnumerationBase_TEnumeration,T_.md#Jcd.Units.EnumerationBase_TEnumeration,T_.T 'Jcd.Units.EnumerationBase<TEnumeration,T>.T')<br/>on the derived enumeration [TEnumeration](Jcd.Units.EnumerationBase_TEnumeration,T_.md#Jcd.Units.EnumerationBase_TEnumeration,T_.TEnumeration 'Jcd.Units.EnumerationBase<TEnumeration,T>.TEnumeration') |
