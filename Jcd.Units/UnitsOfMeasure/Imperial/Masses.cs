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
   /// A(n) grain. Defined as: 64.79891 × SI milligram.
   /// </summary>
   public static readonly Mass Grain = new ("grain", "gr", SI.Masses.Milligram, 64.79891, 0);

   /// <summary>
   /// A(n) drachm. Defined as: 1.7718451953125 × SI gram.
   /// </summary>
   public static readonly Mass Drachm = new ("drachm", "dr", SI.Masses.Gram, 1.7718451953125, 0);

   /// <summary>
   /// A(n) ounce. Defined as: 16.0 × drachm.
   /// </summary>
   public static readonly Mass Ounce = new ("ounce", "oz", Drachm, 16.0, 0);

   /// <summary>
   /// A(n) pound. Defined as: 16.0 × ounce.
   /// </summary>
   public static readonly Mass Pound = new ("pound", "lb", Ounce, 16.0, 0);

   /// <summary>
   /// A(n) stone. Defined as: 14.0 × pound.
   /// </summary>
   public static readonly Mass Stone = new ("stone", "st", Pound, 14.0, 0);

   /// <summary>
   /// A(n) quarter. Defined as: 2.0 × stone.
   /// </summary>
   public static readonly Mass Quarter = new ("quarter", "qtr", Stone, 2.0, 0);

   /// <summary>
   /// A(n) hundredweight. Defined as: 4.0 × quarter.
   /// </summary>
   public static readonly Mass Hundredweight = new ("hundredweight", "cwt", Quarter, 4.0, 0);

   /// <summary>
   /// A(n) ton. Defined as: 20.0 × hundredweight.
   /// </summary>
   public static readonly Mass Ton = new ("ton", "t", Hundredweight, 20.0, 0);
}
