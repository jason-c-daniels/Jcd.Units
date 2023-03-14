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
public class Amounts : Enumeration<Amounts, Amount>
{
   /// <summary>
   /// A(n) count.
   /// </summary>
   public static readonly Amount Count = new ("count", "ct.");

   /// <summary>
   /// A(n) ten count. Defined in terms of a(n)  count.
   /// </summary>
   public static readonly Amount TenCount = new ("ten count", "ten ct.", Count, 10, 0);

   /// <summary>
   /// A(n) hundred count. Defined in terms of a(n) ten count.
   /// </summary>
   public static readonly Amount HundredCount = new ("hundred count", "hundred ct.", TenCount, 10, 0);

   /// <summary>
   /// A(n) thousand count. Defined in terms of a(n) hundred count.
   /// </summary>
   public static readonly Amount ThousandCount = new ("thousand count", "thousand ct.", HundredCount, 10, 0);

   /// <summary>
   /// A(n) million count. Defined in terms of a(n) thousand count.
   /// </summary>
   public static readonly Amount MillionCount = new ("million count", "million ct.", ThousandCount, 1000, 0);

   /// <summary>
   /// A(n) billion count. Defined in terms of a(n) million count.
   /// </summary>
   public static readonly Amount BillionCount = new ("billion count", "billion ct.", MillionCount, 1_000_000, 0);

   /// <summary>
   /// A(n) trillion count. Defined in terms of a(n) billion count.
   /// </summary>
   public static readonly Amount TrillionCount = new ("trillion count", "trillion ct.", BillionCount, 1_000_000, 0);

   /// <summary>
   /// A(n) quadrillion count. Defined in terms of a(n) trillion count.
   /// </summary>
   public static readonly Amount QuadrillionCount = new (
                                                         "quadrillion count"
                                                       , "quadrillion ct."
                                                       , TrillionCount
                                                       , 1_000_000
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) quintillion count. Defined in terms of a(n) quadrillion count.
   /// </summary>
   public static readonly Amount QuintillionCount = new (
                                                         "quintillion count"
                                                       , "quintillion ct."
                                                       , QuadrillionCount
                                                       , 1_000_000
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) sextillion count. Defined in terms of a(n) quintillion count.
   /// </summary>
   public static readonly Amount SextillionCount = new (
                                                        "sextillion count"
                                                      , "sextillion ct."
                                                      , QuintillionCount
                                                      , 1_000_000
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) septillion count. Defined in terms of a(n) sextillion count.
   /// </summary>
   public static readonly Amount SeptillionCount = new (
                                                        "septillion count"
                                                      , "septillion ct."
                                                      , SextillionCount
                                                      , 1_000_000
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) octillion count. Defined in terms of a(n) septillion count.
   /// </summary>
   public static readonly Amount OctillionCount = new (
                                                       "octillion count"
                                                     , "octillion ct."
                                                     , SeptillionCount
                                                     , 1_000_000
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) nonillion count. Defined in terms of a(n) octillion count.
   /// </summary>
   public static readonly Amount NonillionCount = new (
                                                       "nonillion count"
                                                     , "nonillion ct."
                                                     , OctillionCount
                                                     , 1_000_000
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) decillion count. Defined in terms of a(n) nonillion count.
   /// </summary>
   public static readonly Amount DecillionCount = new (
                                                       "decillion count"
                                                     , "decillion ct."
                                                     , NonillionCount
                                                     , 1_000_000
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) quantity. Defined in terms of a(n)  count.
   /// </summary>
   public static readonly Amount Quantity = new ("quantity", "qty.", UnitsOfMeasure.Amounts.Count, 1, 0);

   /// <summary>
   /// A(n) ten quantity. Defined in terms of a(n)  quantity.
   /// </summary>
   public static readonly Amount TenQuantity = new ("ten quantity", "ten qty.", Quantity, 10, 0);

   /// <summary>
   /// A(n) hundred quantity. Defined in terms of a(n) ten quantity.
   /// </summary>
   public static readonly Amount HundredQuantity = new ("hundred quantity", "hundred qty.", TenQuantity, 10, 0);

   /// <summary>
   /// A(n) thousand quantity. Defined in terms of a(n) hundred quantity.
   /// </summary>
   public static readonly Amount ThousandQuantity = new ("thousand quantity", "thousand qty.", HundredQuantity, 10, 0);

   /// <summary>
   /// A(n) million quantity. Defined in terms of a(n) thousand quantity.
   /// </summary>
   public static readonly Amount MillionQuantity = new ("million quantity", "million qty.", ThousandQuantity, 1000, 0);

   /// <summary>
   /// A(n) billion quantity. Defined in terms of a(n) million quantity.
   /// </summary>
   public static readonly Amount BillionQuantity = new (
                                                        "billion quantity"
                                                      , "billion qty."
                                                      , MillionQuantity
                                                      , 1_000_000
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) trillion quantity. Defined in terms of a(n) billion quantity.
   /// </summary>
   public static readonly Amount TrillionQuantity = new (
                                                         "trillion quantity"
                                                       , "trillion qty."
                                                       , BillionQuantity
                                                       , 1_000_000
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) quadrillion quantity. Defined in terms of a(n) trillion quantity.
   /// </summary>
   public static readonly Amount QuadrillionQuantity = new (
                                                            "quadrillion quantity"
                                                          , "quadrillion qty."
                                                          , TrillionQuantity
                                                          , 1_000_000
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quintillion quantity. Defined in terms of a(n) quadrillion quantity.
   /// </summary>
   public static readonly Amount QuintillionQuantity = new (
                                                            "quintillion quantity"
                                                          , "quintillion qty."
                                                          , QuadrillionQuantity
                                                          , 1_000_000
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) sextillion quantity. Defined in terms of a(n) quintillion quantity.
   /// </summary>
   public static readonly Amount SextillionQuantity = new (
                                                           "sextillion quantity"
                                                         , "sextillion qty."
                                                         , QuintillionQuantity
                                                         , 1_000_000
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) septillion quantity. Defined in terms of a(n) sextillion quantity.
   /// </summary>
   public static readonly Amount SeptillionQuantity = new (
                                                           "septillion quantity"
                                                         , "septillion qty."
                                                         , SextillionQuantity
                                                         , 1_000_000
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) octillion quantity. Defined in terms of a(n) septillion quantity.
   /// </summary>
   public static readonly Amount OctillionQuantity = new (
                                                          "octillion quantity"
                                                        , "octillion qty."
                                                        , SeptillionQuantity
                                                        , 1_000_000
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) nonillion quantity. Defined in terms of a(n) octillion quantity.
   /// </summary>
   public static readonly Amount NonillionQuantity = new (
                                                          "nonillion quantity"
                                                        , "nonillion qty."
                                                        , OctillionQuantity
                                                        , 1_000_000
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) decillion quantity. Defined in terms of a(n) nonillion quantity.
   /// </summary>
   public static readonly Amount DecillionQuantity = new (
                                                          "decillion quantity"
                                                        , "decillion qty."
                                                        , NonillionQuantity
                                                        , 1_000_000
                                                        , 0
                                                         );
}
