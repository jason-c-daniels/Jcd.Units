namespace Jcd.Units;

public partial record Length
{
    public static class Astronomy
    {
        public static readonly Length AstronomicalUnit = new ("astronomical unit", "AU", SI.Kilometer, 149597870.691);
        public static readonly Length LightYear = new ("light-year", "ly", SI.Meter, 9_460_730_472_580_800);
        public static readonly Length KiloLightYear = new ("kilolight-year", "kly", LightYear, 1000);
        public static readonly Length MegaLightYear = new ("megalight-year", "Mly", KiloLightYear, 1000);
        public static readonly Length GigaLightYear = new ("gigalight-year", "Gly", MegaLightYear, 1000);
        public static readonly Length TeraLightYear = new ("teralight-year", "Tly", GigaLightYear, 1000);
        public static readonly Length PetaLightYear = new ("petalight-year", "Ply", TeraLightYear, 1000);
        public static readonly Length ExaLightYear = new ("exalight-year", "Ely", PetaLightYear, 1000);
        public static readonly Length ZettaLightYear = new ("zettalight-year", "Zly", ExaLightYear, 1000);
        public static readonly Length YottaLightYear = new ("yottalight-year", "Yly", ZettaLightYear, 1000);

        public static readonly Length Parsec = new ("parsec", "pc", LightYear, 3.2615637769757);
        public static readonly Length Kiloparsec = new ("kiloparsec", "kpc", Parsec, 1000);
        public static readonly Length Megaparsec = new ("megaparsec", "Mpc", Kiloparsec, 1000);
        public static readonly Length Gigaparsec = new ("gigaparsec", "Gpc", Megaparsec, 1000);
        public static readonly Length Teraparsec = new ("teraparsec", "Tpc", Gigaparsec, 1000);
        public static readonly Length Petaparsec = new ("petaparsec", "Ppc", Teraparsec, 1000);
        public static readonly Length Exaparsec = new ("exaparsec", "Epc", Petaparsec, 1000);
        public static readonly Length Zettaparsec = new ("zettaparsec", "Zpc", Exaparsec, 1000);
        public static readonly Length Yottaparsec = new ("yottaparsec", "Ypc", Zettaparsec, 1000);
    }
}