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
   /// bit, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Storage Bit = new ("bit", "b", system: "Data");

   /// <summary>
   /// kilobit, defined as: bit × 1000.0
   /// </summary>
   public static readonly Storage Kilobit = new ("kilobit", "Kb", Bit, 1000.0, system: "Data");

   /// <summary>
   /// megabit, defined as: kilobit × 1000.0
   /// </summary>
   public static readonly Storage Megabit = new ("megabit", "Mb", Kilobit, 1000.0, system: "Data");

   /// <summary>
   /// gigabit, defined as: megabit × 1000.0
   /// </summary>
   public static readonly Storage Gigabit = new ("gigabit", "Gb", Megabit, 1000.0, system: "Data");

   /// <summary>
   /// terabit, defined as: gigabit × 1000.0
   /// </summary>
   public static readonly Storage Terabit = new ("terabit", "Tb", Gigabit, 1000.0, system: "Data");

   /// <summary>
   /// petabit, defined as: terabit × 1000.0
   /// </summary>
   public static readonly Storage Petabit = new ("petabit", "Pb", Terabit, 1000.0, system: "Data");

   /// <summary>
   /// exabit, defined as: petabit × 1000.0
   /// </summary>
   public static readonly Storage Exabit = new ("exabit", "Eb", Petabit, 1000.0, system: "Data");

   /// <summary>
   /// zettabit, defined as: exabit × 1000.0
   /// </summary>
   public static readonly Storage Zettabit = new ("zettabit", "Zb", Exabit, 1000.0, system: "Data");

   /// <summary>
   /// yottabit, defined as: zettabit × 1000.0
   /// </summary>
   public static readonly Storage Yottabit = new ("yottabit", "Yb", Zettabit, 1000.0, system: "Data");

   /// <summary>
   /// ronnabit, defined as: yottabit × 1000.0
   /// </summary>
   public static readonly Storage Ronnabit = new ("ronnabit", "Rb", Yottabit, 1000.0, system: "Data");

   /// <summary>
   /// quettabit, defined as: ronnabit × 1000.0
   /// </summary>
   public static readonly Storage Quettabit = new ("quettabit", "Qb", Ronnabit, 1000.0, system: "Data");

   /// <summary>
   /// kebibit, defined as: bit × 1024.0
   /// </summary>
   public static readonly Storage Kebibit = new ("kebibit", "Kib", Bit, 1024.0, system: "Data");

   /// <summary>
   /// mebibit, defined as: kebibit × 1024.0
   /// </summary>
   public static readonly Storage Mebibit = new ("mebibit", "Mib", Kebibit, 1024.0, system: "Data");

   /// <summary>
   /// gibibit, defined as: mebibit × 1024.0
   /// </summary>
   public static readonly Storage Gibibit = new ("gibibit", "Gib", Mebibit, 1024.0, system: "Data");

   /// <summary>
   /// tebibit, defined as: gibibit × 1024.0
   /// </summary>
   public static readonly Storage Tebibit = new ("tebibit", "Tib", Gibibit, 1024.0, system: "Data");

   /// <summary>
   /// pebibit, defined as: tebibit × 1024.0
   /// </summary>
   public static readonly Storage Pebibit = new ("pebibit", "Pib", Tebibit, 1024.0, system: "Data");

   /// <summary>
   /// exbibit, defined as: pebibit × 1024.0
   /// </summary>
   public static readonly Storage Exbibit = new ("exbibit", "Eib", Pebibit, 1024.0, system: "Data");

   /// <summary>
   /// zebibit, defined as: exbibit × 1024.0
   /// </summary>
   public static readonly Storage Zebibit = new ("zebibit", "Zib", Exbibit, 1024.0, system: "Data");

   /// <summary>
   /// yobibit, defined as: zebibit × 1024.0
   /// </summary>
   public static readonly Storage Yobibit = new ("yobibit", "Yib", Zebibit, 1024.0, system: "Data");

   /// <summary>
   /// robibit, defined as: yobibit × 1024.0
   /// </summary>
   public static readonly Storage Robibit = new ("robibit", "Rib", Yobibit, 1024.0, system: "Data");

   /// <summary>
   /// quebibit, defined as: robibit × 1024.0
   /// </summary>
   public static readonly Storage Quebibit = new ("quebibit", "Qib", Robibit, 1024.0, system: "Data");

   /// <summary>
   /// nybble, defined as: bit × 4d
   /// </summary>
   public static readonly Storage Nybble = new ("nybble", "n", Bit, 4d, system: "Data");

   /// <summary>
   /// kilonybble, defined as: nybble × 1000.0
   /// </summary>
   public static readonly Storage Kilonybble = new ("kilonybble", "Kn", Nybble, 1000.0, system: "Data");

   /// <summary>
   /// meganybble, defined as: kilonybble × 1000.0
   /// </summary>
   public static readonly Storage Meganybble = new ("meganybble", "Mn", Kilonybble, 1000.0, system: "Data");

   /// <summary>
   /// giganybble, defined as: meganybble × 1000.0
   /// </summary>
   public static readonly Storage Giganybble = new ("giganybble", "Gn", Meganybble, 1000.0, system: "Data");

   /// <summary>
   /// teranybble, defined as: giganybble × 1000.0
   /// </summary>
   public static readonly Storage Teranybble = new ("teranybble", "Tn", Giganybble, 1000.0, system: "Data");

   /// <summary>
   /// petanybble, defined as: teranybble × 1000.0
   /// </summary>
   public static readonly Storage Petanybble = new ("petanybble", "Pn", Teranybble, 1000.0, system: "Data");

   /// <summary>
   /// exanybble, defined as: petanybble × 1000.0
   /// </summary>
   public static readonly Storage Exanybble = new ("exanybble", "En", Petanybble, 1000.0, system: "Data");

   /// <summary>
   /// zettanybble, defined as: exanybble × 1000.0
   /// </summary>
   public static readonly Storage Zettanybble = new ("zettanybble", "Zn", Exanybble, 1000.0, system: "Data");

   /// <summary>
   /// yottanybble, defined as: zettanybble × 1000.0
   /// </summary>
   public static readonly Storage Yottanybble = new ("yottanybble", "Yn", Zettanybble, 1000.0, system: "Data");

   /// <summary>
   /// ronnanybble, defined as: yottanybble × 1000.0
   /// </summary>
   public static readonly Storage Ronnanybble = new ("ronnanybble", "Rn", Yottanybble, 1000.0, system: "Data");

   /// <summary>
   /// quettanybble, defined as: ronnanybble × 1000.0
   /// </summary>
   public static readonly Storage Quettanybble = new ("quettanybble", "Qn", Ronnanybble, 1000.0, system: "Data");

   /// <summary>
   /// kebinybble, defined as: nybble × 1024.0
   /// </summary>
   public static readonly Storage Kebinybble = new ("kebinybble", "Kin", Nybble, 1024.0, system: "Data");

   /// <summary>
   /// mebinybble, defined as: kebinybble × 1024.0
   /// </summary>
   public static readonly Storage Mebinybble = new ("mebinybble", "Min", Kebinybble, 1024.0, system: "Data");

   /// <summary>
   /// gibinybble, defined as: mebinybble × 1024.0
   /// </summary>
   public static readonly Storage Gibinybble = new ("gibinybble", "Gin", Mebinybble, 1024.0, system: "Data");

   /// <summary>
   /// tebinybble, defined as: gibinybble × 1024.0
   /// </summary>
   public static readonly Storage Tebinybble = new ("tebinybble", "Tin", Gibinybble, 1024.0, system: "Data");

   /// <summary>
   /// pebinybble, defined as: tebinybble × 1024.0
   /// </summary>
   public static readonly Storage Pebinybble = new ("pebinybble", "Pin", Tebinybble, 1024.0, system: "Data");

   /// <summary>
   /// exbinybble, defined as: pebinybble × 1024.0
   /// </summary>
   public static readonly Storage Exbinybble = new ("exbinybble", "Ein", Pebinybble, 1024.0, system: "Data");

   /// <summary>
   /// zebinybble, defined as: exbinybble × 1024.0
   /// </summary>
   public static readonly Storage Zebinybble = new ("zebinybble", "Zin", Exbinybble, 1024.0, system: "Data");

   /// <summary>
   /// yobinybble, defined as: zebinybble × 1024.0
   /// </summary>
   public static readonly Storage Yobinybble = new ("yobinybble", "Yin", Zebinybble, 1024.0, system: "Data");

   /// <summary>
   /// robinybble, defined as: yobinybble × 1024.0
   /// </summary>
   public static readonly Storage Robinybble = new ("robinybble", "Rin", Yobinybble, 1024.0, system: "Data");

   /// <summary>
   /// quebinybble, defined as: robinybble × 1024.0
   /// </summary>
   public static readonly Storage Quebinybble = new ("quebinybble", "Qin", Robinybble, 1024.0, system: "Data");

   /// <summary>
   /// byte, defined as: nybble × 2d
   /// </summary>
   public static readonly Storage Byte = new ("byte", "B", Nybble, 2d, system: "Data");

   /// <summary>
   /// kilobyte, defined as: byte × 1000.0
   /// </summary>
   public static readonly Storage Kilobyte = new ("kilobyte", "KB", Byte, 1000.0, system: "Data");

   /// <summary>
   /// megabyte, defined as: kilobyte × 1000.0
   /// </summary>
   public static readonly Storage Megabyte = new ("megabyte", "MB", Kilobyte, 1000.0, system: "Data");

   /// <summary>
   /// gigabyte, defined as: megabyte × 1000.0
   /// </summary>
   public static readonly Storage Gigabyte = new ("gigabyte", "GB", Megabyte, 1000.0, system: "Data");

   /// <summary>
   /// terabyte, defined as: gigabyte × 1000.0
   /// </summary>
   public static readonly Storage Terabyte = new ("terabyte", "TB", Gigabyte, 1000.0, system: "Data");

   /// <summary>
   /// petabyte, defined as: terabyte × 1000.0
   /// </summary>
   public static readonly Storage Petabyte = new ("petabyte", "PB", Terabyte, 1000.0, system: "Data");

   /// <summary>
   /// exabyte, defined as: petabyte × 1000.0
   /// </summary>
   public static readonly Storage Exabyte = new ("exabyte", "EB", Petabyte, 1000.0, system: "Data");

   /// <summary>
   /// zettabyte, defined as: exabyte × 1000.0
   /// </summary>
   public static readonly Storage Zettabyte = new ("zettabyte", "ZB", Exabyte, 1000.0, system: "Data");

   /// <summary>
   /// yottabyte, defined as: zettabyte × 1000.0
   /// </summary>
   public static readonly Storage Yottabyte = new ("yottabyte", "YB", Zettabyte, 1000.0, system: "Data");

   /// <summary>
   /// ronnabyte, defined as: yottabyte × 1000.0
   /// </summary>
   public static readonly Storage Ronnabyte = new ("ronnabyte", "RB", Yottabyte, 1000.0, system: "Data");

   /// <summary>
   /// quettabyte, defined as: ronnabyte × 1000.0
   /// </summary>
   public static readonly Storage Quettabyte = new ("quettabyte", "QB", Ronnabyte, 1000.0, system: "Data");

   /// <summary>
   /// kebibyte, defined as: byte × 1024.0
   /// </summary>
   public static readonly Storage Kebibyte = new ("kebibyte", "KiB", Byte, 1024.0, system: "Data");

   /// <summary>
   /// mebibyte, defined as: kebibyte × 1024.0
   /// </summary>
   public static readonly Storage Mebibyte = new ("mebibyte", "MiB", Kebibyte, 1024.0, system: "Data");

   /// <summary>
   /// gibibyte, defined as: mebibyte × 1024.0
   /// </summary>
   public static readonly Storage Gibibyte = new ("gibibyte", "GiB", Mebibyte, 1024.0, system: "Data");

   /// <summary>
   /// tebibyte, defined as: gibibyte × 1024.0
   /// </summary>
   public static readonly Storage Tebibyte = new ("tebibyte", "TiB", Gibibyte, 1024.0, system: "Data");

   /// <summary>
   /// pebibyte, defined as: tebibyte × 1024.0
   /// </summary>
   public static readonly Storage Pebibyte = new ("pebibyte", "PiB", Tebibyte, 1024.0, system: "Data");

   /// <summary>
   /// exbibyte, defined as: pebibyte × 1024.0
   /// </summary>
   public static readonly Storage Exbibyte = new ("exbibyte", "EiB", Pebibyte, 1024.0, system: "Data");

   /// <summary>
   /// zebibyte, defined as: exbibyte × 1024.0
   /// </summary>
   public static readonly Storage Zebibyte = new ("zebibyte", "ZiB", Exbibyte, 1024.0, system: "Data");

   /// <summary>
   /// yobibyte, defined as: zebibyte × 1024.0
   /// </summary>
   public static readonly Storage Yobibyte = new ("yobibyte", "YiB", Zebibyte, 1024.0, system: "Data");

   /// <summary>
   /// robibyte, defined as: yobibyte × 1024.0
   /// </summary>
   public static readonly Storage Robibyte = new ("robibyte", "RiB", Yobibyte, 1024.0, system: "Data");

   /// <summary>
   /// quebibyte, defined as: robibyte × 1024.0
   /// </summary>
   public static readonly Storage Quebibyte = new ("quebibyte", "QiB", Robibyte, 1024.0, system: "Data");
}
