using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Charge.
/// </summary>
public class ElectricalCharges : Enumeration<ElectricalCharges,ElectricalCharge>
{


    /// <summary>
    /// A(n) coulomb.
    /// </summary>
    public static readonly ElectricalCharge Coulomb = new ("coulomb", "C");
    /// <summary>
    /// A(n) decicoulomb. It's defined in terms of a(n) coulomb.
    /// </summary>
    public static readonly ElectricalCharge Decicoulomb = new ("decicoulomb", "dC", Coulomb, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centicoulomb. It's defined in terms of a(n) decicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Centicoulomb = new ("centicoulomb", "cC", Decicoulomb, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millicoulomb. It's defined in terms of a(n) centicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Millicoulomb = new ("millicoulomb", "mC", Centicoulomb, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microcoulomb. It's defined in terms of a(n) millicoulomb.
    /// </summary>
    public static readonly ElectricalCharge Microcoulomb = new ("microcoulomb", "μC", Millicoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanocoulomb. It's defined in terms of a(n) microcoulomb.
    /// </summary>
    public static readonly ElectricalCharge Nanocoulomb = new ("nanocoulomb", "nC", Microcoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picocoulomb. It's defined in terms of a(n) nanocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Picocoulomb = new ("picocoulomb", "pC", Nanocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtocoulomb. It's defined in terms of a(n) picocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Femtocoulomb = new ("femtocoulomb", "fC", Picocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attocoulomb. It's defined in terms of a(n) femtocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Attocoulomb = new ("attocoulomb", "aC", Femtocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptocoulomb. It's defined in terms of a(n) attocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Zeptocoulomb = new ("zeptocoulomb", "zC", Attocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctocoulomb. It's defined in terms of a(n) zeptocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Yoctocoulomb = new ("yoctocoulomb", "yC", Zeptocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontocoulomb. It's defined in terms of a(n) yoctocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Rontocoulomb = new ("rontocoulomb", "rC", Yoctocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectocoulomb. It's defined in terms of a(n) rontocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Quectocoulomb = new ("quectocoulomb", "qC", Rontocoulomb, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekacoulomb. It's defined in terms of a(n) coulomb.
    /// </summary>
    public static readonly ElectricalCharge Dekacoulomb = new ("dekacoulomb", "daC", Coulomb, 10,0);
    
    /// <summary>
    /// A(n) hectocoulomb. It's defined in terms of a(n) dekacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Hectocoulomb = new ("hectocoulomb", "hC", Dekacoulomb, 10,0);
    
    /// <summary>
    /// A(n) kilocoulomb. It's defined in terms of a(n) hectocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Kilocoulomb = new ("kilocoulomb", "kC", Hectocoulomb, 10,0);
    
    /// <summary>
    /// A(n) megacoulomb. It's defined in terms of a(n) kilocoulomb.
    /// </summary>
    public static readonly ElectricalCharge Megacoulomb = new ("megacoulomb", "MC", Kilocoulomb, 1000,0);
    
    /// <summary>
    /// A(n) gigacoulomb. It's defined in terms of a(n) megacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Gigacoulomb = new ("gigacoulomb", "GC", Megacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) teracoulomb. It's defined in terms of a(n) gigacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Teracoulomb = new ("teracoulomb", "TC", Gigacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) petacoulomb. It's defined in terms of a(n) teracoulomb.
    /// </summary>
    public static readonly ElectricalCharge Petacoulomb = new ("petacoulomb", "PC", Teracoulomb, 1000,0);
    
    /// <summary>
    /// A(n) exacoulomb. It's defined in terms of a(n) petacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Exacoulomb = new ("exacoulomb", "EC", Petacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) zettacoulomb. It's defined in terms of a(n) exacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Zettacoulomb = new ("zettacoulomb", "ZC", Exacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) yottacoulomb. It's defined in terms of a(n) zettacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Yottacoulomb = new ("yottacoulomb", "YC", Zettacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) ronnacoulomb. It's defined in terms of a(n) yottacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Ronnacoulomb = new ("ronnacoulomb", "RC", Yottacoulomb, 1000,0);
    
    /// <summary>
    /// A(n) quettacoulomb. It's defined in terms of a(n) ronnacoulomb.
    /// </summary>
    public static readonly ElectricalCharge Quettacoulomb = new ("quettacoulomb", "QC", Ronnacoulomb, 1000,0);

}