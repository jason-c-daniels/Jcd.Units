#region

using System.Reflection;

#endregion

namespace Jcd.Units.Tests._Extensions;

public static class ReflectionExtensions
{
   public static object? CallMethod
            (
            this Type type
          , string methodName
          , BindingFlags bindingAttr = BindingFlags.Default
            )
      => CallMethod(type, methodName, null, null, bindingAttr);

   public static object? CallMethod
            (
            this Type type
          , string methodName
          , object? callTarget = null
          , object?[]? arguments = null
          , BindingFlags bindingAttr = BindingFlags.Default
            )
   {
      var method = type.GetMethod(methodName, bindingAttr);

      return method?.Invoke(callTarget, arguments);
   }

   public static IEnumerable<Type> GetImplementationTypes<T>(this Assembly? assembly)
      => GetImplementationTypes(assembly, typeof(T));

   public static IEnumerable<Type> GetImplementationTypes(this Assembly? assembly, Type targetBaseType)
      => targetBaseType.IsGenericType
               ?
               from type in assembly?.GetTypes()
               let baseType = type.BaseType
               where !type.IsAbstract
                  && !type.IsInterface
                  && baseType is not null
                  && baseType.IsGenericType
                  && baseType.GetGenericTypeDefinition() == targetBaseType
               select type
               :
               from type in assembly?.GetTypes()
               let baseType = type.BaseType
               where !type.IsAbstract
                  && !type.IsInterface
                  && baseType is not null
                  && !baseType.IsGenericType
                  && baseType == targetBaseType
               select type;
}
