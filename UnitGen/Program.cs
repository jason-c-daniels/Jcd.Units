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
var unitDefs = unitDefRepo.GetAll();
var unitTypes = (
        from unitDef in unitDefs 
        select unitDef.UnitType)
    .Distinct();

var unitTypesDir = GenerateUnitTypes(jcdUnitsDir, unitTypes);

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
    // TODO: Make subdir
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
        var sbUnits = new StringBuilder();
        foreach (var unitDefinition in unitTypeGrouping)
        {
            Console.WriteLine($"Generating: {unitDefinition.Prefix.Name}{unitDefinition.Unit.UnitName}");
            // sbUnits.AppendLine(utg.Generate(unitDefinition));
        }
        // var fileContent=utg.GenerateEnumeration(unitTypeEnumerationName,sbUnits.ToString());
        // File.WriteAllText(enumerationsFilePath,fileContent);
    }
}

int i = 9;

return 0;

void CreateDirectoryIfNeeded(string targetDir)
{
    if (!Directory.Exists(targetDir))
    {
        Console.WriteLine($"Creating {targetDir}.");
        //Directory.CreateDirectory(targetDir);
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

string GenerateUnitTypes(string s, IEnumerable<UnitType> enumerable)
{
    var unitTypesDir = Path.Combine(s, "UnitTypes");
    var utg = new UnitTypeGenerator();
// generate the individual unit type files in UnitTypes (in the output directory)
    foreach (var ut in enumerable)
    {
        var unitTypeFileName = $"{ut.UnitTypeName}.cs";
        var unitTypeFilePath = Path.Combine(unitTypesDir,unitTypeFileName);
        Console.WriteLine($"Generating {unitTypeFileName} in '{unitTypesDir}'");
        if (File.Exists(unitTypeFilePath))
            Console.WriteLine($"{unitTypeFilePath} already exists. Overwriting.");
        Console.WriteLine($"--------------------------------------------------------");
        Console.WriteLine(utg.Generate(ut));
    }

    return unitTypesDir;
}
/*
var prefixRepo = new PrefixRepository();
var unitRepo = new UnitRepository();
var unitTypeRepo = new UnitTypeRepository();

var unitTypes = unitTypeRepo.GetAll();
var units = unitRepo.GetAll();//ReadData<BaseUnitDefinition>("Data/units.csv");
var prefixes = prefixRepo.GetAll();//ReadData<PrefixDefinition>("Data/prefixes.csv");

var unitsWithPrefixes = 
    (
        from prefix in prefixes
        from unit in units
        where unit.UsesPrefixes
        select new UnitDefinition
        (
            unit.System,
            unit.UnitType,
            $"{prefix.Name}{unit.UnitName}",
            $"{prefix.Symbol}{unit.UnitSymbol}",
            prefix.IsBasePrefix 
                ? unit.BaseUnit
                : $"{prefix.BasePrefix}{unit.UnitName}",
            prefix.IsBasePrefix 
                ? unit.Coefficient 
                : prefix.Coefficient,
            "0",
            unit.SortIndex,
            prefix.SortIndex
        )
    )
    .OrderBy(x=>x.UnitType)
    .ThenBy(x=>x.UnitSortIndex)
    .ToList();

var unitsWithoutPrefixes = 
    (
        from unit in units
        where !unit.UsesPrefixes
        select new UnitDefinition
        (
            unit.System,
            unit.UnitType,
            $"{unit.UnitName}",
            $"{unit.UnitSymbol}",
            unit.BaseUnit,
            unit.Coefficient,
            unit.Offset,
            unit.SortIndex,
            0
        )
    )
    .OrderBy(x=>x.UnitType)
    .ThenBy(x=>x.Name)
    .ToList();

var allUnits = unitsWithPrefixes.Concat(unitsWithoutPrefixes)
    .OrderBy(x=>x.System)
    .ThenBy(x=>x.UnitType)
    .ThenByDescending(x=>x.IsBaseUnit)
    .ThenBy(x=>x.UnitSortIndex)
    .ThenBy(x=>x.PrefixSortIndex)
    .ThenBy(x=>x.Name)
    .ToList();

var allUnitTypes=(from unit in allUnits select unit.UnitType).Distinct();
var utg = new UnitTypeGenerator();
foreach (var unitType in allUnitTypes)
{
    var unitTypeName = unitType.MakeSymbolName();
    Console.WriteLine($"/// File: {unitTypeName}.cs");
    Console.WriteLine(utg.Generate(unitTypeName));
}

var groupings =
    from unit in allUnits
    group unit by unit.System
    into systemGroup
    from unitType in (
        from unit in systemGroup
        group unit by unit.UnitType
    )
    group unitType by systemGroup.Key;


int i = 0;

IList<T> ReadData<T>(string pathToFile)
{
    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        PrepareHeaderForMatch = args => args.Header.Replace(" ",""),
        HasHeaderRecord = true
    };
    using var reader = new StreamReader(pathToFile);
    using var csv = new CsvReader(reader, config);
    return csv.GetRecords<T>().ToList();
}

void EmitType(string previousType, string typeName)
{
    if (typeName != previousType)
    {
        if (!string.IsNullOrWhiteSpace(previousType))
        {
            Console.WriteLine(Templates.UnitTypeEnd);
            Console.WriteLine("");
        }

        if (!string.IsNullOrWhiteSpace(typeName))
        {
            Console.WriteLine(Templates.UnitTypeStart.Replace("$UnitType$", typeName));
        }
    }
}

string EmitUnit(string typeName, string unitType, UnitDefinition unit)
{
    var template= unit.IsBaseUnit ? Templates.BaseUnitEntry : Templates.DerivedUnitEntry;
   return template
        .Replace("$TypeName$", typeName)
        .Replace("$UnitType$", unitType)
        .Replace("$UnitName$", unit.Name)
        .Replace("$Symbol$", unit.Symbol)
        .Replace("$BaseUnit$", unit.BaseUnit.MakeSymbolName())
        .Replace("$Coefficient$", unit.UnitCoefficient)
        .Replace("$Offset$", unit.Offset);
}
*/