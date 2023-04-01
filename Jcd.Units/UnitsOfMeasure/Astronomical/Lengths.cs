#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Astronomical;

/// <summary>
/// Astronomical Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// light-year, defined as: SI meter × 9_460_730_472_580_800.0
   /// </summary>
   public static readonly Length LightYear = new ("light-year", "ly", SI.Lengths.Meter, 9_460_730_472_580_800.0);

   /// <summary>
   /// dekalight-year, defined as: light-year × 10.0
   /// </summary>
   public static readonly Length DekalightYear = new ("dekalight-year", "daly", LightYear, 10.0);

   /// <summary>
   /// hectolight-year, defined as: dekalight-year × 10.0
   /// </summary>
   public static readonly Length HectolightYear = new ("hectolight-year", "hly", DekalightYear, 10.0);

   /// <summary>
   /// kilolight-year, defined as: hectolight-year × 10.0
   /// </summary>
   public static readonly Length KilolightYear = new ("kilolight-year", "kly", HectolightYear, 10.0);

   /// <summary>
   /// megalight-year, defined as: kilolight-year × 1000.0
   /// </summary>
   public static readonly Length MegalightYear = new ("megalight-year", "Mly", KilolightYear, 1000.0);

   /// <summary>
   /// gigalight-year, defined as: megalight-year × 1000.0
   /// </summary>
   public static readonly Length GigalightYear = new ("gigalight-year", "Gly", MegalightYear, 1000.0);

   /// <summary>
   /// teralight-year, defined as: gigalight-year × 1000.0
   /// </summary>
   public static readonly Length TeralightYear = new ("teralight-year", "Tly", GigalightYear, 1000.0);

   /// <summary>
   /// petalight-year, defined as: teralight-year × 1000.0
   /// </summary>
   public static readonly Length PetalightYear = new ("petalight-year", "Ply", TeralightYear, 1000.0);

   /// <summary>
   /// exalight-year, defined as: petalight-year × 1000.0
   /// </summary>
   public static readonly Length ExalightYear = new ("exalight-year", "Ely", PetalightYear, 1000.0);

   /// <summary>
   /// zettalight-year, defined as: exalight-year × 1000.0
   /// </summary>
   public static readonly Length ZettalightYear = new ("zettalight-year", "Zly", ExalightYear, 1000.0);

   /// <summary>
   /// yottalight-year, defined as: zettalight-year × 1000.0
   /// </summary>
   public static readonly Length YottalightYear = new ("yottalight-year", "Yly", ZettalightYear, 1000.0);

   /// <summary>
   /// ronnalight-year, defined as: yottalight-year × 1000.0
   /// </summary>
   public static readonly Length RonnalightYear = new ("ronnalight-year", "Rly", YottalightYear, 1000.0);

   /// <summary>
   /// quettalight-year, defined as: ronnalight-year × 1000.0
   /// </summary>
   public static readonly Length QuettalightYear = new ("quettalight-year", "Qly", RonnalightYear, 1000.0);

   /// <summary>
   /// light-second, defined as: SI meter × 299_792_458.0
   /// </summary>
   public static readonly Length LightSecond = new ("light-second", "ls", SI.Lengths.Meter, 299_792_458.0);

   /// <summary>
   /// light-minute, defined as: light-second × 60.0
   /// </summary>
   public static readonly Length LightMinute = new ("light-minute", "lm", LightSecond, 60.0);

   /// <summary>
   /// astronomical unit, defined as: SI kilometer × 149597870.691
   /// </summary>
   public static readonly Length AstronomicalUnit = new (
                                                         "astronomical unit"
                                                       , "AU"
                                                       , SI.Lengths.Kilometer
                                                       , 149597870.691
                                                        );

   /// <summary>
   /// light-hour, defined as: light-minute × 60.0
   /// </summary>
   public static readonly Length LightHour = new ("light-hour", "lh", LightMinute, 60.0);

   /// <summary>
   /// light-day, defined as: light-hour × 24.0
   /// </summary>
   public static readonly Length LightDay = new ("light-day", "ld", LightHour, 24.0);

   /// <summary>
   /// light-week, defined as: light-day × 7.0
   /// </summary>
   public static readonly Length LightWeek = new ("light-week", "lw", LightDay, 7.0);

   /// <summary>
   /// parsec, defined as: light-year × 3.2615637769757
   /// </summary>
   public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757);

   /// <summary>
   /// dekaparsec, defined as: parsec × 10.0
   /// </summary>
   public static readonly Length Dekaparsec = new ("dekaparsec", "dapc", Parsec, 10.0);

   /// <summary>
   /// hectoparsec, defined as: dekaparsec × 10.0
   /// </summary>
   public static readonly Length Hectoparsec = new ("hectoparsec", "hpc", Dekaparsec, 10.0);

   /// <summary>
   /// kiloparsec, defined as: hectoparsec × 10.0
   /// </summary>
   public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Hectoparsec, 10.0);

   /// <summary>
   /// megaparsec, defined as: kiloparsec × 1000.0
   /// </summary>
   public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000.0);

   /// <summary>
   /// gigaparsec, defined as: megaparsec × 1000.0
   /// </summary>
   public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000.0);

   /// <summary>
   /// teraparsec, defined as: gigaparsec × 1000.0
   /// </summary>
   public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000.0);

   /// <summary>
   /// petaparsec, defined as: teraparsec × 1000.0
   /// </summary>
   public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000.0);

   /// <summary>
   /// exaparsec, defined as: petaparsec × 1000.0
   /// </summary>
   public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000.0);

   /// <summary>
   /// zettaparsec, defined as: exaparsec × 1000.0
   /// </summary>
   public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000.0);

   /// <summary>
   /// yottaparsec, defined as: zettaparsec × 1000.0
   /// </summary>
   public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000.0);

   /// <summary>
   /// ronnaparsec, defined as: yottaparsec × 1000.0
   /// </summary>
   public static readonly Length Ronnaparsec = new ("ronnaparsec", "Rpc", Yottaparsec, 1000.0);

   /// <summary>
   /// quettaparsec, defined as: ronnaparsec × 1000.0
   /// </summary>
   public static readonly Length Quettaparsec = new ("quettaparsec", "Qpc", Ronnaparsec, 1000.0);

   /// <summary>
   /// earth radius, defined as: SI kilometer × 6_371.0
   /// </summary>
   public static readonly Length EarthRadius = new ("earth radius", "R(⊕)", SI.Lengths.Kilometer, 6_371.0);

   /// <summary>
   /// jovian radius, defined as: SI kilometer × 69_911.0
   /// </summary>
   public static readonly Length JovianRadius = new ("jovian radius", "R(J)", SI.Lengths.Kilometer, 69_911.0);

   /// <summary>
   /// lunar radius, defined as: SI kilometer × 1_737.4
   /// </summary>
   public static readonly Length LunarRadius = new ("lunar radius", "R(L)", SI.Lengths.Kilometer, 1_737.4);

   /// <summary>
   /// mars radius, defined as: SI kilometer × 3_389.5
   /// </summary>
   public static readonly Length MarsRadius = new ("mars radius", "R(♂)", SI.Lengths.Kilometer, 3_389.5);

   /// <summary>
   /// solar radius, defined as: SI kilometer × 695_700.0
   /// </summary>
   public static readonly Length SolarRadius = new ("solar radius", "R(☉)", SI.Lengths.Kilometer, 695_700.0);

   /// <summary>
   /// earth diameter, defined as: earth radius × 2.0
   /// </summary>
   public static readonly Length EarthDiameter = new ("earth diameter", "D(⊕)", EarthRadius, 2.0);

   /// <summary>
   /// jovian diameter, defined as: jovian radius × 2.0
   /// </summary>
   public static readonly Length JovianDiameter = new ("jovian diameter", "D(J)", JovianRadius, 2.0);

   /// <summary>
   /// lunar diameter, defined as: lunar radius × 2.0
   /// </summary>
   public static readonly Length LunarDiameter = new ("lunar diameter", "D(L)", LunarRadius, 2.0);

   /// <summary>
   /// mars diameter, defined as: mars radius × 2.0
   /// </summary>
   public static readonly Length MarsDiameter = new ("mars diameter", "D(♂)", MarsRadius, 2.0);

   /// <summary>
   /// solar diameter, defined as: solar radius × 2.0
   /// </summary>
   public static readonly Length SolarDiameter = new ("solar diameter", "D(☉)", SolarRadius, 2.0);

   /// <summary>
   /// earth circumference, defined as: earth diameter × Math.PI
   /// </summary>
   public static readonly Length EarthCircumference = new ("earth circumference", "C(⊕)", EarthDiameter, Math.PI);

   /// <summary>
   /// jovian circumference, defined as: jovian diameter × Math.PI
   /// </summary>
   public static readonly Length JovianCircumference = new ("jovian circumference", "C(J)", JovianDiameter, Math.PI);

   /// <summary>
   /// lunar circumference, defined as: lunar diameter × Math.PI
   /// </summary>
   public static readonly Length LunarCircumference = new ("lunar circumference", "C(L)", LunarDiameter, Math.PI);

   /// <summary>
   /// mars circumference, defined as: mars diameter × Math.PI
   /// </summary>
   public static readonly Length MarsCircumference = new ("mars circumference", "C(♂)", MarsDiameter, Math.PI);

   /// <summary>
   /// solar circumference, defined as: solar diameter × Math.PI
   /// </summary>
   public static readonly Length SolarCircumference = new ("solar circumference", "C(☉)", SolarDiameter, Math.PI);
}
