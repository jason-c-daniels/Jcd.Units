using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.Astronomy;

/// <summary>
/// Astronomical Units for measuring Length.
/// </summary>
public class Lengths : Enumeration<Lengths,Length>
{
    /// <summary>
    /// Units of a light-year. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length LightYear = new ("light-year", "ly", SI.Lengths.Meter, 9_460_730_472_580_800,0);
    /// <summary>
    /// Units of a decilight-year. It's defined in terms of a(n) SI light-year.
    /// </summary>
    public static readonly Length DecilightYear = new ("decilight-year", "dly", LightYear, 1.0/10.0,0);
    /// <summary>
    /// Units of a centilight-year. It's defined in terms of a(n) SI decilight-year.
    /// </summary>
    public static readonly Length CentilightYear = new ("centilight-year", "cly", DecilightYear, 1.0/10.0,0);
    /// <summary>
    /// Units of a millilight-year. It's defined in terms of a(n) SI centilight-year.
    /// </summary>
    public static readonly Length MillilightYear = new ("millilight-year", "mly", CentilightYear, 1.0/10.0,0);
    /// <summary>
    /// Units of a microlight-year. It's defined in terms of a(n) SI millilight-year.
    /// </summary>
    public static readonly Length MicrolightYear = new ("microlight-year", "μly", MillilightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanolight-year. It's defined in terms of a(n) SI microlight-year.
    /// </summary>
    public static readonly Length NanolightYear = new ("nanolight-year", "nly", MicrolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picolight-year. It's defined in terms of a(n) SI nanolight-year.
    /// </summary>
    public static readonly Length PicolightYear = new ("picolight-year", "ply", NanolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtolight-year. It's defined in terms of a(n) SI picolight-year.
    /// </summary>
    public static readonly Length FemtolightYear = new ("femtolight-year", "fly", PicolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attolight-year. It's defined in terms of a(n) SI femtolight-year.
    /// </summary>
    public static readonly Length AttolightYear = new ("attolight-year", "aly", FemtolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptolight-year. It's defined in terms of a(n) SI attolight-year.
    /// </summary>
    public static readonly Length ZeptolightYear = new ("zeptolight-year", "zly", AttolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctolight-year. It's defined in terms of a(n) SI zeptolight-year.
    /// </summary>
    public static readonly Length YoctolightYear = new ("yoctolight-year", "yly", ZeptolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontolight-year. It's defined in terms of a(n) SI yoctolight-year.
    /// </summary>
    public static readonly Length RontolightYear = new ("rontolight-year", "rly", YoctolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectolight-year. It's defined in terms of a(n) SI rontolight-year.
    /// </summary>
    public static readonly Length QuectolightYear = new ("quectolight-year", "qly", RontolightYear, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekalight-year. It's defined in terms of a(n) SI light-year.
    /// </summary>
    public static readonly Length DekalightYear = new ("dekalight-year", "daly", LightYear, 10,0);
    /// <summary>
    /// Units of a hectolight-year. It's defined in terms of a(n) SI dekalight-year.
    /// </summary>
    public static readonly Length HectolightYear = new ("hectolight-year", "hly", DekalightYear, 10,0);
    /// <summary>
    /// Units of a kilolight-year. It's defined in terms of a(n) SI hectolight-year.
    /// </summary>
    public static readonly Length KilolightYear = new ("kilolight-year", "kly", HectolightYear, 10,0);
    /// <summary>
    /// Units of a megalight-year. It's defined in terms of a(n) SI kilolight-year.
    /// </summary>
    public static readonly Length MegalightYear = new ("megalight-year", "Mly", KilolightYear, 1000,0);
    /// <summary>
    /// Units of a gigalight-year. It's defined in terms of a(n) SI megalight-year.
    /// </summary>
    public static readonly Length GigalightYear = new ("gigalight-year", "Gly", MegalightYear, 1000,0);
    /// <summary>
    /// Units of a teralight-year. It's defined in terms of a(n) SI gigalight-year.
    /// </summary>
    public static readonly Length TeralightYear = new ("teralight-year", "Tly", GigalightYear, 1000,0);
    /// <summary>
    /// Units of a petalight-year. It's defined in terms of a(n) SI teralight-year.
    /// </summary>
    public static readonly Length PetalightYear = new ("petalight-year", "Ply", TeralightYear, 1000,0);
    /// <summary>
    /// Units of a exalight-year. It's defined in terms of a(n) SI petalight-year.
    /// </summary>
    public static readonly Length ExalightYear = new ("exalight-year", "Ely", PetalightYear, 1000,0);
    /// <summary>
    /// Units of a zettalight-year. It's defined in terms of a(n) SI exalight-year.
    /// </summary>
    public static readonly Length ZettalightYear = new ("zettalight-year", "Zly", ExalightYear, 1000,0);
    /// <summary>
    /// Units of a yottalight-year. It's defined in terms of a(n) SI zettalight-year.
    /// </summary>
    public static readonly Length YottalightYear = new ("yottalight-year", "Yly", ZettalightYear, 1000,0);
    /// <summary>
    /// Units of a ronnalight-year. It's defined in terms of a(n) SI yottalight-year.
    /// </summary>
    public static readonly Length RonnalightYear = new ("ronnalight-year", "Rly", YottalightYear, 1000,0);
    /// <summary>
    /// Units of a quettalight-year. It's defined in terms of a(n) SI ronnalight-year.
    /// </summary>
    public static readonly Length QuettalightYear = new ("quettalight-year", "Qly", RonnalightYear, 1000,0);
    /// <summary>
    /// Units of a light-second. It's defined in terms of a(n) SI meter.
    /// </summary>
    public static readonly Length LightSecond = new ("light-second", "ls", SI.Lengths.Meter, 299_792_458,0);
    /// <summary>
    /// Units of a light-minute. It's defined in terms of a(n) Astronomy light-second.
    /// </summary>
    public static readonly Length LightMinute = new ("light-minute", "lm", LightSecond, 60,0);
    /// <summary>
    /// Units of a astronomical unit. It's defined in terms of a(n) SI kilometer.
    /// </summary>
    public static readonly Length AstronomicalUnit = new ("astronomical unit", "AU", SI.Lengths.Kilometer, 149597870.691,0);
    /// <summary>
    /// Units of a light-hour. It's defined in terms of a(n) Astronomy light-minute.
    /// </summary>
    public static readonly Length LightHour = new ("light-hour", "lh", LightMinute, 60,0);
    /// <summary>
    /// Units of a light-day. It's defined in terms of a(n) Astronomy light-hour.
    /// </summary>
    public static readonly Length LightDay = new ("light-day", "ld", LightHour, 24,0);
    /// <summary>
    /// Units of a light-week. It's defined in terms of a(n) Astronomy light-day.
    /// </summary>
    public static readonly Length LightWeek = new ("light-week", "lw", LightDay, 7,0);
    /// <summary>
    /// Units of a parsec. It's defined in terms of a(n) Astronomy light-year.
    /// </summary>
    public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757,0);
    /// <summary>
    /// Units of a deciparsec. It's defined in terms of a(n) Astronomy parsec.
    /// </summary>
    public static readonly Length Deciparsec = new ("deciparsec", "dpc", Parsec, 1.0/10.0,0);
    /// <summary>
    /// Units of a centiparsec. It's defined in terms of a(n) Astronomy deciparsec.
    /// </summary>
    public static readonly Length Centiparsec = new ("centiparsec", "cpc", Deciparsec, 1.0/10.0,0);
    /// <summary>
    /// Units of a milliparsec. It's defined in terms of a(n) Astronomy centiparsec.
    /// </summary>
    public static readonly Length Milliparsec = new ("milliparsec", "mpc", Centiparsec, 1.0/10.0,0);
    /// <summary>
    /// Units of a microparsec. It's defined in terms of a(n) Astronomy milliparsec.
    /// </summary>
    public static readonly Length Microparsec = new ("microparsec", "μpc", Milliparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanoparsec. It's defined in terms of a(n) Astronomy microparsec.
    /// </summary>
    public static readonly Length Nanoparsec = new ("nanoparsec", "npc", Microparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picoparsec. It's defined in terms of a(n) Astronomy nanoparsec.
    /// </summary>
    public static readonly Length Picoparsec = new ("picoparsec", "ppc", Nanoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtoparsec. It's defined in terms of a(n) Astronomy picoparsec.
    /// </summary>
    public static readonly Length Femtoparsec = new ("femtoparsec", "fpc", Picoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attoparsec. It's defined in terms of a(n) Astronomy femtoparsec.
    /// </summary>
    public static readonly Length Attoparsec = new ("attoparsec", "apc", Femtoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptoparsec. It's defined in terms of a(n) Astronomy attoparsec.
    /// </summary>
    public static readonly Length Zeptoparsec = new ("zeptoparsec", "zpc", Attoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctoparsec. It's defined in terms of a(n) Astronomy zeptoparsec.
    /// </summary>
    public static readonly Length Yoctoparsec = new ("yoctoparsec", "ypc", Zeptoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontoparsec. It's defined in terms of a(n) Astronomy yoctoparsec.
    /// </summary>
    public static readonly Length Rontoparsec = new ("rontoparsec", "rpc", Yoctoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectoparsec. It's defined in terms of a(n) Astronomy rontoparsec.
    /// </summary>
    public static readonly Length Quectoparsec = new ("quectoparsec", "qpc", Rontoparsec, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekaparsec. It's defined in terms of a(n) Astronomy parsec.
    /// </summary>
    public static readonly Length Dekaparsec = new ("dekaparsec", "dapc", Parsec, 10,0);
    /// <summary>
    /// Units of a hectoparsec. It's defined in terms of a(n) Astronomy dekaparsec.
    /// </summary>
    public static readonly Length Hectoparsec = new ("hectoparsec", "hpc", Dekaparsec, 10,0);
    /// <summary>
    /// Units of a kiloparsec. It's defined in terms of a(n) Astronomy hectoparsec.
    /// </summary>
    public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Hectoparsec, 10,0);
    /// <summary>
    /// Units of a megaparsec. It's defined in terms of a(n) Astronomy kiloparsec.
    /// </summary>
    public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000,0);
    /// <summary>
    /// Units of a gigaparsec. It's defined in terms of a(n) Astronomy megaparsec.
    /// </summary>
    public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000,0);
    /// <summary>
    /// Units of a teraparsec. It's defined in terms of a(n) Astronomy gigaparsec.
    /// </summary>
    public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000,0);
    /// <summary>
    /// Units of a petaparsec. It's defined in terms of a(n) Astronomy teraparsec.
    /// </summary>
    public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000,0);
    /// <summary>
    /// Units of a exaparsec. It's defined in terms of a(n) Astronomy petaparsec.
    /// </summary>
    public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000,0);
    /// <summary>
    /// Units of a zettaparsec. It's defined in terms of a(n) Astronomy exaparsec.
    /// </summary>
    public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000,0);
    /// <summary>
    /// Units of a yottaparsec. It's defined in terms of a(n) Astronomy zettaparsec.
    /// </summary>
    public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000,0);
    /// <summary>
    /// Units of a ronnaparsec. It's defined in terms of a(n) Astronomy yottaparsec.
    /// </summary>
    public static readonly Length Ronnaparsec = new ("ronnaparsec", "Rpc", Yottaparsec, 1000,0);
    /// <summary>
    /// Units of a quettaparsec. It's defined in terms of a(n) Astronomy ronnaparsec.
    /// </summary>
    public static readonly Length Quettaparsec = new ("quettaparsec", "Qpc", Ronnaparsec, 1000,0);

}