#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Data;

/// <summary>
/// Units used to measure Data for measuring Storage.
/// </summary>
public class StorageUnits : UnitOfMeasureEnumeration<StorageUnits, Storage>
{
   /// <summary>
   /// A(n) bit.
   /// </summary>
   public static readonly Storage Bit = new ("bit", "b");

   /// <summary>
   /// A(n) kilobit. Defined as: (10.0) × bit + (0).
   /// </summary>
   public static readonly Storage Kilobit = new ("kilobit", "Kb", Bit, 10.0, 0);

   /// <summary>
   /// A(n) megabit. Defined as: (1000.0) × kilobit + (0).
   /// </summary>
   public static readonly Storage Megabit = new ("megabit", "Mb", Kilobit, 1000.0, 0);

   /// <summary>
   /// A(n) gigabit. Defined as: (1000.0) × megabit + (0).
   /// </summary>
   public static readonly Storage Gigabit = new ("gigabit", "Gb", Megabit, 1000.0, 0);

   /// <summary>
   /// A(n) terabit. Defined as: (1000.0) × gigabit + (0).
   /// </summary>
   public static readonly Storage Terabit = new ("terabit", "Tb", Gigabit, 1000.0, 0);

   /// <summary>
   /// A(n) petabit. Defined as: (1000.0) × terabit + (0).
   /// </summary>
   public static readonly Storage Petabit = new ("petabit", "Pb", Terabit, 1000.0, 0);

   /// <summary>
   /// A(n) exabit. Defined as: (1000.0) × petabit + (0).
   /// </summary>
   public static readonly Storage Exabit = new ("exabit", "Eb", Petabit, 1000.0, 0);

   /// <summary>
   /// A(n) zettabit. Defined as: (1000.0) × exabit + (0).
   /// </summary>
   public static readonly Storage Zettabit = new ("zettabit", "Zb", Exabit, 1000.0, 0);

   /// <summary>
   /// A(n) yottabit. Defined as: (1000.0) × zettabit + (0).
   /// </summary>
   public static readonly Storage Yottabit = new ("yottabit", "Yb", Zettabit, 1000.0, 0);

   /// <summary>
   /// A(n) ronnabit. Defined as: (1000.0) × yottabit + (0).
   /// </summary>
   public static readonly Storage Ronnabit = new ("ronnabit", "Rb", Yottabit, 1000.0, 0);

   /// <summary>
   /// A(n) quettabit. Defined as: (1000.0) × ronnabit + (0).
   /// </summary>
   public static readonly Storage Quettabit = new ("quettabit", "Qb", Ronnabit, 1000.0, 0);

   /// <summary>
   /// A(n) kebibit. Defined as: (1024.0) × bit + (0).
   /// </summary>
   public static readonly Storage Kebibit = new ("kebibit", "Kib", Bit, 1024.0, 0);

   /// <summary>
   /// A(n) mebibit. Defined as: (1024.0) × kebibit + (0).
   /// </summary>
   public static readonly Storage Mebibit = new ("mebibit", "Mib", Kebibit, 1024.0, 0);

   /// <summary>
   /// A(n) gibibit. Defined as: (1024.0) × mebibit + (0).
   /// </summary>
   public static readonly Storage Gibibit = new ("gibibit", "Gib", Mebibit, 1024.0, 0);

   /// <summary>
   /// A(n) tebibit. Defined as: (1024.0) × gibibit + (0).
   /// </summary>
   public static readonly Storage Tebibit = new ("tebibit", "Tib", Gibibit, 1024.0, 0);

   /// <summary>
   /// A(n) pebibit. Defined as: (1024.0) × tebibit + (0).
   /// </summary>
   public static readonly Storage Pebibit = new ("pebibit", "Pib", Tebibit, 1024.0, 0);

   /// <summary>
   /// A(n) exbibit. Defined as: (1024.0) × pebibit + (0).
   /// </summary>
   public static readonly Storage Exbibit = new ("exbibit", "Eib", Pebibit, 1024.0, 0);

   /// <summary>
   /// A(n) zebibit. Defined as: (1024.0) × exbibit + (0).
   /// </summary>
   public static readonly Storage Zebibit = new ("zebibit", "Zib", Exbibit, 1024.0, 0);

   /// <summary>
   /// A(n) yobibit. Defined as: (1024.0) × zebibit + (0).
   /// </summary>
   public static readonly Storage Yobibit = new ("yobibit", "Yib", Zebibit, 1024.0, 0);

   /// <summary>
   /// A(n) robibit. Defined as: (1024.0) × yobibit + (0).
   /// </summary>
   public static readonly Storage Robibit = new ("robibit", "Rib", Yobibit, 1024.0, 0);

   /// <summary>
   /// A(n) quebibit. Defined as: (1024.0) × robibit + (0).
   /// </summary>
   public static readonly Storage Quebibit = new ("quebibit", "Qib", Robibit, 1024.0, 0);

   /// <summary>
   /// A(n) nybble. Defined as: (4d) × bit + (0).
   /// </summary>
   public static readonly Storage Nybble = new ("nybble", "n", Bit, 4d, 0);

   /// <summary>
   /// A(n) kilonybble. Defined as: (10.0) × nybble + (0).
   /// </summary>
   public static readonly Storage Kilonybble = new ("kilonybble", "Kn", Nybble, 10.0, 0);

   /// <summary>
   /// A(n) meganybble. Defined as: (1000.0) × kilonybble + (0).
   /// </summary>
   public static readonly Storage Meganybble = new ("meganybble", "Mn", Kilonybble, 1000.0, 0);

   /// <summary>
   /// A(n) giganybble. Defined as: (1000.0) × meganybble + (0).
   /// </summary>
   public static readonly Storage Giganybble = new ("giganybble", "Gn", Meganybble, 1000.0, 0);

   /// <summary>
   /// A(n) teranybble. Defined as: (1000.0) × giganybble + (0).
   /// </summary>
   public static readonly Storage Teranybble = new ("teranybble", "Tn", Giganybble, 1000.0, 0);

   /// <summary>
   /// A(n) petanybble. Defined as: (1000.0) × teranybble + (0).
   /// </summary>
   public static readonly Storage Petanybble = new ("petanybble", "Pn", Teranybble, 1000.0, 0);

   /// <summary>
   /// A(n) exanybble. Defined as: (1000.0) × petanybble + (0).
   /// </summary>
   public static readonly Storage Exanybble = new ("exanybble", "En", Petanybble, 1000.0, 0);

   /// <summary>
   /// A(n) zettanybble. Defined as: (1000.0) × exanybble + (0).
   /// </summary>
   public static readonly Storage Zettanybble = new ("zettanybble", "Zn", Exanybble, 1000.0, 0);

   /// <summary>
   /// A(n) yottanybble. Defined as: (1000.0) × zettanybble + (0).
   /// </summary>
   public static readonly Storage Yottanybble = new ("yottanybble", "Yn", Zettanybble, 1000.0, 0);

   /// <summary>
   /// A(n) ronnanybble. Defined as: (1000.0) × yottanybble + (0).
   /// </summary>
   public static readonly Storage Ronnanybble = new ("ronnanybble", "Rn", Yottanybble, 1000.0, 0);

   /// <summary>
   /// A(n) quettanybble. Defined as: (1000.0) × ronnanybble + (0).
   /// </summary>
   public static readonly Storage Quettanybble = new ("quettanybble", "Qn", Ronnanybble, 1000.0, 0);

   /// <summary>
   /// A(n) kebinybble. Defined as: (1024.0) × nybble + (0).
   /// </summary>
   public static readonly Storage Kebinybble = new ("kebinybble", "Kin", Nybble, 1024.0, 0);

   /// <summary>
   /// A(n) mebinybble. Defined as: (1024.0) × kebinybble + (0).
   /// </summary>
   public static readonly Storage Mebinybble = new ("mebinybble", "Min", Kebinybble, 1024.0, 0);

   /// <summary>
   /// A(n) gibinybble. Defined as: (1024.0) × mebinybble + (0).
   /// </summary>
   public static readonly Storage Gibinybble = new ("gibinybble", "Gin", Mebinybble, 1024.0, 0);

   /// <summary>
   /// A(n) tebinybble. Defined as: (1024.0) × gibinybble + (0).
   /// </summary>
   public static readonly Storage Tebinybble = new ("tebinybble", "Tin", Gibinybble, 1024.0, 0);

   /// <summary>
   /// A(n) pebinybble. Defined as: (1024.0) × tebinybble + (0).
   /// </summary>
   public static readonly Storage Pebinybble = new ("pebinybble", "Pin", Tebinybble, 1024.0, 0);

   /// <summary>
   /// A(n) exbinybble. Defined as: (1024.0) × pebinybble + (0).
   /// </summary>
   public static readonly Storage Exbinybble = new ("exbinybble", "Ein", Pebinybble, 1024.0, 0);

   /// <summary>
   /// A(n) zebinybble. Defined as: (1024.0) × exbinybble + (0).
   /// </summary>
   public static readonly Storage Zebinybble = new ("zebinybble", "Zin", Exbinybble, 1024.0, 0);

   /// <summary>
   /// A(n) yobinybble. Defined as: (1024.0) × zebinybble + (0).
   /// </summary>
   public static readonly Storage Yobinybble = new ("yobinybble", "Yin", Zebinybble, 1024.0, 0);

   /// <summary>
   /// A(n) robinybble. Defined as: (1024.0) × yobinybble + (0).
   /// </summary>
   public static readonly Storage Robinybble = new ("robinybble", "Rin", Yobinybble, 1024.0, 0);

   /// <summary>
   /// A(n) quebinybble. Defined as: (1024.0) × robinybble + (0).
   /// </summary>
   public static readonly Storage Quebinybble = new ("quebinybble", "Qin", Robinybble, 1024.0, 0);

   /// <summary>
   /// A(n) byte. Defined as: (2d) × nybble + (0).
   /// </summary>
   public static readonly Storage Byte = new ("byte", "B", Nybble, 2d, 0);

   /// <summary>
   /// A(n) kilobyte. Defined as: (10.0) × byte + (0).
   /// </summary>
   public static readonly Storage Kilobyte = new ("kilobyte", "KB", Byte, 10.0, 0);

   /// <summary>
   /// A(n) megabyte. Defined as: (1000.0) × kilobyte + (0).
   /// </summary>
   public static readonly Storage Megabyte = new ("megabyte", "MB", Kilobyte, 1000.0, 0);

   /// <summary>
   /// A(n) gigabyte. Defined as: (1000.0) × megabyte + (0).
   /// </summary>
   public static readonly Storage Gigabyte = new ("gigabyte", "GB", Megabyte, 1000.0, 0);

   /// <summary>
   /// A(n) terabyte. Defined as: (1000.0) × gigabyte + (0).
   /// </summary>
   public static readonly Storage Terabyte = new ("terabyte", "TB", Gigabyte, 1000.0, 0);

   /// <summary>
   /// A(n) petabyte. Defined as: (1000.0) × terabyte + (0).
   /// </summary>
   public static readonly Storage Petabyte = new ("petabyte", "PB", Terabyte, 1000.0, 0);

   /// <summary>
   /// A(n) exabyte. Defined as: (1000.0) × petabyte + (0).
   /// </summary>
   public static readonly Storage Exabyte = new ("exabyte", "EB", Petabyte, 1000.0, 0);

   /// <summary>
   /// A(n) zettabyte. Defined as: (1000.0) × exabyte + (0).
   /// </summary>
   public static readonly Storage Zettabyte = new ("zettabyte", "ZB", Exabyte, 1000.0, 0);

   /// <summary>
   /// A(n) yottabyte. Defined as: (1000.0) × zettabyte + (0).
   /// </summary>
   public static readonly Storage Yottabyte = new ("yottabyte", "YB", Zettabyte, 1000.0, 0);

   /// <summary>
   /// A(n) ronnabyte. Defined as: (1000.0) × yottabyte + (0).
   /// </summary>
   public static readonly Storage Ronnabyte = new ("ronnabyte", "RB", Yottabyte, 1000.0, 0);

   /// <summary>
   /// A(n) quettabyte. Defined as: (1000.0) × ronnabyte + (0).
   /// </summary>
   public static readonly Storage Quettabyte = new ("quettabyte", "QB", Ronnabyte, 1000.0, 0);

   /// <summary>
   /// A(n) kebibyte. Defined as: (1024.0) × byte + (0).
   /// </summary>
   public static readonly Storage Kebibyte = new ("kebibyte", "KiB", Byte, 1024.0, 0);

   /// <summary>
   /// A(n) mebibyte. Defined as: (1024.0) × kebibyte + (0).
   /// </summary>
   public static readonly Storage Mebibyte = new ("mebibyte", "MiB", Kebibyte, 1024.0, 0);

   /// <summary>
   /// A(n) gibibyte. Defined as: (1024.0) × mebibyte + (0).
   /// </summary>
   public static readonly Storage Gibibyte = new ("gibibyte", "GiB", Mebibyte, 1024.0, 0);

   /// <summary>
   /// A(n) tebibyte. Defined as: (1024.0) × gibibyte + (0).
   /// </summary>
   public static readonly Storage Tebibyte = new ("tebibyte", "TiB", Gibibyte, 1024.0, 0);

   /// <summary>
   /// A(n) pebibyte. Defined as: (1024.0) × tebibyte + (0).
   /// </summary>
   public static readonly Storage Pebibyte = new ("pebibyte", "PiB", Tebibyte, 1024.0, 0);

   /// <summary>
   /// A(n) exbibyte. Defined as: (1024.0) × pebibyte + (0).
   /// </summary>
   public static readonly Storage Exbibyte = new ("exbibyte", "EiB", Pebibyte, 1024.0, 0);

   /// <summary>
   /// A(n) zebibyte. Defined as: (1024.0) × exbibyte + (0).
   /// </summary>
   public static readonly Storage Zebibyte = new ("zebibyte", "ZiB", Exbibyte, 1024.0, 0);

   /// <summary>
   /// A(n) yobibyte. Defined as: (1024.0) × zebibyte + (0).
   /// </summary>
   public static readonly Storage Yobibyte = new ("yobibyte", "YiB", Zebibyte, 1024.0, 0);

   /// <summary>
   /// A(n) robibyte. Defined as: (1024.0) × yobibyte + (0).
   /// </summary>
   public static readonly Storage Robibyte = new ("robibyte", "RiB", Yobibyte, 1024.0, 0);

   /// <summary>
   /// A(n) quebibyte. Defined as: (1024.0) × robibyte + (0).
   /// </summary>
   public static readonly Storage Quebibyte = new ("quebibyte", "QiB", Robibyte, 1024.0, 0);
}
