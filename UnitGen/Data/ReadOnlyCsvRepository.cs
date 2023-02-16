using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using UnitGen.Resources;

namespace UnitGen.Data;

public abstract class ReadOnlyCsvRepository<T> : IReadOnlyRepository<T>
{
    public abstract IList<T> GetAll();

    protected IList<T> ReadFromFile(string pathToFile)
    {
        using var reader = new StreamReader(pathToFile);
        return ReadFrom(reader);
    }
    
    protected IList<T> ReadFromEmbeddedResource(string resourceName)
    {
        using var stream = EmbeddedResource.GetStream(resourceName);
        using var reader = new StreamReader(stream);
        return ReadFrom(reader);
    }

    private static IList<T> ReadFrom(TextReader reader)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.Replace(" ", ""),
            HasHeaderRecord = true
        };
        using var csv = new CsvReader(reader, config);
        return csv.GetRecords<T>().ToList();
    }
}