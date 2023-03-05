#region

using UnitGen.Repositories;

#endregion

namespace UnitGen.Services;

public class TestGenerator
{
   private readonly Dictionary<string, Models.System> _systemLookup;
   private readonly UnitDefinitionRepository _unitDefRepo;
   private readonly string _unitsOfMeasureTestDir;
   private readonly string _unitTypesTestDir;

   public TestGenerator(UnitDefinitionRepository unitDefRepo, string jcdUnitsTestsDir)
   {
      _unitDefRepo           = unitDefRepo;
      _unitTypesTestDir      = Path.Combine(jcdUnitsTestsDir, "UnitTypes");
      _unitsOfMeasureTestDir = Path.Combine(jcdUnitsTestsDir, "UnitsOfMeasure");

      _systemLookup = unitDefRepo.SystemRepo.GetAll()
                                 .ToDictionary(x => x.Name);
   }

   public void CreateUnitTypeTests() { }

   public void CreateUnitOfMeasureTests() { }
}
