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
/// Units used to measure Data for measuring Transfer Rate.
/// </summary>
public class TransferRates : UnitOfMeasureEnumeration<TransferRates, TransferRate>
{
   /// <summary>
   /// bits per second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly TransferRate BitsPerSecond = new ("bits per second", "b/s", system: "Data");

   /// <summary>
   /// kilobits per second, defined as: bits per second × 1000.0
   /// </summary>
   public static readonly TransferRate KilobitsPerSecond = new (
                                                                "kilobits per second"
                                                              , "Kb/s"
                                                              , BitsPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// megabits per second, defined as: kilobits per second × 1000.0
   /// </summary>
   public static readonly TransferRate MegabitsPerSecond = new (
                                                                "megabits per second"
                                                              , "Mb/s"
                                                              , KilobitsPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// gigabits per second, defined as: megabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate GigabitsPerSecond = new (
                                                                "gigabits per second"
                                                              , "Gb/s"
                                                              , MegabitsPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// terabits per second, defined as: gigabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate TerabitsPerSecond = new (
                                                                "terabits per second"
                                                              , "Tb/s"
                                                              , GigabitsPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// petabits per second, defined as: terabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate PetabitsPerSecond = new (
                                                                "petabits per second"
                                                              , "Pb/s"
                                                              , TerabitsPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// exabits per second, defined as: petabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate ExabitsPerSecond = new (
                                                               "exabits per second"
                                                             , "Eb/s"
                                                             , PetabitsPerSecond
                                                             , 1000.0
                                                             , system: "Data"
                                                              );

   /// <summary>
   /// zettabits per second, defined as: exabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate ZettabitsPerSecond =
            new ("zettabits per second", "Zb/s", ExabitsPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// yottabits per second, defined as: zettabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate YottabitsPerSecond =
            new ("yottabits per second", "Yb/s", ZettabitsPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// ronnabits per second, defined as: yottabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate RonnabitsPerSecond =
            new ("ronnabits per second", "Rb/s", YottabitsPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// quettabits per second, defined as: ronnabits per second × 1000.0
   /// </summary>
   public static readonly TransferRate QuettabitsPerSecond =
            new ("quettabits per second", "Qb/s", RonnabitsPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// kebibits per second, defined as: bits per second × 1024.0
   /// </summary>
   public static readonly TransferRate KebibitsPerSecond = new (
                                                                "kebibits per second"
                                                              , "Kib/s"
                                                              , BitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// mebibits per second, defined as: kebibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate MebibitsPerSecond = new (
                                                                "mebibits per second"
                                                              , "Mib/s"
                                                              , KebibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// gibibits per second, defined as: mebibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate GibibitsPerSecond = new (
                                                                "gibibits per second"
                                                              , "Gib/s"
                                                              , MebibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// tebibits per second, defined as: gibibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate TebibitsPerSecond = new (
                                                                "tebibits per second"
                                                              , "Tib/s"
                                                              , GibibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// pebibits per second, defined as: tebibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate PebibitsPerSecond = new (
                                                                "pebibits per second"
                                                              , "Pib/s"
                                                              , TebibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// exbibits per second, defined as: pebibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate ExbibitsPerSecond = new (
                                                                "exbibits per second"
                                                              , "Eib/s"
                                                              , PebibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// zebibits per second, defined as: exbibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate ZebibitsPerSecond = new (
                                                                "zebibits per second"
                                                              , "Zib/s"
                                                              , ExbibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// yobibits per second, defined as: zebibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate YobibitsPerSecond = new (
                                                                "yobibits per second"
                                                              , "Yib/s"
                                                              , ZebibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// robibits per second, defined as: yobibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate RobibitsPerSecond = new (
                                                                "robibits per second"
                                                              , "Rib/s"
                                                              , YobibitsPerSecond
                                                              , 1024.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// quebibits per second, defined as: robibits per second × 1024.0
   /// </summary>
   public static readonly TransferRate QuebibitsPerSecond =
            new ("quebibits per second", "Qib/s", RobibitsPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// nybbles per second, defined as: bits per second × 4d
   /// </summary>
   public static readonly TransferRate NybblesPerSecond = new (
                                                               "nybbles per second"
                                                             , "n/s"
                                                             , BitsPerSecond
                                                             , 4d
                                                             , system: "Data"
                                                              );

   /// <summary>
   /// kilonybbles per second, defined as: nybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate KilonybblesPerSecond =
            new ("kilonybbles per second", "Kn/s", NybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// meganybbles per second, defined as: kilonybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate MeganybblesPerSecond =
            new ("meganybbles per second", "Mn/s", KilonybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// giganybbles per second, defined as: meganybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate GiganybblesPerSecond =
            new ("giganybbles per second", "Gn/s", MeganybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// teranybbles per second, defined as: giganybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate TeranybblesPerSecond =
            new ("teranybbles per second", "Tn/s", GiganybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// petanybbles per second, defined as: teranybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate PetanybblesPerSecond =
            new ("petanybbles per second", "Pn/s", TeranybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// exanybbles per second, defined as: petanybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate ExanybblesPerSecond =
            new ("exanybbles per second", "En/s", PetanybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// zettanybbles per second, defined as: exanybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate ZettanybblesPerSecond =
            new ("zettanybbles per second", "Zn/s", ExanybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// yottanybbles per second, defined as: zettanybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate YottanybblesPerSecond =
            new ("yottanybbles per second", "Yn/s", ZettanybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// ronnanybbles per second, defined as: yottanybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate RonnanybblesPerSecond =
            new ("ronnanybbles per second", "Rn/s", YottanybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// quettanybbles per second, defined as: ronnanybbles per second × 1000.0
   /// </summary>
   public static readonly TransferRate QuettanybblesPerSecond =
            new ("quettanybbles per second", "Qn/s", RonnanybblesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// kebinybbles per second, defined as: nybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate KebinybblesPerSecond =
            new ("kebinybbles per second", "Kin/s", NybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// mebinybbles per second, defined as: kebinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate MebinybblesPerSecond =
            new ("mebinybbles per second", "Min/s", KebinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// gibinybbles per second, defined as: mebinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate GibinybblesPerSecond =
            new ("gibinybbles per second", "Gin/s", MebinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// tebinybbles per second, defined as: gibinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate TebinybblesPerSecond =
            new ("tebinybbles per second", "Tin/s", GibinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// pebinybbles per second, defined as: tebinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate PebinybblesPerSecond =
            new ("pebinybbles per second", "Pin/s", TebinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// exbinybbles per second, defined as: pebinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate ExbinybblesPerSecond =
            new ("exbinybbles per second", "Ein/s", PebinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// zebinybbles per second, defined as: exbinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate ZebinybblesPerSecond =
            new ("zebinybbles per second", "Zin/s", ExbinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// yobinybbles per second, defined as: zebinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate YobinybblesPerSecond =
            new ("yobinybbles per second", "Yin/s", ZebinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// robinybbles per second, defined as: yobinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate RobinybblesPerSecond =
            new ("robinybbles per second", "Rin/s", YobinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// quebinybbles per second, defined as: robinybbles per second × 1024.0
   /// </summary>
   public static readonly TransferRate QuebinybblesPerSecond =
            new ("quebinybbles per second", "Qin/s", RobinybblesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// bytes per second, defined as: nybbles per second × 2d
   /// </summary>
   public static readonly TransferRate BytesPerSecond = new (
                                                             "bytes per second"
                                                           , "B/s"
                                                           , NybblesPerSecond
                                                           , 2d
                                                           , system: "Data"
                                                            );

   /// <summary>
   /// kilobytes per second, defined as: bytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate KilobytesPerSecond =
            new ("kilobytes per second", "KB/s", BytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// megabytes per second, defined as: kilobytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate MegabytesPerSecond =
            new ("megabytes per second", "MB/s", KilobytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// gigabytes per second, defined as: megabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate GigabytesPerSecond =
            new ("gigabytes per second", "GB/s", MegabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// terabytes per second, defined as: gigabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate TerabytesPerSecond =
            new ("terabytes per second", "TB/s", GigabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// petabytes per second, defined as: terabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate PetabytesPerSecond =
            new ("petabytes per second", "PB/s", TerabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// exabytes per second, defined as: petabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate ExabytesPerSecond = new (
                                                                "exabytes per second"
                                                              , "EB/s"
                                                              , PetabytesPerSecond
                                                              , 1000.0
                                                              , system: "Data"
                                                               );

   /// <summary>
   /// zettabytes per second, defined as: exabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate ZettabytesPerSecond =
            new ("zettabytes per second", "ZB/s", ExabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// yottabytes per second, defined as: zettabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate YottabytesPerSecond =
            new ("yottabytes per second", "YB/s", ZettabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// ronnabytes per second, defined as: yottabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate RonnabytesPerSecond =
            new ("ronnabytes per second", "RB/s", YottabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// quettabytes per second, defined as: ronnabytes per second × 1000.0
   /// </summary>
   public static readonly TransferRate QuettabytesPerSecond =
            new ("quettabytes per second", "QB/s", RonnabytesPerSecond, 1000.0, system: "Data");

   /// <summary>
   /// kebibytes per second, defined as: bytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate KebibytesPerSecond =
            new ("kebibytes per second", "KiB/s", BytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// mebibytes per second, defined as: kebibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate MebibytesPerSecond =
            new ("mebibytes per second", "MiB/s", KebibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// gibibytes per second, defined as: mebibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate GibibytesPerSecond =
            new ("gibibytes per second", "GiB/s", MebibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// tebibytes per second, defined as: gibibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate TebibytesPerSecond =
            new ("tebibytes per second", "TiB/s", GibibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// pebibytes per second, defined as: tebibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate PebibytesPerSecond =
            new ("pebibytes per second", "PiB/s", TebibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// exbibytes per second, defined as: pebibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate ExbibytesPerSecond =
            new ("exbibytes per second", "EiB/s", PebibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// zebibytes per second, defined as: exbibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate ZebibytesPerSecond =
            new ("zebibytes per second", "ZiB/s", ExbibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// yobibytes per second, defined as: zebibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate YobibytesPerSecond =
            new ("yobibytes per second", "YiB/s", ZebibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// robibytes per second, defined as: yobibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate RobibytesPerSecond =
            new ("robibytes per second", "RiB/s", YobibytesPerSecond, 1024.0, system: "Data");

   /// <summary>
   /// quebibytes per second, defined as: robibytes per second × 1024.0
   /// </summary>
   public static readonly TransferRate QuebibytesPerSecond =
            new ("quebibytes per second", "QiB/s", RobibytesPerSecond, 1024.0, system: "Data");
}
