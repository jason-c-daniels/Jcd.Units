using UnitGen.Repositories;
using UnitGen.Services;
using FSS=UnitGen.Services.FileSystemService;

if (EssentialDirectoriesAreMissing(out var jcdUnitsDir, out var jcdUnitsTestsDir)) 
    return -1; // abort the app. We can't run.

var unitDefRepo = new UnitDefinitionRepository();

var sourceGen = new SourceCodeGenerator(unitDefRepo,jcdUnitsDir);
var testGen = new TestGenerator(unitDefRepo,jcdUnitsTestsDir);

try
{
    sourceGen.CreateUnitTypeFiles();
    testGen.CreateUnitTypeTests();    
    sourceGen.CreateUnitOfMeasureFiles();
    testGen.CreateUnitOfMeasureTests();
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Internal Error: {ex.Message}");
    return -1;
}

return 0;

bool EssentialDirectoriesAreMissing(out string jcdUnitsDirResult, out string jcdUnitsTestsDirResult)
{
    var jcdUnitsDirTest = FSS.FindDirectory("Jcd.Units");
    var jcdUnitsTestsDirTest = FSS.FindDirectory("Jcd.Units.Tests");

    if (jcdUnitsDirTest != null && jcdUnitsTestsDirTest != null)
    {
        (jcdUnitsDirResult, jcdUnitsTestsDirResult) = (jcdUnitsDirTest, jcdUnitsTestsDirTest);
        return false;
    }

    if (jcdUnitsDirTest == null)
        Console.Error.WriteLine("Directory: Jcd.Units could not be found.");
    
    if (jcdUnitsTestsDirTest == null)
        Console.Error.WriteLine("Directory: Jcd.Units.Tests could not be found.");

    jcdUnitsDirResult = jcdUnitsTestsDirResult = string.Empty; // this shuts the compiler up.

    Console.Error.WriteLine("Is unit-gen.exe in the correct directory (Any under the Jcd.Units solution directory)?");
    Console.Error.WriteLine("One or more essential directories could not be found.");
    Console.Error.WriteLine("ABORTING!");
    Console.WriteLine();
    Console.WriteLine("Press ANY KEY to continue.");
    Console.ReadKey();
    return true;
}