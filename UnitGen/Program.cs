//#define WRITE_TO_CONSOLE

using System.Reflection;
using System.Text;
using UnitGen.CodeGenerators;
using UnitGen.Data;

var jcdUnitsDir = FindDirectory("Jcd.Units");
var jcdUnitsTestsDir = FindDirectory("Jcd.Units.Tests");

if (jcdUnitsDir == null || jcdUnitsTestsDir == null)
{
    if (jcdUnitsDir == null) Console.Error.WriteLine("Directory: Jcd.Units could not be found.");
    if (jcdUnitsTestsDir == null) Console.Error.WriteLine("Directory: Jcd.Units.Tests could not be found.");
    
    Console.Error.WriteLine("Is gen-unit.exe in the correct directory (Any under the Jcd.Units solution directory)?");
    Console.Error.WriteLine("One or more essential directories could not be found.");
    Console.Error.WriteLine("ABORTING!");
    Console.WriteLine("Press ANY KEY to continue.");
    Console.ReadKey();
    return -1;
}

var unitTypesDir = Path.Combine(jcdUnitsDir, "UnitTypes");
var unitsOfMeasureDir = Path.Combine(jcdUnitsDir, "UnitsOfMeasure");

var unitDefRepo = new UnitDefinitionRepository();

var unitDefs = unitDefRepo.GetAll();
var unitTypes = (
        from unitDef in unitDefs 
        select unitDef.UnitType)
    .Distinct();

var groupings =
    from unit in unitDefs
    group unit by unit.System.Name
    into systemGroup
    from unitType in (
        from unit in systemGroup
        group unit by unit.UnitType.Name
    )
    group unitType by systemGroup.Key;

var gen = new SourceCodeGenerator(unitDefRepo.SystemRepo.GetAll());
GenerateUnitTypes(unitTypesDir, unitTypes,gen);
CreateDirectoryIfNeeded(unitsOfMeasureDir);

foreach (var systemGrouping in groupings)
{
    var namespaceName=systemGrouping.Key.MakeSymbolName();
    var systemUnitsFolder = Path.Combine(unitsOfMeasureDir, namespaceName);
    if (namespaceName.Trim().Length > 0)
    {
        CreateDirectoryIfNeeded(systemUnitsFolder);
    }

    var subnamespaceName = string.IsNullOrWhiteSpace(namespaceName) ? string.Empty : $".{namespaceName}";
    var namespaceDocFileContent=gen.GenerateUnitOfMeasureNamespaceDoc(systemGrouping.Key,subnamespaceName);
    var namespaceDocPath = Path.Combine(systemUnitsFolder,"NamespaceDoc.cs");
    
    WriteFileContent(namespaceDocPath,namespaceDocFileContent);
    
    var uomWithNamespaceDir = string.IsNullOrWhiteSpace(namespaceName)
        ? unitsOfMeasureDir
        : Path.Combine(unitsOfMeasureDir, namespaceName);
    
    CreateDirectoryIfNeeded(uomWithNamespaceDir);
    
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
        WriteFileContent(enumerationsFilePath,enumerationFileContent);
    }
}

return 0;

void WriteFileContent(string filePath, string fileContent)
{
    Console.Write($"Generating: {filePath}. ");
    if (File.Exists(filePath))
        Console.Write($"File already exists, overwriting.");
    Console.WriteLine();

#if WRITE_TO_CONSOLE
    Console.WriteLine(fileContent);
#else        
    File.WriteAllText(filePath,fileContent, Encoding.UTF8);
#endif
}

void CreateDirectoryIfNeeded(string targetDir)
{
    if (!Directory.Exists(targetDir))
    {
        Console.WriteLine($"Creating {targetDir}.");
        Directory.CreateDirectory(targetDir);
    }
}

string? FindDirectory(string targetDir)
{
    var startupDir = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
    var testDir = startupDir;
    while (testDir != null && !Directory.Exists(Path.Combine(testDir, targetDir)))
        testDir = Path.GetDirectoryName(testDir);

    if (testDir == null)
    {
        Console.Error.WriteLine($"Could not locate {targetDir} folder.");
    }

    return testDir != null ? Path.Combine(testDir,targetDir) : null;
}

string GenerateUnitTypes(string unitTypesDir, IEnumerable<UnitType> enumerable, SourceCodeGenerator gen)
{
    CreateDirectoryIfNeeded(unitTypesDir);

    // generate the individual unit type files in UnitTypes (in the output directory)
    foreach (var ut in enumerable)
    {
        var unitTypeFileName = $"{ut.UnitTypeName}.cs";
        var unitTypeFilePath = Path.Combine(unitTypesDir,unitTypeFileName);
        var fileContent = gen.GenerateUnitType(ut);
        WriteFileContent(unitTypeFilePath,fileContent);
    }
    return unitTypesDir;
}
