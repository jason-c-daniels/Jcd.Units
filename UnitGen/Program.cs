//#define WRITE_TO_CONSOLE

using System.Text;
using UnitGen.Models;
using UnitGen.Repositories;
using UnitGen.Services;
using FSS=UnitGen.Services.FileSystemService;

if (EssentialDirectoriesAreMissing(out var jcdUnitsDir, out var jcdUnitsTestsDir)) 
    return -1; // abort the app. We can't run.

var unitTypesDir = Path.Combine(jcdUnitsDir, "UnitTypes");
var unitsOfMeasureDir = Path.Combine(jcdUnitsDir, "UnitsOfMeasure");

var unitDefRepo = new UnitDefinitionRepository();
var unitDefs = unitDefRepo.GetAll();

var unitTypes = unitDefRepo.GetUsedUnitTypes();

var groupings = unitDefRepo.GetSystemToUnitTypeToUnitDefinitionGroupings();

var gen = new SourceCodeGenerator(unitDefRepo.SystemRepo.GetAll());

GenerateUnitTypes(unitTypesDir, unitTypes, gen);
FSS.CreateDirectoryIfNeeded(unitsOfMeasureDir);

foreach (var systemGrouping in groupings)
{
    var namespaceName=systemGrouping.Key.MakeSymbolName();
    var systemUnitsFolder = Path.Combine(unitsOfMeasureDir, namespaceName);
    if (namespaceName.Trim().Length > 0)
    {
        FSS.CreateDirectoryIfNeeded(systemUnitsFolder);
    }

    var subnamespaceName = string.IsNullOrWhiteSpace(namespaceName) ? string.Empty : $".{namespaceName}";
    var namespaceDocFileContent=gen.GenerateUnitOfMeasureNamespaceDoc(systemGrouping.Key,subnamespaceName);
    var namespaceDocPath = Path.Combine(systemUnitsFolder,"NamespaceDoc.cs");
    
    FSS.WriteFileContent(namespaceDocPath,namespaceDocFileContent);
    
    var uomWithNamespaceDir = string.IsNullOrWhiteSpace(namespaceName)
        ? unitsOfMeasureDir
        : Path.Combine(unitsOfMeasureDir, namespaceName);
    
    FSS.CreateDirectoryIfNeeded(uomWithNamespaceDir);
    
    foreach (var unitTypeGrouping in systemGrouping)
    {
        var ut = unitTypeGrouping.First().UnitType;
        var enumerationName = ut.EnumerationName;
        var enumerationFileName = $"{enumerationName}.cs";
        var enumerationsFilePath = Path.Combine(uomWithNamespaceDir,enumerationFileName);
        
        Console.WriteLine();
        Console.WriteLine($"--------------------------------------------------------");

        var sortedGrouping = unitTypeGrouping
                .OrderBy(u => u.System.Name)
                .ThenBy(u => u.UnitType.Name)
                .ThenByDescending(u => u.IsBaseUnit)
                .ThenBy(u => u.Unit.SortIndex)
                .ThenBy(u => u.Prefix.SortIndex)
                .ToList()
            ;
        var sbUnits = new StringBuilder();
        foreach (var unitDefinition in sortedGrouping)
        {
            Console.WriteLine($"Generating: {unitDefinition.Prefix.Name}{unitDefinition.Unit.UnitName}");
            sbUnits.AppendLine(gen.GenerateUnit(unitDefinition));
        }

        var enumerationFileContent=gen.GenerateEnumeration(sortedGrouping[0],sbUnits.ToString());
        FSS.WriteFileContent(enumerationsFilePath,enumerationFileContent);
    }
}

return 0;

void GenerateUnitTypes(string unitTypesDirPath, IEnumerable<UnitType> enumerable, SourceCodeGenerator gen)
{
    FSS.CreateDirectoryIfNeeded(unitTypesDirPath);

    // generate the individual unit type files in UnitTypes (in the output directory)
    foreach (var ut in enumerable)
    {
        var unitTypeFileName = $"{ut.UnitTypeName}.cs";
        var unitTypeFilePath = Path.Combine(unitTypesDirPath,unitTypeFileName);
        var fileContent = gen.GenerateUnitType(ut);
        FSS.WriteFileContent(unitTypeFilePath,fileContent);
    }
}

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

    Console.Error.WriteLine("Is gen-unit.exe in the correct directory (Any under the Jcd.Units solution directory)?");
    Console.Error.WriteLine("One or more essential directories could not be found.");
    Console.Error.WriteLine("ABORTING!");
    Console.WriteLine();
    Console.WriteLine("Press ANY KEY to continue.");
    Console.ReadKey();
    return true;
}
