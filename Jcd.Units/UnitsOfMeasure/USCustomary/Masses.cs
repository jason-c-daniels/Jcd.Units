﻿#region

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
   /// grain, defined as: SI milligram × 64.79891
   /// </summary>
   public static readonly Mass Grain = new ("grain", "gr", SI.Masses.Milligram, 64.79891);

   /// <summary>
   /// dram, defined as: grain × 27.34375
   /// </summary>
   public static readonly Mass Dram = new ("dram", "dr", Grain, 27.34375);

   /// <summary>
   /// ounce, defined as: dram × 16.0
   /// </summary>
   public static readonly Mass Ounce = new ("ounce", "oz", Dram, 16.0);

   /// <summary>
   /// pound, defined as: ounce × 16.0
   /// </summary>
   public static readonly Mass Pound = new ("pound", "lb", Ounce, 16.0);

   /// <summary>
   /// hundredweight, defined as: pound × 100.0
   /// </summary>
   public static readonly Mass Hundredweight = new ("hundredweight", "cwt", Pound, 100.0);

   /// <summary>
   /// long hundredweight, defined as: pound × 112.0
   /// </summary>
   public static readonly Mass LongHundredweight = new ("long hundredweight", "long cwt", Pound, 112.0);

   /// <summary>
   /// short ton, defined as: hundredweight × 20.0
   /// </summary>
   public static readonly Mass ShortTon = new ("short ton", "short ton", Hundredweight, 20.0);

   /// <summary>
   /// ton, a synonym for short ton
   /// </summary>
   public static readonly Mass Ton = new ("ton", "t", ShortTon);

   /// <summary>
   /// long ton, defined as: long hundredweight × 20.0
   /// </summary>
   public static readonly Mass LongTon = new ("long ton", "long ton", LongHundredweight, 20.0);
}
