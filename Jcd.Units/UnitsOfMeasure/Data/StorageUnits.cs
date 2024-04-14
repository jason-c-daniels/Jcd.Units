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
   public static readonly Storage Bit = new("bit", "b", system: "Data");
   
   /// <summary>
   /// kilobit defined such that: bit = Kb × 1000.0.
   /// </summary>
   public static readonly Storage Kilobit = new("kilobit", "Kb", Bit, 1000.0, system: "Data");
   
   /// <summary>
   /// megabit defined such that: kilobit = Mb × 1000.0.
   /// </summary>
   public static readonly Storage Megabit = new("megabit", "Mb", Kilobit, 1000.0, system: "Data");
   
   /// <summary>
   /// gigabit defined such that: megabit = Gb × 1000.0.
   /// </summary>
   public static readonly Storage Gigabit = new("gigabit", "Gb", Megabit, 1000.0, system: "Data");
   
   /// <summary>
   /// terabit defined such that: gigabit = Tb × 1000.0.
   /// </summary>
   public static readonly Storage Terabit = new("terabit", "Tb", Gigabit, 1000.0, system: "Data");
   
   /// <summary>
   /// petabit defined such that: terabit = Pb × 1000.0.
   /// </summary>
   public static readonly Storage Petabit = new("petabit", "Pb", Terabit, 1000.0, system: "Data");
   
   /// <summary>
   /// exabit defined such that: petabit = Eb × 1000.0.
   /// </summary>
   public static readonly Storage Exabit = new("exabit", "Eb", Petabit, 1000.0, system: "Data");
   
   /// <summary>
   /// zettabit defined such that: exabit = Zb × 1000.0.
   /// </summary>
   public static readonly Storage Zettabit = new("zettabit", "Zb", Exabit, 1000.0, system: "Data");
   
   /// <summary>
   /// yottabit defined such that: zettabit = Yb × 1000.0.
   /// </summary>
   public static readonly Storage Yottabit = new("yottabit", "Yb", Zettabit, 1000.0, system: "Data");
   
   /// <summary>
   /// ronnabit defined such that: yottabit = Rb × 1000.0.
   /// </summary>
   public static readonly Storage Ronnabit = new("ronnabit", "Rb", Yottabit, 1000.0, system: "Data");
   
   /// <summary>
   /// quettabit defined such that: ronnabit = Qb × 1000.0.
   /// </summary>
   public static readonly Storage Quettabit = new("quettabit", "Qb", Ronnabit, 1000.0, system: "Data");
   
   /// <summary>
   /// kebibit defined such that: bit = Kib × 1024.0.
   /// </summary>
   public static readonly Storage Kebibit = new("kebibit", "Kib", Bit, 1024.0, system: "Data");
   
   /// <summary>
   /// mebibit defined such that: kebibit = Mib × 1024.0.
   /// </summary>
   public static readonly Storage Mebibit = new("mebibit", "Mib", Kebibit, 1024.0, system: "Data");
   
   /// <summary>
   /// gibibit defined such that: mebibit = Gib × 1024.0.
   /// </summary>
   public static readonly Storage Gibibit = new("gibibit", "Gib", Mebibit, 1024.0, system: "Data");
   
   /// <summary>
   /// tebibit defined such that: gibibit = Tib × 1024.0.
   /// </summary>
   public static readonly Storage Tebibit = new("tebibit", "Tib", Gibibit, 1024.0, system: "Data");
   
   /// <summary>
   /// pebibit defined such that: tebibit = Pib × 1024.0.
   /// </summary>
   public static readonly Storage Pebibit = new("pebibit", "Pib", Tebibit, 1024.0, system: "Data");
   
   /// <summary>
   /// exbibit defined such that: pebibit = Eib × 1024.0.
   /// </summary>
   public static readonly Storage Exbibit = new("exbibit", "Eib", Pebibit, 1024.0, system: "Data");
   
   /// <summary>
   /// zebibit defined such that: exbibit = Zib × 1024.0.
   /// </summary>
   public static readonly Storage Zebibit = new("zebibit", "Zib", Exbibit, 1024.0, system: "Data");
   
   /// <summary>
   /// yobibit defined such that: zebibit = Yib × 1024.0.
   /// </summary>
   public static readonly Storage Yobibit = new("yobibit", "Yib", Zebibit, 1024.0, system: "Data");
   
   /// <summary>
   /// robibit defined such that: yobibit = Rib × 1024.0.
   /// </summary>
   public static readonly Storage Robibit = new("robibit", "Rib", Yobibit, 1024.0, system: "Data");
   
   /// <summary>
   /// quebibit defined such that: robibit = Qib × 1024.0.
   /// </summary>
   public static readonly Storage Quebibit = new("quebibit", "Qib", Robibit, 1024.0, system: "Data");
   
   /// <summary>
   /// nybble defined such that: bit = n × 4d.
   /// </summary>
   public static readonly Storage Nybble = new("nybble", "n", Bit, 4d, system: "Data");
   
   /// <summary>
   /// kilonybble defined such that: nybble = Kn × 1000.0.
   /// </summary>
   public static readonly Storage Kilonybble = new("kilonybble", "Kn", Nybble, 1000.0, system: "Data");
   
   /// <summary>
   /// meganybble defined such that: kilonybble = Mn × 1000.0.
   /// </summary>
   public static readonly Storage Meganybble = new("meganybble", "Mn", Kilonybble, 1000.0, system: "Data");
   
   /// <summary>
   /// giganybble defined such that: meganybble = Gn × 1000.0.
   /// </summary>
   public static readonly Storage Giganybble = new("giganybble", "Gn", Meganybble, 1000.0, system: "Data");
   
   /// <summary>
   /// teranybble defined such that: giganybble = Tn × 1000.0.
   /// </summary>
   public static readonly Storage Teranybble = new("teranybble", "Tn", Giganybble, 1000.0, system: "Data");
   
   /// <summary>
   /// petanybble defined such that: teranybble = Pn × 1000.0.
   /// </summary>
   public static readonly Storage Petanybble = new("petanybble", "Pn", Teranybble, 1000.0, system: "Data");
   
   /// <summary>
   /// exanybble defined such that: petanybble = En × 1000.0.
   /// </summary>
   public static readonly Storage Exanybble = new("exanybble", "En", Petanybble, 1000.0, system: "Data");
   
   /// <summary>
   /// zettanybble defined such that: exanybble = Zn × 1000.0.
   /// </summary>
   public static readonly Storage Zettanybble = new("zettanybble", "Zn", Exanybble, 1000.0, system: "Data");
   
   /// <summary>
   /// yottanybble defined such that: zettanybble = Yn × 1000.0.
   /// </summary>
   public static readonly Storage Yottanybble = new("yottanybble", "Yn", Zettanybble, 1000.0, system: "Data");
   
   /// <summary>
   /// ronnanybble defined such that: yottanybble = Rn × 1000.0.
   /// </summary>
   public static readonly Storage Ronnanybble = new("ronnanybble", "Rn", Yottanybble, 1000.0, system: "Data");
   
   /// <summary>
   /// quettanybble defined such that: ronnanybble = Qn × 1000.0.
   /// </summary>
   public static readonly Storage Quettanybble = new("quettanybble", "Qn", Ronnanybble, 1000.0, system: "Data");
   
   /// <summary>
   /// kebinybble defined such that: nybble = Kin × 1024.0.
   /// </summary>
   public static readonly Storage Kebinybble = new("kebinybble", "Kin", Nybble, 1024.0, system: "Data");
   
   /// <summary>
   /// mebinybble defined such that: kebinybble = Min × 1024.0.
   /// </summary>
   public static readonly Storage Mebinybble = new("mebinybble", "Min", Kebinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// gibinybble defined such that: mebinybble = Gin × 1024.0.
   /// </summary>
   public static readonly Storage Gibinybble = new("gibinybble", "Gin", Mebinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// tebinybble defined such that: gibinybble = Tin × 1024.0.
   /// </summary>
   public static readonly Storage Tebinybble = new("tebinybble", "Tin", Gibinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// pebinybble defined such that: tebinybble = Pin × 1024.0.
   /// </summary>
   public static readonly Storage Pebinybble = new("pebinybble", "Pin", Tebinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// exbinybble defined such that: pebinybble = Ein × 1024.0.
   /// </summary>
   public static readonly Storage Exbinybble = new("exbinybble", "Ein", Pebinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// zebinybble defined such that: exbinybble = Zin × 1024.0.
   /// </summary>
   public static readonly Storage Zebinybble = new("zebinybble", "Zin", Exbinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// yobinybble defined such that: zebinybble = Yin × 1024.0.
   /// </summary>
   public static readonly Storage Yobinybble = new("yobinybble", "Yin", Zebinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// robinybble defined such that: yobinybble = Rin × 1024.0.
   /// </summary>
   public static readonly Storage Robinybble = new("robinybble", "Rin", Yobinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// quebinybble defined such that: robinybble = Qin × 1024.0.
   /// </summary>
   public static readonly Storage Quebinybble = new("quebinybble", "Qin", Robinybble, 1024.0, system: "Data");
   
   /// <summary>
   /// byte defined such that: nybble = B × 2d.
   /// </summary>
   public static readonly Storage Byte = new("byte", "B", Nybble, 2d, system: "Data");
   
   /// <summary>
   /// kilobyte defined such that: byte = KB × 1000.0.
   /// </summary>
   public static readonly Storage Kilobyte = new("kilobyte", "KB", Byte, 1000.0, system: "Data");
   
   /// <summary>
   /// megabyte defined such that: kilobyte = MB × 1000.0.
   /// </summary>
   public static readonly Storage Megabyte = new("megabyte", "MB", Kilobyte, 1000.0, system: "Data");
   
   /// <summary>
   /// gigabyte defined such that: megabyte = GB × 1000.0.
   /// </summary>
   public static readonly Storage Gigabyte = new("gigabyte", "GB", Megabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// terabyte defined such that: gigabyte = TB × 1000.0.
   /// </summary>
   public static readonly Storage Terabyte = new("terabyte", "TB", Gigabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// petabyte defined such that: terabyte = PB × 1000.0.
   /// </summary>
   public static readonly Storage Petabyte = new("petabyte", "PB", Terabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// exabyte defined such that: petabyte = EB × 1000.0.
   /// </summary>
   public static readonly Storage Exabyte = new("exabyte", "EB", Petabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// zettabyte defined such that: exabyte = ZB × 1000.0.
   /// </summary>
   public static readonly Storage Zettabyte = new("zettabyte", "ZB", Exabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// yottabyte defined such that: zettabyte = YB × 1000.0.
   /// </summary>
   public static readonly Storage Yottabyte = new("yottabyte", "YB", Zettabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// ronnabyte defined such that: yottabyte = RB × 1000.0.
   /// </summary>
   public static readonly Storage Ronnabyte = new("ronnabyte", "RB", Yottabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// quettabyte defined such that: ronnabyte = QB × 1000.0.
   /// </summary>
   public static readonly Storage Quettabyte = new("quettabyte", "QB", Ronnabyte, 1000.0, system: "Data");
   
   /// <summary>
   /// kebibyte defined such that: byte = KiB × 1024.0.
   /// </summary>
   public static readonly Storage Kebibyte = new("kebibyte", "KiB", Byte, 1024.0, system: "Data");
   
   /// <summary>
   /// mebibyte defined such that: kebibyte = MiB × 1024.0.
   /// </summary>
   public static readonly Storage Mebibyte = new("mebibyte", "MiB", Kebibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// gibibyte defined such that: mebibyte = GiB × 1024.0.
   /// </summary>
   public static readonly Storage Gibibyte = new("gibibyte", "GiB", Mebibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// tebibyte defined such that: gibibyte = TiB × 1024.0.
   /// </summary>
   public static readonly Storage Tebibyte = new("tebibyte", "TiB", Gibibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// pebibyte defined such that: tebibyte = PiB × 1024.0.
   /// </summary>
   public static readonly Storage Pebibyte = new("pebibyte", "PiB", Tebibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// exbibyte defined such that: pebibyte = EiB × 1024.0.
   /// </summary>
   public static readonly Storage Exbibyte = new("exbibyte", "EiB", Pebibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// zebibyte defined such that: exbibyte = ZiB × 1024.0.
   /// </summary>
   public static readonly Storage Zebibyte = new("zebibyte", "ZiB", Exbibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// yobibyte defined such that: zebibyte = YiB × 1024.0.
   /// </summary>
   public static readonly Storage Yobibyte = new("yobibyte", "YiB", Zebibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// robibyte defined such that: yobibyte = RiB × 1024.0.
   /// </summary>
   public static readonly Storage Robibyte = new("robibyte", "RiB", Yobibyte, 1024.0, system: "Data");
   
   /// <summary>
   /// quebibyte defined such that: robibyte = QiB × 1024.0.
   /// </summary>
   public static readonly Storage Quebibyte = new("quebibyte", "QiB", Robibyte, 1024.0, system: "Data");
}