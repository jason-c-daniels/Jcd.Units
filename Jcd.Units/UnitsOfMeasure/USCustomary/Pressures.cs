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
   /// pounds per square inch defined such that: SI kilopascal = psi × 6.894757.
   /// </summary>
   public static readonly Pressure PoundsPerSquareInch = new("pounds per square inch", "psi", SI.Pressures.Kilopascal, 6.894757, system: "US Customary");
   
   /// <summary>
   /// standard atmosphere defined such that: SI pascal = atm × 101325.
   /// </summary>
   public static readonly Pressure StandardAtmosphere = new("standard atmosphere", "atm", SI.Pressures.Pascal, 101325, system: "US Customary");
   
   /// <summary>
   /// bar defined such that: standard atmosphere = bar × 0.986923.
   /// </summary>
   public static readonly Pressure Bar = new("bar", "bar", StandardAtmosphere, 0.986923, system: "US Customary");
   
   /// <summary>
   /// decibar defined such that: bar = dbar × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Decibar = new("decibar", "dbar", Bar, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// centibar defined such that: decibar = cbar × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Centibar = new("centibar", "cbar", Decibar, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// millibar defined such that: centibar = mbar × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Millibar = new("millibar", "mbar", Centibar, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// microbar defined such that: millibar = μbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Microbar = new("microbar", "μbar", Millibar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nanobar defined such that: microbar = nbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Nanobar = new("nanobar", "nbar", Microbar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// picobar defined such that: nanobar = pbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Picobar = new("picobar", "pbar", Nanobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// femtobar defined such that: picobar = fbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Femtobar = new("femtobar", "fbar", Picobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// attobar defined such that: femtobar = abar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Attobar = new("attobar", "abar", Femtobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// zeptobar defined such that: attobar = zbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Zeptobar = new("zeptobar", "zbar", Attobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yoctobar defined such that: zeptobar = ybar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Yoctobar = new("yoctobar", "ybar", Zeptobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// rontobar defined such that: yoctobar = rbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Rontobar = new("rontobar", "rbar", Yoctobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// quectobar defined such that: rontobar = qbar × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Quectobar = new("quectobar", "qbar", Rontobar, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// dekabar defined such that: bar = dabar × 10.0.
   /// </summary>
   public static readonly Pressure Dekabar = new("dekabar", "dabar", Bar, 10.0, system: "US Customary");
   
   /// <summary>
   /// hectobar defined such that: dekabar = hbar × 10.0.
   /// </summary>
   public static readonly Pressure Hectobar = new("hectobar", "hbar", Dekabar, 10.0, system: "US Customary");
   
   /// <summary>
   /// kilobar defined such that: hectobar = kbar × 10.0.
   /// </summary>
   public static readonly Pressure Kilobar = new("kilobar", "kbar", Hectobar, 10.0, system: "US Customary");
   
   /// <summary>
   /// megabar defined such that: kilobar = Mbar × 1000.0.
   /// </summary>
   public static readonly Pressure Megabar = new("megabar", "Mbar", Kilobar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// gigabar defined such that: megabar = Gbar × 1000.0.
   /// </summary>
   public static readonly Pressure Gigabar = new("gigabar", "Gbar", Megabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// terabar defined such that: gigabar = Tbar × 1000.0.
   /// </summary>
   public static readonly Pressure Terabar = new("terabar", "Tbar", Gigabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// petabar defined such that: terabar = Pbar × 1000.0.
   /// </summary>
   public static readonly Pressure Petabar = new("petabar", "Pbar", Terabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// exabar defined such that: petabar = Ebar × 1000.0.
   /// </summary>
   public static readonly Pressure Exabar = new("exabar", "Ebar", Petabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// zettabar defined such that: exabar = Zbar × 1000.0.
   /// </summary>
   public static readonly Pressure Zettabar = new("zettabar", "Zbar", Exabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// yottabar defined such that: zettabar = Ybar × 1000.0.
   /// </summary>
   public static readonly Pressure Yottabar = new("yottabar", "Ybar", Zettabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// ronnabar defined such that: yottabar = Rbar × 1000.0.
   /// </summary>
   public static readonly Pressure Ronnabar = new("ronnabar", "Rbar", Yottabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// quettabar defined such that: ronnabar = Qbar × 1000.0.
   /// </summary>
   public static readonly Pressure Quettabar = new("quettabar", "Qbar", Ronnabar, 1000.0, system: "US Customary");
   
   /// <summary>
   /// torr defined such that: standard atmosphere = Torr × 1.0/760.0.
   /// </summary>
   public static readonly Pressure Torr = new("torr", "Torr", StandardAtmosphere, 1.0 / 760.0, system: "US Customary");
   
   /// <summary>
   /// decitorr defined such that: torr = dTorr × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Decitorr = new("decitorr", "dTorr", Torr, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// centitorr defined such that: decitorr = cTorr × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Centitorr = new("centitorr", "cTorr", Decitorr, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// millitorr defined such that: centitorr = mTorr × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Millitorr = new("millitorr", "mTorr", Centitorr, 1.0 / 10.0, system: "US Customary");
   
   /// <summary>
   /// microtorr defined such that: millitorr = μTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Microtorr = new("microtorr", "μTorr", Millitorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// nanotorr defined such that: microtorr = nTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Nanotorr = new("nanotorr", "nTorr", Microtorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// picotorr defined such that: nanotorr = pTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Picotorr = new("picotorr", "pTorr", Nanotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// femtotorr defined such that: picotorr = fTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Femtotorr = new("femtotorr", "fTorr", Picotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// attotorr defined such that: femtotorr = aTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Attotorr = new("attotorr", "aTorr", Femtotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// zeptotorr defined such that: attotorr = zTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Zeptotorr = new("zeptotorr", "zTorr", Attotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// yoctotorr defined such that: zeptotorr = yTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Yoctotorr = new("yoctotorr", "yTorr", Zeptotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// rontotorr defined such that: yoctotorr = rTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Rontotorr = new("rontotorr", "rTorr", Yoctotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// quectotorr defined such that: rontotorr = qTorr × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Quectotorr = new("quectotorr", "qTorr", Rontotorr, 1.0 / 1000.0, system: "US Customary");
   
   /// <summary>
   /// dekatorr defined such that: torr = daTorr × 10.0.
   /// </summary>
   public static readonly Pressure Dekatorr = new("dekatorr", "daTorr", Torr, 10.0, system: "US Customary");
   
   /// <summary>
   /// hectotorr defined such that: dekatorr = hTorr × 10.0.
   /// </summary>
   public static readonly Pressure Hectotorr = new("hectotorr", "hTorr", Dekatorr, 10.0, system: "US Customary");
   
   /// <summary>
   /// kilotorr defined such that: hectotorr = kTorr × 10.0.
   /// </summary>
   public static readonly Pressure Kilotorr = new("kilotorr", "kTorr", Hectotorr, 10.0, system: "US Customary");
   
   /// <summary>
   /// megatorr defined such that: kilotorr = MTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Megatorr = new("megatorr", "MTorr", Kilotorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// gigatorr defined such that: megatorr = GTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Gigatorr = new("gigatorr", "GTorr", Megatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// teratorr defined such that: gigatorr = TTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Teratorr = new("teratorr", "TTorr", Gigatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// petatorr defined such that: teratorr = PTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Petatorr = new("petatorr", "PTorr", Teratorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// exatorr defined such that: petatorr = ETorr × 1000.0.
   /// </summary>
   public static readonly Pressure Exatorr = new("exatorr", "ETorr", Petatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// zettatorr defined such that: exatorr = ZTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Zettatorr = new("zettatorr", "ZTorr", Exatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// yottatorr defined such that: zettatorr = YTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Yottatorr = new("yottatorr", "YTorr", Zettatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// ronnatorr defined such that: yottatorr = RTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Ronnatorr = new("ronnatorr", "RTorr", Yottatorr, 1000.0, system: "US Customary");
   
   /// <summary>
   /// quettatorr defined such that: ronnatorr = QTorr × 1000.0.
   /// </summary>
   public static readonly Pressure Quettatorr = new("quettatorr", "QTorr", Ronnatorr, 1000.0, system: "US Customary");
}