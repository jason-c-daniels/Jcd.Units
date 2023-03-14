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
public class Lengths : Enumeration<Lengths, Length>
{
   /// <summary>
   /// A(n) light-year. Defined in terms of a(n) SI meter.
   /// </summary>
   public static readonly Length LightYear = new ("light-year", "ly", SI.Lengths.Meter, 9_460_730_472_580_800.0, 0);

   /// <summary>
   /// A(n) dekalight-year. Defined in terms of a(n) light-year.
   /// </summary>
   public static readonly Length DekalightYear = new ("dekalight-year", "daly", LightYear, 10.0, 0);

   /// <summary>
   /// A(n) hectolight-year. Defined in terms of a(n) dekalight-year.
   /// </summary>
   public static readonly Length HectolightYear = new ("hectolight-year", "hly", DekalightYear, 10.0, 0);

   /// <summary>
   /// A(n) kilolight-year. Defined in terms of a(n) hectolight-year.
   /// </summary>
   public static readonly Length KilolightYear = new ("kilolight-year", "kly", HectolightYear, 10.0, 0);

   /// <summary>
   /// A(n) megalight-year. Defined in terms of a(n) kilolight-year.
   /// </summary>
   public static readonly Length MegalightYear = new ("megalight-year", "Mly", KilolightYear, 1000.0, 0);

   /// <summary>
   /// A(n) gigalight-year. Defined in terms of a(n) megalight-year.
   /// </summary>
   public static readonly Length GigalightYear = new ("gigalight-year", "Gly", MegalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) teralight-year. Defined in terms of a(n) gigalight-year.
   /// </summary>
   public static readonly Length TeralightYear = new ("teralight-year", "Tly", GigalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) petalight-year. Defined in terms of a(n) teralight-year.
   /// </summary>
   public static readonly Length PetalightYear = new ("petalight-year", "Ply", TeralightYear, 1000.0, 0);

   /// <summary>
   /// A(n) exalight-year. Defined in terms of a(n) petalight-year.
   /// </summary>
   public static readonly Length ExalightYear = new ("exalight-year", "Ely", PetalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) zettalight-year. Defined in terms of a(n) exalight-year.
   /// </summary>
   public static readonly Length ZettalightYear = new ("zettalight-year", "Zly", ExalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) yottalight-year. Defined in terms of a(n) zettalight-year.
   /// </summary>
   public static readonly Length YottalightYear = new ("yottalight-year", "Yly", ZettalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) ronnalight-year. Defined in terms of a(n) yottalight-year.
   /// </summary>
   public static readonly Length RonnalightYear = new ("ronnalight-year", "Rly", YottalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) quettalight-year. Defined in terms of a(n) ronnalight-year.
   /// </summary>
   public static readonly Length QuettalightYear = new ("quettalight-year", "Qly", RonnalightYear, 1000.0, 0);

   /// <summary>
   /// A(n) light-second. Defined in terms of a(n) SI meter.
   /// </summary>
   public static readonly Length LightSecond = new ("light-second", "ls", SI.Lengths.Meter, 299_792_458.0, 0);

   /// <summary>
   /// A(n) light-minute. Defined in terms of a(n) light-second.
   /// </summary>
   public static readonly Length LightMinute = new ("light-minute", "lm", LightSecond, 60.0, 0);

   /// <summary>
   /// A(n) astronomical unit. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length AstronomicalUnit = new (
                                                         "astronomical unit"
                                                       , "AU"
                                                       , SI.Lengths.Kilometer
                                                       , 149597870.691
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) light-hour. Defined in terms of a(n) light-minute.
   /// </summary>
   public static readonly Length LightHour = new ("light-hour", "lh", LightMinute, 60.0, 0);

   /// <summary>
   /// A(n) light-day. Defined in terms of a(n) light-hour.
   /// </summary>
   public static readonly Length LightDay = new ("light-day", "ld", LightHour, 24.0, 0);

   /// <summary>
   /// A(n) light-week. Defined in terms of a(n) light-day.
   /// </summary>
   public static readonly Length LightWeek = new ("light-week", "lw", LightDay, 7.0, 0);

   /// <summary>
   /// A(n) parsec. Defined in terms of a(n) light-year.
   /// </summary>
   public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757, 0);

   /// <summary>
   /// A(n) dekaparsec. Defined in terms of a(n) parsec.
   /// </summary>
   public static readonly Length Dekaparsec = new ("dekaparsec", "dapc", Parsec, 10.0, 0);

   /// <summary>
   /// A(n) hectoparsec. Defined in terms of a(n) dekaparsec.
   /// </summary>
   public static readonly Length Hectoparsec = new ("hectoparsec", "hpc", Dekaparsec, 10.0, 0);

   /// <summary>
   /// A(n) kiloparsec. Defined in terms of a(n) hectoparsec.
   /// </summary>
   public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Hectoparsec, 10.0, 0);

   /// <summary>
   /// A(n) megaparsec. Defined in terms of a(n) kiloparsec.
   /// </summary>
   public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000.0, 0);

   /// <summary>
   /// A(n) gigaparsec. Defined in terms of a(n) megaparsec.
   /// </summary>
   public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) teraparsec. Defined in terms of a(n) gigaparsec.
   /// </summary>
   public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) petaparsec. Defined in terms of a(n) teraparsec.
   /// </summary>
   public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000.0, 0);

   /// <summary>
   /// A(n) exaparsec. Defined in terms of a(n) petaparsec.
   /// </summary>
   public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) zettaparsec. Defined in terms of a(n) exaparsec.
   /// </summary>
   public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) yottaparsec. Defined in terms of a(n) zettaparsec.
   /// </summary>
   public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) ronnaparsec. Defined in terms of a(n) yottaparsec.
   /// </summary>
   public static readonly Length Ronnaparsec = new ("ronnaparsec", "Rpc", Yottaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) quettaparsec. Defined in terms of a(n) ronnaparsec.
   /// </summary>
   public static readonly Length Quettaparsec = new ("quettaparsec", "Qpc", Ronnaparsec, 1000.0, 0);

   /// <summary>
   /// A(n) earth radius. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length EarthRadius = new ("earth radius", "R(⊕)", SI.Lengths.Kilometer, 6_371.0, 0);

   /// <summary>
   /// A(n) jovian radius. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length JovianRadius = new ("jovian radius", "R(J)", SI.Lengths.Kilometer, 69_911.0, 0);

   /// <summary>
   /// A(n) lunar radius. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length LunarRadius = new ("lunar radius", "R(L)", SI.Lengths.Kilometer, 1_737.4, 0);

   /// <summary>
   /// A(n) mars radius. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length MarsRadius = new ("mars radius", "R(♂)", SI.Lengths.Kilometer, 3_389.5, 0);

   /// <summary>
   /// A(n) solar radius. Defined in terms of a(n) SI kilometer.
   /// </summary>
   public static readonly Length SolarRadius = new ("solar radius", "R(☉)", SI.Lengths.Kilometer, 695_700.0, 0);

   /// <summary>
   /// A(n) earth diameter. Defined in terms of a(n) earth radius.
   /// </summary>
   public static readonly Length EarthDiameter = new ("earth diameter", "D(⊕)", EarthRadius, 2.0, 0);

   /// <summary>
   /// A(n) jovian diameter. Defined in terms of a(n) jovian radius.
   /// </summary>
   public static readonly Length JovianDiameter = new ("jovian diameter", "D(J)", JovianRadius, 2.0, 0);

   /// <summary>
   /// A(n) lunar diameter. Defined in terms of a(n) lunar radius.
   /// </summary>
   public static readonly Length LunarDiameter = new ("lunar diameter", "D(L)", LunarRadius, 2.0, 0);

   /// <summary>
   /// A(n) mars diameter. Defined in terms of a(n) mars radius.
   /// </summary>
   public static readonly Length MarsDiameter = new ("mars diameter", "D(♂)", MarsRadius, 2.0, 0);

   /// <summary>
   /// A(n) solar diameter. Defined in terms of a(n) solar radius.
   /// </summary>
   public static readonly Length SolarDiameter = new ("solar diameter", "D(☉)", SolarRadius, 2.0, 0);

   /// <summary>
   /// A(n) earth circumference. Defined in terms of a(n) earth diameter.
   /// </summary>
   public static readonly Length EarthCircumference = new ("earth circumference", "C(⊕)", EarthDiameter, Math.PI, 0);

   /// <summary>
   /// A(n) jovian circumference. Defined in terms of a(n) jovian diameter.
   /// </summary>
   public static readonly Length JovianCircumference = new ("jovian circumference", "C(J)", JovianDiameter, Math.PI, 0);

   /// <summary>
   /// A(n) lunar circumference. Defined in terms of a(n) lunar diameter.
   /// </summary>
   public static readonly Length LunarCircumference = new ("lunar circumference", "C(L)", LunarDiameter, Math.PI, 0);

   /// <summary>
   /// A(n) mars circumference. Defined in terms of a(n) mars diameter.
   /// </summary>
   public static readonly Length MarsCircumference = new ("mars circumference", "C(♂)", MarsDiameter, Math.PI, 0);

   /// <summary>
   /// A(n) solar circumference. Defined in terms of a(n) solar diameter.
   /// </summary>
   public static readonly Length SolarCircumference = new ("solar circumference", "C(☉)", SolarDiameter, Math.PI, 0);
}
