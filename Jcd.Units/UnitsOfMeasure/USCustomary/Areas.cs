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
/// United States Customary Units for measuring Area.
/// </summary>
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// square inch, defined as: SI square centimeter × (2.54)*(2.54)
   /// </summary>
   public static readonly Area SquareInch = new (
                                                 "square inch"
                                               , "in²"
                                               , SI.Areas.SquareCentimeter
                                               , 2.54 * 2.54
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square mil, defined as: square inch × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareMil = new (
                                                "square mil"
                                              , "mil²"
                                              , SquareInch
                                              , 1.0 / 1000.0 * (1.0 / 1000.0)
                                              , system: "US Customary"
                                               );

   /// <summary>
   /// square point, defined as: square inch × (1.0/72.0)*(1.0/72.0)
   /// </summary>
   public static readonly Area SquarePoint = new (
                                                  "square point"
                                                , "p²"
                                                , SquareInch
                                                , 1.0 / 72.0 * (1.0 / 72.0)
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// square twip, defined as: square point × (1.0/20.0)*(1.0/20.0)
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip²"
                                               , SquarePoint
                                               , 1.0 / 20.0 * (1.0 / 20.0)
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square pica, defined as: square point × (12.0)*(12.0)
   /// </summary>
   public static readonly Area SquarePica = new ("square pica", "P²", SquarePoint, 12.0 * 12.0, system: "US Customary");

   /// <summary>
   /// square foot, defined as: square inch × (12.0)*(12.0)
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft²", SquareInch, 12.0 * 12.0, system: "US Customary");

   /// <summary>
   /// square yard, defined as: square foot × (3.0)*(3.0)
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, system: "US Customary");

   /// <summary>
   /// square mile, defined as: square yard × (1760.0)*(1760.0)
   /// </summary>
   public static readonly Area SquareMile = new (
                                                 "square mile"
                                               , "mi²"
                                               , SquareYard
                                               , 1760.0 * 1760.0
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square league, defined as: square mile × (3.0)*(3.0)
   /// </summary>
   public static readonly Area SquareLeague = new (
                                                   "square league"
                                                 , "le²"
                                                 , SquareMile
                                                 , 3.0 * 3.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// square fathom, defined as: square yard × (2.0)*(2.0)
   /// </summary>
   public static readonly Area SquareFathom = new (
                                                   "square fathom"
                                                 , "ftm²"
                                                 , SquareYard
                                                 , 2.0 * 2.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// square cable, defined as: square fathom × (120.0)*(120.0)
   /// </summary>
   public static readonly Area SquareCable = new (
                                                  "square cable"
                                                , "cb²"
                                                , SquareFathom
                                                , 120.0 * 120.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// square nautical mile, defined as: SI square meter × (1852.0)*(1852.0)
   /// </summary>
   public static readonly Area SquareNauticalMile = new (
                                                         "square nautical mile"
                                                       , "nmi²"
                                                       , SI.Areas.SquareMeter
                                                       , 1852.0 * 1852.0
                                                       , system: "US Customary"
                                                        );
}
