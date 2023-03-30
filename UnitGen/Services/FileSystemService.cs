#region

using System.Reflection;
using System.Text;

// ReSharper disable HeapView.ObjectAllocation

#endregion

namespace UnitGen.Services;

public static class FileSystemService
{
   public static void WriteFileContent(string filePath, string fileContent)
   {
      Console.Write($"Generating: {filePath}. ");

      if (File.Exists(filePath))
         Console.Write("File already exists, overwriting.");

      Console.WriteLine();

#if WRITE_TO_CONSOLE
      Console.WriteLine(fileContent);
#else
      File.WriteAllText(filePath, fileContent, Encoding.UTF8);
#endif
   }

   public static void CreateDirectoryIfNeeded(string targetDir)
   {
      if (Directory.Exists(targetDir)) return;

      Console.WriteLine($"Creating {targetDir}.");
      Directory.CreateDirectory(targetDir);
   }

   public static string? FindDirectory(string targetDir)
   {
      var startupDir = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
      var testDir    = startupDir;

      while (testDir is not null && !Directory.Exists(Path.Combine(testDir, targetDir)))
         testDir = Path.GetDirectoryName(testDir);

      if (testDir is null) Console.Error.WriteLine($"Could not locate {targetDir} folder.");

      return testDir is not null ? Path.Combine(testDir, targetDir) : null;
   }
}
