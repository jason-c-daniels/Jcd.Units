using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Charge.
/// </summary>
public class ElectricalCharges : Enumeration<ElectricalCharges,ElectricalCharge>
{

    /// <summary>
    /// Units of a coulomb.
    /// </summary>
    public static readonly ElectricalCharge Coulomb = new ("coulomb", "C");
    /// <summary>
    /// Units of a decicoulomb. It's defined in terms of a(n) SI coulomb.
    /// </summary>
    public static readonly ElectricalCharge Decicoulomb = new ("decicoulomb", "dC", Coulomb, 1.0/10.0,0);
    /// <summary>
    /// Units of a centicoulomb. It's defined in terms of a(n) SI decicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Centicoulomb = new ("centicoulomb", "cC", Decicoulomb, 1.0/10.0,0);
    /// <summary>
    /// Units of a millicoulomb. It's defined in terms of a(n) SI centicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Millicoulomb = new ("millicoulomb", "mC", Centicoulomb, 1.0/10.0,0);
    /// <summary>
    /// Units of a microcoulomb. It's defined in terms of a(n) SI millicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Microcoulomb = new ("microcoulomb", "μC", Millicoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanocoulomb. It's defined in terms of a(n) SI microcoulomb.
    /// </summary>
    public static readonly ElectricalCharge Nanocoulomb = new ("nanocoulomb", "nC", Microcoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picocoulomb. It's defined in terms of a(n) SI nanocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Picocoulomb = new ("picocoulomb", "pC", Nanocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtocoulomb. It's defined in terms of a(n) SI picocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Femtocoulomb = new ("femtocoulomb", "fC", Picocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attocoulomb. It's defined in terms of a(n) SI femtocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Attocoulomb = new ("attocoulomb", "aC", Femtocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptocoulomb. It's defined in terms of a(n) SI attocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Zeptocoulomb = new ("zeptocoulomb", "zC", Attocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctocoulomb. It's defined in terms of a(n) SI zeptocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Yoctocoulomb = new ("yoctocoulomb", "yC", Zeptocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontocoulomb. It's defined in terms of a(n) SI yoctocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Rontocoulomb = new ("rontocoulomb", "rC", Yoctocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectocoulomb. It's defined in terms of a(n) SI rontocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Quectocoulomb = new ("quectocoulomb", "qC", Rontocoulomb, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekacoulomb. It's defined in terms of a(n) SI coulomb.
    /// </summary>
    public static readonly ElectricalCharge Dekacoulomb = new ("dekacoulomb", "daC", Coulomb, 10,0);
    /// <summary>
    /// Units of a hectocoulomb. It's defined in terms of a(n) SI dekacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Hectocoulomb = new ("hectocoulomb", "hC", Dekacoulomb, 10,0);
    /// <summary>
    /// Units of a kilocoulomb. It's defined in terms of a(n) SI hectocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Kilocoulomb = new ("kilocoulomb", "kC", Hectocoulomb, 10,0);
    /// <summary>
    /// Units of a megacoulomb. It's defined in terms of a(n) SI kilocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Megacoulomb = new ("megacoulomb", "MC", Kilocoulomb, 1000,0);
    /// <summary>
    /// Units of a gigacoulomb. It's defined in terms of a(n) SI megacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Gigacoulomb = new ("gigacoulomb", "GC", Megacoulomb, 1000,0);
    /// <summary>
    /// Units of a teracoulomb. It's defined in terms of a(n) SI gigacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Teracoulomb = new ("teracoulomb", "TC", Gigacoulomb, 1000,0);
    /// <summary>
    /// Units of a petacoulomb. It's defined in terms of a(n) SI teracoulomb.
    /// </summary>
    public static readonly ElectricalCharge Petacoulomb = new ("petacoulomb", "PC", Teracoulomb, 1000,0);
    /// <summary>
    /// Units of a exacoulomb. It's defined in terms of a(n) SI petacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Exacoulomb = new ("exacoulomb", "EC", Petacoulomb, 1000,0);
    /// <summary>
    /// Units of a zettacoulomb. It's defined in terms of a(n) SI exacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Zettacoulomb = new ("zettacoulomb", "ZC", Exacoulomb, 1000,0);
    /// <summary>
    /// Units of a yottacoulomb. It's defined in terms of a(n) SI zettacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Yottacoulomb = new ("yottacoulomb", "YC", Zettacoulomb, 1000,0);
    /// <summary>
    /// Units of a ronnacoulomb. It's defined in terms of a(n) SI yottacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Ronnacoulomb = new ("ronnacoulomb", "RC", Yottacoulomb, 1000,0);
    /// <summary>
    /// Units of a quettacoulomb. It's defined in terms of a(n) SI ronnacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Quettacoulomb = new ("quettacoulomb", "QC", Ronnacoulomb, 1000,0);

}