#region

using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.Units.Tests;

public class UnitRegistryTests
{
   [Fact]
   public void AutoRegisterAllUnits_Registers_All_Units()
   {
      var tempsRegistry = UnitRegistry<Temperature>.Default;
      var lengthsRegistry = UnitRegistry<Temperature>.Default;
      UnitRegistry.Default.AutoregisterAllUnits();
      Assert.True(tempsRegistry.All.Count   > 0);
      Assert.True(lengthsRegistry.All.Count > 0);
      Assert.Single(tempsRegistry.NameLookup["degrees celsius"]);
      Assert.Single(tempsRegistry.SymbolLookup["°C"]);
      Assert.Single(UnitRegistry.Default.GetNameLookup<Temperature>()["degrees celsius"]);
      Assert.Single(UnitRegistry.Default.GetSymbolLookup<Temperature>()["°C"]);
   }
}