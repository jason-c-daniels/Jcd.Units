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
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : UnitOfMeasureEnumeration<ElectricalCurrents, ElectricalCurrent>
{
   /// <summary>
   /// ampere, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly ElectricalCurrent Ampere = new ("ampere", "A", system: "SI");

   /// <summary>
   /// deciampere, defined as: ampere × 1.0/10.0
   /// </summary>
   public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiampere, defined as: deciampere × 1.0/10.0
   /// </summary>
   public static readonly ElectricalCurrent Centiampere = new (
                                                               "centiampere"
                                                             , "cA"
                                                             , Deciampere
                                                             , 1.0 / 10.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// milliampere, defined as: centiampere × 1.0/10.0
   /// </summary>
   public static readonly ElectricalCurrent Milliampere = new (
                                                               "milliampere"
                                                             , "mA"
                                                             , Centiampere
                                                             , 1.0 / 10.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// microampere, defined as: milliampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Microampere = new (
                                                               "microampere"
                                                             , "μA"
                                                             , Milliampere
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// nanoampere, defined as: microampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Nanoampere = new (
                                                              "nanoampere"
                                                            , "nA"
                                                            , Microampere
                                                            , 1.0 / 1000.0
                                                            , system: "SI"
                                                             );

   /// <summary>
   /// picoampere, defined as: nanoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Picoampere = new (
                                                              "picoampere"
                                                            , "pA"
                                                            , Nanoampere
                                                            , 1.0 / 1000.0
                                                            , system: "SI"
                                                             );

   /// <summary>
   /// femtoampere, defined as: picoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Femtoampere = new (
                                                               "femtoampere"
                                                             , "fA"
                                                             , Picoampere
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// attoampere, defined as: femtoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Attoampere = new (
                                                              "attoampere"
                                                            , "aA"
                                                            , Femtoampere
                                                            , 1.0 / 1000.0
                                                            , system: "SI"
                                                             );

   /// <summary>
   /// zeptoampere, defined as: attoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Zeptoampere = new (
                                                               "zeptoampere"
                                                             , "zA"
                                                             , Attoampere
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// yoctoampere, defined as: zeptoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Yoctoampere = new (
                                                               "yoctoampere"
                                                             , "yA"
                                                             , Zeptoampere
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// rontoampere, defined as: yoctoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Rontoampere = new (
                                                               "rontoampere"
                                                             , "rA"
                                                             , Yoctoampere
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// quectoampere, defined as: rontoampere × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalCurrent Quectoampere = new (
                                                                "quectoampere"
                                                              , "qA"
                                                              , Rontoampere
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// dekaampere, defined as: ampere × 10.0
   /// </summary>
   public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10.0, system: "SI");

   /// <summary>
   /// hectoampere, defined as: dekaampere × 10.0
   /// </summary>
   public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10.0, system: "SI");

   /// <summary>
   /// kiloampere, defined as: hectoampere × 10.0
   /// </summary>
   public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10.0, system: "SI");

   /// <summary>
   /// megaampere, defined as: kiloampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000.0, system: "SI");

   /// <summary>
   /// gigaampere, defined as: megaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000.0, system: "SI");

   /// <summary>
   /// teraampere, defined as: gigaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000.0, system: "SI");

   /// <summary>
   /// petaampere, defined as: teraampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000.0, system: "SI");

   /// <summary>
   /// exaampere, defined as: petaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000.0, system: "SI");

   /// <summary>
   /// zettaampere, defined as: exaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000.0, system: "SI");

   /// <summary>
   /// yottaampere, defined as: zettaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000.0, system: "SI");

   /// <summary>
   /// ronnaampere, defined as: yottaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000.0, system: "SI");

   /// <summary>
   /// quettaampere, defined as: ronnaampere × 1000.0
   /// </summary>
   public static readonly ElectricalCurrent
            Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000.0, system: "SI");
}
