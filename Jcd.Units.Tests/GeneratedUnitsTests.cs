#region

using System.Collections;
using System.Reflection;

using Jcd.Reflection;

#endregion

namespace Jcd.Units.Tests;

public class GeneratedUnitsTests : TestBase
{
   /// <summary>
   /// Use reflection to call GetAll on all <see cref="Enumeration{TEnumeration,T}" /> derived types.
   /// </summary>
   public static IEnumerable<object[]> EnumerationsTypesAndUnitOfMeasureInstances
   {
      get
      {
         var enumerationTypes =
                  Assembly.GetAssembly(typeof(Enumeration<,>))
                          .FindImplementationsOf(typeof(Enumeration<,>));

         return
                  from enumeration in enumerationTypes
                  select new[] { enumeration, enumeration.Invoke("GetAll") };
      }
   }

   [Theory]
   [MemberData(nameof(EnumerationsTypesAndUnitOfMeasureInstances))]
   public void All_Enumerations_GetAll_Returns_NonEmpty_Collections(Type enumerationType, IEnumerable unitsOfMeasure)
   {
      Assert.NotNull(enumerationType);
      Assert.NotNull(unitsOfMeasure);
      Assert.NotEmpty(unitsOfMeasure);
   }
}
