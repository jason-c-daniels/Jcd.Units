using UnitGen.Repositories;

namespace UnitGen.Services;

public class TestGenerator
{
    private readonly UnitDefinitionRepository _unitDefRepo;
    private readonly string _unitTypesTestDir;
    private readonly string _unitsOfMeasureTestDir;
    private readonly Dictionary<string, Models.System> _systemLookup;

    public TestGenerator(UnitDefinitionRepository unitDefRepo, string jcdUnitsTestsDir)
    {
        _unitDefRepo = unitDefRepo;
        _unitTypesTestDir = Path.Combine(jcdUnitsTestsDir, "UnitTypes");
        _unitsOfMeasureTestDir = Path.Combine(jcdUnitsTestsDir, "UnitsOfMeasure");
        
        _systemLookup = unitDefRepo.SystemRepo.GetAll().ToDictionary(x => x.Name);
    }

    public void CreateUnitTypeTests()
    {
        
    }
    
    public void CreateUnitOfMeasureTests()
    {
        
    }
}