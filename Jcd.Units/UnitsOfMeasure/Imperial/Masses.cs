#region

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
   /// grain defined such that: SI milligram = gr × 64.79891.
   /// </summary>
   public static readonly Mass Grain = new ("grain", "gr", SI.Masses.Milligram, 64.79891, system: "Imperial");

   /// <summary>
   /// drachm defined such that: grain = dr × 2711.0/32.0.
   /// </summary>
   public static readonly Mass Drachm = new ("drachm", "dr", Grain, 2711.0 / 32.0, system: "Imperial");

   /// <summary>
   /// ounce defined such that: drachm = oz × 16.0.
   /// </summary>
   public static readonly Mass Ounce = new ("ounce", "oz", Drachm, 16.0, system: "Imperial");

   /// <summary>
   /// pound defined such that: ounce = lb × 16.0.
   /// </summary>
   public static readonly Mass Pound = new ("pound", "lb", Ounce, 16.0, system: "Imperial");

   /// <summary>
   /// stone defined such that: pound = st × 14.0.
   /// </summary>
   public static readonly Mass Stone = new ("stone", "st", Pound, 14.0, system: "Imperial");

   /// <summary>
   /// quarter defined such that: stone = qtr × 2.0.
   /// </summary>
   public static readonly Mass Quarter = new ("quarter", "qtr", Stone, 2.0, system: "Imperial");

   /// <summary>
   /// hundredweight defined such that: quarter = cwt × 4.0.
   /// </summary>
   public static readonly Mass Hundredweight = new ("hundredweight", "cwt", Quarter, 4.0, system: "Imperial");

   /// <summary>
   /// ton defined such that: hundredweight = t × 20.0.
   /// </summary>
   public static readonly Mass Ton = new ("ton", "t", Hundredweight, 20.0, system: "Imperial");
}
