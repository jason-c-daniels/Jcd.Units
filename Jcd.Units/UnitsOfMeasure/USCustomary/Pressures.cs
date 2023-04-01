#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Pressure.
/// </summary>
public class Pressures : UnitOfMeasureEnumeration<Pressures, Pressure>
{
   /// <summary>
   /// pounds per square inch, defined as: SI kilopascal × 6.894757
   /// </summary>
   public static readonly Pressure PoundsPerSquareInch = new (
                                                              "pounds per square inch"
                                                            , "psi"
                                                            , SI.Pressures.Kilopascal
                                                            , 6.894757
                                                            , system: "US Customary"
                                                             );

   /// <summary>
   /// standard atmosphere, defined as: SI pascal × 101325
   /// </summary>
   public static readonly Pressure StandardAtmosphere = new (
                                                             "standard atmosphere"
                                                           , "atm"
                                                           , SI.Pressures.Pascal
                                                           , 101325
                                                           , system: "US Customary"
                                                            );

   /// <summary>
   /// bar, defined as: standard atmosphere × 0.986923
   /// </summary>
   public static readonly Pressure Bar = new ("bar", "bar", StandardAtmosphere, 0.986923, system: "US Customary");

   /// <summary>
   /// decibar, defined as: bar × 1.0/10.0
   /// </summary>
   public static readonly Pressure Decibar = new ("decibar", "dbar", Bar, 1.0 / 10.0, system: "US Customary");

   /// <summary>
   /// centibar, defined as: decibar × 1.0/10.0
   /// </summary>
   public static readonly Pressure Centibar = new ("centibar", "cbar", Decibar, 1.0 / 10.0, system: "US Customary");

   /// <summary>
   /// millibar, defined as: centibar × 1.0/10.0
   /// </summary>
   public static readonly Pressure Millibar = new ("millibar", "mbar", Centibar, 1.0 / 10.0, system: "US Customary");

   /// <summary>
   /// microbar, defined as: millibar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Microbar = new ("microbar", "μbar", Millibar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// nanobar, defined as: microbar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Nanobar = new ("nanobar", "nbar", Microbar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// picobar, defined as: nanobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Picobar = new ("picobar", "pbar", Nanobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// femtobar, defined as: picobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Femtobar = new ("femtobar", "fbar", Picobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// attobar, defined as: femtobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Attobar = new ("attobar", "abar", Femtobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// zeptobar, defined as: attobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Zeptobar = new ("zeptobar", "zbar", Attobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// yoctobar, defined as: zeptobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Yoctobar = new ("yoctobar", "ybar", Zeptobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// rontobar, defined as: yoctobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Rontobar = new ("rontobar", "rbar", Yoctobar, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// quectobar, defined as: rontobar × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Quectobar = new (
                                                    "quectobar"
                                                  , "qbar"
                                                  , Rontobar
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// dekabar, defined as: bar × 10.0
   /// </summary>
   public static readonly Pressure Dekabar = new ("dekabar", "dabar", Bar, 10.0, system: "US Customary");

   /// <summary>
   /// hectobar, defined as: dekabar × 10.0
   /// </summary>
   public static readonly Pressure Hectobar = new ("hectobar", "hbar", Dekabar, 10.0, system: "US Customary");

   /// <summary>
   /// kilobar, defined as: hectobar × 10.0
   /// </summary>
   public static readonly Pressure Kilobar = new ("kilobar", "kbar", Hectobar, 10.0, system: "US Customary");

   /// <summary>
   /// megabar, defined as: kilobar × 1000.0
   /// </summary>
   public static readonly Pressure Megabar = new ("megabar", "Mbar", Kilobar, 1000.0, system: "US Customary");

   /// <summary>
   /// gigabar, defined as: megabar × 1000.0
   /// </summary>
   public static readonly Pressure Gigabar = new ("gigabar", "Gbar", Megabar, 1000.0, system: "US Customary");

   /// <summary>
   /// terabar, defined as: gigabar × 1000.0
   /// </summary>
   public static readonly Pressure Terabar = new ("terabar", "Tbar", Gigabar, 1000.0, system: "US Customary");

   /// <summary>
   /// petabar, defined as: terabar × 1000.0
   /// </summary>
   public static readonly Pressure Petabar = new ("petabar", "Pbar", Terabar, 1000.0, system: "US Customary");

   /// <summary>
   /// exabar, defined as: petabar × 1000.0
   /// </summary>
   public static readonly Pressure Exabar = new ("exabar", "Ebar", Petabar, 1000.0, system: "US Customary");

   /// <summary>
   /// zettabar, defined as: exabar × 1000.0
   /// </summary>
   public static readonly Pressure Zettabar = new ("zettabar", "Zbar", Exabar, 1000.0, system: "US Customary");

   /// <summary>
   /// yottabar, defined as: zettabar × 1000.0
   /// </summary>
   public static readonly Pressure Yottabar = new ("yottabar", "Ybar", Zettabar, 1000.0, system: "US Customary");

   /// <summary>
   /// ronnabar, defined as: yottabar × 1000.0
   /// </summary>
   public static readonly Pressure Ronnabar = new ("ronnabar", "Rbar", Yottabar, 1000.0, system: "US Customary");

   /// <summary>
   /// quettabar, defined as: ronnabar × 1000.0
   /// </summary>
   public static readonly Pressure Quettabar = new ("quettabar", "Qbar", Ronnabar, 1000.0, system: "US Customary");

   /// <summary>
   /// torr, defined as: standard atmosphere × 1.0/760.0
   /// </summary>
   public static readonly Pressure Torr = new ("torr", "Torr", StandardAtmosphere, 1.0 / 760.0, system: "US Customary");

   /// <summary>
   /// decitorr, defined as: torr × 1.0/10.0
   /// </summary>
   public static readonly Pressure Decitorr = new ("decitorr", "dTorr", Torr, 1.0 / 10.0, system: "US Customary");

   /// <summary>
   /// centitorr, defined as: decitorr × 1.0/10.0
   /// </summary>
   public static readonly Pressure Centitorr = new ("centitorr", "cTorr", Decitorr, 1.0 / 10.0, system: "US Customary");

   /// <summary>
   /// millitorr, defined as: centitorr × 1.0/10.0
   /// </summary>
   public static readonly Pressure Millitorr = new (
                                                    "millitorr"
                                                  , "mTorr"
                                                  , Centitorr
                                                  , 1.0 / 10.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// microtorr, defined as: millitorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Microtorr = new (
                                                    "microtorr"
                                                  , "μTorr"
                                                  , Millitorr
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// nanotorr, defined as: microtorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Nanotorr = new (
                                                   "nanotorr"
                                                 , "nTorr"
                                                 , Microtorr
                                                 , 1.0 / 1000.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// picotorr, defined as: nanotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Picotorr = new ("picotorr", "pTorr", Nanotorr, 1.0 / 1000.0, system: "US Customary");

   /// <summary>
   /// femtotorr, defined as: picotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Femtotorr = new (
                                                    "femtotorr"
                                                  , "fTorr"
                                                  , Picotorr
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// attotorr, defined as: femtotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Attotorr = new (
                                                   "attotorr"
                                                 , "aTorr"
                                                 , Femtotorr
                                                 , 1.0 / 1000.0
                                                 , system: "US Customary"
                                                  );

   /// <summary>
   /// zeptotorr, defined as: attotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Zeptotorr = new (
                                                    "zeptotorr"
                                                  , "zTorr"
                                                  , Attotorr
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// yoctotorr, defined as: zeptotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Yoctotorr = new (
                                                    "yoctotorr"
                                                  , "yTorr"
                                                  , Zeptotorr
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// rontotorr, defined as: yoctotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Rontotorr = new (
                                                    "rontotorr"
                                                  , "rTorr"
                                                  , Yoctotorr
                                                  , 1.0 / 1000.0
                                                  , system: "US Customary"
                                                   );

   /// <summary>
   /// quectotorr, defined as: rontotorr × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Quectotorr = new (
                                                     "quectotorr"
                                                   , "qTorr"
                                                   , Rontotorr
                                                   , 1.0 / 1000.0
                                                   , system: "US Customary"
                                                    );

   /// <summary>
   /// dekatorr, defined as: torr × 10.0
   /// </summary>
   public static readonly Pressure Dekatorr = new ("dekatorr", "daTorr", Torr, 10.0, system: "US Customary");

   /// <summary>
   /// hectotorr, defined as: dekatorr × 10.0
   /// </summary>
   public static readonly Pressure Hectotorr = new ("hectotorr", "hTorr", Dekatorr, 10.0, system: "US Customary");

   /// <summary>
   /// kilotorr, defined as: hectotorr × 10.0
   /// </summary>
   public static readonly Pressure Kilotorr = new ("kilotorr", "kTorr", Hectotorr, 10.0, system: "US Customary");

   /// <summary>
   /// megatorr, defined as: kilotorr × 1000.0
   /// </summary>
   public static readonly Pressure Megatorr = new ("megatorr", "MTorr", Kilotorr, 1000.0, system: "US Customary");

   /// <summary>
   /// gigatorr, defined as: megatorr × 1000.0
   /// </summary>
   public static readonly Pressure Gigatorr = new ("gigatorr", "GTorr", Megatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// teratorr, defined as: gigatorr × 1000.0
   /// </summary>
   public static readonly Pressure Teratorr = new ("teratorr", "TTorr", Gigatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// petatorr, defined as: teratorr × 1000.0
   /// </summary>
   public static readonly Pressure Petatorr = new ("petatorr", "PTorr", Teratorr, 1000.0, system: "US Customary");

   /// <summary>
   /// exatorr, defined as: petatorr × 1000.0
   /// </summary>
   public static readonly Pressure Exatorr = new ("exatorr", "ETorr", Petatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// zettatorr, defined as: exatorr × 1000.0
   /// </summary>
   public static readonly Pressure Zettatorr = new ("zettatorr", "ZTorr", Exatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// yottatorr, defined as: zettatorr × 1000.0
   /// </summary>
   public static readonly Pressure Yottatorr = new ("yottatorr", "YTorr", Zettatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// ronnatorr, defined as: yottatorr × 1000.0
   /// </summary>
   public static readonly Pressure Ronnatorr = new ("ronnatorr", "RTorr", Yottatorr, 1000.0, system: "US Customary");

   /// <summary>
   /// quettatorr, defined as: ronnatorr × 1000.0
   /// </summary>
   public static readonly Pressure Quettatorr = new ("quettatorr", "QTorr", Ronnatorr, 1000.0, system: "US Customary");
}
