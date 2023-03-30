﻿#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Imperial;

/// <summary>
/// British Imperial Units for measuring Mass.
/// </summary>
public class Masses : UnitOfMeasureEnumeration<Masses, Mass>
{
   /// <summary>
   /// grain, defined as: SI milligram × 64.79891
   /// </summary>
   public static readonly Mass Grain = new ("grain", "gr", SI.Masses.Milligram, 64.79891);

   /// <summary>
   /// drachm, defined as: SI gram × 1.7718451953125
   /// </summary>
   public static readonly Mass Drachm = new ("drachm", "dr", SI.Masses.Gram, 1.7718451953125);

   /// <summary>
   /// ounce, defined as: drachm × 16.0
   /// </summary>
   public static readonly Mass Ounce = new ("ounce", "oz", Drachm, 16.0);

   /// <summary>
   /// pound, defined as: ounce × 16.0
   /// </summary>
   public static readonly Mass Pound = new ("pound", "lb", Ounce, 16.0);

   /// <summary>
   /// stone, defined as: pound × 14.0
   /// </summary>
   public static readonly Mass Stone = new ("stone", "st", Pound, 14.0);

   /// <summary>
   /// quarter, defined as: stone × 2.0
   /// </summary>
   public static readonly Mass Quarter = new ("quarter", "qtr", Stone, 2.0);

   /// <summary>
   /// hundredweight, defined as: quarter × 4.0
   /// </summary>
   public static readonly Mass Hundredweight = new ("hundredweight", "cwt", Quarter, 4.0);

   /// <summary>
   /// ton, defined as: hundredweight × 20.0
   /// </summary>
   public static readonly Mass Ton = new ("ton", "t", Hundredweight, 20.0);
}
