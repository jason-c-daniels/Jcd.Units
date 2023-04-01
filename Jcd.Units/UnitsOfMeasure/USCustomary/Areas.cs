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
   /// square inch defined such that: SI square centimeter = in² × (2.54)*(2.54).
   /// </summary>
   public static readonly Area SquareInch = new (
                                                 "square inch"
                                               , "in²"
                                               , SI.Areas.SquareCentimeter
                                               , 2.54 * 2.54
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square mil defined such that: square inch = mil² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareMil = new (
                                                "square mil"
                                              , "mil²"
                                              , SquareInch
                                              , 1.0 / 1000.0 * (1.0 / 1000.0)
                                              , system: "US Customary"
                                               );

   /// <summary>
   /// square point defined such that: square inch = p² × (1.0/72.0)*(1.0/72.0).
   /// </summary>
   public static readonly Area SquarePoint = new (
                                                  "square point"
                                                , "p²"
                                                , SquareInch
                                                , 1.0 / 72.0 * (1.0 / 72.0)
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// square twip defined such that: square point = twip² × (1.0/20.0)*(1.0/20.0).
   /// </summary>
   public static readonly Area SquareTwip = new (
                                                 "square twip"
                                               , "twip²"
                                               , SquarePoint
                                               , 1.0 / 20.0 * (1.0 / 20.0)
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square pica defined such that: square point = P² × (12.0)*(12.0).
   /// </summary>
   public static readonly Area SquarePica = new ("square pica", "P²", SquarePoint, 12.0 * 12.0, system: "US Customary");

   /// <summary>
   /// square foot defined such that: square inch = ft² × (12.0)*(12.0).
   /// </summary>
   public static readonly Area SquareFoot = new ("square foot", "ft²", SquareInch, 12.0 * 12.0, system: "US Customary");

   /// <summary>
   /// square yard defined such that: square foot = yd² × (3.0)*(3.0).
   /// </summary>
   public static readonly Area SquareYard = new ("square yard", "yd²", SquareFoot, 3.0 * 3.0, system: "US Customary");

   /// <summary>
   /// square mile defined such that: square yard = mi² × (1760.0)*(1760.0).
   /// </summary>
   public static readonly Area SquareMile = new (
                                                 "square mile"
                                               , "mi²"
                                               , SquareYard
                                               , 1760.0 * 1760.0
                                               , system: "US Customary"
                                                );

   /// <summary>
   /// square league defined such that: square mile = le² × (3.0)*(3.0).
   /// </summary>
   public static readonly Area SquareLeague = new (
                                                   "square league"
                                                 , "le²"
                                                 , SquareMile
                                                 , 3.0 * 3.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// square fathom defined such that: square yard = ftm² × (2.0)*(2.0).
   /// </summary>
   public static readonly Area SquareFathom = new (
                                                   "square fathom"
                                                 , "ftm²"
                                                 , SquareYard
                                                 , 2.0 * 2.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// square cable defined such that: square fathom = cb² × (120.0)*(120.0).
   /// </summary>
   public static readonly Area SquareCable = new (
                                                  "square cable"
                                                , "cb²"
                                                , SquareFathom
                                                , 120.0 * 120.0
                                                , system: "US Customary"
                                                 );

   /// <summary>
   /// square nautical mile defined such that: SI square meter = nmi² × (1852.0)*(1852.0).
   /// </summary>
   public static readonly Area SquareNauticalMile = new (
                                                         "square nautical mile"
                                                       , "nmi²"
                                                       , SI.Areas.SquareMeter
                                                       , 1852.0 * 1852.0
                                                       , system: "US Customary"
                                                        );
}
