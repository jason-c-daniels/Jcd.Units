//#define WRITE_TO_CONSOLE

using System.Reflection;
using System.Text;
using UnitGen.CodeGenerators;
using UnitGen.Data;

var jcdUnitsDir = FindDirectory("Jcd.Units");
var jcdUnitsTestsDir = FindDirectory("Jcd.Units.Tests");

if (jcdUnitsDir == null || jcdUnitsTestsDir == null)
{
    Console.Error.WriteLine("One or more essential directories could not be found. ABORTING.");
    return -1;
}

var unitDefRepo = new UnitDefinitionRepository();
var gen = new SourceCodeGenerator(unitDefRepo.SystemRepo.GetAll());

var unitDefs = unitDefRepo.GetAll();
var unitTypes = (
        from unitDef in unitDefs 
        select unitDef.UnitType)
    .Distinct();
var unitTypesDir = GenerateUnitTypes(jcdUnitsDir, unitTypes,gen);

var unitsOfMeasureDir = Path.Combine(jcdUnitsDir, "UnitsOfMeasure");

CreateDirectoryIfNeeded(unitsOfMeasureDir);
CreateDirectoryIfNeeded(unitTypesDir);

var groupings =
    from unit in unitDefs
    group unit by unit.System.Name
    into systemGroup
    from unitType in (
        from unit in systemGroup
        group unit by unit.UnitType.Name
    )
    group unitType by systemGroup.Key;

foreach (var systemGrouping in groupings)
{
    var namespaceName=systemGrouping.Key.MakeSymbolName();
    if (namespaceName.Trim().Length > 0)
    {
        CreateDirectoryIfNeeded(Path.Combine(unitsOfMeasureDir,namespaceName));
    }

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
        Console.WriteLine($"Generating: {enumerationsFilePath}");
        if (File.Exists(enumerationsFilePath))
            Console.WriteLine($"{enumerationFileName} already exists. Overwriting.");
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

        var fileContent=gen.GenerateEnumeration(sortedGrouping[0],sbUnits.ToString());
#if WRITE_TO_CONSOLE
        Console.WriteLine(fileContent);
#else        
        File.WriteAllText(enumerationsFilePath,fileContent, Encoding.UTF8);
#endif
    }
}

int i = 9;

return 0;

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

string GenerateUnitTypes(string s, IEnumerable<UnitType> enumerable, SourceCodeGenerator gen)
{
    var unitTypesDir = Path.Combine(s, "UnitTypes");
    CreateDirectoryIfNeeded(unitTypesDir);
// generate the individual unit type files in UnitTypes (in the output directory)
    foreach (var ut in enumerable)
    {
        var unitTypeFileName = $"{ut.UnitTypeName}.cs";
        var unitTypeFilePath = Path.Combine(unitTypesDir,unitTypeFileName);
        Console.WriteLine($"Generating {unitTypeFileName} in '{unitTypesDir}'");
        if (File.Exists(unitTypeFilePath))
            Console.WriteLine($"{unitTypeFilePath} already exists. Overwriting.");
        Console.WriteLine($"--------------------------------------------------------");
        var fileContent = gen.GenerateUnitType(ut);
#if WRITE_TO_CONSOLE
        Console.WriteLine(fileContent);
#else
        File.WriteAllText(unitTypeFilePath, fileContent, Encoding.UTF8);
#endif
    }

    return unitTypesDir;
}
