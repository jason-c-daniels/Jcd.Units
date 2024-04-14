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
   /// count is a synonym for  count
   /// </summary>
   public static readonly Amount Count = new("count", "ct.", UnitsOfMeasure.Amounts.Count, system: "US Customary");

   /// <summary>
   /// ten count defined such that:  count = ten ct. × 10.0.
   /// </summary>
   public static readonly Amount TenCount = new("ten count", "ten ct.", Count, 10.0, system: "US Customary");

   /// <summary>
   /// hundred count defined such that: ten count = hundred ct. × 10.0.
   /// </summary>
   public static readonly Amount HundredCount = new("hundred count", "hundred ct.", TenCount, 10.0, system: "US Customary");

   /// <summary>
   /// thousand count defined such that: hundred count = thousand ct. × 10.0.
   /// </summary>
   public static readonly Amount ThousandCount = new("thousand count", "thousand ct.", HundredCount, 10.0, system: "US Customary");

   /// <summary>
   /// million count defined such that: thousand count = million ct. × 1000.0.
   /// </summary>
   public static readonly Amount MillionCount = new("million count", "million ct.", ThousandCount, 1000.0, system: "US Customary");

   /// <summary>
   /// billion count defined such that: million count = billion ct. × 1000.0.
   /// </summary>
   public static readonly Amount BillionCount = new("billion count", "billion ct.", MillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// trillion count defined such that: billion count = trillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount TrillionCount = new("trillion count", "trillion ct.", BillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// quadrillion count defined such that: trillion count = quadrillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount QuadrillionCount = new("quadrillion count", "quadrillion ct.", TrillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// quintillion count defined such that: quadrillion count = quintillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount QuintillionCount = new("quintillion count", "quintillion ct.", QuadrillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// sextillion count defined such that: quintillion count = sextillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount SextillionCount = new("sextillion count", "sextillion ct.", QuintillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// septillion count defined such that: sextillion count = septillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount SeptillionCount = new("septillion count", "septillion ct.", SextillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// octillion count defined such that: septillion count = octillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount OctillionCount = new("octillion count", "octillion ct.", SeptillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// nonillion count defined such that: octillion count = nonillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount NonillionCount = new("nonillion count", "nonillion ct.", OctillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// decillion count defined such that: nonillion count = decillion ct. × 1000.0.
   /// </summary>
   public static readonly Amount DecillionCount = new("decillion count", "decillion ct.", NonillionCount, 1000.0, system: "US Customary");

   /// <summary>
   /// quantity is a synonym for  count
   /// </summary>
   public static readonly Amount Quantity = new("quantity", "qty.", UnitsOfMeasure.Amounts.Count, system: "US Customary");

   /// <summary>
   /// ten quantity defined such that:  quantity = ten qty. × 10.0.
   /// </summary>
   public static readonly Amount TenQuantity = new("ten quantity", "ten qty.", Quantity, 10.0, system: "US Customary");

   /// <summary>
   /// hundred quantity defined such that: ten quantity = hundred qty. × 10.0.
   /// </summary>
   public static readonly Amount HundredQuantity = new("hundred quantity", "hundred qty.", TenQuantity, 10.0, system: "US Customary");

   /// <summary>
   /// thousand quantity defined such that: hundred quantity = thousand qty. × 10.0.
   /// </summary>
   public static readonly Amount ThousandQuantity = new("thousand quantity", "thousand qty.", HundredQuantity, 10.0, system: "US Customary");

   /// <summary>
   /// million quantity defined such that: thousand quantity = million qty. × 1000.0.
   /// </summary>
   public static readonly Amount MillionQuantity = new("million quantity", "million qty.", ThousandQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// billion quantity defined such that: million quantity = billion qty. × 1000.0.
   /// </summary>
   public static readonly Amount BillionQuantity = new("billion quantity", "billion qty.", MillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// trillion quantity defined such that: billion quantity = trillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount TrillionQuantity = new("trillion quantity", "trillion qty.", BillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// quadrillion quantity defined such that: trillion quantity = quadrillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount QuadrillionQuantity = new("quadrillion quantity", "quadrillion qty.", TrillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// quintillion quantity defined such that: quadrillion quantity = quintillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount QuintillionQuantity = new("quintillion quantity", "quintillion qty.", QuadrillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// sextillion quantity defined such that: quintillion quantity = sextillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount SextillionQuantity = new("sextillion quantity", "sextillion qty.", QuintillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// septillion quantity defined such that: sextillion quantity = septillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount SeptillionQuantity = new("septillion quantity", "septillion qty.", SextillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// octillion quantity defined such that: septillion quantity = octillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount OctillionQuantity = new("octillion quantity", "octillion qty.", SeptillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// nonillion quantity defined such that: octillion quantity = nonillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount NonillionQuantity = new("nonillion quantity", "nonillion qty.", OctillionQuantity, 1000.0, system: "US Customary");

   /// <summary>
   /// decillion quantity defined such that: nonillion quantity = decillion qty. × 1000.0.
   /// </summary>
   public static readonly Amount DecillionQuantity = new("decillion quantity", "decillion qty.", NonillionQuantity, 1000.0, system: "US Customary");
}