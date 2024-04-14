#region

using UnitGen.Repositories;
using UnitGen.Services;

using FSS = UnitGen.Services.FileSystemService;

// ReSharper disable HeapView.ObjectAllocation

#endregion

if (EssentialDirectoriesAreMissing(out var jcdUnitsDir))
{
   return -1; // abort the app. We can't run.
}

var unitDefRepo = new UnitDefinitionRepository();

var sourceGen = new SourceCodeGenerator(unitDefRepo, jcdUnitsDir);

try
{
   sourceGen.CreateUnitTypeFiles();
   sourceGen.CreateUnitOfMeasureFiles();
}
catch (Exception ex)
{
   Console.Error.WriteLine($"Internal Error: {ex.Message}");
   
   return -1;
}

return 0;

bool EssentialDirectoriesAreMissing(out string jcdUnitsDirResult)
{
   var jcdUnitsDirTest = FSS.FindDirectory("Jcd.Units");
   
   if (jcdUnitsDirTest is not null)
   {
      jcdUnitsDirResult = jcdUnitsDirTest;
      
      return false;
   }
   
   if (jcdUnitsDirTest is null)
   {
      Console.Error.WriteLine("Directory: Jcd.Units could not be found.");
   }
   
   jcdUnitsDirResult = string.Empty; // this shuts the compiler up.
   
   Console.Error.WriteLine("Is unit-gen.exe in the correct directory (Any under the Jcd.Units solution directory)?");
   Console.Error.WriteLine("One or more essential directories could not be found.");
   Console.Error.WriteLine("ABORTING!");
   Console.WriteLine();
   Console.WriteLine("Press ANY KEY to continue.");
   Console.ReadKey();
   
   return true;
}