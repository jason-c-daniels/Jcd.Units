#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Frequency.
/// </summary>
public class Frequencies : UnitOfMeasureEnumeration<Frequencies, Frequency>
{
   /// <summary>
   /// A(n) hertz.
   /// </summary>
   public static readonly Frequency Hertz = new ("hertz", "Hz");

   /// <summary>
   /// A(n) decihertz. Defined as: 1.0/10.0 × hertz.
   /// </summary>
   public static readonly Frequency Decihertz = new ("decihertz", "dHz", Hertz, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centihertz. Defined as: 1.0/10.0 × decihertz.
   /// </summary>
   public static readonly Frequency Centihertz = new ("centihertz", "cHz", Decihertz, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millihertz. Defined as: 1.0/10.0 × centihertz.
   /// </summary>
   public static readonly Frequency Millihertz = new ("millihertz", "mHz", Centihertz, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microhertz. Defined as: 1.0/1000.0 × millihertz.
   /// </summary>
   public static readonly Frequency Microhertz = new ("microhertz", "μHz", Millihertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanohertz. Defined as: 1.0/1000.0 × microhertz.
   /// </summary>
   public static readonly Frequency Nanohertz = new ("nanohertz", "nHz", Microhertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picohertz. Defined as: 1.0/1000.0 × nanohertz.
   /// </summary>
   public static readonly Frequency Picohertz = new ("picohertz", "pHz", Nanohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtohertz. Defined as: 1.0/1000.0 × picohertz.
   /// </summary>
   public static readonly Frequency Femtohertz = new ("femtohertz", "fHz", Picohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attohertz. Defined as: 1.0/1000.0 × femtohertz.
   /// </summary>
   public static readonly Frequency Attohertz = new ("attohertz", "aHz", Femtohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptohertz. Defined as: 1.0/1000.0 × attohertz.
   /// </summary>
   public static readonly Frequency Zeptohertz = new ("zeptohertz", "zHz", Attohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctohertz. Defined as: 1.0/1000.0 × zeptohertz.
   /// </summary>
   public static readonly Frequency Yoctohertz = new ("yoctohertz", "yHz", Zeptohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontohertz. Defined as: 1.0/1000.0 × yoctohertz.
   /// </summary>
   public static readonly Frequency Rontohertz = new ("rontohertz", "rHz", Yoctohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectohertz. Defined as: 1.0/1000.0 × rontohertz.
   /// </summary>
   public static readonly Frequency Quectohertz = new ("quectohertz", "qHz", Rontohertz, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekahertz. Defined as: 10.0 × hertz.
   /// </summary>
   public static readonly Frequency Dekahertz = new ("dekahertz", "daHz", Hertz, 10.0, 0);

   /// <summary>
   /// A(n) hectohertz. Defined as: 10.0 × dekahertz.
   /// </summary>
   public static readonly Frequency Hectohertz = new ("hectohertz", "hHz", Dekahertz, 10.0, 0);

   /// <summary>
   /// A(n) kilohertz. Defined as: 10.0 × hectohertz.
   /// </summary>
   public static readonly Frequency Kilohertz = new ("kilohertz", "kHz", Hectohertz, 10.0, 0);

   /// <summary>
   /// A(n) megahertz. Defined as: 1000.0 × kilohertz.
   /// </summary>
   public static readonly Frequency Megahertz = new ("megahertz", "MHz", Kilohertz, 1000.0, 0);

   /// <summary>
   /// A(n) gigahertz. Defined as: 1000.0 × megahertz.
   /// </summary>
   public static readonly Frequency Gigahertz = new ("gigahertz", "GHz", Megahertz, 1000.0, 0);

   /// <summary>
   /// A(n) terahertz. Defined as: 1000.0 × gigahertz.
   /// </summary>
   public static readonly Frequency Terahertz = new ("terahertz", "THz", Gigahertz, 1000.0, 0);

   /// <summary>
   /// A(n) petahertz. Defined as: 1000.0 × terahertz.
   /// </summary>
   public static readonly Frequency Petahertz = new ("petahertz", "PHz", Terahertz, 1000.0, 0);

   /// <summary>
   /// A(n) exahertz. Defined as: 1000.0 × petahertz.
   /// </summary>
   public static readonly Frequency Exahertz = new ("exahertz", "EHz", Petahertz, 1000.0, 0);

   /// <summary>
   /// A(n) zettahertz. Defined as: 1000.0 × exahertz.
   /// </summary>
   public static readonly Frequency Zettahertz = new ("zettahertz", "ZHz", Exahertz, 1000.0, 0);

   /// <summary>
   /// A(n) yottahertz. Defined as: 1000.0 × zettahertz.
   /// </summary>
   public static readonly Frequency Yottahertz = new ("yottahertz", "YHz", Zettahertz, 1000.0, 0);

   /// <summary>
   /// A(n) ronnahertz. Defined as: 1000.0 × yottahertz.
   /// </summary>
   public static readonly Frequency Ronnahertz = new ("ronnahertz", "RHz", Yottahertz, 1000.0, 0);

   /// <summary>
   /// A(n) quettahertz. Defined as: 1000.0 × ronnahertz.
   /// </summary>
   public static readonly Frequency Quettahertz = new ("quettahertz", "QHz", Ronnahertz, 1000.0, 0);
}
