#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.DataCapacity;

/// <summary>
/// Units used to measure Data for measuring Transfer Rate.
/// </summary>
public class TransferRates : UnitOfMeasureEnumeration<TransferRates, TransferRate>
{
   /// <summary>
   /// A(n) bits per second.
   /// </summary>
   public static readonly TransferRate BitsPerSecond = new ("bits per second", "b/s");

   /// <summary>
   /// A(n) kilobits per second. Defined as: (10.0) × bits per second + (0).
   /// </summary>
   public static readonly TransferRate KilobitsPerSecond = new ("kilobits per second", "Kb/s", BitsPerSecond, 10.0, 0);

   /// <summary>
   /// A(n) megabits per second. Defined as: (1000.0) × kilobits per second + (0).
   /// </summary>
   public static readonly TransferRate MegabitsPerSecond = new (
                                                                "megabits per second"
                                                              , "Mb/s"
                                                              , KilobitsPerSecond
                                                              , 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gigabits per second. Defined as: (1000.0) × megabits per second + (0).
   /// </summary>
   public static readonly TransferRate GigabitsPerSecond = new (
                                                                "gigabits per second"
                                                              , "Gb/s"
                                                              , MegabitsPerSecond
                                                              , 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) terabits per second. Defined as: (1000.0) × gigabits per second + (0).
   /// </summary>
   public static readonly TransferRate TerabitsPerSecond = new (
                                                                "terabits per second"
                                                              , "Tb/s"
                                                              , GigabitsPerSecond
                                                              , 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) petabits per second. Defined as: (1000.0) × terabits per second + (0).
   /// </summary>
   public static readonly TransferRate PetabitsPerSecond = new (
                                                                "petabits per second"
                                                              , "Pb/s"
                                                              , TerabitsPerSecond
                                                              , 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) exabits per second. Defined as: (1000.0) × petabits per second + (0).
   /// </summary>
   public static readonly TransferRate ExabitsPerSecond = new (
                                                               "exabits per second"
                                                             , "Eb/s"
                                                             , PetabitsPerSecond
                                                             , 1000.0
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) zettabits per second. Defined as: (1000.0) × exabits per second + (0).
   /// </summary>
   public static readonly TransferRate ZettabitsPerSecond =
            new ("zettabits per second", "Zb/s", ExabitsPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) yottabits per second. Defined as: (1000.0) × zettabits per second + (0).
   /// </summary>
   public static readonly TransferRate YottabitsPerSecond =
            new ("yottabits per second", "Yb/s", ZettabitsPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) ronnabits per second. Defined as: (1000.0) × yottabits per second + (0).
   /// </summary>
   public static readonly TransferRate RonnabitsPerSecond =
            new ("ronnabits per second", "Rb/s", YottabitsPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) quettabits per second. Defined as: (1000.0) × ronnabits per second + (0).
   /// </summary>
   public static readonly TransferRate QuettabitsPerSecond =
            new ("quettabits per second", "Qb/s", RonnabitsPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) kebibits per second. Defined as: (1024.0) × bits per second + (0).
   /// </summary>
   public static readonly TransferRate KebibitsPerSecond = new (
                                                                "kebibits per second"
                                                              , "Kib/s"
                                                              , BitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) mebibits per second. Defined as: (1024.0) × kebibits per second + (0).
   /// </summary>
   public static readonly TransferRate MebibitsPerSecond = new (
                                                                "mebibits per second"
                                                              , "Mib/s"
                                                              , KebibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gibibits per second. Defined as: (1024.0) × mebibits per second + (0).
   /// </summary>
   public static readonly TransferRate GibibitsPerSecond = new (
                                                                "gibibits per second"
                                                              , "Gib/s"
                                                              , MebibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) tebibits per second. Defined as: (1024.0) × gibibits per second + (0).
   /// </summary>
   public static readonly TransferRate TebibitsPerSecond = new (
                                                                "tebibits per second"
                                                              , "Tib/s"
                                                              , GibibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) pebibits per second. Defined as: (1024.0) × tebibits per second + (0).
   /// </summary>
   public static readonly TransferRate PebibitsPerSecond = new (
                                                                "pebibits per second"
                                                              , "Pib/s"
                                                              , TebibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) exbibits per second. Defined as: (1024.0) × pebibits per second + (0).
   /// </summary>
   public static readonly TransferRate ExbibitsPerSecond = new (
                                                                "exbibits per second"
                                                              , "Eib/s"
                                                              , PebibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) zebibits per second. Defined as: (1024.0) × exbibits per second + (0).
   /// </summary>
   public static readonly TransferRate ZebibitsPerSecond = new (
                                                                "zebibits per second"
                                                              , "Zib/s"
                                                              , ExbibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yobibits per second. Defined as: (1024.0) × zebibits per second + (0).
   /// </summary>
   public static readonly TransferRate YobibitsPerSecond = new (
                                                                "yobibits per second"
                                                              , "Yib/s"
                                                              , ZebibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) robibits per second. Defined as: (1024.0) × yobibits per second + (0).
   /// </summary>
   public static readonly TransferRate RobibitsPerSecond = new (
                                                                "robibits per second"
                                                              , "Rib/s"
                                                              , YobibitsPerSecond
                                                              , 1024.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) quebibits per second. Defined as: (1024.0) × robibits per second + (0).
   /// </summary>
   public static readonly TransferRate QuebibitsPerSecond =
            new ("quebibits per second", "Qib/s", RobibitsPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) nybbles per second. Defined as: (4d) × bits per second + (0).
   /// </summary>
   public static readonly TransferRate NybblesPerSecond = new ("nybbles per second", "n/s", BitsPerSecond, 4d, 0);

   /// <summary>
   /// A(n) kilonybbles per second. Defined as: (10.0) × nybbles per second + (0).
   /// </summary>
   public static readonly TransferRate KilonybblesPerSecond =
            new ("kilonybbles per second", "Kn/s", NybblesPerSecond, 10.0, 0);

   /// <summary>
   /// A(n) meganybbles per second. Defined as: (1000.0) × kilonybbles per second + (0).
   /// </summary>
   public static readonly TransferRate MeganybblesPerSecond =
            new ("meganybbles per second", "Mn/s", KilonybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) giganybbles per second. Defined as: (1000.0) × meganybbles per second + (0).
   /// </summary>
   public static readonly TransferRate GiganybblesPerSecond =
            new ("giganybbles per second", "Gn/s", MeganybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) teranybbles per second. Defined as: (1000.0) × giganybbles per second + (0).
   /// </summary>
   public static readonly TransferRate TeranybblesPerSecond =
            new ("teranybbles per second", "Tn/s", GiganybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) petanybbles per second. Defined as: (1000.0) × teranybbles per second + (0).
   /// </summary>
   public static readonly TransferRate PetanybblesPerSecond =
            new ("petanybbles per second", "Pn/s", TeranybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) exanybbles per second. Defined as: (1000.0) × petanybbles per second + (0).
   /// </summary>
   public static readonly TransferRate ExanybblesPerSecond =
            new ("exanybbles per second", "En/s", PetanybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) zettanybbles per second. Defined as: (1000.0) × exanybbles per second + (0).
   /// </summary>
   public static readonly TransferRate ZettanybblesPerSecond =
            new ("zettanybbles per second", "Zn/s", ExanybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) yottanybbles per second. Defined as: (1000.0) × zettanybbles per second + (0).
   /// </summary>
   public static readonly TransferRate YottanybblesPerSecond =
            new ("yottanybbles per second", "Yn/s", ZettanybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) ronnanybbles per second. Defined as: (1000.0) × yottanybbles per second + (0).
   /// </summary>
   public static readonly TransferRate RonnanybblesPerSecond =
            new ("ronnanybbles per second", "Rn/s", YottanybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) quettanybbles per second. Defined as: (1000.0) × ronnanybbles per second + (0).
   /// </summary>
   public static readonly TransferRate QuettanybblesPerSecond =
            new ("quettanybbles per second", "Qn/s", RonnanybblesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) kebinybbles per second. Defined as: (1024.0) × nybbles per second + (0).
   /// </summary>
   public static readonly TransferRate KebinybblesPerSecond =
            new ("kebinybbles per second", "Kin/s", NybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) mebinybbles per second. Defined as: (1024.0) × kebinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate MebinybblesPerSecond =
            new ("mebinybbles per second", "Min/s", KebinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) gibinybbles per second. Defined as: (1024.0) × mebinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate GibinybblesPerSecond =
            new ("gibinybbles per second", "Gin/s", MebinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) tebinybbles per second. Defined as: (1024.0) × gibinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate TebinybblesPerSecond =
            new ("tebinybbles per second", "Tin/s", GibinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) pebinybbles per second. Defined as: (1024.0) × tebinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate PebinybblesPerSecond =
            new ("pebinybbles per second", "Pin/s", TebinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) exbinybbles per second. Defined as: (1024.0) × pebinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate ExbinybblesPerSecond =
            new ("exbinybbles per second", "Ein/s", PebinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) zebinybbles per second. Defined as: (1024.0) × exbinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate ZebinybblesPerSecond =
            new ("zebinybbles per second", "Zin/s", ExbinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) yobinybbles per second. Defined as: (1024.0) × zebinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate YobinybblesPerSecond =
            new ("yobinybbles per second", "Yin/s", ZebinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) robinybbles per second. Defined as: (1024.0) × yobinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate RobinybblesPerSecond =
            new ("robinybbles per second", "Rin/s", YobinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) quebinybbles per second. Defined as: (1024.0) × robinybbles per second + (0).
   /// </summary>
   public static readonly TransferRate QuebinybblesPerSecond =
            new ("quebinybbles per second", "Qin/s", RobinybblesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) bytes per second. Defined as: (2d) × nybbles per second + (0).
   /// </summary>
   public static readonly TransferRate BytesPerSecond = new ("bytes per second", "B/s", NybblesPerSecond, 2d, 0);

   /// <summary>
   /// A(n) kilobytes per second. Defined as: (10.0) × bytes per second + (0).
   /// </summary>
   public static readonly TransferRate KilobytesPerSecond =
            new ("kilobytes per second", "KB/s", BytesPerSecond, 10.0, 0);

   /// <summary>
   /// A(n) megabytes per second. Defined as: (1000.0) × kilobytes per second + (0).
   /// </summary>
   public static readonly TransferRate MegabytesPerSecond =
            new ("megabytes per second", "MB/s", KilobytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) gigabytes per second. Defined as: (1000.0) × megabytes per second + (0).
   /// </summary>
   public static readonly TransferRate GigabytesPerSecond =
            new ("gigabytes per second", "GB/s", MegabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) terabytes per second. Defined as: (1000.0) × gigabytes per second + (0).
   /// </summary>
   public static readonly TransferRate TerabytesPerSecond =
            new ("terabytes per second", "TB/s", GigabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) petabytes per second. Defined as: (1000.0) × terabytes per second + (0).
   /// </summary>
   public static readonly TransferRate PetabytesPerSecond =
            new ("petabytes per second", "PB/s", TerabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) exabytes per second. Defined as: (1000.0) × petabytes per second + (0).
   /// </summary>
   public static readonly TransferRate ExabytesPerSecond = new (
                                                                "exabytes per second"
                                                              , "EB/s"
                                                              , PetabytesPerSecond
                                                              , 1000.0
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) zettabytes per second. Defined as: (1000.0) × exabytes per second + (0).
   /// </summary>
   public static readonly TransferRate ZettabytesPerSecond =
            new ("zettabytes per second", "ZB/s", ExabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) yottabytes per second. Defined as: (1000.0) × zettabytes per second + (0).
   /// </summary>
   public static readonly TransferRate YottabytesPerSecond =
            new ("yottabytes per second", "YB/s", ZettabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) ronnabytes per second. Defined as: (1000.0) × yottabytes per second + (0).
   /// </summary>
   public static readonly TransferRate RonnabytesPerSecond =
            new ("ronnabytes per second", "RB/s", YottabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) quettabytes per second. Defined as: (1000.0) × ronnabytes per second + (0).
   /// </summary>
   public static readonly TransferRate QuettabytesPerSecond =
            new ("quettabytes per second", "QB/s", RonnabytesPerSecond, 1000.0, 0);

   /// <summary>
   /// A(n) kebibytes per second. Defined as: (1024.0) × bytes per second + (0).
   /// </summary>
   public static readonly TransferRate KebibytesPerSecond =
            new ("kebibytes per second", "KiB/s", BytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) mebibytes per second. Defined as: (1024.0) × kebibytes per second + (0).
   /// </summary>
   public static readonly TransferRate MebibytesPerSecond =
            new ("mebibytes per second", "MiB/s", KebibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) gibibytes per second. Defined as: (1024.0) × mebibytes per second + (0).
   /// </summary>
   public static readonly TransferRate GibibytesPerSecond =
            new ("gibibytes per second", "GiB/s", MebibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) tebibytes per second. Defined as: (1024.0) × gibibytes per second + (0).
   /// </summary>
   public static readonly TransferRate TebibytesPerSecond =
            new ("tebibytes per second", "TiB/s", GibibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) pebibytes per second. Defined as: (1024.0) × tebibytes per second + (0).
   /// </summary>
   public static readonly TransferRate PebibytesPerSecond =
            new ("pebibytes per second", "PiB/s", TebibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) exbibytes per second. Defined as: (1024.0) × pebibytes per second + (0).
   /// </summary>
   public static readonly TransferRate ExbibytesPerSecond =
            new ("exbibytes per second", "EiB/s", PebibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) zebibytes per second. Defined as: (1024.0) × exbibytes per second + (0).
   /// </summary>
   public static readonly TransferRate ZebibytesPerSecond =
            new ("zebibytes per second", "ZiB/s", ExbibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) yobibytes per second. Defined as: (1024.0) × zebibytes per second + (0).
   /// </summary>
   public static readonly TransferRate YobibytesPerSecond =
            new ("yobibytes per second", "YiB/s", ZebibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) robibytes per second. Defined as: (1024.0) × yobibytes per second + (0).
   /// </summary>
   public static readonly TransferRate RobibytesPerSecond =
            new ("robibytes per second", "RiB/s", YobibytesPerSecond, 1024.0, 0);

   /// <summary>
   /// A(n) quebibytes per second. Defined as: (1024.0) × robibytes per second + (0).
   /// </summary>
   public static readonly TransferRate QuebibytesPerSecond =
            new ("quebibytes per second", "QiB/s", RobibytesPerSecond, 1024.0, 0);
}
