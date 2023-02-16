using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Jcd.Units;

public class Enumeration<TEnumeration,T>
    where T : IEquatable<T>
{
    public static IEnumerable<T> GetAll() =>
        typeof(TEnumeration).GetFields(BindingFlags.Public |
                                       BindingFlags.Static |
                                       BindingFlags.DeclaredOnly)
            .Select(f => f.GetValue(null))
            .Cast<T>();
}