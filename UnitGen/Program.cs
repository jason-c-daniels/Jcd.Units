// See https://aka.ms/new-console-template for more information


using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;
using UnitGen;
using UnitGen.CodeGenerators;
using UnitGen.Data;
using UnitGen.Resources;
using PrefixDefinition = UnitGen.PrefixDefinition;

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
            $"{prefix.Prefix}{unit.UnitName}",
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
    var unitTypeName = unitType.MakeCodeName();
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
        .Replace("$BaseUnit$", unit.BaseUnit.MakeCodeName())
        .Replace("$Coefficient$", unit.UnitCoefficient)
        .Replace("$Offset$", unit.Offset);
}