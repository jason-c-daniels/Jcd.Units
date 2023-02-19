using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : Enumeration<ElectricalCurrents,ElectricalCurrent>
{


    /// <summary>
    /// A(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Ampere = new ("ampere", "A");
    /// <summary>
    /// A(n) deciampere. It's defined in terms of a(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centiampere. It's defined in terms of a(n) deciampere.
    /// </summary>
    public static readonly ElectricalCurrent Centiampere = new ("centiampere", "cA", Deciampere, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) milliampere. It's defined in terms of a(n) centiampere.
    /// </summary>
    public static readonly ElectricalCurrent Milliampere = new ("milliampere", "mA", Centiampere, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microampere. It's defined in terms of a(n) milliampere.
    /// </summary>
    public static readonly ElectricalCurrent Microampere = new ("microampere", "μA", Milliampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanoampere. It's defined in terms of a(n) microampere.
    /// </summary>
    public static readonly ElectricalCurrent Nanoampere = new ("nanoampere", "nA", Microampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picoampere. It's defined in terms of a(n) nanoampere.
    /// </summary>
    public static readonly ElectricalCurrent Picoampere = new ("picoampere", "pA", Nanoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtoampere. It's defined in terms of a(n) picoampere.
    /// </summary>
    public static readonly ElectricalCurrent Femtoampere = new ("femtoampere", "fA", Picoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attoampere. It's defined in terms of a(n) femtoampere.
    /// </summary>
    public static readonly ElectricalCurrent Attoampere = new ("attoampere", "aA", Femtoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptoampere. It's defined in terms of a(n) attoampere.
    /// </summary>
    public static readonly ElectricalCurrent Zeptoampere = new ("zeptoampere", "zA", Attoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctoampere. It's defined in terms of a(n) zeptoampere.
    /// </summary>
    public static readonly ElectricalCurrent Yoctoampere = new ("yoctoampere", "yA", Zeptoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontoampere. It's defined in terms of a(n) yoctoampere.
    /// </summary>
    public static readonly ElectricalCurrent Rontoampere = new ("rontoampere", "rA", Yoctoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectoampere. It's defined in terms of a(n) rontoampere.
    /// </summary>
    public static readonly ElectricalCurrent Quectoampere = new ("quectoampere", "qA", Rontoampere, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekaampere. It's defined in terms of a(n) ampere.
    /// </summary>
    public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10,0);
    
    /// <summary>
    /// A(n) hectoampere. It's defined in terms of a(n) dekaampere.
    /// </summary>
    public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10,0);
    
    /// <summary>
    /// A(n) kiloampere. It's defined in terms of a(n) hectoampere.
    /// </summary>
    public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10,0);
    
    /// <summary>
    /// A(n) megaampere. It's defined in terms of a(n) kiloampere.
    /// </summary>
    public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000,0);
    
    /// <summary>
    /// A(n) gigaampere. It's defined in terms of a(n) megaampere.
    /// </summary>
    public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000,0);
    
    /// <summary>
    /// A(n) teraampere. It's defined in terms of a(n) gigaampere.
    /// </summary>
    public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000,0);
    
    /// <summary>
    /// A(n) petaampere. It's defined in terms of a(n) teraampere.
    /// </summary>
    public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000,0);
    
    /// <summary>
    /// A(n) exaampere. It's defined in terms of a(n) petaampere.
    /// </summary>
    public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000,0);
    
    /// <summary>
    /// A(n) zettaampere. It's defined in terms of a(n) exaampere.
    /// </summary>
    public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000,0);
    
    /// <summary>
    /// A(n) yottaampere. It's defined in terms of a(n) zettaampere.
    /// </summary>
    public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000,0);
    
    /// <summary>
    /// A(n) ronnaampere. It's defined in terms of a(n) yottaampere.
    /// </summary>
    public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000,0);
    
    /// <summary>
    /// A(n) quettaampere. It's defined in terms of a(n) ronnaampere.
    /// </summary>
    public static readonly ElectricalCurrent Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000,0);

}