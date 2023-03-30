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
/// British Imperial Units for measuring Amount.
/// </summary>
public class Amounts : UnitOfMeasureEnumeration<Amounts, Amount>
{
   /// <summary>
   /// count, a synonym for  count
   /// </summary>
   public static readonly Amount Count = new ("count", "ct.", UnitsOfMeasure.Amounts.Count);

   /// <summary>
   /// ten count, defined as:  count × 10.0
   /// </summary>
   public static readonly Amount TenCount = new ("ten count", "ten ct.", Count, 10.0);

   /// <summary>
   /// hundred count, defined as: ten count × 10.0
   /// </summary>
   public static readonly Amount HundredCount = new ("hundred count", "hundred ct.", TenCount, 10.0);

   /// <summary>
   /// thousand count, defined as: hundred count × 10.0
   /// </summary>
   public static readonly Amount ThousandCount = new ("thousand count", "thousand ct.", HundredCount, 10.0);

   /// <summary>
   /// million count, defined as: thousand count × 1000.0
   /// </summary>
   public static readonly Amount MillionCount = new ("million count", "million ct.", ThousandCount, 1000.0);

   /// <summary>
   /// billion count, defined as: million count × 1_000_000.0
   /// </summary>
   public static readonly Amount BillionCount = new ("billion count", "billion ct.", MillionCount, 1_000_000.0);

   /// <summary>
   /// trillion count, defined as: billion count × 1_000_000.0
   /// </summary>
   public static readonly Amount TrillionCount = new ("trillion count", "trillion ct.", BillionCount, 1_000_000.0);

   /// <summary>
   /// quadrillion count, defined as: trillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount QuadrillionCount = new (
                                                         "quadrillion count"
                                                       , "quadrillion ct."
                                                       , TrillionCount
                                                       , 1_000_000.0
                                                        );

   /// <summary>
   /// quintillion count, defined as: quadrillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount QuintillionCount = new (
                                                         "quintillion count"
                                                       , "quintillion ct."
                                                       , QuadrillionCount
                                                       , 1_000_000.0
                                                        );

   /// <summary>
   /// sextillion count, defined as: quintillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount SextillionCount = new (
                                                        "sextillion count"
                                                      , "sextillion ct."
                                                      , QuintillionCount
                                                      , 1_000_000.0
                                                       );

   /// <summary>
   /// septillion count, defined as: sextillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount SeptillionCount = new (
                                                        "septillion count"
                                                      , "septillion ct."
                                                      , SextillionCount
                                                      , 1_000_000.0
                                                       );

   /// <summary>
   /// octillion count, defined as: septillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount OctillionCount = new (
                                                       "octillion count"
                                                     , "octillion ct."
                                                     , SeptillionCount
                                                     , 1_000_000.0
                                                      );

   /// <summary>
   /// nonillion count, defined as: octillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount NonillionCount = new ("nonillion count", "nonillion ct.", OctillionCount, 1_000_000.0);

   /// <summary>
   /// decillion count, defined as: nonillion count × 1_000_000.0
   /// </summary>
   public static readonly Amount DecillionCount = new ("decillion count", "decillion ct.", NonillionCount, 1_000_000.0);

   /// <summary>
   /// quantity, a synonym for  count
   /// </summary>
   public static readonly Amount Quantity = new ("quantity", "qty.", UnitsOfMeasure.Amounts.Count);

   /// <summary>
   /// ten quantity, defined as:  quantity × 10.0
   /// </summary>
   public static readonly Amount TenQuantity = new ("ten quantity", "ten qty.", Quantity, 10.0);

   /// <summary>
   /// hundred quantity, defined as: ten quantity × 10.0
   /// </summary>
   public static readonly Amount HundredQuantity = new ("hundred quantity", "hundred qty.", TenQuantity, 10.0);

   /// <summary>
   /// thousand quantity, defined as: hundred quantity × 10.0
   /// </summary>
   public static readonly Amount ThousandQuantity = new ("thousand quantity", "thousand qty.", HundredQuantity, 10.0);

   /// <summary>
   /// million quantity, defined as: thousand quantity × 1000.0
   /// </summary>
   public static readonly Amount MillionQuantity = new ("million quantity", "million qty.", ThousandQuantity, 1000.0);

   /// <summary>
   /// billion quantity, defined as: million quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount BillionQuantity = new (
                                                        "billion quantity"
                                                      , "billion qty."
                                                      , MillionQuantity
                                                      , 1_000_000.0
                                                       );

   /// <summary>
   /// trillion quantity, defined as: billion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount TrillionQuantity = new (
                                                         "trillion quantity"
                                                       , "trillion qty."
                                                       , BillionQuantity
                                                       , 1_000_000.0
                                                        );

   /// <summary>
   /// quadrillion quantity, defined as: trillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount QuadrillionQuantity = new (
                                                            "quadrillion quantity"
                                                          , "quadrillion qty."
                                                          , TrillionQuantity
                                                          , 1_000_000.0
                                                           );

   /// <summary>
   /// quintillion quantity, defined as: quadrillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount QuintillionQuantity = new (
                                                            "quintillion quantity"
                                                          , "quintillion qty."
                                                          , QuadrillionQuantity
                                                          , 1_000_000.0
                                                           );

   /// <summary>
   /// sextillion quantity, defined as: quintillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount SextillionQuantity = new (
                                                           "sextillion quantity"
                                                         , "sextillion qty."
                                                         , QuintillionQuantity
                                                         , 1_000_000.0
                                                          );

   /// <summary>
   /// septillion quantity, defined as: sextillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount SeptillionQuantity = new (
                                                           "septillion quantity"
                                                         , "septillion qty."
                                                         , SextillionQuantity
                                                         , 1_000_000.0
                                                          );

   /// <summary>
   /// octillion quantity, defined as: septillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount OctillionQuantity = new (
                                                          "octillion quantity"
                                                        , "octillion qty."
                                                        , SeptillionQuantity
                                                        , 1_000_000.0
                                                         );

   /// <summary>
   /// nonillion quantity, defined as: octillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount NonillionQuantity = new (
                                                          "nonillion quantity"
                                                        , "nonillion qty."
                                                        , OctillionQuantity
                                                        , 1_000_000.0
                                                         );

   /// <summary>
   /// decillion quantity, defined as: nonillion quantity × 1_000_000.0
   /// </summary>
   public static readonly Amount DecillionQuantity = new (
                                                          "decillion quantity"
                                                        , "decillion qty."
                                                        , NonillionQuantity
                                                        , 1_000_000.0
                                                         );
}
