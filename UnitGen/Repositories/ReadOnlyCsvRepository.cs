#region

using System.Globalization;

using CsvHelper;
using CsvHelper.Configuration;

using UnitGen.Resources;

#endregion

namespace UnitGen.Repositories;

public abstract class ReadOnlyCsvRepository<T> : IReadOnlyRepository<T>
{
   // ReSharper disable once NotAccessedField.Local
   private IReadOnlyList<T>? _allItems;

   public virtual IReadOnlyList<T> GetAll()
   {
      if (_allItems == null) return _allItems = ReadAll();

      return _allItems;
   }

   protected abstract IReadOnlyList<T> ReadAll();

   // ReSharper disable once UnusedMember.Global
   protected IReadOnlyList<T> ReadFromFile(string pathToFile)
   {
      using var reader = new StreamReader(pathToFile);

      return ReadFrom(reader);
   }

   protected IReadOnlyList<T> ReadFromEmbeddedResource(string resourceName)
   {
      using var stream = EmbeddedResource.GetStream(resourceName);
      using var reader = new StreamReader(stream!);

      return ReadFrom(reader);
   }

   private static IReadOnlyList<T> ReadFrom(TextReader reader)
   {
      var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                   {
                            PrepareHeaderForMatch = args => args.Header.Replace(" ", ""), HasHeaderRecord = true
                   };

      using var csv = new CsvReader(reader, config);

      return csv.GetRecords<T>()
                .ToList();
   }
}
