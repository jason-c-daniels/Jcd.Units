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
   /// A(n) grain. Defined in terms of a(n) SI milligram.
   /// </summary>
   public static readonly Mass Grain = new ("grain", "gr", SI.Masses.Milligram, 64.79891, 0);

   /// <summary>
   /// A(n) dram. Defined in terms of a(n) grain.
   /// </summary>
   public static readonly Mass Dram = new ("dram", "dr", Grain, 27.34375, 0);

   /// <summary>
   /// A(n) ounce. Defined in terms of a(n) dram.
   /// </summary>
   public static readonly Mass Ounce = new ("ounce", "oz", Dram, 16.0, 0);

   /// <summary>
   /// A(n) pound. Defined in terms of a(n) ounce.
   /// </summary>
   public static readonly Mass Pound = new ("pound", "lb", Ounce, 16.0, 0);

   /// <summary>
   /// A(n) hundredweight. Defined in terms of a(n) pound.
   /// </summary>
   public static readonly Mass Hundredweight = new ("hundredweight", "cwt", Pound, 100.0, 0);

   /// <summary>
   /// A(n) long hundredweight. Defined in terms of a(n) pound.
   /// </summary>
   public static readonly Mass LongHundredweight = new ("long hundredweight", "long cwt", Pound, 112.0, 0);

   /// <summary>
   /// A(n) short ton. Defined in terms of a(n) hundredweight.
   /// </summary>
   public static readonly Mass ShortTon = new ("short ton", "short ton", Hundredweight, 20.0, 0);

   /// <summary>
   /// A(n) ton. Defined in terms of a(n) short ton.
   /// </summary>
   public static readonly Mass Ton = new ("ton", "t", ShortTon, 1, 0);

   /// <summary>
   /// A(n) long ton. Defined in terms of a(n) long hundredweight.
   /// </summary>
   public static readonly Mass LongTon = new ("long ton", "long ton", LongHundredweight, 20.0, 0);
}
