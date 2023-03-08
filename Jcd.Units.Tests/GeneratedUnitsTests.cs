#region

using System.Collections;
using System.Reflection;

#endregion

namespace Jcd.Units.Tests;

public class GeneratedUnitsTests
{
   [Theory]
   [MemberData(nameof(EnumerationsTypesAndUnitOfMeasureInstances))]
   public void All_Enumerations_GetAll_Returns_NonEmpty_Collections(Type enumerationType, IEnumerable unitsOfMeasure)
   {
      Assert.NotNull(enumerationType);
      Assert.NotNull(unitsOfMeasure);
      Assert.NotEmpty(unitsOfMeasure);
   }

   /// <summary>
   /// Use reflection to 
   /// </summary>
   public static IEnumerable<object[]> EnumerationsTypesAndUnitOfMeasureInstances
   {
      get
      {
         // enumerates all types implementing Enumeration<TEnumeration,TUnit>
         var enumerationTypes =
                  from type in Assembly.GetAssembly(typeof(Enumeration<,>))!.GetTypes()
                  let baseType = type.BaseType
                  where !type.IsAbstract
                     && !type.IsInterface
                     && baseType is not null
                     && baseType.IsGenericType
                     && baseType.GetGenericTypeDefinition() == typeof(Enumeration<,>)
                  select type;

         // ReSharper disable once HeapView.ObjectAllocation.Possible
         foreach (var enumerationType in enumerationTypes)
         {
            // bind the GetAll method.
            var baseType = enumerationType.BaseType;
            var method   = baseType?.GetMethod("GetAll", BindingFlags.Public | BindingFlags.Static);

            // call GetAll
            var results = method?.Invoke(null, null) as IEnumerable;

            yield return new object[] { enumerationType, results! };
         }
      }
   }
}
