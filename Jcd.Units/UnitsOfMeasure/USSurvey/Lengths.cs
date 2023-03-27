﻿#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USSurvey;

/// <summary>
/// United States Survey Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// A(n) link. Defined as: (0.20116) × SI meter + (0).
   /// </summary>
   public static readonly Length Link = new ("link", "li", SI.Lengths.Meter, 0.20116, 0);

   /// <summary>
   /// A(n) rod. Defined as: (5.0292) × SI meter + (0).
   /// </summary>
   public static readonly Length Rod = new ("rod", "rd", SI.Lengths.Meter, 5.0292, 0);

   /// <summary>
   /// A(n) chain. Defined as: (20.1168) × SI meter + (0).
   /// </summary>
   public static readonly Length Chain = new ("chain", "ch", SI.Lengths.Meter, 20.1168, 0);

   /// <summary>
   /// A(n) furlong. Defined as: (201.168) × SI meter + (0).
   /// </summary>
   public static readonly Length Furlong = new ("furlong", "fur", SI.Lengths.Meter, 201.168, 0);

   /// <summary>
   /// A(n) league. Defined as: (4828.032) × SI meter + (0).
   /// </summary>
   public static readonly Length League = new ("league", "lea", SI.Lengths.Meter, 4828.032, 0);
}
