// See https://aka.ms/new-console-template for more information

//var siPrefixes =

using System.Globalization;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;
using UnitGen;
using UnitGen.Resources;

var siBaseUnits = ReadData<BaseUnitDefinition>("SI.baseunits.csv");
var siPrefixes = ReadData<SiPrefix>("SI.prefixes.csv");

var unitsWithPrefixes = 
    (
        from prefix in siPrefixes
        from baseUnit in siBaseUnits
        where baseUnit.UsesPrefixes
        select new UnitDefinition
        (
            "SI",
            baseUnit.QuantityName,
            $"{prefix.Prefix}{baseUnit.UnitName}",
            $"{prefix.Symbol}{baseUnit.UnitSymbol}",
            baseUnit.BaseUnit,
            prefix.Coefficient,
            "0",
            prefix.SortIndex
        )
    )
    .OrderBy(x=>x.QuantityName)
    .ThenBy(x=>x.SortIndex)
    .ToList();

var unitsWithoutPrefixes = 
    (
        from baseUnit in siBaseUnits
        where !baseUnit.UsesPrefixes
        select new UnitDefinition
        (
            "SI",
            baseUnit.QuantityName,
            $"{baseUnit.UnitName}",
            $"{baseUnit.UnitSymbol}",
            baseUnit.BaseUnit,
            baseUnit.Coefficient,
            baseUnit.Offset,
            baseUnit.SortIndex+21
        )
    )
    .OrderBy(x=>x.QuantityName)
    .ThenBy(x=>x.Name)
    .ToList();

var allUnits = unitsWithPrefixes.Concat(unitsWithoutPrefixes)
    .OrderBy(x=>x.System)
    .ThenBy(x=>x.QuantityName)
    .ThenByDescending(x=>x.IsBaseUnit)
    .ThenBy(x=>x.SortIndex)
    .ThenBy(x=>x.Name)
    .ToList();

var previousTypeName = string.Empty;
foreach (var unit in allUnits)
{
    var typeName = MakeCodeName(unit.QuantityName);
    var unitType = MakeCodeName(unit.Name);
    EmitType(previousTypeName, typeName);
    EmitUnit(typeName, unitType, unit);
    previousTypeName = typeName;
}
EmitType(previousTypeName, string.Empty);

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

string MakeCodeName(string text) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Regex.Replace(text, @"\p{P}", " ")).Replace(" ","");

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

void EmitUnit(string typeName, string unitType, UnitDefinition unit)
{
    var template=unit.IsBaseUnit ? Templates.BaseUnitEntry : Templates.DerivedUnitEntry;
    var entry = template
        .Replace("$TypeName$", typeName)
        .Replace("$UnitType$", unitType)
        .Replace("$UnitName$", unit.Name)
        .Replace("$Symbol$", unit.Symbol)
        .Replace("$BaseUnit$", MakeCodeName(unit.BaseUnit))
        .Replace("$Coefficient$", unit.Coefficient)
        .Replace("$Offset$", unit.Offset);
    Console.WriteLine(entry);
}