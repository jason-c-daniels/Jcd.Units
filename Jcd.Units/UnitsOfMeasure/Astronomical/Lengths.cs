using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.Astronomical;

/// <summary>
/// Astronomical Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{

    /// <summary>
    /// A(n) light-year. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length LightYear = new ("light-year", "ly", SI.Lengths.Meter, 9_460_730_472_580_800,0);

    /// <summary>
    /// A(n) decilight-year. Defined in terms of a(n) light-year.
    /// </summary>
    public static readonly Length DecilightYear = new ("decilight-year", "dly", LightYear, 1.0/10.0,0);

    /// <summary>
    /// A(n) centilight-year. Defined in terms of a(n) decilight-year.
    /// </summary>
    public static readonly Length CentilightYear = new ("centilight-year", "cly", DecilightYear, 1.0/10.0,0);

    /// <summary>
    /// A(n) millilight-year. Defined in terms of a(n) centilight-year.
    /// </summary>
    public static readonly Length MillilightYear = new ("millilight-year", "mly", CentilightYear, 1.0/10.0,0);

    /// <summary>
    /// A(n) microlight-year. Defined in terms of a(n) millilight-year.
    /// </summary>
    public static readonly Length MicrolightYear = new ("microlight-year", "μly", MillilightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanolight-year. Defined in terms of a(n) microlight-year.
    /// </summary>
    public static readonly Length NanolightYear = new ("nanolight-year", "nly", MicrolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picolight-year. Defined in terms of a(n) nanolight-year.
    /// </summary>
    public static readonly Length PicolightYear = new ("picolight-year", "ply", NanolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtolight-year. Defined in terms of a(n) picolight-year.
    /// </summary>
    public static readonly Length FemtolightYear = new ("femtolight-year", "fly", PicolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attolight-year. Defined in terms of a(n) femtolight-year.
    /// </summary>
    public static readonly Length AttolightYear = new ("attolight-year", "aly", FemtolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptolight-year. Defined in terms of a(n) attolight-year.
    /// </summary>
    public static readonly Length ZeptolightYear = new ("zeptolight-year", "zly", AttolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctolight-year. Defined in terms of a(n) zeptolight-year.
    /// </summary>
    public static readonly Length YoctolightYear = new ("yoctolight-year", "yly", ZeptolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontolight-year. Defined in terms of a(n) yoctolight-year.
    /// </summary>
    public static readonly Length RontolightYear = new ("rontolight-year", "rly", YoctolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectolight-year. Defined in terms of a(n) rontolight-year.
    /// </summary>
    public static readonly Length QuectolightYear = new ("quectolight-year", "qly", RontolightYear, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekalight-year. Defined in terms of a(n) light-year.
    /// </summary>
    public static readonly Length DekalightYear = new ("dekalight-year", "daly", LightYear, 10,0);

    /// <summary>
    /// A(n) hectolight-year. Defined in terms of a(n) dekalight-year.
    /// </summary>
    public static readonly Length HectolightYear = new ("hectolight-year", "hly", DekalightYear, 10,0);

    /// <summary>
    /// A(n) kilolight-year. Defined in terms of a(n) hectolight-year.
    /// </summary>
    public static readonly Length KilolightYear = new ("kilolight-year", "kly", HectolightYear, 10,0);

    /// <summary>
    /// A(n) megalight-year. Defined in terms of a(n) kilolight-year.
    /// </summary>
    public static readonly Length MegalightYear = new ("megalight-year", "Mly", KilolightYear, 1000,0);

    /// <summary>
    /// A(n) gigalight-year. Defined in terms of a(n) megalight-year.
    /// </summary>
    public static readonly Length GigalightYear = new ("gigalight-year", "Gly", MegalightYear, 1000,0);

    /// <summary>
    /// A(n) teralight-year. Defined in terms of a(n) gigalight-year.
    /// </summary>
    public static readonly Length TeralightYear = new ("teralight-year", "Tly", GigalightYear, 1000,0);

    /// <summary>
    /// A(n) petalight-year. Defined in terms of a(n) teralight-year.
    /// </summary>
    public static readonly Length PetalightYear = new ("petalight-year", "Ply", TeralightYear, 1000,0);

    /// <summary>
    /// A(n) exalight-year. Defined in terms of a(n) petalight-year.
    /// </summary>
    public static readonly Length ExalightYear = new ("exalight-year", "Ely", PetalightYear, 1000,0);

    /// <summary>
    /// A(n) zettalight-year. Defined in terms of a(n) exalight-year.
    /// </summary>
    public static readonly Length ZettalightYear = new ("zettalight-year", "Zly", ExalightYear, 1000,0);

    /// <summary>
    /// A(n) yottalight-year. Defined in terms of a(n) zettalight-year.
    /// </summary>
    public static readonly Length YottalightYear = new ("yottalight-year", "Yly", ZettalightYear, 1000,0);

    /// <summary>
    /// A(n) ronnalight-year. Defined in terms of a(n) yottalight-year.
    /// </summary>
    public static readonly Length RonnalightYear = new ("ronnalight-year", "Rly", YottalightYear, 1000,0);

    /// <summary>
    /// A(n) quettalight-year. Defined in terms of a(n) ronnalight-year.
    /// </summary>
    public static readonly Length QuettalightYear = new ("quettalight-year", "Qly", RonnalightYear, 1000,0);

    /// <summary>
    /// A(n) light-second. Defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length LightSecond = new ("light-second", "ls", SI.Lengths.Meter, 299_792_458,0);

    /// <summary>
    /// A(n) light-minute. Defined in terms of a(n) light-second.
    /// </summary>
    public static readonly Length LightMinute = new ("light-minute", "lm", LightSecond, 60,0);

    /// <summary>
    /// A(n) astronomical unit. Defined in terms of a(n) SI kilometer.
    /// </summary>
    public static readonly Length AstronomicalUnit = new ("astronomical unit", "AU", SI.Lengths.Kilometer, 149597870.691,0);

    /// <summary>
    /// A(n) light-hour. Defined in terms of a(n) light-minute.
    /// </summary>
    public static readonly Length LightHour = new ("light-hour", "lh", LightMinute, 60,0);

    /// <summary>
    /// A(n) light-day. Defined in terms of a(n) light-hour.
    /// </summary>
    public static readonly Length LightDay = new ("light-day", "ld", LightHour, 24,0);

    /// <summary>
    /// A(n) light-week. Defined in terms of a(n) light-day.
    /// </summary>
    public static readonly Length LightWeek = new ("light-week", "lw", LightDay, 7,0);

    /// <summary>
    /// A(n) parsec. Defined in terms of a(n) light-year.
    /// </summary>
    public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757,0);

    /// <summary>
    /// A(n) deciparsec. Defined in terms of a(n) parsec.
    /// </summary>
    public static readonly Length Deciparsec = new ("deciparsec", "dpc", Parsec, 1.0/10.0,0);

    /// <summary>
    /// A(n) centiparsec. Defined in terms of a(n) deciparsec.
    /// </summary>
    public static readonly Length Centiparsec = new ("centiparsec", "cpc", Deciparsec, 1.0/10.0,0);

    /// <summary>
    /// A(n) milliparsec. Defined in terms of a(n) centiparsec.
    /// </summary>
    public static readonly Length Milliparsec = new ("milliparsec", "mpc", Centiparsec, 1.0/10.0,0);

    /// <summary>
    /// A(n) microparsec. Defined in terms of a(n) milliparsec.
    /// </summary>
    public static readonly Length Microparsec = new ("microparsec", "μpc", Milliparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanoparsec. Defined in terms of a(n) microparsec.
    /// </summary>
    public static readonly Length Nanoparsec = new ("nanoparsec", "npc", Microparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picoparsec. Defined in terms of a(n) nanoparsec.
    /// </summary>
    public static readonly Length Picoparsec = new ("picoparsec", "ppc", Nanoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtoparsec. Defined in terms of a(n) picoparsec.
    /// </summary>
    public static readonly Length Femtoparsec = new ("femtoparsec", "fpc", Picoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attoparsec. Defined in terms of a(n) femtoparsec.
    /// </summary>
    public static readonly Length Attoparsec = new ("attoparsec", "apc", Femtoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptoparsec. Defined in terms of a(n) attoparsec.
    /// </summary>
    public static readonly Length Zeptoparsec = new ("zeptoparsec", "zpc", Attoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctoparsec. Defined in terms of a(n) zeptoparsec.
    /// </summary>
    public static readonly Length Yoctoparsec = new ("yoctoparsec", "ypc", Zeptoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontoparsec. Defined in terms of a(n) yoctoparsec.
    /// </summary>
    public static readonly Length Rontoparsec = new ("rontoparsec", "rpc", Yoctoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectoparsec. Defined in terms of a(n) rontoparsec.
    /// </summary>
    public static readonly Length Quectoparsec = new ("quectoparsec", "qpc", Rontoparsec, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekaparsec. Defined in terms of a(n) parsec.
    /// </summary>
    public static readonly Length Dekaparsec = new ("dekaparsec", "dapc", Parsec, 10,0);

    /// <summary>
    /// A(n) hectoparsec. Defined in terms of a(n) dekaparsec.
    /// </summary>
    public static readonly Length Hectoparsec = new ("hectoparsec", "hpc", Dekaparsec, 10,0);

    /// <summary>
    /// A(n) kiloparsec. Defined in terms of a(n) hectoparsec.
    /// </summary>
    public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Hectoparsec, 10,0);

    /// <summary>
    /// A(n) megaparsec. Defined in terms of a(n) kiloparsec.
    /// </summary>
    public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000,0);

    /// <summary>
    /// A(n) gigaparsec. Defined in terms of a(n) megaparsec.
    /// </summary>
    public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000,0);

    /// <summary>
    /// A(n) teraparsec. Defined in terms of a(n) gigaparsec.
    /// </summary>
    public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000,0);

    /// <summary>
    /// A(n) petaparsec. Defined in terms of a(n) teraparsec.
    /// </summary>
    public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000,0);

    /// <summary>
    /// A(n) exaparsec. Defined in terms of a(n) petaparsec.
    /// </summary>
    public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000,0);

    /// <summary>
    /// A(n) zettaparsec. Defined in terms of a(n) exaparsec.
    /// </summary>
    public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000,0);

    /// <summary>
    /// A(n) yottaparsec. Defined in terms of a(n) zettaparsec.
    /// </summary>
    public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000,0);

    /// <summary>
    /// A(n) ronnaparsec. Defined in terms of a(n) yottaparsec.
    /// </summary>
    public static readonly Length Ronnaparsec = new ("ronnaparsec", "Rpc", Yottaparsec, 1000,0);

    /// <summary>
    /// A(n) quettaparsec. Defined in terms of a(n) ronnaparsec.
    /// </summary>
    public static readonly Length Quettaparsec = new ("quettaparsec", "Qpc", Ronnaparsec, 1000,0);

}