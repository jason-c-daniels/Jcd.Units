#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Mass.
/// </summary>
public class Masses : UnitOfMeasureEnumeration<Masses, Mass>
{
   /// <summary>
   /// grain defined such that: SI milligram = gr × 64.79891.
   /// </summary>
   public static readonly Mass Grain = new("grain", "gr", SI.Masses.Milligram, 64.79891, system: "US Customary");
   
   /// <summary>
   /// dram defined such that: grain = dr × 27.34375.
   /// </summary>
   public static readonly Mass Dram = new("dram", "dr", Grain, 27.34375, system: "US Customary");
   
   /// <summary>
   /// ounce defined such that: dram = oz × 16.0.
   /// </summary>
   public static readonly Mass Ounce = new("ounce", "oz", Dram, 16.0, system: "US Customary");
   
   /// <summary>
   /// pound defined such that: ounce = lb × 16.0.
   /// </summary>
   public static readonly Mass Pound = new("pound", "lb", Ounce, 16.0, system: "US Customary");
   
   /// <summary>
   /// hundredweight defined such that: pound = cwt × 100.0.
   /// </summary>
   public static readonly Mass Hundredweight = new("hundredweight", "cwt", Pound, 100.0, system: "US Customary");
   
   /// <summary>
   /// long hundredweight defined such that: pound = long cwt × 112.0.
   /// </summary>
   public static readonly Mass LongHundredweight = new("long hundredweight", "long cwt", Pound, 112.0, system: "US Customary");
   
   /// <summary>
   /// short ton defined such that: hundredweight = short ton × 20.0.
   /// </summary>
   public static readonly Mass ShortTon = new("short ton", "short ton", Hundredweight, 20.0, system: "US Customary");
   
   /// <summary>
   /// ton is a synonym for short ton
   /// </summary>
   public static readonly Mass Ton = new("ton", "t", ShortTon, system: "US Customary");
   
   /// <summary>
   /// long ton defined such that: long hundredweight = long ton × 20.0.
   /// </summary>
   public static readonly Mass LongTon = new("long ton", "long ton", LongHundredweight, 20.0, system: "US Customary");
}