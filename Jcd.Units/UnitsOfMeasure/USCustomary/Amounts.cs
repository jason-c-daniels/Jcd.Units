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
/// United States Customary Units for measuring Amount.
/// </summary>
public class Amounts : UnitOfMeasureEnumeration<Amounts, Amount>
{
   /// <summary>
   /// A(n) count. Defined as: (1.0) ×  count + (0).
   /// </summary>
   public static readonly Amount Count = new ("count", "ct.", UnitsOfMeasure.Amounts.Count, 1.0, 0);

   /// <summary>
   /// A(n) ten count. Defined as: (10.0) ×  count + (0).
   /// </summary>
   public static readonly Amount TenCount = new ("ten count", "ten ct.", Count, 10.0, 0);

   /// <summary>
   /// A(n) hundred count. Defined as: (10.0) × ten count + (0).
   /// </summary>
   public static readonly Amount HundredCount = new ("hundred count", "hundred ct.", TenCount, 10.0, 0);

   /// <summary>
   /// A(n) thousand count. Defined as: (10.0) × hundred count + (0).
   /// </summary>
   public static readonly Amount ThousandCount = new ("thousand count", "thousand ct.", HundredCount, 10.0, 0);

   /// <summary>
   /// A(n) million count. Defined as: (1000.0) × thousand count + (0).
   /// </summary>
   public static readonly Amount MillionCount = new ("million count", "million ct.", ThousandCount, 1000.0, 0);

   /// <summary>
   /// A(n) billion count. Defined as: (1000.0) × million count + (0).
   /// </summary>
   public static readonly Amount BillionCount = new ("billion count", "billion ct.", MillionCount, 1000.0, 0);

   /// <summary>
   /// A(n) trillion count. Defined as: (1000.0) × billion count + (0).
   /// </summary>
   public static readonly Amount TrillionCount = new ("trillion count", "trillion ct.", BillionCount, 1000.0, 0);

   /// <summary>
   /// A(n) quadrillion count. Defined as: (1000.0) × trillion count + (0).
   /// </summary>
   public static readonly Amount QuadrillionCount = new (
                                                         "quadrillion count"
                                                       , "quadrillion ct."
                                                       , TrillionCount
                                                       , 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) quintillion count. Defined as: (1000.0) × quadrillion count + (0).
   /// </summary>
   public static readonly Amount QuintillionCount = new (
                                                         "quintillion count"
                                                       , "quintillion ct."
                                                       , QuadrillionCount
                                                       , 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) sextillion count. Defined as: (1000.0) × quintillion count + (0).
   /// </summary>
   public static readonly Amount SextillionCount = new (
                                                        "sextillion count"
                                                      , "sextillion ct."
                                                      , QuintillionCount
                                                      , 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) septillion count. Defined as: (1000.0) × sextillion count + (0).
   /// </summary>
   public static readonly Amount SeptillionCount = new (
                                                        "septillion count"
                                                      , "septillion ct."
                                                      , SextillionCount
                                                      , 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) octillion count. Defined as: (1000.0) × septillion count + (0).
   /// </summary>
   public static readonly Amount OctillionCount = new ("octillion count", "octillion ct.", SeptillionCount, 1000.0, 0);

   /// <summary>
   /// A(n) nonillion count. Defined as: (1000.0) × octillion count + (0).
   /// </summary>
   public static readonly Amount NonillionCount = new ("nonillion count", "nonillion ct.", OctillionCount, 1000.0, 0);

   /// <summary>
   /// A(n) decillion count. Defined as: (1000.0) × nonillion count + (0).
   /// </summary>
   public static readonly Amount DecillionCount = new ("decillion count", "decillion ct.", NonillionCount, 1000.0, 0);

   /// <summary>
   /// A(n) quantity. Defined as: (1.0) ×  count + (0).
   /// </summary>
   public static readonly Amount Quantity = new ("quantity", "qty.", UnitsOfMeasure.Amounts.Count, 1.0, 0);

   /// <summary>
   /// A(n) ten quantity. Defined as: (10.0) ×  quantity + (0).
   /// </summary>
   public static readonly Amount TenQuantity = new ("ten quantity", "ten qty.", Quantity, 10.0, 0);

   /// <summary>
   /// A(n) hundred quantity. Defined as: (10.0) × ten quantity + (0).
   /// </summary>
   public static readonly Amount HundredQuantity = new ("hundred quantity", "hundred qty.", TenQuantity, 10.0, 0);

   /// <summary>
   /// A(n) thousand quantity. Defined as: (10.0) × hundred quantity + (0).
   /// </summary>
   public static readonly Amount ThousandQuantity = new (
                                                         "thousand quantity"
                                                       , "thousand qty."
                                                       , HundredQuantity
                                                       , 10.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) million quantity. Defined as: (1000.0) × thousand quantity + (0).
   /// </summary>
   public static readonly Amount MillionQuantity = new (
                                                        "million quantity"
                                                      , "million qty."
                                                      , ThousandQuantity
                                                      , 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) billion quantity. Defined as: (1000.0) × million quantity + (0).
   /// </summary>
   public static readonly Amount BillionQuantity = new ("billion quantity", "billion qty.", MillionQuantity, 1000.0, 0);

   /// <summary>
   /// A(n) trillion quantity. Defined as: (1000.0) × billion quantity + (0).
   /// </summary>
   public static readonly Amount TrillionQuantity = new (
                                                         "trillion quantity"
                                                       , "trillion qty."
                                                       , BillionQuantity
                                                       , 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) quadrillion quantity. Defined as: (1000.0) × trillion quantity + (0).
   /// </summary>
   public static readonly Amount QuadrillionQuantity = new (
                                                            "quadrillion quantity"
                                                          , "quadrillion qty."
                                                          , TrillionQuantity
                                                          , 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quintillion quantity. Defined as: (1000.0) × quadrillion quantity + (0).
   /// </summary>
   public static readonly Amount QuintillionQuantity = new (
                                                            "quintillion quantity"
                                                          , "quintillion qty."
                                                          , QuadrillionQuantity
                                                          , 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) sextillion quantity. Defined as: (1000.0) × quintillion quantity + (0).
   /// </summary>
   public static readonly Amount SextillionQuantity = new (
                                                           "sextillion quantity"
                                                         , "sextillion qty."
                                                         , QuintillionQuantity
                                                         , 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) septillion quantity. Defined as: (1000.0) × sextillion quantity + (0).
   /// </summary>
   public static readonly Amount SeptillionQuantity = new (
                                                           "septillion quantity"
                                                         , "septillion qty."
                                                         , SextillionQuantity
                                                         , 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) octillion quantity. Defined as: (1000.0) × septillion quantity + (0).
   /// </summary>
   public static readonly Amount OctillionQuantity = new (
                                                          "octillion quantity"
                                                        , "octillion qty."
                                                        , SeptillionQuantity
                                                        , 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) nonillion quantity. Defined as: (1000.0) × octillion quantity + (0).
   /// </summary>
   public static readonly Amount NonillionQuantity = new (
                                                          "nonillion quantity"
                                                        , "nonillion qty."
                                                        , OctillionQuantity
                                                        , 1000.0
                                                        , 0
                                                         );

   /// <summary>
   /// A(n) decillion quantity. Defined as: (1000.0) × nonillion quantity + (0).
   /// </summary>
   public static readonly Amount DecillionQuantity = new (
                                                          "decillion quantity"
                                                        , "decillion qty."
                                                        , NonillionQuantity
                                                        , 1000.0
                                                        , 0
                                                         );
}
