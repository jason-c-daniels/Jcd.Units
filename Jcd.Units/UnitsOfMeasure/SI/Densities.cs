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
/// International System of Units for measuring Density.
/// </summary>
public class Densities : Enumeration<Densities, Density>
{
   /// <summary>
   /// A(n) gram per cubic meter.
   /// </summary>
   public static readonly Density GramPerCubicMeter = new ("gram per cubic meter", "g/m^3");

   /// <summary>
   /// A(n) gram per cubic decimeter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density GramPerCubicDecimeter = new (
                                                               "gram per cubic decimeter"
                                                             , "g/dm^3"
                                                             , GramPerCubicMeter
                                                             , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic meter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DecigramPerCubicMeter = new (
                                                               "decigram per cubic meter"
                                                             , "dg/m^3"
                                                             , GramPerCubicMeter
                                                             , 1.0 / 10.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gram per cubic centimeter. Defined in terms of a(n) gram per cubic decimeter.
   /// </summary>
   public static readonly Density GramPerCubicCentimeter = new (
                                                                "gram per cubic centimeter"
                                                              , "g/cm^3"
                                                              , GramPerCubicDecimeter
                                                              , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic decimeter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DecigramPerCubicDecimeter = new (
                                                                   "decigram per cubic decimeter"
                                                                 , "dg/dm^3"
                                                                 , GramPerCubicMeter
                                                                 , 1.0
                                                                 / 10.0
                                                                 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic meter. Defined in terms of a(n) decigram per cubic meter.
   /// </summary>
   public static readonly Density CentigramPerCubicMeter = new (
                                                                "centigram per cubic meter"
                                                              , "cg/m^3"
                                                              , DecigramPerCubicMeter
                                                              , 1.0 / 10.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic millimeter. Defined in terms of a(n) gram per cubic centimeter.
   /// </summary>
   public static readonly Density GramPerCubicMillimeter = new (
                                                                "gram per cubic millimeter"
                                                              , "g/mm^3"
                                                              , GramPerCubicCentimeter
                                                              , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic centimeter. Defined in terms of a(n) gram per cubic decimeter.
   /// </summary>
   public static readonly Density DecigramPerCubicCentimeter = new (
                                                                    "decigram per cubic centimeter"
                                                                  , "dg/cm^3"
                                                                  , GramPerCubicDecimeter
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic decimeter. Defined in terms of a(n) decigram per cubic meter.
   /// </summary>
   public static readonly Density CentigramPerCubicDecimeter = new (
                                                                    "centigram per cubic decimeter"
                                                                  , "cg/dm^3"
                                                                  , DecigramPerCubicMeter
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic meter. Defined in terms of a(n) centigram per cubic meter.
   /// </summary>
   public static readonly Density MilligramPerCubicMeter = new (
                                                                "milligram per cubic meter"
                                                              , "mg/m^3"
                                                              , CentigramPerCubicMeter
                                                              , 1.0 / 10.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic micrometer. Defined in terms of a(n) gram per cubic millimeter.
   /// </summary>
   public static readonly Density GramPerCubicMicrometer = new (
                                                                "gram per cubic micrometer"
                                                              , "g/μm^3"
                                                              , GramPerCubicMillimeter
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic millimeter. Defined in terms of a(n) gram per cubic centimeter.
   /// </summary>
   public static readonly Density DecigramPerCubicMillimeter = new (
                                                                    "decigram per cubic millimeter"
                                                                  , "dg/mm^3"
                                                                  , GramPerCubicCentimeter
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic centimeter. Defined in terms of a(n) decigram per cubic decimeter.
   /// </summary>
   public static readonly Density CentigramPerCubicCentimeter = new (
                                                                     "centigram per cubic centimeter"
                                                                   , "cg/cm^3"
                                                                   , DecigramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic decimeter. Defined in terms of a(n) centigram per cubic meter.
   /// </summary>
   public static readonly Density MilligramPerCubicDecimeter = new (
                                                                    "milligram per cubic decimeter"
                                                                  , "mg/dm^3"
                                                                  , CentigramPerCubicMeter
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic meter. Defined in terms of a(n) milligram per cubic meter.
   /// </summary>
   public static readonly Density MicrogramPerCubicMeter = new (
                                                                "microgram per cubic meter"
                                                              , "μg/m^3"
                                                              , MilligramPerCubicMeter
                                                              , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic nanometer. Defined in terms of a(n) gram per cubic micrometer.
   /// </summary>
   public static readonly Density GramPerCubicNanometer = new (
                                                               "gram per cubic nanometer"
                                                             , "g/nm^3"
                                                             , GramPerCubicMicrometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic micrometer. Defined in terms of a(n) gram per cubic millimeter.
   /// </summary>
   public static readonly Density DecigramPerCubicMicrometer = new (
                                                                    "decigram per cubic micrometer"
                                                                  , "dg/μm^3"
                                                                  , GramPerCubicMillimeter
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic millimeter. Defined in terms of a(n) decigram per cubic centimeter.
   /// </summary>
   public static readonly Density CentigramPerCubicMillimeter = new (
                                                                     "centigram per cubic millimeter"
                                                                   , "cg/mm^3"
                                                                   , DecigramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic centimeter. Defined in terms of a(n) centigram per cubic decimeter.
   /// </summary>
   public static readonly Density MilligramPerCubicCentimeter = new (
                                                                     "milligram per cubic centimeter"
                                                                   , "mg/cm^3"
                                                                   , CentigramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic decimeter. Defined in terms of a(n) milligram per cubic meter.
   /// </summary>
   public static readonly Density MicrogramPerCubicDecimeter = new (
                                                                    "microgram per cubic decimeter"
                                                                  , "μg/dm^3"
                                                                  , MilligramPerCubicMeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic meter. Defined in terms of a(n) microgram per cubic meter.
   /// </summary>
   public static readonly Density NanogramPerCubicMeter = new (
                                                               "nanogram per cubic meter"
                                                             , "ng/m^3"
                                                             , MicrogramPerCubicMeter
                                                             , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gram per cubic picometer. Defined in terms of a(n) gram per cubic nanometer.
   /// </summary>
   public static readonly Density GramPerCubicPicometer = new (
                                                               "gram per cubic picometer"
                                                             , "g/pm^3"
                                                             , GramPerCubicNanometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic nanometer. Defined in terms of a(n) gram per cubic micrometer.
   /// </summary>
   public static readonly Density DecigramPerCubicNanometer = new (
                                                                   "decigram per cubic nanometer"
                                                                 , "dg/nm^3"
                                                                 , GramPerCubicMicrometer
                                                                 , 1.0
                                                                 / 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic micrometer. Defined in terms of a(n) decigram per cubic millimeter.
   /// </summary>
   public static readonly Density CentigramPerCubicMicrometer = new (
                                                                     "centigram per cubic micrometer"
                                                                   , "cg/μm^3"
                                                                   , DecigramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic millimeter. Defined in terms of a(n) centigram per cubic centimeter.
   /// </summary>
   public static readonly Density MilligramPerCubicMillimeter = new (
                                                                     "milligram per cubic millimeter"
                                                                   , "mg/mm^3"
                                                                   , CentigramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic centimeter. Defined in terms of a(n) milligram per cubic decimeter.
   /// </summary>
   public static readonly Density MicrogramPerCubicCentimeter = new (
                                                                     "microgram per cubic centimeter"
                                                                   , "μg/cm^3"
                                                                   , MilligramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic decimeter. Defined in terms of a(n) microgram per cubic meter.
   /// </summary>
   public static readonly Density NanogramPerCubicDecimeter = new (
                                                                   "nanogram per cubic decimeter"
                                                                 , "ng/dm^3"
                                                                 , MicrogramPerCubicMeter
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic meter. Defined in terms of a(n) nanogram per cubic meter.
   /// </summary>
   public static readonly Density PicogramPerCubicMeter = new (
                                                               "picogram per cubic meter"
                                                             , "pg/m^3"
                                                             , NanogramPerCubicMeter
                                                             , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gram per cubic femtometer. Defined in terms of a(n) gram per cubic picometer.
   /// </summary>
   public static readonly Density GramPerCubicFemtometer = new (
                                                                "gram per cubic femtometer"
                                                              , "g/fm^3"
                                                              , GramPerCubicPicometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic picometer. Defined in terms of a(n) gram per cubic nanometer.
   /// </summary>
   public static readonly Density DecigramPerCubicPicometer = new (
                                                                   "decigram per cubic picometer"
                                                                 , "dg/pm^3"
                                                                 , GramPerCubicNanometer
                                                                 , 1.0
                                                                 / 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic nanometer. Defined in terms of a(n) decigram per cubic micrometer.
   /// </summary>
   public static readonly Density CentigramPerCubicNanometer = new (
                                                                    "centigram per cubic nanometer"
                                                                  , "cg/nm^3"
                                                                  , DecigramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic micrometer. Defined in terms of a(n) centigram per cubic millimeter.
   /// </summary>
   public static readonly Density MilligramPerCubicMicrometer = new (
                                                                     "milligram per cubic micrometer"
                                                                   , "mg/μm^3"
                                                                   , CentigramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic millimeter. Defined in terms of a(n) milligram per cubic centimeter.
   /// </summary>
   public static readonly Density MicrogramPerCubicMillimeter = new (
                                                                     "microgram per cubic millimeter"
                                                                   , "μg/mm^3"
                                                                   , MilligramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic centimeter. Defined in terms of a(n) microgram per cubic decimeter.
   /// </summary>
   public static readonly Density NanogramPerCubicCentimeter = new (
                                                                    "nanogram per cubic centimeter"
                                                                  , "ng/cm^3"
                                                                  , MicrogramPerCubicDecimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic decimeter. Defined in terms of a(n) nanogram per cubic meter.
   /// </summary>
   public static readonly Density PicogramPerCubicDecimeter = new (
                                                                   "picogram per cubic decimeter"
                                                                 , "pg/dm^3"
                                                                 , NanogramPerCubicMeter
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic meter. Defined in terms of a(n) picogram per cubic meter.
   /// </summary>
   public static readonly Density FemtogramPerCubicMeter = new (
                                                                "femtogram per cubic meter"
                                                              , "fg/m^3"
                                                              , PicogramPerCubicMeter
                                                              , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic attometer. Defined in terms of a(n) gram per cubic femtometer.
   /// </summary>
   public static readonly Density GramPerCubicAttometer = new (
                                                               "gram per cubic attometer"
                                                             , "g/am^3"
                                                             , GramPerCubicFemtometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic femtometer. Defined in terms of a(n) gram per cubic picometer.
   /// </summary>
   public static readonly Density DecigramPerCubicFemtometer = new (
                                                                    "decigram per cubic femtometer"
                                                                  , "dg/fm^3"
                                                                  , GramPerCubicPicometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic picometer. Defined in terms of a(n) decigram per cubic nanometer.
   /// </summary>
   public static readonly Density CentigramPerCubicPicometer = new (
                                                                    "centigram per cubic picometer"
                                                                  , "cg/pm^3"
                                                                  , DecigramPerCubicNanometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic nanometer. Defined in terms of a(n) centigram per cubic micrometer.
   /// </summary>
   public static readonly Density MilligramPerCubicNanometer = new (
                                                                    "milligram per cubic nanometer"
                                                                  , "mg/nm^3"
                                                                  , CentigramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic micrometer. Defined in terms of a(n) milligram per cubic millimeter.
   /// </summary>
   public static readonly Density MicrogramPerCubicMicrometer = new (
                                                                     "microgram per cubic micrometer"
                                                                   , "μg/μm^3"
                                                                   , MilligramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic millimeter. Defined in terms of a(n) microgram per cubic centimeter.
   /// </summary>
   public static readonly Density NanogramPerCubicMillimeter = new (
                                                                    "nanogram per cubic millimeter"
                                                                  , "ng/mm^3"
                                                                  , MicrogramPerCubicCentimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic centimeter. Defined in terms of a(n) nanogram per cubic decimeter.
   /// </summary>
   public static readonly Density PicogramPerCubicCentimeter = new (
                                                                    "picogram per cubic centimeter"
                                                                  , "pg/cm^3"
                                                                  , NanogramPerCubicDecimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic decimeter. Defined in terms of a(n) picogram per cubic meter.
   /// </summary>
   public static readonly Density FemtogramPerCubicDecimeter = new (
                                                                    "femtogram per cubic decimeter"
                                                                  , "fg/dm^3"
                                                                  , PicogramPerCubicMeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic meter. Defined in terms of a(n) femtogram per cubic meter.
   /// </summary>
   public static readonly Density AttogramPerCubicMeter = new (
                                                               "attogram per cubic meter"
                                                             , "ag/m^3"
                                                             , FemtogramPerCubicMeter
                                                             , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gram per cubic zeptometer. Defined in terms of a(n) gram per cubic attometer.
   /// </summary>
   public static readonly Density GramPerCubicZeptometer = new (
                                                                "gram per cubic zeptometer"
                                                              , "g/zm^3"
                                                              , GramPerCubicAttometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic attometer. Defined in terms of a(n) gram per cubic femtometer.
   /// </summary>
   public static readonly Density DecigramPerCubicAttometer = new (
                                                                   "decigram per cubic attometer"
                                                                 , "dg/am^3"
                                                                 , GramPerCubicFemtometer
                                                                 , 1.0
                                                                 / 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic femtometer. Defined in terms of a(n) decigram per cubic picometer.
   /// </summary>
   public static readonly Density CentigramPerCubicFemtometer = new (
                                                                     "centigram per cubic femtometer"
                                                                   , "cg/fm^3"
                                                                   , DecigramPerCubicPicometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic picometer. Defined in terms of a(n) centigram per cubic nanometer.
   /// </summary>
   public static readonly Density MilligramPerCubicPicometer = new (
                                                                    "milligram per cubic picometer"
                                                                  , "mg/pm^3"
                                                                  , CentigramPerCubicNanometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic nanometer. Defined in terms of a(n) milligram per cubic micrometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicNanometer = new (
                                                                    "microgram per cubic nanometer"
                                                                  , "μg/nm^3"
                                                                  , MilligramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic micrometer. Defined in terms of a(n) microgram per cubic millimeter.
   /// </summary>
   public static readonly Density NanogramPerCubicMicrometer = new (
                                                                    "nanogram per cubic micrometer"
                                                                  , "ng/μm^3"
                                                                  , MicrogramPerCubicMillimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic millimeter. Defined in terms of a(n) nanogram per cubic centimeter.
   /// </summary>
   public static readonly Density PicogramPerCubicMillimeter = new (
                                                                    "picogram per cubic millimeter"
                                                                  , "pg/mm^3"
                                                                  , NanogramPerCubicCentimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic centimeter. Defined in terms of a(n) picogram per cubic decimeter.
   /// </summary>
   public static readonly Density FemtogramPerCubicCentimeter = new (
                                                                     "femtogram per cubic centimeter"
                                                                   , "fg/cm^3"
                                                                   , PicogramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic decimeter. Defined in terms of a(n) femtogram per cubic meter.
   /// </summary>
   public static readonly Density AttogramPerCubicDecimeter = new (
                                                                   "attogram per cubic decimeter"
                                                                 , "ag/dm^3"
                                                                 , FemtogramPerCubicMeter
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic meter. Defined in terms of a(n) attogram per cubic meter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicMeter = new (
                                                                "zeptogram per cubic meter"
                                                              , "zg/m^3"
                                                              , AttogramPerCubicMeter
                                                              , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic yoctometer. Defined in terms of a(n) gram per cubic zeptometer.
   /// </summary>
   public static readonly Density GramPerCubicYoctometer = new (
                                                                "gram per cubic yoctometer"
                                                              , "g/ym^3"
                                                              , GramPerCubicZeptometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic zeptometer. Defined in terms of a(n) gram per cubic attometer.
   /// </summary>
   public static readonly Density DecigramPerCubicZeptometer = new (
                                                                    "decigram per cubic zeptometer"
                                                                  , "dg/zm^3"
                                                                  , GramPerCubicAttometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic attometer. Defined in terms of a(n) decigram per cubic femtometer.
   /// </summary>
   public static readonly Density CentigramPerCubicAttometer = new (
                                                                    "centigram per cubic attometer"
                                                                  , "cg/am^3"
                                                                  , DecigramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic femtometer. Defined in terms of a(n) centigram per cubic picometer.
   /// </summary>
   public static readonly Density MilligramPerCubicFemtometer = new (
                                                                     "milligram per cubic femtometer"
                                                                   , "mg/fm^3"
                                                                   , CentigramPerCubicPicometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic picometer. Defined in terms of a(n) milligram per cubic nanometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicPicometer = new (
                                                                    "microgram per cubic picometer"
                                                                  , "μg/pm^3"
                                                                  , MilligramPerCubicNanometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic nanometer. Defined in terms of a(n) microgram per cubic micrometer.
   /// </summary>
   public static readonly Density NanogramPerCubicNanometer = new (
                                                                   "nanogram per cubic nanometer"
                                                                 , "ng/nm^3"
                                                                 , MicrogramPerCubicMicrometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic micrometer. Defined in terms of a(n) nanogram per cubic millimeter.
   /// </summary>
   public static readonly Density PicogramPerCubicMicrometer = new (
                                                                    "picogram per cubic micrometer"
                                                                  , "pg/μm^3"
                                                                  , NanogramPerCubicMillimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic millimeter. Defined in terms of a(n) picogram per cubic centimeter.
   /// </summary>
   public static readonly Density FemtogramPerCubicMillimeter = new (
                                                                     "femtogram per cubic millimeter"
                                                                   , "fg/mm^3"
                                                                   , PicogramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic centimeter. Defined in terms of a(n) femtogram per cubic decimeter.
   /// </summary>
   public static readonly Density AttogramPerCubicCentimeter = new (
                                                                    "attogram per cubic centimeter"
                                                                  , "ag/cm^3"
                                                                  , FemtogramPerCubicDecimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic decimeter. Defined in terms of a(n) attogram per cubic meter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicDecimeter = new (
                                                                    "zeptogram per cubic decimeter"
                                                                  , "zg/dm^3"
                                                                  , AttogramPerCubicMeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic meter. Defined in terms of a(n) zeptogram per cubic meter.
   /// </summary>
   public static readonly Density YoctogramPerCubicMeter = new (
                                                                "yoctogram per cubic meter"
                                                              , "yg/m^3"
                                                              , ZeptogramPerCubicMeter
                                                              , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic rontometer. Defined in terms of a(n) gram per cubic yoctometer.
   /// </summary>
   public static readonly Density GramPerCubicRontometer = new (
                                                                "gram per cubic rontometer"
                                                              , "g/rm^3"
                                                              , GramPerCubicYoctometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic yoctometer. Defined in terms of a(n) gram per cubic zeptometer.
   /// </summary>
   public static readonly Density DecigramPerCubicYoctometer = new (
                                                                    "decigram per cubic yoctometer"
                                                                  , "dg/ym^3"
                                                                  , GramPerCubicZeptometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic zeptometer. Defined in terms of a(n) decigram per cubic attometer.
   /// </summary>
   public static readonly Density CentigramPerCubicZeptometer = new (
                                                                     "centigram per cubic zeptometer"
                                                                   , "cg/zm^3"
                                                                   , DecigramPerCubicAttometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic attometer. Defined in terms of a(n) centigram per cubic femtometer.
   /// </summary>
   public static readonly Density MilligramPerCubicAttometer = new (
                                                                    "milligram per cubic attometer"
                                                                  , "mg/am^3"
                                                                  , CentigramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic femtometer. Defined in terms of a(n) milligram per cubic picometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicFemtometer = new (
                                                                     "microgram per cubic femtometer"
                                                                   , "μg/fm^3"
                                                                   , MilligramPerCubicPicometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic picometer. Defined in terms of a(n) microgram per cubic nanometer.
   /// </summary>
   public static readonly Density NanogramPerCubicPicometer = new (
                                                                   "nanogram per cubic picometer"
                                                                 , "ng/pm^3"
                                                                 , MicrogramPerCubicNanometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic nanometer. Defined in terms of a(n) nanogram per cubic micrometer.
   /// </summary>
   public static readonly Density PicogramPerCubicNanometer = new (
                                                                   "picogram per cubic nanometer"
                                                                 , "pg/nm^3"
                                                                 , NanogramPerCubicMicrometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic micrometer. Defined in terms of a(n) picogram per cubic millimeter.
   /// </summary>
   public static readonly Density FemtogramPerCubicMicrometer = new (
                                                                     "femtogram per cubic micrometer"
                                                                   , "fg/μm^3"
                                                                   , PicogramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic millimeter. Defined in terms of a(n) femtogram per cubic centimeter.
   /// </summary>
   public static readonly Density AttogramPerCubicMillimeter = new (
                                                                    "attogram per cubic millimeter"
                                                                  , "ag/mm^3"
                                                                  , FemtogramPerCubicCentimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic centimeter. Defined in terms of a(n) attogram per cubic decimeter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicCentimeter = new (
                                                                     "zeptogram per cubic centimeter"
                                                                   , "zg/cm^3"
                                                                   , AttogramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic decimeter. Defined in terms of a(n) zeptogram per cubic meter.
   /// </summary>
   public static readonly Density YoctogramPerCubicDecimeter = new (
                                                                    "yoctogram per cubic decimeter"
                                                                  , "yg/dm^3"
                                                                  , ZeptogramPerCubicMeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic meter. Defined in terms of a(n) yoctogram per cubic meter.
   /// </summary>
   public static readonly Density RontogramPerCubicMeter = new (
                                                                "rontogram per cubic meter"
                                                              , "rg/m^3"
                                                              , YoctogramPerCubicMeter
                                                              , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) gram per cubic quectometer. Defined in terms of a(n) gram per cubic rontometer.
   /// </summary>
   public static readonly Density GramPerCubicQuectometer = new (
                                                                 "gram per cubic quectometer"
                                                               , "g/qm^3"
                                                               , GramPerCubicRontometer
                                                               , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) decigram per cubic rontometer. Defined in terms of a(n) gram per cubic yoctometer.
   /// </summary>
   public static readonly Density DecigramPerCubicRontometer = new (
                                                                    "decigram per cubic rontometer"
                                                                  , "dg/rm^3"
                                                                  , GramPerCubicYoctometer
                                                                  , 1.0
                                                                  / 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic yoctometer. Defined in terms of a(n) decigram per cubic zeptometer.
   /// </summary>
   public static readonly Density CentigramPerCubicYoctometer = new (
                                                                     "centigram per cubic yoctometer"
                                                                   , "cg/ym^3"
                                                                   , DecigramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic zeptometer. Defined in terms of a(n) centigram per cubic attometer.
   /// </summary>
   public static readonly Density MilligramPerCubicZeptometer = new (
                                                                     "milligram per cubic zeptometer"
                                                                   , "mg/zm^3"
                                                                   , CentigramPerCubicAttometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic attometer. Defined in terms of a(n) milligram per cubic femtometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicAttometer = new (
                                                                    "microgram per cubic attometer"
                                                                  , "μg/am^3"
                                                                  , MilligramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic femtometer. Defined in terms of a(n) microgram per cubic picometer.
   /// </summary>
   public static readonly Density NanogramPerCubicFemtometer = new (
                                                                    "nanogram per cubic femtometer"
                                                                  , "ng/fm^3"
                                                                  , MicrogramPerCubicPicometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic picometer. Defined in terms of a(n) nanogram per cubic nanometer.
   /// </summary>
   public static readonly Density PicogramPerCubicPicometer = new (
                                                                   "picogram per cubic picometer"
                                                                 , "pg/pm^3"
                                                                 , NanogramPerCubicNanometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic nanometer. Defined in terms of a(n) picogram per cubic micrometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicNanometer = new (
                                                                    "femtogram per cubic nanometer"
                                                                  , "fg/nm^3"
                                                                  , PicogramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic micrometer. Defined in terms of a(n) femtogram per cubic millimeter.
   /// </summary>
   public static readonly Density AttogramPerCubicMicrometer = new (
                                                                    "attogram per cubic micrometer"
                                                                  , "ag/μm^3"
                                                                  , FemtogramPerCubicMillimeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic millimeter. Defined in terms of a(n) attogram per cubic centimeter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicMillimeter = new (
                                                                     "zeptogram per cubic millimeter"
                                                                   , "zg/mm^3"
                                                                   , AttogramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic centimeter. Defined in terms of a(n) zeptogram per cubic decimeter.
   /// </summary>
   public static readonly Density YoctogramPerCubicCentimeter = new (
                                                                     "yoctogram per cubic centimeter"
                                                                   , "yg/cm^3"
                                                                   , ZeptogramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic decimeter. Defined in terms of a(n) yoctogram per cubic meter.
   /// </summary>
   public static readonly Density RontogramPerCubicDecimeter = new (
                                                                    "rontogram per cubic decimeter"
                                                                  , "rg/dm^3"
                                                                  , YoctogramPerCubicMeter
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic meter. Defined in terms of a(n) rontogram per cubic meter.
   /// </summary>
   public static readonly Density QuectogramPerCubicMeter = new (
                                                                 "quectogram per cubic meter"
                                                               , "qg/m^3"
                                                               , RontogramPerCubicMeter
                                                               , 1.0 / 1000.0 / (1.0 * 1.0 * 1.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) dekagram per cubic meter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DekagramPerCubicMeter = new (
                                                               "dekagram per cubic meter"
                                                             , "dag/m^3"
                                                             , GramPerCubicMeter
                                                             , 10.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gram per cubic dekameter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density GramPerCubicDekameter = new (
                                                               "gram per cubic dekameter"
                                                             , "g/dam^3"
                                                             , GramPerCubicMeter
                                                             , 1.0 / (10.0 * 10.0 * 10.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic quectometer. Defined in terms of a(n) gram per cubic rontometer.
   /// </summary>
   public static readonly Density DecigramPerCubicQuectometer = new (
                                                                     "decigram per cubic quectometer"
                                                                   , "dg/qm^3"
                                                                   , GramPerCubicRontometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centigram per cubic rontometer. Defined in terms of a(n) decigram per cubic yoctometer.
   /// </summary>
   public static readonly Density CentigramPerCubicRontometer = new (
                                                                     "centigram per cubic rontometer"
                                                                   , "cg/rm^3"
                                                                   , DecigramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic yoctometer. Defined in terms of a(n) centigram per cubic zeptometer.
   /// </summary>
   public static readonly Density MilligramPerCubicYoctometer = new (
                                                                     "milligram per cubic yoctometer"
                                                                   , "mg/ym^3"
                                                                   , CentigramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic zeptometer. Defined in terms of a(n) milligram per cubic attometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicZeptometer = new (
                                                                     "microgram per cubic zeptometer"
                                                                   , "μg/zm^3"
                                                                   , MilligramPerCubicAttometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic attometer. Defined in terms of a(n) microgram per cubic femtometer.
   /// </summary>
   public static readonly Density NanogramPerCubicAttometer = new (
                                                                   "nanogram per cubic attometer"
                                                                 , "ng/am^3"
                                                                 , MicrogramPerCubicFemtometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic femtometer. Defined in terms of a(n) nanogram per cubic picometer.
   /// </summary>
   public static readonly Density PicogramPerCubicFemtometer = new (
                                                                    "picogram per cubic femtometer"
                                                                  , "pg/fm^3"
                                                                  , NanogramPerCubicPicometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic picometer. Defined in terms of a(n) picogram per cubic nanometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicPicometer = new (
                                                                    "femtogram per cubic picometer"
                                                                  , "fg/pm^3"
                                                                  , PicogramPerCubicNanometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic nanometer. Defined in terms of a(n) femtogram per cubic micrometer.
   /// </summary>
   public static readonly Density AttogramPerCubicNanometer = new (
                                                                   "attogram per cubic nanometer"
                                                                 , "ag/nm^3"
                                                                 , FemtogramPerCubicMicrometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic micrometer. Defined in terms of a(n) attogram per cubic millimeter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicMicrometer = new (
                                                                     "zeptogram per cubic micrometer"
                                                                   , "zg/μm^3"
                                                                   , AttogramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic millimeter. Defined in terms of a(n) zeptogram per cubic centimeter.
   /// </summary>
   public static readonly Density YoctogramPerCubicMillimeter = new (
                                                                     "yoctogram per cubic millimeter"
                                                                   , "yg/mm^3"
                                                                   , ZeptogramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic centimeter. Defined in terms of a(n) yoctogram per cubic decimeter.
   /// </summary>
   public static readonly Density RontogramPerCubicCentimeter = new (
                                                                     "rontogram per cubic centimeter"
                                                                   , "rg/cm^3"
                                                                   , YoctogramPerCubicDecimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic decimeter. Defined in terms of a(n) rontogram per cubic meter.
   /// </summary>
   public static readonly Density QuectogramPerCubicDecimeter = new (
                                                                     "quectogram per cubic decimeter"
                                                                   , "qg/dm^3"
                                                                   , RontogramPerCubicMeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectogram per cubic meter. Defined in terms of a(n) dekagram per cubic meter.
   /// </summary>
   public static readonly Density HectogramPerCubicMeter = new (
                                                                "hectogram per cubic meter"
                                                              , "hg/m^3"
                                                              , DekagramPerCubicMeter
                                                              , 10.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) dekagram per cubic decimeter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DekagramPerCubicDecimeter = new (
                                                                   "dekagram per cubic decimeter"
                                                                 , "dag/dm^3"
                                                                 , GramPerCubicMeter
                                                                 , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gram per cubic hectometer. Defined in terms of a(n) gram per cubic dekameter.
   /// </summary>
   public static readonly Density GramPerCubicHectometer = new (
                                                                "gram per cubic hectometer"
                                                              , "g/hm^3"
                                                              , GramPerCubicDekameter
                                                              , 1.0 / (10.0 * 10.0 * 10.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic dekameter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DecigramPerCubicDekameter = new (
                                                                   "decigram per cubic dekameter"
                                                                 , "dg/dam^3"
                                                                 , GramPerCubicMeter
                                                                 , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic quectometer. Defined in terms of a(n) decigram per cubic rontometer.
   /// </summary>
   public static readonly Density CentigramPerCubicQuectometer = new (
                                                                      "centigram per cubic quectometer"
                                                                    , "cg/qm^3"
                                                                    , DecigramPerCubicRontometer
                                                                    , 1.0
                                                                    / 10.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) milligram per cubic rontometer. Defined in terms of a(n) centigram per cubic yoctometer.
   /// </summary>
   public static readonly Density MilligramPerCubicRontometer = new (
                                                                     "milligram per cubic rontometer"
                                                                   , "mg/rm^3"
                                                                   , CentigramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic yoctometer. Defined in terms of a(n) milligram per cubic zeptometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicYoctometer = new (
                                                                     "microgram per cubic yoctometer"
                                                                   , "μg/ym^3"
                                                                   , MilligramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic zeptometer. Defined in terms of a(n) microgram per cubic attometer.
   /// </summary>
   public static readonly Density NanogramPerCubicZeptometer = new (
                                                                    "nanogram per cubic zeptometer"
                                                                  , "ng/zm^3"
                                                                  , MicrogramPerCubicAttometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic attometer. Defined in terms of a(n) nanogram per cubic femtometer.
   /// </summary>
   public static readonly Density PicogramPerCubicAttometer = new (
                                                                   "picogram per cubic attometer"
                                                                 , "pg/am^3"
                                                                 , NanogramPerCubicFemtometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic femtometer. Defined in terms of a(n) picogram per cubic picometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicFemtometer = new (
                                                                     "femtogram per cubic femtometer"
                                                                   , "fg/fm^3"
                                                                   , PicogramPerCubicPicometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic picometer. Defined in terms of a(n) femtogram per cubic nanometer.
   /// </summary>
   public static readonly Density AttogramPerCubicPicometer = new (
                                                                   "attogram per cubic picometer"
                                                                 , "ag/pm^3"
                                                                 , FemtogramPerCubicNanometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic nanometer. Defined in terms of a(n) attogram per cubic micrometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicNanometer = new (
                                                                    "zeptogram per cubic nanometer"
                                                                  , "zg/nm^3"
                                                                  , AttogramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic micrometer. Defined in terms of a(n) zeptogram per cubic millimeter.
   /// </summary>
   public static readonly Density YoctogramPerCubicMicrometer = new (
                                                                     "yoctogram per cubic micrometer"
                                                                   , "yg/μm^3"
                                                                   , ZeptogramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic millimeter. Defined in terms of a(n) yoctogram per cubic centimeter.
   /// </summary>
   public static readonly Density RontogramPerCubicMillimeter = new (
                                                                     "rontogram per cubic millimeter"
                                                                   , "rg/mm^3"
                                                                   , YoctogramPerCubicCentimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic centimeter. Defined in terms of a(n) rontogram per cubic decimeter.
   /// </summary>
   public static readonly Density QuectogramPerCubicCentimeter = new (
                                                                      "quectogram per cubic centimeter"
                                                                    , "qg/cm^3"
                                                                    , RontogramPerCubicDecimeter
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) kilogram per cubic meter. Defined in terms of a(n) hectogram per cubic meter.
   /// </summary>
   public static readonly Density KilogramPerCubicMeter = new (
                                                               "kilogram per cubic meter"
                                                             , "kg/m^3"
                                                             , HectogramPerCubicMeter
                                                             , 10.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) hectogram per cubic decimeter. Defined in terms of a(n) dekagram per cubic meter.
   /// </summary>
   public static readonly Density HectogramPerCubicDecimeter = new (
                                                                    "hectogram per cubic decimeter"
                                                                  , "hg/dm^3"
                                                                  , DekagramPerCubicMeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic centimeter. Defined in terms of a(n) gram per cubic decimeter.
   /// </summary>
   public static readonly Density DekagramPerCubicCentimeter = new (
                                                                    "dekagram per cubic centimeter"
                                                                  , "dag/cm^3"
                                                                  , GramPerCubicDecimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic kilometer. Defined in terms of a(n) gram per cubic hectometer.
   /// </summary>
   public static readonly Density GramPerCubicKilometer = new (
                                                               "gram per cubic kilometer"
                                                             , "g/km^3"
                                                             , GramPerCubicHectometer
                                                             , 1.0 / (10.0 * 10.0 * 10.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic hectometer. Defined in terms of a(n) gram per cubic dekameter.
   /// </summary>
   public static readonly Density DecigramPerCubicHectometer = new (
                                                                    "decigram per cubic hectometer"
                                                                  , "dg/hm^3"
                                                                  , GramPerCubicDekameter
                                                                  , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic dekameter. Defined in terms of a(n) decigram per cubic meter.
   /// </summary>
   public static readonly Density CentigramPerCubicDekameter = new (
                                                                    "centigram per cubic dekameter"
                                                                  , "cg/dam^3"
                                                                  , DecigramPerCubicMeter
                                                                  , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic quectometer. Defined in terms of a(n) centigram per cubic rontometer.
   /// </summary>
   public static readonly Density MilligramPerCubicQuectometer = new (
                                                                      "milligram per cubic quectometer"
                                                                    , "mg/qm^3"
                                                                    , CentigramPerCubicRontometer
                                                                    , 1.0
                                                                    / 10.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) microgram per cubic rontometer. Defined in terms of a(n) milligram per cubic yoctometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicRontometer = new (
                                                                     "microgram per cubic rontometer"
                                                                   , "μg/rm^3"
                                                                   , MilligramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic yoctometer. Defined in terms of a(n) microgram per cubic zeptometer.
   /// </summary>
   public static readonly Density NanogramPerCubicYoctometer = new (
                                                                    "nanogram per cubic yoctometer"
                                                                  , "ng/ym^3"
                                                                  , MicrogramPerCubicZeptometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic zeptometer. Defined in terms of a(n) nanogram per cubic attometer.
   /// </summary>
   public static readonly Density PicogramPerCubicZeptometer = new (
                                                                    "picogram per cubic zeptometer"
                                                                  , "pg/zm^3"
                                                                  , NanogramPerCubicAttometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic attometer. Defined in terms of a(n) picogram per cubic femtometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicAttometer = new (
                                                                    "femtogram per cubic attometer"
                                                                  , "fg/am^3"
                                                                  , PicogramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic femtometer. Defined in terms of a(n) femtogram per cubic picometer.
   /// </summary>
   public static readonly Density AttogramPerCubicFemtometer = new (
                                                                    "attogram per cubic femtometer"
                                                                  , "ag/fm^3"
                                                                  , FemtogramPerCubicPicometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic picometer. Defined in terms of a(n) attogram per cubic nanometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicPicometer = new (
                                                                    "zeptogram per cubic picometer"
                                                                  , "zg/pm^3"
                                                                  , AttogramPerCubicNanometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic nanometer. Defined in terms of a(n) zeptogram per cubic micrometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicNanometer = new (
                                                                    "yoctogram per cubic nanometer"
                                                                  , "yg/nm^3"
                                                                  , ZeptogramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic micrometer. Defined in terms of a(n) yoctogram per cubic millimeter.
   /// </summary>
   public static readonly Density RontogramPerCubicMicrometer = new (
                                                                     "rontogram per cubic micrometer"
                                                                   , "rg/μm^3"
                                                                   , YoctogramPerCubicMillimeter
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic millimeter. Defined in terms of a(n) rontogram per cubic centimeter.
   /// </summary>
   public static readonly Density QuectogramPerCubicMillimeter = new (
                                                                      "quectogram per cubic millimeter"
                                                                    , "qg/mm^3"
                                                                    , RontogramPerCubicCentimeter
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) megagram per cubic meter. Defined in terms of a(n) kilogram per cubic meter.
   /// </summary>
   public static readonly Density MegagramPerCubicMeter = new (
                                                               "megagram per cubic meter"
                                                             , "Mg/m^3"
                                                             , KilogramPerCubicMeter
                                                             , 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) kilogram per cubic decimeter. Defined in terms of a(n) hectogram per cubic meter.
   /// </summary>
   public static readonly Density KilogramPerCubicDecimeter = new (
                                                                   "kilogram per cubic decimeter"
                                                                 , "kg/dm^3"
                                                                 , HectogramPerCubicMeter
                                                                 , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic centimeter. Defined in terms of a(n) dekagram per cubic decimeter.
   /// </summary>
   public static readonly Density HectogramPerCubicCentimeter = new (
                                                                     "hectogram per cubic centimeter"
                                                                   , "hg/cm^3"
                                                                   , DekagramPerCubicDecimeter
                                                                   , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic millimeter. Defined in terms of a(n) gram per cubic centimeter.
   /// </summary>
   public static readonly Density DekagramPerCubicMillimeter = new (
                                                                    "dekagram per cubic millimeter"
                                                                  , "dag/mm^3"
                                                                  , GramPerCubicCentimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic megameter. Defined in terms of a(n) gram per cubic kilometer.
   /// </summary>
   public static readonly Density GramPerCubicMegameter = new (
                                                               "gram per cubic megameter"
                                                             , "g/Mm^3"
                                                             , GramPerCubicKilometer
                                                             , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic kilometer. Defined in terms of a(n) gram per cubic hectometer.
   /// </summary>
   public static readonly Density DecigramPerCubicKilometer = new (
                                                                   "decigram per cubic kilometer"
                                                                 , "dg/km^3"
                                                                 , GramPerCubicHectometer
                                                                 , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic hectometer. Defined in terms of a(n) decigram per cubic dekameter.
   /// </summary>
   public static readonly Density CentigramPerCubicHectometer = new (
                                                                     "centigram per cubic hectometer"
                                                                   , "cg/hm^3"
                                                                   , DecigramPerCubicDekameter
                                                                   , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic dekameter. Defined in terms of a(n) centigram per cubic meter.
   /// </summary>
   public static readonly Density MilligramPerCubicDekameter = new (
                                                                    "milligram per cubic dekameter"
                                                                  , "mg/dam^3"
                                                                  , CentigramPerCubicMeter
                                                                  , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic quectometer. Defined in terms of a(n) milligram per cubic rontometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicQuectometer = new (
                                                                      "microgram per cubic quectometer"
                                                                    , "μg/qm^3"
                                                                    , MilligramPerCubicRontometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanogram per cubic rontometer. Defined in terms of a(n) microgram per cubic yoctometer.
   /// </summary>
   public static readonly Density NanogramPerCubicRontometer = new (
                                                                    "nanogram per cubic rontometer"
                                                                  , "ng/rm^3"
                                                                  , MicrogramPerCubicYoctometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic yoctometer. Defined in terms of a(n) nanogram per cubic zeptometer.
   /// </summary>
   public static readonly Density PicogramPerCubicYoctometer = new (
                                                                    "picogram per cubic yoctometer"
                                                                  , "pg/ym^3"
                                                                  , NanogramPerCubicZeptometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic zeptometer. Defined in terms of a(n) picogram per cubic attometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicZeptometer = new (
                                                                     "femtogram per cubic zeptometer"
                                                                   , "fg/zm^3"
                                                                   , PicogramPerCubicAttometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic attometer. Defined in terms of a(n) femtogram per cubic femtometer.
   /// </summary>
   public static readonly Density AttogramPerCubicAttometer = new (
                                                                   "attogram per cubic attometer"
                                                                 , "ag/am^3"
                                                                 , FemtogramPerCubicFemtometer
                                                                 , 1.0
                                                                 / 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic femtometer. Defined in terms of a(n) attogram per cubic picometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicFemtometer = new (
                                                                     "zeptogram per cubic femtometer"
                                                                   , "zg/fm^3"
                                                                   , AttogramPerCubicPicometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic picometer. Defined in terms of a(n) zeptogram per cubic nanometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicPicometer = new (
                                                                    "yoctogram per cubic picometer"
                                                                  , "yg/pm^3"
                                                                  , ZeptogramPerCubicNanometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic nanometer. Defined in terms of a(n) yoctogram per cubic micrometer.
   /// </summary>
   public static readonly Density RontogramPerCubicNanometer = new (
                                                                    "rontogram per cubic nanometer"
                                                                  , "rg/nm^3"
                                                                  , YoctogramPerCubicMicrometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic micrometer. Defined in terms of a(n) rontogram per cubic millimeter.
   /// </summary>
   public static readonly Density QuectogramPerCubicMicrometer = new (
                                                                      "quectogram per cubic micrometer"
                                                                    , "qg/μm^3"
                                                                    , RontogramPerCubicMillimeter
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) gigagram per cubic meter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density GigagramPerCubicMeter = new (
                                                               "gigagram per cubic meter"
                                                             , "Gg/m^3"
                                                             , MegagramPerCubicMeter
                                                             , 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) megagram per cubic decimeter. Defined in terms of a(n) kilogram per cubic meter.
   /// </summary>
   public static readonly Density MegagramPerCubicDecimeter = new (
                                                                   "megagram per cubic decimeter"
                                                                 , "Mg/dm^3"
                                                                 , KilogramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic centimeter. Defined in terms of a(n) hectogram per cubic decimeter.
   /// </summary>
   public static readonly Density KilogramPerCubicCentimeter = new (
                                                                    "kilogram per cubic centimeter"
                                                                  , "kg/cm^3"
                                                                  , HectogramPerCubicDecimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic millimeter. Defined in terms of a(n) dekagram per cubic centimeter.
   /// </summary>
   public static readonly Density HectogramPerCubicMillimeter = new (
                                                                     "hectogram per cubic millimeter"
                                                                   , "hg/mm^3"
                                                                   , DekagramPerCubicCentimeter
                                                                   , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic micrometer. Defined in terms of a(n) gram per cubic millimeter.
   /// </summary>
   public static readonly Density DekagramPerCubicMicrometer = new (
                                                                    "dekagram per cubic micrometer"
                                                                  , "dag/μm^3"
                                                                  , GramPerCubicMillimeter
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic gigameter. Defined in terms of a(n) gram per cubic megameter.
   /// </summary>
   public static readonly Density GramPerCubicGigameter = new (
                                                               "gram per cubic gigameter"
                                                             , "g/Gm^3"
                                                             , GramPerCubicMegameter
                                                             , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic megameter. Defined in terms of a(n) gram per cubic kilometer.
   /// </summary>
   public static readonly Density DecigramPerCubicMegameter = new (
                                                                   "decigram per cubic megameter"
                                                                 , "dg/Mm^3"
                                                                 , GramPerCubicKilometer
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic kilometer. Defined in terms of a(n) decigram per cubic hectometer.
   /// </summary>
   public static readonly Density CentigramPerCubicKilometer = new (
                                                                    "centigram per cubic kilometer"
                                                                  , "cg/km^3"
                                                                  , DecigramPerCubicHectometer
                                                                  , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic hectometer. Defined in terms of a(n) centigram per cubic dekameter.
   /// </summary>
   public static readonly Density MilligramPerCubicHectometer = new (
                                                                     "milligram per cubic hectometer"
                                                                   , "mg/hm^3"
                                                                   , CentigramPerCubicDekameter
                                                                   , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic dekameter. Defined in terms of a(n) milligram per cubic meter.
   /// </summary>
   public static readonly Density MicrogramPerCubicDekameter = new (
                                                                    "microgram per cubic dekameter"
                                                                  , "μg/dam^3"
                                                                  , MilligramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic quectometer. Defined in terms of a(n) microgram per cubic rontometer.
   /// </summary>
   public static readonly Density NanogramPerCubicQuectometer = new (
                                                                     "nanogram per cubic quectometer"
                                                                   , "ng/qm^3"
                                                                   , MicrogramPerCubicRontometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picogram per cubic rontometer. Defined in terms of a(n) nanogram per cubic yoctometer.
   /// </summary>
   public static readonly Density PicogramPerCubicRontometer = new (
                                                                    "picogram per cubic rontometer"
                                                                  , "pg/rm^3"
                                                                  , NanogramPerCubicYoctometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic yoctometer. Defined in terms of a(n) picogram per cubic zeptometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicYoctometer = new (
                                                                     "femtogram per cubic yoctometer"
                                                                   , "fg/ym^3"
                                                                   , PicogramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic zeptometer. Defined in terms of a(n) femtogram per cubic attometer.
   /// </summary>
   public static readonly Density AttogramPerCubicZeptometer = new (
                                                                    "attogram per cubic zeptometer"
                                                                  , "ag/zm^3"
                                                                  , FemtogramPerCubicAttometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic attometer. Defined in terms of a(n) attogram per cubic femtometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicAttometer = new (
                                                                    "zeptogram per cubic attometer"
                                                                  , "zg/am^3"
                                                                  , AttogramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic femtometer. Defined in terms of a(n) zeptogram per cubic picometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicFemtometer = new (
                                                                     "yoctogram per cubic femtometer"
                                                                   , "yg/fm^3"
                                                                   , ZeptogramPerCubicPicometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic picometer. Defined in terms of a(n) yoctogram per cubic nanometer.
   /// </summary>
   public static readonly Density RontogramPerCubicPicometer = new (
                                                                    "rontogram per cubic picometer"
                                                                  , "rg/pm^3"
                                                                  , YoctogramPerCubicNanometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic nanometer. Defined in terms of a(n) rontogram per cubic micrometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicNanometer = new (
                                                                     "quectogram per cubic nanometer"
                                                                   , "qg/nm^3"
                                                                   , RontogramPerCubicMicrometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) teragram per cubic meter. Defined in terms of a(n) gigagram per cubic meter.
   /// </summary>
   public static readonly Density TeragramPerCubicMeter = new (
                                                               "teragram per cubic meter"
                                                             , "Tg/m^3"
                                                             , GigagramPerCubicMeter
                                                             , 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) gigagram per cubic decimeter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density GigagramPerCubicDecimeter = new (
                                                                   "gigagram per cubic decimeter"
                                                                 , "Gg/dm^3"
                                                                 , MegagramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic centimeter. Defined in terms of a(n) kilogram per cubic decimeter.
   /// </summary>
   public static readonly Density MegagramPerCubicCentimeter = new (
                                                                    "megagram per cubic centimeter"
                                                                  , "Mg/cm^3"
                                                                  , KilogramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic millimeter. Defined in terms of a(n) hectogram per cubic centimeter.
   /// </summary>
   public static readonly Density KilogramPerCubicMillimeter = new (
                                                                    "kilogram per cubic millimeter"
                                                                  , "kg/mm^3"
                                                                  , HectogramPerCubicCentimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic micrometer. Defined in terms of a(n) dekagram per cubic millimeter.
   /// </summary>
   public static readonly Density HectogramPerCubicMicrometer = new (
                                                                     "hectogram per cubic micrometer"
                                                                   , "hg/μm^3"
                                                                   , DekagramPerCubicMillimeter
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic nanometer. Defined in terms of a(n) gram per cubic micrometer.
   /// </summary>
   public static readonly Density DekagramPerCubicNanometer = new (
                                                                   "dekagram per cubic nanometer"
                                                                 , "dag/nm^3"
                                                                 , GramPerCubicMicrometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gram per cubic terameter. Defined in terms of a(n) gram per cubic gigameter.
   /// </summary>
   public static readonly Density GramPerCubicTerameter = new (
                                                               "gram per cubic terameter"
                                                             , "g/Tm^3"
                                                             , GramPerCubicGigameter
                                                             , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic gigameter. Defined in terms of a(n) gram per cubic megameter.
   /// </summary>
   public static readonly Density DecigramPerCubicGigameter = new (
                                                                   "decigram per cubic gigameter"
                                                                 , "dg/Gm^3"
                                                                 , GramPerCubicMegameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic megameter. Defined in terms of a(n) decigram per cubic kilometer.
   /// </summary>
   public static readonly Density CentigramPerCubicMegameter = new (
                                                                    "centigram per cubic megameter"
                                                                  , "cg/Mm^3"
                                                                  , DecigramPerCubicKilometer
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic kilometer. Defined in terms of a(n) centigram per cubic hectometer.
   /// </summary>
   public static readonly Density MilligramPerCubicKilometer = new (
                                                                    "milligram per cubic kilometer"
                                                                  , "mg/km^3"
                                                                  , CentigramPerCubicHectometer
                                                                  , 1.0 / 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic hectometer. Defined in terms of a(n) milligram per cubic dekameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicHectometer = new (
                                                                     "microgram per cubic hectometer"
                                                                   , "μg/hm^3"
                                                                   , MilligramPerCubicDekameter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic dekameter. Defined in terms of a(n) microgram per cubic meter.
   /// </summary>
   public static readonly Density NanogramPerCubicDekameter = new (
                                                                   "nanogram per cubic dekameter"
                                                                 , "ng/dam^3"
                                                                 , MicrogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic quectometer. Defined in terms of a(n) nanogram per cubic rontometer.
   /// </summary>
   public static readonly Density PicogramPerCubicQuectometer = new (
                                                                     "picogram per cubic quectometer"
                                                                   , "pg/qm^3"
                                                                   , NanogramPerCubicRontometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtogram per cubic rontometer. Defined in terms of a(n) picogram per cubic yoctometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicRontometer = new (
                                                                     "femtogram per cubic rontometer"
                                                                   , "fg/rm^3"
                                                                   , PicogramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic yoctometer. Defined in terms of a(n) femtogram per cubic zeptometer.
   /// </summary>
   public static readonly Density AttogramPerCubicYoctometer = new (
                                                                    "attogram per cubic yoctometer"
                                                                  , "ag/ym^3"
                                                                  , FemtogramPerCubicZeptometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic zeptometer. Defined in terms of a(n) attogram per cubic attometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicZeptometer = new (
                                                                     "zeptogram per cubic zeptometer"
                                                                   , "zg/zm^3"
                                                                   , AttogramPerCubicAttometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic attometer. Defined in terms of a(n) zeptogram per cubic femtometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicAttometer = new (
                                                                    "yoctogram per cubic attometer"
                                                                  , "yg/am^3"
                                                                  , ZeptogramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic femtometer. Defined in terms of a(n) yoctogram per cubic picometer.
   /// </summary>
   public static readonly Density RontogramPerCubicFemtometer = new (
                                                                     "rontogram per cubic femtometer"
                                                                   , "rg/fm^3"
                                                                   , YoctogramPerCubicPicometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic picometer. Defined in terms of a(n) rontogram per cubic nanometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicPicometer = new (
                                                                     "quectogram per cubic picometer"
                                                                   , "qg/pm^3"
                                                                   , RontogramPerCubicNanometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) petagram per cubic meter. Defined in terms of a(n) teragram per cubic meter.
   /// </summary>
   public static readonly Density PetagramPerCubicMeter = new (
                                                               "petagram per cubic meter"
                                                             , "Pg/m^3"
                                                             , TeragramPerCubicMeter
                                                             , 1000.0 / (1.0 * 1.0 * 1.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) teragram per cubic decimeter. Defined in terms of a(n) gigagram per cubic meter.
   /// </summary>
   public static readonly Density TeragramPerCubicDecimeter = new (
                                                                   "teragram per cubic decimeter"
                                                                 , "Tg/dm^3"
                                                                 , GigagramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic centimeter. Defined in terms of a(n) megagram per cubic decimeter.
   /// </summary>
   public static readonly Density GigagramPerCubicCentimeter = new (
                                                                    "gigagram per cubic centimeter"
                                                                  , "Gg/cm^3"
                                                                  , MegagramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic millimeter. Defined in terms of a(n) kilogram per cubic centimeter.
   /// </summary>
   public static readonly Density MegagramPerCubicMillimeter = new (
                                                                    "megagram per cubic millimeter"
                                                                  , "Mg/mm^3"
                                                                  , KilogramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic micrometer. Defined in terms of a(n) hectogram per cubic millimeter.
   /// </summary>
   public static readonly Density KilogramPerCubicMicrometer = new (
                                                                    "kilogram per cubic micrometer"
                                                                  , "kg/μm^3"
                                                                  , HectogramPerCubicMillimeter
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic nanometer. Defined in terms of a(n) dekagram per cubic micrometer.
   /// </summary>
   public static readonly Density HectogramPerCubicNanometer = new (
                                                                    "hectogram per cubic nanometer"
                                                                  , "hg/nm^3"
                                                                  , DekagramPerCubicMicrometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic picometer. Defined in terms of a(n) gram per cubic nanometer.
   /// </summary>
   public static readonly Density DekagramPerCubicPicometer = new (
                                                                   "dekagram per cubic picometer"
                                                                 , "dag/pm^3"
                                                                 , GramPerCubicNanometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gram per cubic petameter. Defined in terms of a(n) gram per cubic terameter.
   /// </summary>
   public static readonly Density GramPerCubicPetameter = new (
                                                               "gram per cubic petameter"
                                                             , "g/Pm^3"
                                                             , GramPerCubicTerameter
                                                             , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                             , 0
                                                              );

   /// <summary>
   /// A(n) decigram per cubic terameter. Defined in terms of a(n) gram per cubic gigameter.
   /// </summary>
   public static readonly Density DecigramPerCubicTerameter = new (
                                                                   "decigram per cubic terameter"
                                                                 , "dg/Tm^3"
                                                                 , GramPerCubicGigameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic gigameter. Defined in terms of a(n) decigram per cubic megameter.
   /// </summary>
   public static readonly Density CentigramPerCubicGigameter = new (
                                                                    "centigram per cubic gigameter"
                                                                  , "cg/Gm^3"
                                                                  , DecigramPerCubicMegameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic megameter. Defined in terms of a(n) centigram per cubic kilometer.
   /// </summary>
   public static readonly Density MilligramPerCubicMegameter = new (
                                                                    "milligram per cubic megameter"
                                                                  , "mg/Mm^3"
                                                                  , CentigramPerCubicKilometer
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic kilometer. Defined in terms of a(n) milligram per cubic hectometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicKilometer = new (
                                                                    "microgram per cubic kilometer"
                                                                  , "μg/km^3"
                                                                  , MilligramPerCubicHectometer
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic hectometer. Defined in terms of a(n) microgram per cubic dekameter.
   /// </summary>
   public static readonly Density NanogramPerCubicHectometer = new (
                                                                    "nanogram per cubic hectometer"
                                                                  , "ng/hm^3"
                                                                  , MicrogramPerCubicDekameter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic dekameter. Defined in terms of a(n) nanogram per cubic meter.
   /// </summary>
   public static readonly Density PicogramPerCubicDekameter = new (
                                                                   "picogram per cubic dekameter"
                                                                 , "pg/dam^3"
                                                                 , NanogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic quectometer. Defined in terms of a(n) picogram per cubic rontometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicQuectometer = new (
                                                                      "femtogram per cubic quectometer"
                                                                    , "fg/qm^3"
                                                                    , PicogramPerCubicRontometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attogram per cubic rontometer. Defined in terms of a(n) femtogram per cubic yoctometer.
   /// </summary>
   public static readonly Density AttogramPerCubicRontometer = new (
                                                                    "attogram per cubic rontometer"
                                                                  , "ag/rm^3"
                                                                  , FemtogramPerCubicYoctometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic yoctometer. Defined in terms of a(n) attogram per cubic zeptometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicYoctometer = new (
                                                                     "zeptogram per cubic yoctometer"
                                                                   , "zg/ym^3"
                                                                   , AttogramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic zeptometer. Defined in terms of a(n) zeptogram per cubic attometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicZeptometer = new (
                                                                     "yoctogram per cubic zeptometer"
                                                                   , "yg/zm^3"
                                                                   , ZeptogramPerCubicAttometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic attometer. Defined in terms of a(n) yoctogram per cubic femtometer.
   /// </summary>
   public static readonly Density RontogramPerCubicAttometer = new (
                                                                    "rontogram per cubic attometer"
                                                                  , "rg/am^3"
                                                                  , YoctogramPerCubicFemtometer
                                                                  , 1.0
                                                                  / 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic femtometer. Defined in terms of a(n) rontogram per cubic picometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicFemtometer = new (
                                                                      "quectogram per cubic femtometer"
                                                                    , "qg/fm^3"
                                                                    , RontogramPerCubicPicometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) exagram per cubic meter. Defined in terms of a(n) petagram per cubic meter.
   /// </summary>
   public static readonly Density ExagramPerCubicMeter = new (
                                                              "exagram per cubic meter"
                                                            , "Eg/m^3"
                                                            , PetagramPerCubicMeter
                                                            , 1000.0 / (1.0 * 1.0 * 1.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) petagram per cubic decimeter. Defined in terms of a(n) teragram per cubic meter.
   /// </summary>
   public static readonly Density PetagramPerCubicDecimeter = new (
                                                                   "petagram per cubic decimeter"
                                                                 , "Pg/dm^3"
                                                                 , TeragramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic centimeter. Defined in terms of a(n) gigagram per cubic decimeter.
   /// </summary>
   public static readonly Density TeragramPerCubicCentimeter = new (
                                                                    "teragram per cubic centimeter"
                                                                  , "Tg/cm^3"
                                                                  , GigagramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic millimeter. Defined in terms of a(n) megagram per cubic centimeter.
   /// </summary>
   public static readonly Density GigagramPerCubicMillimeter = new (
                                                                    "gigagram per cubic millimeter"
                                                                  , "Gg/mm^3"
                                                                  , MegagramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic micrometer. Defined in terms of a(n) kilogram per cubic millimeter.
   /// </summary>
   public static readonly Density MegagramPerCubicMicrometer = new (
                                                                    "megagram per cubic micrometer"
                                                                  , "Mg/μm^3"
                                                                  , KilogramPerCubicMillimeter
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic nanometer. Defined in terms of a(n) hectogram per cubic micrometer.
   /// </summary>
   public static readonly Density KilogramPerCubicNanometer = new (
                                                                   "kilogram per cubic nanometer"
                                                                 , "kg/nm^3"
                                                                 , HectogramPerCubicMicrometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic picometer. Defined in terms of a(n) dekagram per cubic nanometer.
   /// </summary>
   public static readonly Density HectogramPerCubicPicometer = new (
                                                                    "hectogram per cubic picometer"
                                                                  , "hg/pm^3"
                                                                  , DekagramPerCubicNanometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic femtometer. Defined in terms of a(n) gram per cubic picometer.
   /// </summary>
   public static readonly Density DekagramPerCubicFemtometer = new (
                                                                    "dekagram per cubic femtometer"
                                                                  , "dag/fm^3"
                                                                  , GramPerCubicPicometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic exameter. Defined in terms of a(n) gram per cubic petameter.
   /// </summary>
   public static readonly Density GramPerCubicExameter = new (
                                                              "gram per cubic exameter"
                                                            , "g/Em^3"
                                                            , GramPerCubicPetameter
                                                            , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                            , 0
                                                             );

   /// <summary>
   /// A(n) decigram per cubic petameter. Defined in terms of a(n) gram per cubic terameter.
   /// </summary>
   public static readonly Density DecigramPerCubicPetameter = new (
                                                                   "decigram per cubic petameter"
                                                                 , "dg/Pm^3"
                                                                 , GramPerCubicTerameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic terameter. Defined in terms of a(n) decigram per cubic gigameter.
   /// </summary>
   public static readonly Density CentigramPerCubicTerameter = new (
                                                                    "centigram per cubic terameter"
                                                                  , "cg/Tm^3"
                                                                  , DecigramPerCubicGigameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic gigameter. Defined in terms of a(n) centigram per cubic megameter.
   /// </summary>
   public static readonly Density MilligramPerCubicGigameter = new (
                                                                    "milligram per cubic gigameter"
                                                                  , "mg/Gm^3"
                                                                  , CentigramPerCubicMegameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic megameter. Defined in terms of a(n) milligram per cubic kilometer.
   /// </summary>
   public static readonly Density MicrogramPerCubicMegameter = new (
                                                                    "microgram per cubic megameter"
                                                                  , "μg/Mm^3"
                                                                  , MilligramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic kilometer. Defined in terms of a(n) microgram per cubic hectometer.
   /// </summary>
   public static readonly Density NanogramPerCubicKilometer = new (
                                                                   "nanogram per cubic kilometer"
                                                                 , "ng/km^3"
                                                                 , MicrogramPerCubicHectometer
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic hectometer. Defined in terms of a(n) nanogram per cubic dekameter.
   /// </summary>
   public static readonly Density PicogramPerCubicHectometer = new (
                                                                    "picogram per cubic hectometer"
                                                                  , "pg/hm^3"
                                                                  , NanogramPerCubicDekameter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic dekameter. Defined in terms of a(n) picogram per cubic meter.
   /// </summary>
   public static readonly Density FemtogramPerCubicDekameter = new (
                                                                    "femtogram per cubic dekameter"
                                                                  , "fg/dam^3"
                                                                  , PicogramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic quectometer. Defined in terms of a(n) femtogram per cubic rontometer.
   /// </summary>
   public static readonly Density AttogramPerCubicQuectometer = new (
                                                                     "attogram per cubic quectometer"
                                                                   , "ag/qm^3"
                                                                   , FemtogramPerCubicRontometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptogram per cubic rontometer. Defined in terms of a(n) attogram per cubic yoctometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicRontometer = new (
                                                                     "zeptogram per cubic rontometer"
                                                                   , "zg/rm^3"
                                                                   , AttogramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic yoctometer. Defined in terms of a(n) zeptogram per cubic zeptometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicYoctometer = new (
                                                                     "yoctogram per cubic yoctometer"
                                                                   , "yg/ym^3"
                                                                   , ZeptogramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic zeptometer. Defined in terms of a(n) yoctogram per cubic attometer.
   /// </summary>
   public static readonly Density RontogramPerCubicZeptometer = new (
                                                                     "rontogram per cubic zeptometer"
                                                                   , "rg/zm^3"
                                                                   , YoctogramPerCubicAttometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic attometer. Defined in terms of a(n) rontogram per cubic femtometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicAttometer = new (
                                                                     "quectogram per cubic attometer"
                                                                   , "qg/am^3"
                                                                   , RontogramPerCubicFemtometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic meter. Defined in terms of a(n) exagram per cubic meter.
   /// </summary>
   public static readonly Density ZettagramPerCubicMeter = new (
                                                                "zettagram per cubic meter"
                                                              , "Zg/m^3"
                                                              , ExagramPerCubicMeter
                                                              , 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) exagram per cubic decimeter. Defined in terms of a(n) petagram per cubic meter.
   /// </summary>
   public static readonly Density ExagramPerCubicDecimeter = new (
                                                                  "exagram per cubic decimeter"
                                                                , "Eg/dm^3"
                                                                , PetagramPerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic centimeter. Defined in terms of a(n) teragram per cubic decimeter.
   /// </summary>
   public static readonly Density PetagramPerCubicCentimeter = new (
                                                                    "petagram per cubic centimeter"
                                                                  , "Pg/cm^3"
                                                                  , TeragramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic millimeter. Defined in terms of a(n) gigagram per cubic centimeter.
   /// </summary>
   public static readonly Density TeragramPerCubicMillimeter = new (
                                                                    "teragram per cubic millimeter"
                                                                  , "Tg/mm^3"
                                                                  , GigagramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic micrometer. Defined in terms of a(n) megagram per cubic millimeter.
   /// </summary>
   public static readonly Density GigagramPerCubicMicrometer = new (
                                                                    "gigagram per cubic micrometer"
                                                                  , "Gg/μm^3"
                                                                  , MegagramPerCubicMillimeter
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic nanometer. Defined in terms of a(n) kilogram per cubic micrometer.
   /// </summary>
   public static readonly Density MegagramPerCubicNanometer = new (
                                                                   "megagram per cubic nanometer"
                                                                 , "Mg/nm^3"
                                                                 , KilogramPerCubicMicrometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic picometer. Defined in terms of a(n) hectogram per cubic nanometer.
   /// </summary>
   public static readonly Density KilogramPerCubicPicometer = new (
                                                                   "kilogram per cubic picometer"
                                                                 , "kg/pm^3"
                                                                 , HectogramPerCubicNanometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic femtometer. Defined in terms of a(n) dekagram per cubic picometer.
   /// </summary>
   public static readonly Density HectogramPerCubicFemtometer = new (
                                                                     "hectogram per cubic femtometer"
                                                                   , "hg/fm^3"
                                                                   , DekagramPerCubicPicometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic attometer. Defined in terms of a(n) gram per cubic femtometer.
   /// </summary>
   public static readonly Density DekagramPerCubicAttometer = new (
                                                                   "dekagram per cubic attometer"
                                                                 , "dag/am^3"
                                                                 , GramPerCubicFemtometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gram per cubic zettameter. Defined in terms of a(n) gram per cubic exameter.
   /// </summary>
   public static readonly Density GramPerCubicZettameter = new (
                                                                "gram per cubic zettameter"
                                                              , "g/Zm^3"
                                                              , GramPerCubicExameter
                                                              , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic exameter. Defined in terms of a(n) gram per cubic petameter.
   /// </summary>
   public static readonly Density DecigramPerCubicExameter = new (
                                                                  "decigram per cubic exameter"
                                                                , "dg/Em^3"
                                                                , GramPerCubicPetameter
                                                                , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) centigram per cubic petameter. Defined in terms of a(n) decigram per cubic terameter.
   /// </summary>
   public static readonly Density CentigramPerCubicPetameter = new (
                                                                    "centigram per cubic petameter"
                                                                  , "cg/Pm^3"
                                                                  , DecigramPerCubicTerameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic terameter. Defined in terms of a(n) centigram per cubic gigameter.
   /// </summary>
   public static readonly Density MilligramPerCubicTerameter = new (
                                                                    "milligram per cubic terameter"
                                                                  , "mg/Tm^3"
                                                                  , CentigramPerCubicGigameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic gigameter. Defined in terms of a(n) milligram per cubic megameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicGigameter = new (
                                                                    "microgram per cubic gigameter"
                                                                  , "μg/Gm^3"
                                                                  , MilligramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic megameter. Defined in terms of a(n) microgram per cubic kilometer.
   /// </summary>
   public static readonly Density NanogramPerCubicMegameter = new (
                                                                   "nanogram per cubic megameter"
                                                                 , "ng/Mm^3"
                                                                 , MicrogramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic kilometer. Defined in terms of a(n) nanogram per cubic hectometer.
   /// </summary>
   public static readonly Density PicogramPerCubicKilometer = new (
                                                                   "picogram per cubic kilometer"
                                                                 , "pg/km^3"
                                                                 , NanogramPerCubicHectometer
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic hectometer. Defined in terms of a(n) picogram per cubic dekameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicHectometer = new (
                                                                     "femtogram per cubic hectometer"
                                                                   , "fg/hm^3"
                                                                   , PicogramPerCubicDekameter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic dekameter. Defined in terms of a(n) femtogram per cubic meter.
   /// </summary>
   public static readonly Density AttogramPerCubicDekameter = new (
                                                                   "attogram per cubic dekameter"
                                                                 , "ag/dam^3"
                                                                 , FemtogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic quectometer. Defined in terms of a(n) attogram per cubic rontometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicQuectometer = new (
                                                                      "zeptogram per cubic quectometer"
                                                                    , "zg/qm^3"
                                                                    , AttogramPerCubicRontometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctogram per cubic rontometer. Defined in terms of a(n) zeptogram per cubic yoctometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicRontometer = new (
                                                                     "yoctogram per cubic rontometer"
                                                                   , "yg/rm^3"
                                                                   , ZeptogramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic yoctometer. Defined in terms of a(n) yoctogram per cubic zeptometer.
   /// </summary>
   public static readonly Density RontogramPerCubicYoctometer = new (
                                                                     "rontogram per cubic yoctometer"
                                                                   , "rg/ym^3"
                                                                   , YoctogramPerCubicZeptometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic zeptometer. Defined in terms of a(n) rontogram per cubic attometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicZeptometer = new (
                                                                      "quectogram per cubic zeptometer"
                                                                    , "qg/zm^3"
                                                                    , RontogramPerCubicAttometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottagram per cubic meter. Defined in terms of a(n) zettagram per cubic meter.
   /// </summary>
   public static readonly Density YottagramPerCubicMeter = new (
                                                                "yottagram per cubic meter"
                                                              , "Yg/m^3"
                                                              , ZettagramPerCubicMeter
                                                              , 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) zettagram per cubic decimeter. Defined in terms of a(n) exagram per cubic meter.
   /// </summary>
   public static readonly Density ZettagramPerCubicDecimeter = new (
                                                                    "zettagram per cubic decimeter"
                                                                  , "Zg/dm^3"
                                                                  , ExagramPerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic centimeter. Defined in terms of a(n) petagram per cubic decimeter.
   /// </summary>
   public static readonly Density ExagramPerCubicCentimeter = new (
                                                                   "exagram per cubic centimeter"
                                                                 , "Eg/cm^3"
                                                                 , PetagramPerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic millimeter. Defined in terms of a(n) teragram per cubic centimeter.
   /// </summary>
   public static readonly Density PetagramPerCubicMillimeter = new (
                                                                    "petagram per cubic millimeter"
                                                                  , "Pg/mm^3"
                                                                  , TeragramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic micrometer. Defined in terms of a(n) gigagram per cubic millimeter.
   /// </summary>
   public static readonly Density TeragramPerCubicMicrometer = new (
                                                                    "teragram per cubic micrometer"
                                                                  , "Tg/μm^3"
                                                                  , GigagramPerCubicMillimeter
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic nanometer. Defined in terms of a(n) megagram per cubic micrometer.
   /// </summary>
   public static readonly Density GigagramPerCubicNanometer = new (
                                                                   "gigagram per cubic nanometer"
                                                                 , "Gg/nm^3"
                                                                 , MegagramPerCubicMicrometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic picometer. Defined in terms of a(n) kilogram per cubic nanometer.
   /// </summary>
   public static readonly Density MegagramPerCubicPicometer = new (
                                                                   "megagram per cubic picometer"
                                                                 , "Mg/pm^3"
                                                                 , KilogramPerCubicNanometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic femtometer. Defined in terms of a(n) hectogram per cubic picometer.
   /// </summary>
   public static readonly Density KilogramPerCubicFemtometer = new (
                                                                    "kilogram per cubic femtometer"
                                                                  , "kg/fm^3"
                                                                  , HectogramPerCubicPicometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic attometer. Defined in terms of a(n) dekagram per cubic femtometer.
   /// </summary>
   public static readonly Density HectogramPerCubicAttometer = new (
                                                                    "hectogram per cubic attometer"
                                                                  , "hg/am^3"
                                                                  , DekagramPerCubicFemtometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic zeptometer. Defined in terms of a(n) gram per cubic attometer.
   /// </summary>
   public static readonly Density DekagramPerCubicZeptometer = new (
                                                                    "dekagram per cubic zeptometer"
                                                                  , "dag/zm^3"
                                                                  , GramPerCubicAttometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic yottameter. Defined in terms of a(n) gram per cubic zettameter.
   /// </summary>
   public static readonly Density GramPerCubicYottameter = new (
                                                                "gram per cubic yottameter"
                                                              , "g/Ym^3"
                                                              , GramPerCubicZettameter
                                                              , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic zettameter. Defined in terms of a(n) gram per cubic exameter.
   /// </summary>
   public static readonly Density DecigramPerCubicZettameter = new (
                                                                    "decigram per cubic zettameter"
                                                                  , "dg/Zm^3"
                                                                  , GramPerCubicExameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic exameter. Defined in terms of a(n) decigram per cubic petameter.
   /// </summary>
   public static readonly Density CentigramPerCubicExameter = new (
                                                                   "centigram per cubic exameter"
                                                                 , "cg/Em^3"
                                                                 , DecigramPerCubicPetameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) milligram per cubic petameter. Defined in terms of a(n) centigram per cubic terameter.
   /// </summary>
   public static readonly Density MilligramPerCubicPetameter = new (
                                                                    "milligram per cubic petameter"
                                                                  , "mg/Pm^3"
                                                                  , CentigramPerCubicTerameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) microgram per cubic terameter. Defined in terms of a(n) milligram per cubic gigameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicTerameter = new (
                                                                    "microgram per cubic terameter"
                                                                  , "μg/Tm^3"
                                                                  , MilligramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic gigameter. Defined in terms of a(n) microgram per cubic megameter.
   /// </summary>
   public static readonly Density NanogramPerCubicGigameter = new (
                                                                   "nanogram per cubic gigameter"
                                                                 , "ng/Gm^3"
                                                                 , MicrogramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic megameter. Defined in terms of a(n) nanogram per cubic kilometer.
   /// </summary>
   public static readonly Density PicogramPerCubicMegameter = new (
                                                                   "picogram per cubic megameter"
                                                                 , "pg/Mm^3"
                                                                 , NanogramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic kilometer. Defined in terms of a(n) picogram per cubic hectometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicKilometer = new (
                                                                    "femtogram per cubic kilometer"
                                                                  , "fg/km^3"
                                                                  , PicogramPerCubicHectometer
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic hectometer. Defined in terms of a(n) femtogram per cubic dekameter.
   /// </summary>
   public static readonly Density AttogramPerCubicHectometer = new (
                                                                    "attogram per cubic hectometer"
                                                                  , "ag/hm^3"
                                                                  , FemtogramPerCubicDekameter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic dekameter. Defined in terms of a(n) attogram per cubic meter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicDekameter = new (
                                                                    "zeptogram per cubic dekameter"
                                                                  , "zg/dam^3"
                                                                  , AttogramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic quectometer. Defined in terms of a(n) zeptogram per cubic rontometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicQuectometer = new (
                                                                      "yoctogram per cubic quectometer"
                                                                    , "yg/qm^3"
                                                                    , ZeptogramPerCubicRontometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rontogram per cubic rontometer. Defined in terms of a(n) yoctogram per cubic yoctometer.
   /// </summary>
   public static readonly Density RontogramPerCubicRontometer = new (
                                                                     "rontogram per cubic rontometer"
                                                                   , "rg/rm^3"
                                                                   , YoctogramPerCubicYoctometer
                                                                   , 1.0
                                                                   / 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic yoctometer. Defined in terms of a(n) rontogram per cubic zeptometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicYoctometer = new (
                                                                      "quectogram per cubic yoctometer"
                                                                    , "qg/ym^3"
                                                                    , RontogramPerCubicZeptometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic meter. Defined in terms of a(n) yottagram per cubic meter.
   /// </summary>
   public static readonly Density RonnagramPerCubicMeter = new (
                                                                "ronnagram per cubic meter"
                                                              , "Rg/m^3"
                                                              , YottagramPerCubicMeter
                                                              , 1000.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) yottagram per cubic decimeter. Defined in terms of a(n) zettagram per cubic meter.
   /// </summary>
   public static readonly Density YottagramPerCubicDecimeter = new (
                                                                    "yottagram per cubic decimeter"
                                                                  , "Yg/dm^3"
                                                                  , ZettagramPerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic centimeter. Defined in terms of a(n) exagram per cubic decimeter.
   /// </summary>
   public static readonly Density ZettagramPerCubicCentimeter = new (
                                                                     "zettagram per cubic centimeter"
                                                                   , "Zg/cm^3"
                                                                   , ExagramPerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic millimeter. Defined in terms of a(n) petagram per cubic centimeter.
   /// </summary>
   public static readonly Density ExagramPerCubicMillimeter = new (
                                                                   "exagram per cubic millimeter"
                                                                 , "Eg/mm^3"
                                                                 , PetagramPerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic micrometer. Defined in terms of a(n) teragram per cubic millimeter.
   /// </summary>
   public static readonly Density PetagramPerCubicMicrometer = new (
                                                                    "petagram per cubic micrometer"
                                                                  , "Pg/μm^3"
                                                                  , TeragramPerCubicMillimeter
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic nanometer. Defined in terms of a(n) gigagram per cubic micrometer.
   /// </summary>
   public static readonly Density TeragramPerCubicNanometer = new (
                                                                   "teragram per cubic nanometer"
                                                                 , "Tg/nm^3"
                                                                 , GigagramPerCubicMicrometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic picometer. Defined in terms of a(n) megagram per cubic nanometer.
   /// </summary>
   public static readonly Density GigagramPerCubicPicometer = new (
                                                                   "gigagram per cubic picometer"
                                                                 , "Gg/pm^3"
                                                                 , MegagramPerCubicNanometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic femtometer. Defined in terms of a(n) kilogram per cubic picometer.
   /// </summary>
   public static readonly Density MegagramPerCubicFemtometer = new (
                                                                    "megagram per cubic femtometer"
                                                                  , "Mg/fm^3"
                                                                  , KilogramPerCubicPicometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic attometer. Defined in terms of a(n) hectogram per cubic femtometer.
   /// </summary>
   public static readonly Density KilogramPerCubicAttometer = new (
                                                                   "kilogram per cubic attometer"
                                                                 , "kg/am^3"
                                                                 , HectogramPerCubicFemtometer
                                                                 , 10.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic zeptometer. Defined in terms of a(n) dekagram per cubic attometer.
   /// </summary>
   public static readonly Density HectogramPerCubicZeptometer = new (
                                                                     "hectogram per cubic zeptometer"
                                                                   , "hg/zm^3"
                                                                   , DekagramPerCubicAttometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic yoctometer. Defined in terms of a(n) gram per cubic zeptometer.
   /// </summary>
   public static readonly Density DekagramPerCubicYoctometer = new (
                                                                    "dekagram per cubic yoctometer"
                                                                  , "dag/ym^3"
                                                                  , GramPerCubicZeptometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic ronnameter. Defined in terms of a(n) gram per cubic yottameter.
   /// </summary>
   public static readonly Density GramPerCubicRonnameter = new (
                                                                "gram per cubic ronnameter"
                                                              , "g/Rm^3"
                                                              , GramPerCubicYottameter
                                                              , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) decigram per cubic yottameter. Defined in terms of a(n) gram per cubic zettameter.
   /// </summary>
   public static readonly Density DecigramPerCubicYottameter = new (
                                                                    "decigram per cubic yottameter"
                                                                  , "dg/Ym^3"
                                                                  , GramPerCubicZettameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic zettameter. Defined in terms of a(n) decigram per cubic exameter.
   /// </summary>
   public static readonly Density CentigramPerCubicZettameter = new (
                                                                     "centigram per cubic zettameter"
                                                                   , "cg/Zm^3"
                                                                   , DecigramPerCubicExameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic exameter. Defined in terms of a(n) centigram per cubic petameter.
   /// </summary>
   public static readonly Density MilligramPerCubicExameter = new (
                                                                   "milligram per cubic exameter"
                                                                 , "mg/Em^3"
                                                                 , CentigramPerCubicPetameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) microgram per cubic petameter. Defined in terms of a(n) milligram per cubic terameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicPetameter = new (
                                                                    "microgram per cubic petameter"
                                                                  , "μg/Pm^3"
                                                                  , MilligramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) nanogram per cubic terameter. Defined in terms of a(n) microgram per cubic gigameter.
   /// </summary>
   public static readonly Density NanogramPerCubicTerameter = new (
                                                                   "nanogram per cubic terameter"
                                                                 , "ng/Tm^3"
                                                                 , MicrogramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic gigameter. Defined in terms of a(n) nanogram per cubic megameter.
   /// </summary>
   public static readonly Density PicogramPerCubicGigameter = new (
                                                                   "picogram per cubic gigameter"
                                                                 , "pg/Gm^3"
                                                                 , NanogramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic megameter. Defined in terms of a(n) picogram per cubic kilometer.
   /// </summary>
   public static readonly Density FemtogramPerCubicMegameter = new (
                                                                    "femtogram per cubic megameter"
                                                                  , "fg/Mm^3"
                                                                  , PicogramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic kilometer. Defined in terms of a(n) femtogram per cubic hectometer.
   /// </summary>
   public static readonly Density AttogramPerCubicKilometer = new (
                                                                   "attogram per cubic kilometer"
                                                                 , "ag/km^3"
                                                                 , FemtogramPerCubicHectometer
                                                                 , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic hectometer. Defined in terms of a(n) attogram per cubic dekameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicHectometer = new (
                                                                     "zeptogram per cubic hectometer"
                                                                   , "zg/hm^3"
                                                                   , AttogramPerCubicDekameter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic dekameter. Defined in terms of a(n) zeptogram per cubic meter.
   /// </summary>
   public static readonly Density YoctogramPerCubicDekameter = new (
                                                                    "yoctogram per cubic dekameter"
                                                                  , "yg/dam^3"
                                                                  , ZeptogramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic quectometer. Defined in terms of a(n) yoctogram per cubic rontometer.
   /// </summary>
   public static readonly Density RontogramPerCubicQuectometer = new (
                                                                      "rontogram per cubic quectometer"
                                                                    , "rg/qm^3"
                                                                    , YoctogramPerCubicRontometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quectogram per cubic rontometer. Defined in terms of a(n) rontogram per cubic yoctometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicRontometer = new (
                                                                      "quectogram per cubic rontometer"
                                                                    , "qg/rm^3"
                                                                    , RontogramPerCubicYoctometer
                                                                    , 1.0
                                                                    / 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic meter. Defined in terms of a(n) ronnagram per cubic meter.
   /// </summary>
   public static readonly Density QuettagramPerCubicMeter = new (
                                                                 "quettagram per cubic meter"
                                                               , "Qg/m^3"
                                                               , RonnagramPerCubicMeter
                                                               , 1000.0 / (1.0 * 1.0 * 1.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) ronnagram per cubic decimeter. Defined in terms of a(n) yottagram per cubic meter.
   /// </summary>
   public static readonly Density RonnagramPerCubicDecimeter = new (
                                                                    "ronnagram per cubic decimeter"
                                                                  , "Rg/dm^3"
                                                                  , YottagramPerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic centimeter. Defined in terms of a(n) zettagram per cubic decimeter.
   /// </summary>
   public static readonly Density YottagramPerCubicCentimeter = new (
                                                                     "yottagram per cubic centimeter"
                                                                   , "Yg/cm^3"
                                                                   , ZettagramPerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic millimeter. Defined in terms of a(n) exagram per cubic centimeter.
   /// </summary>
   public static readonly Density ZettagramPerCubicMillimeter = new (
                                                                     "zettagram per cubic millimeter"
                                                                   , "Zg/mm^3"
                                                                   , ExagramPerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic micrometer. Defined in terms of a(n) petagram per cubic millimeter.
   /// </summary>
   public static readonly Density ExagramPerCubicMicrometer = new (
                                                                   "exagram per cubic micrometer"
                                                                 , "Eg/μm^3"
                                                                 , PetagramPerCubicMillimeter
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic nanometer. Defined in terms of a(n) teragram per cubic micrometer.
   /// </summary>
   public static readonly Density PetagramPerCubicNanometer = new (
                                                                   "petagram per cubic nanometer"
                                                                 , "Pg/nm^3"
                                                                 , TeragramPerCubicMicrometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic picometer. Defined in terms of a(n) gigagram per cubic nanometer.
   /// </summary>
   public static readonly Density TeragramPerCubicPicometer = new (
                                                                   "teragram per cubic picometer"
                                                                 , "Tg/pm^3"
                                                                 , GigagramPerCubicNanometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic femtometer. Defined in terms of a(n) megagram per cubic picometer.
   /// </summary>
   public static readonly Density GigagramPerCubicFemtometer = new (
                                                                    "gigagram per cubic femtometer"
                                                                  , "Gg/fm^3"
                                                                  , MegagramPerCubicPicometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic attometer. Defined in terms of a(n) kilogram per cubic femtometer.
   /// </summary>
   public static readonly Density MegagramPerCubicAttometer = new (
                                                                   "megagram per cubic attometer"
                                                                 , "Mg/am^3"
                                                                 , KilogramPerCubicFemtometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic zeptometer. Defined in terms of a(n) hectogram per cubic attometer.
   /// </summary>
   public static readonly Density KilogramPerCubicZeptometer = new (
                                                                    "kilogram per cubic zeptometer"
                                                                  , "kg/zm^3"
                                                                  , HectogramPerCubicAttometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic yoctometer. Defined in terms of a(n) dekagram per cubic zeptometer.
   /// </summary>
   public static readonly Density HectogramPerCubicYoctometer = new (
                                                                     "hectogram per cubic yoctometer"
                                                                   , "hg/ym^3"
                                                                   , DekagramPerCubicZeptometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic rontometer. Defined in terms of a(n) gram per cubic yoctometer.
   /// </summary>
   public static readonly Density DekagramPerCubicRontometer = new (
                                                                    "dekagram per cubic rontometer"
                                                                  , "dag/rm^3"
                                                                  , GramPerCubicYoctometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gram per cubic quettameter. Defined in terms of a(n) gram per cubic ronnameter.
   /// </summary>
   public static readonly Density GramPerCubicQuettameter = new (
                                                                 "gram per cubic quettameter"
                                                               , "g/Qm^3"
                                                               , GramPerCubicRonnameter
                                                               , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) decigram per cubic ronnameter. Defined in terms of a(n) gram per cubic yottameter.
   /// </summary>
   public static readonly Density DecigramPerCubicRonnameter = new (
                                                                    "decigram per cubic ronnameter"
                                                                  , "dg/Rm^3"
                                                                  , GramPerCubicYottameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) centigram per cubic yottameter. Defined in terms of a(n) decigram per cubic zettameter.
   /// </summary>
   public static readonly Density CentigramPerCubicYottameter = new (
                                                                     "centigram per cubic yottameter"
                                                                   , "cg/Ym^3"
                                                                   , DecigramPerCubicZettameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic zettameter. Defined in terms of a(n) centigram per cubic exameter.
   /// </summary>
   public static readonly Density MilligramPerCubicZettameter = new (
                                                                     "milligram per cubic zettameter"
                                                                   , "mg/Zm^3"
                                                                   , CentigramPerCubicExameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic exameter. Defined in terms of a(n) milligram per cubic petameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicExameter = new (
                                                                   "microgram per cubic exameter"
                                                                 , "μg/Em^3"
                                                                 , MilligramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanogram per cubic petameter. Defined in terms of a(n) microgram per cubic terameter.
   /// </summary>
   public static readonly Density NanogramPerCubicPetameter = new (
                                                                   "nanogram per cubic petameter"
                                                                 , "ng/Pm^3"
                                                                 , MicrogramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic terameter. Defined in terms of a(n) nanogram per cubic gigameter.
   /// </summary>
   public static readonly Density PicogramPerCubicTerameter = new (
                                                                   "picogram per cubic terameter"
                                                                 , "pg/Tm^3"
                                                                 , NanogramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic gigameter. Defined in terms of a(n) picogram per cubic megameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicGigameter = new (
                                                                    "femtogram per cubic gigameter"
                                                                  , "fg/Gm^3"
                                                                  , PicogramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic megameter. Defined in terms of a(n) femtogram per cubic kilometer.
   /// </summary>
   public static readonly Density AttogramPerCubicMegameter = new (
                                                                   "attogram per cubic megameter"
                                                                 , "ag/Mm^3"
                                                                 , FemtogramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic kilometer. Defined in terms of a(n) attogram per cubic hectometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicKilometer = new (
                                                                    "zeptogram per cubic kilometer"
                                                                  , "zg/km^3"
                                                                  , AttogramPerCubicHectometer
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic hectometer. Defined in terms of a(n) zeptogram per cubic dekameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicHectometer = new (
                                                                     "yoctogram per cubic hectometer"
                                                                   , "yg/hm^3"
                                                                   , ZeptogramPerCubicDekameter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic dekameter. Defined in terms of a(n) yoctogram per cubic meter.
   /// </summary>
   public static readonly Density RontogramPerCubicDekameter = new (
                                                                    "rontogram per cubic dekameter"
                                                                  , "rg/dam^3"
                                                                  , YoctogramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic quectometer. Defined in terms of a(n) rontogram per cubic rontometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicQuectometer = new (
                                                                       "quectogram per cubic quectometer"
                                                                     , "qg/qm^3"
                                                                     , RontogramPerCubicRontometer
                                                                     , 1.0
                                                                     / 1000.0
                                                                     / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quettagram per cubic decimeter. Defined in terms of a(n) ronnagram per cubic meter.
   /// </summary>
   public static readonly Density QuettagramPerCubicDecimeter = new (
                                                                     "quettagram per cubic decimeter"
                                                                   , "Qg/dm^3"
                                                                   , RonnagramPerCubicMeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic centimeter. Defined in terms of a(n) yottagram per cubic decimeter.
   /// </summary>
   public static readonly Density RonnagramPerCubicCentimeter = new (
                                                                     "ronnagram per cubic centimeter"
                                                                   , "Rg/cm^3"
                                                                   , YottagramPerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic millimeter. Defined in terms of a(n) zettagram per cubic centimeter.
   /// </summary>
   public static readonly Density YottagramPerCubicMillimeter = new (
                                                                     "yottagram per cubic millimeter"
                                                                   , "Yg/mm^3"
                                                                   , ZettagramPerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic micrometer. Defined in terms of a(n) exagram per cubic millimeter.
   /// </summary>
   public static readonly Density ZettagramPerCubicMicrometer = new (
                                                                     "zettagram per cubic micrometer"
                                                                   , "Zg/μm^3"
                                                                   , ExagramPerCubicMillimeter
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic nanometer. Defined in terms of a(n) petagram per cubic micrometer.
   /// </summary>
   public static readonly Density ExagramPerCubicNanometer = new (
                                                                  "exagram per cubic nanometer"
                                                                , "Eg/nm^3"
                                                                , PetagramPerCubicMicrometer
                                                                , 1000.0
                                                                / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic picometer. Defined in terms of a(n) teragram per cubic nanometer.
   /// </summary>
   public static readonly Density PetagramPerCubicPicometer = new (
                                                                   "petagram per cubic picometer"
                                                                 , "Pg/pm^3"
                                                                 , TeragramPerCubicNanometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic femtometer. Defined in terms of a(n) gigagram per cubic picometer.
   /// </summary>
   public static readonly Density TeragramPerCubicFemtometer = new (
                                                                    "teragram per cubic femtometer"
                                                                  , "Tg/fm^3"
                                                                  , GigagramPerCubicPicometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic attometer. Defined in terms of a(n) megagram per cubic femtometer.
   /// </summary>
   public static readonly Density GigagramPerCubicAttometer = new (
                                                                   "gigagram per cubic attometer"
                                                                 , "Gg/am^3"
                                                                 , MegagramPerCubicFemtometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic zeptometer. Defined in terms of a(n) kilogram per cubic attometer.
   /// </summary>
   public static readonly Density MegagramPerCubicZeptometer = new (
                                                                    "megagram per cubic zeptometer"
                                                                  , "Mg/zm^3"
                                                                  , KilogramPerCubicAttometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic yoctometer. Defined in terms of a(n) hectogram per cubic zeptometer.
   /// </summary>
   public static readonly Density KilogramPerCubicYoctometer = new (
                                                                    "kilogram per cubic yoctometer"
                                                                  , "kg/ym^3"
                                                                  , HectogramPerCubicZeptometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic rontometer. Defined in terms of a(n) dekagram per cubic yoctometer.
   /// </summary>
   public static readonly Density HectogramPerCubicRontometer = new (
                                                                     "hectogram per cubic rontometer"
                                                                   , "hg/rm^3"
                                                                   , DekagramPerCubicYoctometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic quectometer. Defined in terms of a(n) gram per cubic rontometer.
   /// </summary>
   public static readonly Density DekagramPerCubicQuectometer = new (
                                                                     "dekagram per cubic quectometer"
                                                                   , "dag/qm^3"
                                                                   , GramPerCubicRontometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) decigram per cubic quettameter. Defined in terms of a(n) gram per cubic ronnameter.
   /// </summary>
   public static readonly Density DecigramPerCubicQuettameter = new (
                                                                     "decigram per cubic quettameter"
                                                                   , "dg/Qm^3"
                                                                   , GramPerCubicRonnameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) centigram per cubic ronnameter. Defined in terms of a(n) decigram per cubic yottameter.
   /// </summary>
   public static readonly Density CentigramPerCubicRonnameter = new (
                                                                     "centigram per cubic ronnameter"
                                                                   , "cg/Rm^3"
                                                                   , DecigramPerCubicYottameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) milligram per cubic yottameter. Defined in terms of a(n) centigram per cubic zettameter.
   /// </summary>
   public static readonly Density MilligramPerCubicYottameter = new (
                                                                     "milligram per cubic yottameter"
                                                                   , "mg/Ym^3"
                                                                   , CentigramPerCubicZettameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic zettameter. Defined in terms of a(n) milligram per cubic exameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicZettameter = new (
                                                                     "microgram per cubic zettameter"
                                                                   , "μg/Zm^3"
                                                                   , MilligramPerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic exameter. Defined in terms of a(n) microgram per cubic petameter.
   /// </summary>
   public static readonly Density NanogramPerCubicExameter = new (
                                                                  "nanogram per cubic exameter"
                                                                , "ng/Em^3"
                                                                , MicrogramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) picogram per cubic petameter. Defined in terms of a(n) nanogram per cubic terameter.
   /// </summary>
   public static readonly Density PicogramPerCubicPetameter = new (
                                                                   "picogram per cubic petameter"
                                                                 , "pg/Pm^3"
                                                                 , NanogramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic terameter. Defined in terms of a(n) picogram per cubic gigameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicTerameter = new (
                                                                    "femtogram per cubic terameter"
                                                                  , "fg/Tm^3"
                                                                  , PicogramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic gigameter. Defined in terms of a(n) femtogram per cubic megameter.
   /// </summary>
   public static readonly Density AttogramPerCubicGigameter = new (
                                                                   "attogram per cubic gigameter"
                                                                 , "ag/Gm^3"
                                                                 , FemtogramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic megameter. Defined in terms of a(n) attogram per cubic kilometer.
   /// </summary>
   public static readonly Density ZeptogramPerCubicMegameter = new (
                                                                    "zeptogram per cubic megameter"
                                                                  , "zg/Mm^3"
                                                                  , AttogramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic kilometer. Defined in terms of a(n) zeptogram per cubic hectometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicKilometer = new (
                                                                    "yoctogram per cubic kilometer"
                                                                  , "yg/km^3"
                                                                  , ZeptogramPerCubicHectometer
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic hectometer. Defined in terms of a(n) yoctogram per cubic dekameter.
   /// </summary>
   public static readonly Density RontogramPerCubicHectometer = new (
                                                                     "rontogram per cubic hectometer"
                                                                   , "rg/hm^3"
                                                                   , YoctogramPerCubicDekameter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic dekameter. Defined in terms of a(n) rontogram per cubic meter.
   /// </summary>
   public static readonly Density QuectogramPerCubicDekameter = new (
                                                                     "quectogram per cubic dekameter"
                                                                   , "qg/dam^3"
                                                                   , RontogramPerCubicMeter
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic centimeter. Defined in terms of a(n) ronnagram per cubic decimeter.
   /// </summary>
   public static readonly Density QuettagramPerCubicCentimeter = new (
                                                                      "quettagram per cubic centimeter"
                                                                    , "Qg/cm^3"
                                                                    , RonnagramPerCubicDecimeter
                                                                    , 1000.0
                                                                    / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic millimeter. Defined in terms of a(n) yottagram per cubic centimeter.
   /// </summary>
   public static readonly Density RonnagramPerCubicMillimeter = new (
                                                                     "ronnagram per cubic millimeter"
                                                                   , "Rg/mm^3"
                                                                   , YottagramPerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic micrometer. Defined in terms of a(n) zettagram per cubic millimeter.
   /// </summary>
   public static readonly Density YottagramPerCubicMicrometer = new (
                                                                     "yottagram per cubic micrometer"
                                                                   , "Yg/μm^3"
                                                                   , ZettagramPerCubicMillimeter
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic nanometer. Defined in terms of a(n) exagram per cubic micrometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicNanometer = new (
                                                                    "zettagram per cubic nanometer"
                                                                  , "Zg/nm^3"
                                                                  , ExagramPerCubicMicrometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic picometer. Defined in terms of a(n) petagram per cubic nanometer.
   /// </summary>
   public static readonly Density ExagramPerCubicPicometer = new (
                                                                  "exagram per cubic picometer"
                                                                , "Eg/pm^3"
                                                                , PetagramPerCubicNanometer
                                                                , 1000.0
                                                                / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic femtometer. Defined in terms of a(n) teragram per cubic picometer.
   /// </summary>
   public static readonly Density PetagramPerCubicFemtometer = new (
                                                                    "petagram per cubic femtometer"
                                                                  , "Pg/fm^3"
                                                                  , TeragramPerCubicPicometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic attometer. Defined in terms of a(n) gigagram per cubic femtometer.
   /// </summary>
   public static readonly Density TeragramPerCubicAttometer = new (
                                                                   "teragram per cubic attometer"
                                                                 , "Tg/am^3"
                                                                 , GigagramPerCubicFemtometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic zeptometer. Defined in terms of a(n) megagram per cubic attometer.
   /// </summary>
   public static readonly Density GigagramPerCubicZeptometer = new (
                                                                    "gigagram per cubic zeptometer"
                                                                  , "Gg/zm^3"
                                                                  , MegagramPerCubicAttometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic yoctometer. Defined in terms of a(n) kilogram per cubic zeptometer.
   /// </summary>
   public static readonly Density MegagramPerCubicYoctometer = new (
                                                                    "megagram per cubic yoctometer"
                                                                  , "Mg/ym^3"
                                                                  , KilogramPerCubicZeptometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic rontometer. Defined in terms of a(n) hectogram per cubic yoctometer.
   /// </summary>
   public static readonly Density KilogramPerCubicRontometer = new (
                                                                    "kilogram per cubic rontometer"
                                                                  , "kg/rm^3"
                                                                  , HectogramPerCubicYoctometer
                                                                  , 10.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic quectometer. Defined in terms of a(n) dekagram per cubic rontometer.
   /// </summary>
   public static readonly Density HectogramPerCubicQuectometer = new (
                                                                      "hectogram per cubic quectometer"
                                                                    , "hg/qm^3"
                                                                    , DekagramPerCubicRontometer
                                                                    , 10.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) dekagram per cubic dekameter. Defined in terms of a(n) gram per cubic meter.
   /// </summary>
   public static readonly Density DekagramPerCubicDekameter = new (
                                                                   "dekagram per cubic dekameter"
                                                                 , "dag/dam^3"
                                                                 , GramPerCubicMeter
                                                                 , 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) centigram per cubic quettameter. Defined in terms of a(n) decigram per cubic ronnameter.
   /// </summary>
   public static readonly Density CentigramPerCubicQuettameter = new (
                                                                      "centigram per cubic quettameter"
                                                                    , "cg/Qm^3"
                                                                    , DecigramPerCubicRonnameter
                                                                    , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) milligram per cubic ronnameter. Defined in terms of a(n) centigram per cubic yottameter.
   /// </summary>
   public static readonly Density MilligramPerCubicRonnameter = new (
                                                                     "milligram per cubic ronnameter"
                                                                   , "mg/Rm^3"
                                                                   , CentigramPerCubicYottameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) microgram per cubic yottameter. Defined in terms of a(n) milligram per cubic zettameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicYottameter = new (
                                                                     "microgram per cubic yottameter"
                                                                   , "μg/Ym^3"
                                                                   , MilligramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic zettameter. Defined in terms of a(n) microgram per cubic exameter.
   /// </summary>
   public static readonly Density NanogramPerCubicZettameter = new (
                                                                    "nanogram per cubic zettameter"
                                                                  , "ng/Zm^3"
                                                                  , MicrogramPerCubicExameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic exameter. Defined in terms of a(n) nanogram per cubic petameter.
   /// </summary>
   public static readonly Density PicogramPerCubicExameter = new (
                                                                  "picogram per cubic exameter"
                                                                , "pg/Em^3"
                                                                , NanogramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) femtogram per cubic petameter. Defined in terms of a(n) picogram per cubic terameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicPetameter = new (
                                                                    "femtogram per cubic petameter"
                                                                  , "fg/Pm^3"
                                                                  , PicogramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) attogram per cubic terameter. Defined in terms of a(n) femtogram per cubic gigameter.
   /// </summary>
   public static readonly Density AttogramPerCubicTerameter = new (
                                                                   "attogram per cubic terameter"
                                                                 , "ag/Tm^3"
                                                                 , FemtogramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic gigameter. Defined in terms of a(n) attogram per cubic megameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicGigameter = new (
                                                                    "zeptogram per cubic gigameter"
                                                                  , "zg/Gm^3"
                                                                  , AttogramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic megameter. Defined in terms of a(n) zeptogram per cubic kilometer.
   /// </summary>
   public static readonly Density YoctogramPerCubicMegameter = new (
                                                                    "yoctogram per cubic megameter"
                                                                  , "yg/Mm^3"
                                                                  , ZeptogramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic kilometer. Defined in terms of a(n) yoctogram per cubic hectometer.
   /// </summary>
   public static readonly Density RontogramPerCubicKilometer = new (
                                                                    "rontogram per cubic kilometer"
                                                                  , "rg/km^3"
                                                                  , YoctogramPerCubicHectometer
                                                                  , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic hectometer. Defined in terms of a(n) rontogram per cubic dekameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicHectometer = new (
                                                                      "quectogram per cubic hectometer"
                                                                    , "qg/hm^3"
                                                                    , RontogramPerCubicDekameter
                                                                    , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic millimeter. Defined in terms of a(n) ronnagram per cubic centimeter.
   /// </summary>
   public static readonly Density QuettagramPerCubicMillimeter = new (
                                                                      "quettagram per cubic millimeter"
                                                                    , "Qg/mm^3"
                                                                    , RonnagramPerCubicCentimeter
                                                                    , 1000.0
                                                                    / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic micrometer. Defined in terms of a(n) yottagram per cubic millimeter.
   /// </summary>
   public static readonly Density RonnagramPerCubicMicrometer = new (
                                                                     "ronnagram per cubic micrometer"
                                                                   , "Rg/μm^3"
                                                                   , YottagramPerCubicMillimeter
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic nanometer. Defined in terms of a(n) zettagram per cubic micrometer.
   /// </summary>
   public static readonly Density YottagramPerCubicNanometer = new (
                                                                    "yottagram per cubic nanometer"
                                                                  , "Yg/nm^3"
                                                                  , ZettagramPerCubicMicrometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic picometer. Defined in terms of a(n) exagram per cubic nanometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicPicometer = new (
                                                                    "zettagram per cubic picometer"
                                                                  , "Zg/pm^3"
                                                                  , ExagramPerCubicNanometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic femtometer. Defined in terms of a(n) petagram per cubic picometer.
   /// </summary>
   public static readonly Density ExagramPerCubicFemtometer = new (
                                                                   "exagram per cubic femtometer"
                                                                 , "Eg/fm^3"
                                                                 , PetagramPerCubicPicometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic attometer. Defined in terms of a(n) teragram per cubic femtometer.
   /// </summary>
   public static readonly Density PetagramPerCubicAttometer = new (
                                                                   "petagram per cubic attometer"
                                                                 , "Pg/am^3"
                                                                 , TeragramPerCubicFemtometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic zeptometer. Defined in terms of a(n) gigagram per cubic attometer.
   /// </summary>
   public static readonly Density TeragramPerCubicZeptometer = new (
                                                                    "teragram per cubic zeptometer"
                                                                  , "Tg/zm^3"
                                                                  , GigagramPerCubicAttometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic yoctometer. Defined in terms of a(n) megagram per cubic zeptometer.
   /// </summary>
   public static readonly Density GigagramPerCubicYoctometer = new (
                                                                    "gigagram per cubic yoctometer"
                                                                  , "Gg/ym^3"
                                                                  , MegagramPerCubicZeptometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic rontometer. Defined in terms of a(n) kilogram per cubic yoctometer.
   /// </summary>
   public static readonly Density MegagramPerCubicRontometer = new (
                                                                    "megagram per cubic rontometer"
                                                                  , "Mg/rm^3"
                                                                  , KilogramPerCubicYoctometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic quectometer. Defined in terms of a(n) hectogram per cubic rontometer.
   /// </summary>
   public static readonly Density KilogramPerCubicQuectometer = new (
                                                                     "kilogram per cubic quectometer"
                                                                   , "kg/qm^3"
                                                                   , HectogramPerCubicRontometer
                                                                   , 10.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) hectogram per cubic dekameter. Defined in terms of a(n) dekagram per cubic meter.
   /// </summary>
   public static readonly Density HectogramPerCubicDekameter = new (
                                                                    "hectogram per cubic dekameter"
                                                                  , "hg/dam^3"
                                                                  , DekagramPerCubicMeter
                                                                  , 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic hectometer. Defined in terms of a(n) gram per cubic dekameter.
   /// </summary>
   public static readonly Density DekagramPerCubicHectometer = new (
                                                                    "dekagram per cubic hectometer"
                                                                  , "dag/hm^3"
                                                                  , GramPerCubicDekameter
                                                                  , 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) milligram per cubic quettameter. Defined in terms of a(n) centigram per cubic ronnameter.
   /// </summary>
   public static readonly Density MilligramPerCubicQuettameter = new (
                                                                      "milligram per cubic quettameter"
                                                                    , "mg/Qm^3"
                                                                    , CentigramPerCubicRonnameter
                                                                    , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) microgram per cubic ronnameter. Defined in terms of a(n) milligram per cubic yottameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicRonnameter = new (
                                                                     "microgram per cubic ronnameter"
                                                                   , "μg/Rm^3"
                                                                   , MilligramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) nanogram per cubic yottameter. Defined in terms of a(n) microgram per cubic zettameter.
   /// </summary>
   public static readonly Density NanogramPerCubicYottameter = new (
                                                                    "nanogram per cubic yottameter"
                                                                  , "ng/Ym^3"
                                                                  , MicrogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic zettameter. Defined in terms of a(n) nanogram per cubic exameter.
   /// </summary>
   public static readonly Density PicogramPerCubicZettameter = new (
                                                                    "picogram per cubic zettameter"
                                                                  , "pg/Zm^3"
                                                                  , NanogramPerCubicExameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic exameter. Defined in terms of a(n) picogram per cubic petameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicExameter = new (
                                                                   "femtogram per cubic exameter"
                                                                 , "fg/Em^3"
                                                                 , PicogramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attogram per cubic petameter. Defined in terms of a(n) femtogram per cubic terameter.
   /// </summary>
   public static readonly Density AttogramPerCubicPetameter = new (
                                                                   "attogram per cubic petameter"
                                                                 , "ag/Pm^3"
                                                                 , FemtogramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zeptogram per cubic terameter. Defined in terms of a(n) attogram per cubic gigameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicTerameter = new (
                                                                    "zeptogram per cubic terameter"
                                                                  , "zg/Tm^3"
                                                                  , AttogramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic gigameter. Defined in terms of a(n) zeptogram per cubic megameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicGigameter = new (
                                                                    "yoctogram per cubic gigameter"
                                                                  , "yg/Gm^3"
                                                                  , ZeptogramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic megameter. Defined in terms of a(n) yoctogram per cubic kilometer.
   /// </summary>
   public static readonly Density RontogramPerCubicMegameter = new (
                                                                    "rontogram per cubic megameter"
                                                                  , "rg/Mm^3"
                                                                  , YoctogramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic kilometer. Defined in terms of a(n) rontogram per cubic hectometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicKilometer = new (
                                                                     "quectogram per cubic kilometer"
                                                                   , "qg/km^3"
                                                                   , RontogramPerCubicHectometer
                                                                   , 1.0 / 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic micrometer. Defined in terms of a(n) ronnagram per cubic millimeter.
   /// </summary>
   public static readonly Density QuettagramPerCubicMicrometer = new (
                                                                      "quettagram per cubic micrometer"
                                                                    , "Qg/μm^3"
                                                                    , RonnagramPerCubicMillimeter
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic nanometer. Defined in terms of a(n) yottagram per cubic micrometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicNanometer = new (
                                                                    "ronnagram per cubic nanometer"
                                                                  , "Rg/nm^3"
                                                                  , YottagramPerCubicMicrometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic picometer. Defined in terms of a(n) zettagram per cubic nanometer.
   /// </summary>
   public static readonly Density YottagramPerCubicPicometer = new (
                                                                    "yottagram per cubic picometer"
                                                                  , "Yg/pm^3"
                                                                  , ZettagramPerCubicNanometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic femtometer. Defined in terms of a(n) exagram per cubic picometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicFemtometer = new (
                                                                     "zettagram per cubic femtometer"
                                                                   , "Zg/fm^3"
                                                                   , ExagramPerCubicPicometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic attometer. Defined in terms of a(n) petagram per cubic femtometer.
   /// </summary>
   public static readonly Density ExagramPerCubicAttometer = new (
                                                                  "exagram per cubic attometer"
                                                                , "Eg/am^3"
                                                                , PetagramPerCubicFemtometer
                                                                , 1000.0
                                                                / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic zeptometer. Defined in terms of a(n) teragram per cubic attometer.
   /// </summary>
   public static readonly Density PetagramPerCubicZeptometer = new (
                                                                    "petagram per cubic zeptometer"
                                                                  , "Pg/zm^3"
                                                                  , TeragramPerCubicAttometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic yoctometer. Defined in terms of a(n) gigagram per cubic zeptometer.
   /// </summary>
   public static readonly Density TeragramPerCubicYoctometer = new (
                                                                    "teragram per cubic yoctometer"
                                                                  , "Tg/ym^3"
                                                                  , GigagramPerCubicZeptometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic rontometer. Defined in terms of a(n) megagram per cubic yoctometer.
   /// </summary>
   public static readonly Density GigagramPerCubicRontometer = new (
                                                                    "gigagram per cubic rontometer"
                                                                  , "Gg/rm^3"
                                                                  , MegagramPerCubicYoctometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic quectometer. Defined in terms of a(n) kilogram per cubic rontometer.
   /// </summary>
   public static readonly Density MegagramPerCubicQuectometer = new (
                                                                     "megagram per cubic quectometer"
                                                                   , "Mg/qm^3"
                                                                   , KilogramPerCubicRontometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) kilogram per cubic dekameter. Defined in terms of a(n) hectogram per cubic meter.
   /// </summary>
   public static readonly Density KilogramPerCubicDekameter = new (
                                                                   "kilogram per cubic dekameter"
                                                                 , "kg/dam^3"
                                                                 , HectogramPerCubicMeter
                                                                 , 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic hectometer. Defined in terms of a(n) dekagram per cubic dekameter.
   /// </summary>
   public static readonly Density HectogramPerCubicHectometer = new (
                                                                     "hectogram per cubic hectometer"
                                                                   , "hg/hm^3"
                                                                   , DekagramPerCubicDekameter
                                                                   , 10.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic kilometer. Defined in terms of a(n) gram per cubic hectometer.
   /// </summary>
   public static readonly Density DekagramPerCubicKilometer = new (
                                                                   "dekagram per cubic kilometer"
                                                                 , "dag/km^3"
                                                                 , GramPerCubicHectometer
                                                                 , 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) microgram per cubic quettameter. Defined in terms of a(n) milligram per cubic ronnameter.
   /// </summary>
   public static readonly Density MicrogramPerCubicQuettameter = new (
                                                                      "microgram per cubic quettameter"
                                                                    , "μg/Qm^3"
                                                                    , MilligramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanogram per cubic ronnameter. Defined in terms of a(n) microgram per cubic yottameter.
   /// </summary>
   public static readonly Density NanogramPerCubicRonnameter = new (
                                                                    "nanogram per cubic ronnameter"
                                                                  , "ng/Rm^3"
                                                                  , MicrogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) picogram per cubic yottameter. Defined in terms of a(n) nanogram per cubic zettameter.
   /// </summary>
   public static readonly Density PicogramPerCubicYottameter = new (
                                                                    "picogram per cubic yottameter"
                                                                  , "pg/Ym^3"
                                                                  , NanogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic zettameter. Defined in terms of a(n) picogram per cubic exameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicZettameter = new (
                                                                     "femtogram per cubic zettameter"
                                                                   , "fg/Zm^3"
                                                                   , PicogramPerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic exameter. Defined in terms of a(n) femtogram per cubic petameter.
   /// </summary>
   public static readonly Density AttogramPerCubicExameter = new (
                                                                  "attogram per cubic exameter"
                                                                , "ag/Em^3"
                                                                , FemtogramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptogram per cubic petameter. Defined in terms of a(n) attogram per cubic terameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicPetameter = new (
                                                                    "zeptogram per cubic petameter"
                                                                  , "zg/Pm^3"
                                                                  , AttogramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic terameter. Defined in terms of a(n) zeptogram per cubic gigameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicTerameter = new (
                                                                    "yoctogram per cubic terameter"
                                                                  , "yg/Tm^3"
                                                                  , ZeptogramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic gigameter. Defined in terms of a(n) yoctogram per cubic megameter.
   /// </summary>
   public static readonly Density RontogramPerCubicGigameter = new (
                                                                    "rontogram per cubic gigameter"
                                                                  , "rg/Gm^3"
                                                                  , YoctogramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic megameter. Defined in terms of a(n) rontogram per cubic kilometer.
   /// </summary>
   public static readonly Density QuectogramPerCubicMegameter = new (
                                                                     "quectogram per cubic megameter"
                                                                   , "qg/Mm^3"
                                                                   , RontogramPerCubicKilometer
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic nanometer. Defined in terms of a(n) ronnagram per cubic micrometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicNanometer = new (
                                                                     "quettagram per cubic nanometer"
                                                                   , "Qg/nm^3"
                                                                   , RonnagramPerCubicMicrometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic picometer. Defined in terms of a(n) yottagram per cubic nanometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicPicometer = new (
                                                                    "ronnagram per cubic picometer"
                                                                  , "Rg/pm^3"
                                                                  , YottagramPerCubicNanometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic femtometer. Defined in terms of a(n) zettagram per cubic picometer.
   /// </summary>
   public static readonly Density YottagramPerCubicFemtometer = new (
                                                                     "yottagram per cubic femtometer"
                                                                   , "Yg/fm^3"
                                                                   , ZettagramPerCubicPicometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic attometer. Defined in terms of a(n) exagram per cubic femtometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicAttometer = new (
                                                                    "zettagram per cubic attometer"
                                                                  , "Zg/am^3"
                                                                  , ExagramPerCubicFemtometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic zeptometer. Defined in terms of a(n) petagram per cubic attometer.
   /// </summary>
   public static readonly Density ExagramPerCubicZeptometer = new (
                                                                   "exagram per cubic zeptometer"
                                                                 , "Eg/zm^3"
                                                                 , PetagramPerCubicAttometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic yoctometer. Defined in terms of a(n) teragram per cubic zeptometer.
   /// </summary>
   public static readonly Density PetagramPerCubicYoctometer = new (
                                                                    "petagram per cubic yoctometer"
                                                                  , "Pg/ym^3"
                                                                  , TeragramPerCubicZeptometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic rontometer. Defined in terms of a(n) gigagram per cubic yoctometer.
   /// </summary>
   public static readonly Density TeragramPerCubicRontometer = new (
                                                                    "teragram per cubic rontometer"
                                                                  , "Tg/rm^3"
                                                                  , GigagramPerCubicYoctometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic quectometer. Defined in terms of a(n) megagram per cubic rontometer.
   /// </summary>
   public static readonly Density GigagramPerCubicQuectometer = new (
                                                                     "gigagram per cubic quectometer"
                                                                   , "Gg/qm^3"
                                                                   , MegagramPerCubicRontometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) megagram per cubic dekameter. Defined in terms of a(n) kilogram per cubic meter.
   /// </summary>
   public static readonly Density MegagramPerCubicDekameter = new (
                                                                   "megagram per cubic dekameter"
                                                                 , "Mg/dam^3"
                                                                 , KilogramPerCubicMeter
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic hectometer. Defined in terms of a(n) hectogram per cubic dekameter.
   /// </summary>
   public static readonly Density KilogramPerCubicHectometer = new (
                                                                    "kilogram per cubic hectometer"
                                                                  , "kg/hm^3"
                                                                  , HectogramPerCubicDekameter
                                                                  , 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic kilometer. Defined in terms of a(n) dekagram per cubic hectometer.
   /// </summary>
   public static readonly Density HectogramPerCubicKilometer = new (
                                                                    "hectogram per cubic kilometer"
                                                                  , "hg/km^3"
                                                                  , DekagramPerCubicHectometer
                                                                  , 10.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic megameter. Defined in terms of a(n) gram per cubic kilometer.
   /// </summary>
   public static readonly Density DekagramPerCubicMegameter = new (
                                                                   "dekagram per cubic megameter"
                                                                 , "dag/Mm^3"
                                                                 , GramPerCubicKilometer
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) nanogram per cubic quettameter. Defined in terms of a(n) microgram per cubic ronnameter.
   /// </summary>
   public static readonly Density NanogramPerCubicQuettameter = new (
                                                                     "nanogram per cubic quettameter"
                                                                   , "ng/Qm^3"
                                                                   , MicrogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picogram per cubic ronnameter. Defined in terms of a(n) nanogram per cubic yottameter.
   /// </summary>
   public static readonly Density PicogramPerCubicRonnameter = new (
                                                                    "picogram per cubic ronnameter"
                                                                  , "pg/Rm^3"
                                                                  , NanogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) femtogram per cubic yottameter. Defined in terms of a(n) picogram per cubic zettameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicYottameter = new (
                                                                     "femtogram per cubic yottameter"
                                                                   , "fg/Ym^3"
                                                                   , PicogramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic zettameter. Defined in terms of a(n) femtogram per cubic exameter.
   /// </summary>
   public static readonly Density AttogramPerCubicZettameter = new (
                                                                    "attogram per cubic zettameter"
                                                                  , "ag/Zm^3"
                                                                  , FemtogramPerCubicExameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic exameter. Defined in terms of a(n) attogram per cubic petameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicExameter = new (
                                                                   "zeptogram per cubic exameter"
                                                                 , "zg/Em^3"
                                                                 , AttogramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yoctogram per cubic petameter. Defined in terms of a(n) zeptogram per cubic terameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicPetameter = new (
                                                                    "yoctogram per cubic petameter"
                                                                  , "yg/Pm^3"
                                                                  , ZeptogramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic terameter. Defined in terms of a(n) yoctogram per cubic gigameter.
   /// </summary>
   public static readonly Density RontogramPerCubicTerameter = new (
                                                                    "rontogram per cubic terameter"
                                                                  , "rg/Tm^3"
                                                                  , YoctogramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic gigameter. Defined in terms of a(n) rontogram per cubic megameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicGigameter = new (
                                                                     "quectogram per cubic gigameter"
                                                                   , "qg/Gm^3"
                                                                   , RontogramPerCubicMegameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic picometer. Defined in terms of a(n) ronnagram per cubic nanometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicPicometer = new (
                                                                     "quettagram per cubic picometer"
                                                                   , "Qg/pm^3"
                                                                   , RonnagramPerCubicNanometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic femtometer. Defined in terms of a(n) yottagram per cubic picometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicFemtometer = new (
                                                                     "ronnagram per cubic femtometer"
                                                                   , "Rg/fm^3"
                                                                   , YottagramPerCubicPicometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic attometer. Defined in terms of a(n) zettagram per cubic femtometer.
   /// </summary>
   public static readonly Density YottagramPerCubicAttometer = new (
                                                                    "yottagram per cubic attometer"
                                                                  , "Yg/am^3"
                                                                  , ZettagramPerCubicFemtometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic zeptometer. Defined in terms of a(n) exagram per cubic attometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicZeptometer = new (
                                                                     "zettagram per cubic zeptometer"
                                                                   , "Zg/zm^3"
                                                                   , ExagramPerCubicAttometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic yoctometer. Defined in terms of a(n) petagram per cubic zeptometer.
   /// </summary>
   public static readonly Density ExagramPerCubicYoctometer = new (
                                                                   "exagram per cubic yoctometer"
                                                                 , "Eg/ym^3"
                                                                 , PetagramPerCubicZeptometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic rontometer. Defined in terms of a(n) teragram per cubic yoctometer.
   /// </summary>
   public static readonly Density PetagramPerCubicRontometer = new (
                                                                    "petagram per cubic rontometer"
                                                                  , "Pg/rm^3"
                                                                  , TeragramPerCubicYoctometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic quectometer. Defined in terms of a(n) gigagram per cubic rontometer.
   /// </summary>
   public static readonly Density TeragramPerCubicQuectometer = new (
                                                                     "teragram per cubic quectometer"
                                                                   , "Tg/qm^3"
                                                                   , GigagramPerCubicRontometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) gigagram per cubic dekameter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density GigagramPerCubicDekameter = new (
                                                                   "gigagram per cubic dekameter"
                                                                 , "Gg/dam^3"
                                                                 , MegagramPerCubicMeter
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic hectometer. Defined in terms of a(n) kilogram per cubic dekameter.
   /// </summary>
   public static readonly Density MegagramPerCubicHectometer = new (
                                                                    "megagram per cubic hectometer"
                                                                  , "Mg/hm^3"
                                                                  , KilogramPerCubicDekameter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic kilometer. Defined in terms of a(n) hectogram per cubic hectometer.
   /// </summary>
   public static readonly Density KilogramPerCubicKilometer = new (
                                                                   "kilogram per cubic kilometer"
                                                                 , "kg/km^3"
                                                                 , HectogramPerCubicHectometer
                                                                 , 10.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic megameter. Defined in terms of a(n) dekagram per cubic kilometer.
   /// </summary>
   public static readonly Density HectogramPerCubicMegameter = new (
                                                                    "hectogram per cubic megameter"
                                                                  , "hg/Mm^3"
                                                                  , DekagramPerCubicKilometer
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic gigameter. Defined in terms of a(n) gram per cubic megameter.
   /// </summary>
   public static readonly Density DekagramPerCubicGigameter = new (
                                                                   "dekagram per cubic gigameter"
                                                                 , "dag/Gm^3"
                                                                 , GramPerCubicMegameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) picogram per cubic quettameter. Defined in terms of a(n) nanogram per cubic ronnameter.
   /// </summary>
   public static readonly Density PicogramPerCubicQuettameter = new (
                                                                     "picogram per cubic quettameter"
                                                                   , "pg/Qm^3"
                                                                   , NanogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) femtogram per cubic ronnameter. Defined in terms of a(n) picogram per cubic yottameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicRonnameter = new (
                                                                     "femtogram per cubic ronnameter"
                                                                   , "fg/Rm^3"
                                                                   , PicogramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) attogram per cubic yottameter. Defined in terms of a(n) femtogram per cubic zettameter.
   /// </summary>
   public static readonly Density AttogramPerCubicYottameter = new (
                                                                    "attogram per cubic yottameter"
                                                                  , "ag/Ym^3"
                                                                  , FemtogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic zettameter. Defined in terms of a(n) attogram per cubic exameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicZettameter = new (
                                                                     "zeptogram per cubic zettameter"
                                                                   , "zg/Zm^3"
                                                                   , AttogramPerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic exameter. Defined in terms of a(n) zeptogram per cubic petameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicExameter = new (
                                                                   "yoctogram per cubic exameter"
                                                                 , "yg/Em^3"
                                                                 , ZeptogramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) rontogram per cubic petameter. Defined in terms of a(n) yoctogram per cubic terameter.
   /// </summary>
   public static readonly Density RontogramPerCubicPetameter = new (
                                                                    "rontogram per cubic petameter"
                                                                  , "rg/Pm^3"
                                                                  , YoctogramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic terameter. Defined in terms of a(n) rontogram per cubic gigameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicTerameter = new (
                                                                     "quectogram per cubic terameter"
                                                                   , "qg/Tm^3"
                                                                   , RontogramPerCubicGigameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic femtometer. Defined in terms of a(n) ronnagram per cubic picometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicFemtometer = new (
                                                                      "quettagram per cubic femtometer"
                                                                    , "Qg/fm^3"
                                                                    , RonnagramPerCubicPicometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic attometer. Defined in terms of a(n) yottagram per cubic femtometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicAttometer = new (
                                                                    "ronnagram per cubic attometer"
                                                                  , "Rg/am^3"
                                                                  , YottagramPerCubicFemtometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic zeptometer. Defined in terms of a(n) zettagram per cubic attometer.
   /// </summary>
   public static readonly Density YottagramPerCubicZeptometer = new (
                                                                     "yottagram per cubic zeptometer"
                                                                   , "Yg/zm^3"
                                                                   , ZettagramPerCubicAttometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic yoctometer. Defined in terms of a(n) exagram per cubic zeptometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicYoctometer = new (
                                                                     "zettagram per cubic yoctometer"
                                                                   , "Zg/ym^3"
                                                                   , ExagramPerCubicZeptometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic rontometer. Defined in terms of a(n) petagram per cubic yoctometer.
   /// </summary>
   public static readonly Density ExagramPerCubicRontometer = new (
                                                                   "exagram per cubic rontometer"
                                                                 , "Eg/rm^3"
                                                                 , PetagramPerCubicYoctometer
                                                                 , 1000.0
                                                                 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic quectometer. Defined in terms of a(n) teragram per cubic rontometer.
   /// </summary>
   public static readonly Density PetagramPerCubicQuectometer = new (
                                                                     "petagram per cubic quectometer"
                                                                   , "Pg/qm^3"
                                                                   , TeragramPerCubicRontometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) teragram per cubic dekameter. Defined in terms of a(n) gigagram per cubic meter.
   /// </summary>
   public static readonly Density TeragramPerCubicDekameter = new (
                                                                   "teragram per cubic dekameter"
                                                                 , "Tg/dam^3"
                                                                 , GigagramPerCubicMeter
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic hectometer. Defined in terms of a(n) megagram per cubic dekameter.
   /// </summary>
   public static readonly Density GigagramPerCubicHectometer = new (
                                                                    "gigagram per cubic hectometer"
                                                                  , "Gg/hm^3"
                                                                  , MegagramPerCubicDekameter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic kilometer. Defined in terms of a(n) kilogram per cubic hectometer.
   /// </summary>
   public static readonly Density MegagramPerCubicKilometer = new (
                                                                   "megagram per cubic kilometer"
                                                                 , "Mg/km^3"
                                                                 , KilogramPerCubicHectometer
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic megameter. Defined in terms of a(n) hectogram per cubic kilometer.
   /// </summary>
   public static readonly Density KilogramPerCubicMegameter = new (
                                                                   "kilogram per cubic megameter"
                                                                 , "kg/Mm^3"
                                                                 , HectogramPerCubicKilometer
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic gigameter. Defined in terms of a(n) dekagram per cubic megameter.
   /// </summary>
   public static readonly Density HectogramPerCubicGigameter = new (
                                                                    "hectogram per cubic gigameter"
                                                                  , "hg/Gm^3"
                                                                  , DekagramPerCubicMegameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic terameter. Defined in terms of a(n) gram per cubic gigameter.
   /// </summary>
   public static readonly Density DekagramPerCubicTerameter = new (
                                                                   "dekagram per cubic terameter"
                                                                 , "dag/Tm^3"
                                                                 , GramPerCubicGigameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) femtogram per cubic quettameter. Defined in terms of a(n) picogram per cubic ronnameter.
   /// </summary>
   public static readonly Density FemtogramPerCubicQuettameter = new (
                                                                      "femtogram per cubic quettameter"
                                                                    , "fg/Qm^3"
                                                                    , PicogramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attogram per cubic ronnameter. Defined in terms of a(n) femtogram per cubic yottameter.
   /// </summary>
   public static readonly Density AttogramPerCubicRonnameter = new (
                                                                    "attogram per cubic ronnameter"
                                                                  , "ag/Rm^3"
                                                                  , FemtogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zeptogram per cubic yottameter. Defined in terms of a(n) attogram per cubic zettameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicYottameter = new (
                                                                     "zeptogram per cubic yottameter"
                                                                   , "zg/Ym^3"
                                                                   , AttogramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic zettameter. Defined in terms of a(n) zeptogram per cubic exameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicZettameter = new (
                                                                     "yoctogram per cubic zettameter"
                                                                   , "yg/Zm^3"
                                                                   , ZeptogramPerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic exameter. Defined in terms of a(n) yoctogram per cubic petameter.
   /// </summary>
   public static readonly Density RontogramPerCubicExameter = new (
                                                                   "rontogram per cubic exameter"
                                                                 , "rg/Em^3"
                                                                 , YoctogramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) quectogram per cubic petameter. Defined in terms of a(n) rontogram per cubic terameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicPetameter = new (
                                                                     "quectogram per cubic petameter"
                                                                   , "qg/Pm^3"
                                                                   , RontogramPerCubicTerameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic attometer. Defined in terms of a(n) ronnagram per cubic femtometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicAttometer = new (
                                                                     "quettagram per cubic attometer"
                                                                   , "Qg/am^3"
                                                                   , RonnagramPerCubicFemtometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic zeptometer. Defined in terms of a(n) yottagram per cubic attometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicZeptometer = new (
                                                                     "ronnagram per cubic zeptometer"
                                                                   , "Rg/zm^3"
                                                                   , YottagramPerCubicAttometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic yoctometer. Defined in terms of a(n) zettagram per cubic zeptometer.
   /// </summary>
   public static readonly Density YottagramPerCubicYoctometer = new (
                                                                     "yottagram per cubic yoctometer"
                                                                   , "Yg/ym^3"
                                                                   , ZettagramPerCubicZeptometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic rontometer. Defined in terms of a(n) exagram per cubic yoctometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicRontometer = new (
                                                                     "zettagram per cubic rontometer"
                                                                   , "Zg/rm^3"
                                                                   , ExagramPerCubicYoctometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic quectometer. Defined in terms of a(n) petagram per cubic rontometer.
   /// </summary>
   public static readonly Density ExagramPerCubicQuectometer = new (
                                                                    "exagram per cubic quectometer"
                                                                  , "Eg/qm^3"
                                                                  , PetagramPerCubicRontometer
                                                                  , 1000.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) petagram per cubic dekameter. Defined in terms of a(n) teragram per cubic meter.
   /// </summary>
   public static readonly Density PetagramPerCubicDekameter = new (
                                                                   "petagram per cubic dekameter"
                                                                 , "Pg/dam^3"
                                                                 , TeragramPerCubicMeter
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic hectometer. Defined in terms of a(n) gigagram per cubic dekameter.
   /// </summary>
   public static readonly Density TeragramPerCubicHectometer = new (
                                                                    "teragram per cubic hectometer"
                                                                  , "Tg/hm^3"
                                                                  , GigagramPerCubicDekameter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic kilometer. Defined in terms of a(n) megagram per cubic hectometer.
   /// </summary>
   public static readonly Density GigagramPerCubicKilometer = new (
                                                                   "gigagram per cubic kilometer"
                                                                 , "Gg/km^3"
                                                                 , MegagramPerCubicHectometer
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic megameter. Defined in terms of a(n) kilogram per cubic kilometer.
   /// </summary>
   public static readonly Density MegagramPerCubicMegameter = new (
                                                                   "megagram per cubic megameter"
                                                                 , "Mg/Mm^3"
                                                                 , KilogramPerCubicKilometer
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic gigameter. Defined in terms of a(n) hectogram per cubic megameter.
   /// </summary>
   public static readonly Density KilogramPerCubicGigameter = new (
                                                                   "kilogram per cubic gigameter"
                                                                 , "kg/Gm^3"
                                                                 , HectogramPerCubicMegameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic terameter. Defined in terms of a(n) dekagram per cubic gigameter.
   /// </summary>
   public static readonly Density HectogramPerCubicTerameter = new (
                                                                    "hectogram per cubic terameter"
                                                                  , "hg/Tm^3"
                                                                  , DekagramPerCubicGigameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic petameter. Defined in terms of a(n) gram per cubic terameter.
   /// </summary>
   public static readonly Density DekagramPerCubicPetameter = new (
                                                                   "dekagram per cubic petameter"
                                                                 , "dag/Pm^3"
                                                                 , GramPerCubicTerameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) attogram per cubic quettameter. Defined in terms of a(n) femtogram per cubic ronnameter.
   /// </summary>
   public static readonly Density AttogramPerCubicQuettameter = new (
                                                                     "attogram per cubic quettameter"
                                                                   , "ag/Qm^3"
                                                                   , FemtogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptogram per cubic ronnameter. Defined in terms of a(n) attogram per cubic yottameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicRonnameter = new (
                                                                     "zeptogram per cubic ronnameter"
                                                                   , "zg/Rm^3"
                                                                   , AttogramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yoctogram per cubic yottameter. Defined in terms of a(n) zeptogram per cubic zettameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicYottameter = new (
                                                                     "yoctogram per cubic yottameter"
                                                                   , "yg/Ym^3"
                                                                   , ZeptogramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic zettameter. Defined in terms of a(n) yoctogram per cubic exameter.
   /// </summary>
   public static readonly Density RontogramPerCubicZettameter = new (
                                                                     "rontogram per cubic zettameter"
                                                                   , "rg/Zm^3"
                                                                   , YoctogramPerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic exameter. Defined in terms of a(n) rontogram per cubic petameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicExameter = new (
                                                                    "quectogram per cubic exameter"
                                                                  , "qg/Em^3"
                                                                  , RontogramPerCubicPetameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettagram per cubic zeptometer. Defined in terms of a(n) ronnagram per cubic attometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicZeptometer = new (
                                                                      "quettagram per cubic zeptometer"
                                                                    , "Qg/zm^3"
                                                                    , RonnagramPerCubicAttometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic yoctometer. Defined in terms of a(n) yottagram per cubic zeptometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicYoctometer = new (
                                                                     "ronnagram per cubic yoctometer"
                                                                   , "Rg/ym^3"
                                                                   , YottagramPerCubicZeptometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic rontometer. Defined in terms of a(n) zettagram per cubic yoctometer.
   /// </summary>
   public static readonly Density YottagramPerCubicRontometer = new (
                                                                     "yottagram per cubic rontometer"
                                                                   , "Yg/rm^3"
                                                                   , ZettagramPerCubicYoctometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic quectometer. Defined in terms of a(n) exagram per cubic rontometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicQuectometer = new (
                                                                      "zettagram per cubic quectometer"
                                                                    , "Zg/qm^3"
                                                                    , ExagramPerCubicRontometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) exagram per cubic dekameter. Defined in terms of a(n) petagram per cubic meter.
   /// </summary>
   public static readonly Density ExagramPerCubicDekameter = new (
                                                                  "exagram per cubic dekameter"
                                                                , "Eg/dam^3"
                                                                , PetagramPerCubicMeter
                                                                , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic hectometer. Defined in terms of a(n) teragram per cubic dekameter.
   /// </summary>
   public static readonly Density PetagramPerCubicHectometer = new (
                                                                    "petagram per cubic hectometer"
                                                                  , "Pg/hm^3"
                                                                  , TeragramPerCubicDekameter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic kilometer. Defined in terms of a(n) gigagram per cubic hectometer.
   /// </summary>
   public static readonly Density TeragramPerCubicKilometer = new (
                                                                   "teragram per cubic kilometer"
                                                                 , "Tg/km^3"
                                                                 , GigagramPerCubicHectometer
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic megameter. Defined in terms of a(n) megagram per cubic kilometer.
   /// </summary>
   public static readonly Density GigagramPerCubicMegameter = new (
                                                                   "gigagram per cubic megameter"
                                                                 , "Gg/Mm^3"
                                                                 , MegagramPerCubicKilometer
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic gigameter. Defined in terms of a(n) kilogram per cubic megameter.
   /// </summary>
   public static readonly Density MegagramPerCubicGigameter = new (
                                                                   "megagram per cubic gigameter"
                                                                 , "Mg/Gm^3"
                                                                 , KilogramPerCubicMegameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic terameter. Defined in terms of a(n) hectogram per cubic gigameter.
   /// </summary>
   public static readonly Density KilogramPerCubicTerameter = new (
                                                                   "kilogram per cubic terameter"
                                                                 , "kg/Tm^3"
                                                                 , HectogramPerCubicGigameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic petameter. Defined in terms of a(n) dekagram per cubic terameter.
   /// </summary>
   public static readonly Density HectogramPerCubicPetameter = new (
                                                                    "hectogram per cubic petameter"
                                                                  , "hg/Pm^3"
                                                                  , DekagramPerCubicTerameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) dekagram per cubic exameter. Defined in terms of a(n) gram per cubic petameter.
   /// </summary>
   public static readonly Density DekagramPerCubicExameter = new (
                                                                  "dekagram per cubic exameter"
                                                                , "dag/Em^3"
                                                                , GramPerCubicPetameter
                                                                , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) zeptogram per cubic quettameter. Defined in terms of a(n) attogram per cubic ronnameter.
   /// </summary>
   public static readonly Density ZeptogramPerCubicQuettameter = new (
                                                                      "zeptogram per cubic quettameter"
                                                                    , "zg/Qm^3"
                                                                    , AttogramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctogram per cubic ronnameter. Defined in terms of a(n) zeptogram per cubic yottameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicRonnameter = new (
                                                                     "yoctogram per cubic ronnameter"
                                                                   , "yg/Rm^3"
                                                                   , ZeptogramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) rontogram per cubic yottameter. Defined in terms of a(n) yoctogram per cubic zettameter.
   /// </summary>
   public static readonly Density RontogramPerCubicYottameter = new (
                                                                     "rontogram per cubic yottameter"
                                                                   , "rg/Ym^3"
                                                                   , YoctogramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic zettameter. Defined in terms of a(n) rontogram per cubic exameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicZettameter = new (
                                                                      "quectogram per cubic zettameter"
                                                                    , "qg/Zm^3"
                                                                    , RontogramPerCubicExameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic yoctometer. Defined in terms of a(n) ronnagram per cubic zeptometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicYoctometer = new (
                                                                      "quettagram per cubic yoctometer"
                                                                    , "Qg/ym^3"
                                                                    , RonnagramPerCubicZeptometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic rontometer. Defined in terms of a(n) yottagram per cubic yoctometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicRontometer = new (
                                                                     "ronnagram per cubic rontometer"
                                                                   , "Rg/rm^3"
                                                                   , YottagramPerCubicYoctometer
                                                                   , 1000.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic quectometer. Defined in terms of a(n) zettagram per cubic rontometer.
   /// </summary>
   public static readonly Density YottagramPerCubicQuectometer = new (
                                                                      "yottagram per cubic quectometer"
                                                                    , "Yg/qm^3"
                                                                    , ZettagramPerCubicRontometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) zettagram per cubic dekameter. Defined in terms of a(n) exagram per cubic meter.
   /// </summary>
   public static readonly Density ZettagramPerCubicDekameter = new (
                                                                    "zettagram per cubic dekameter"
                                                                  , "Zg/dam^3"
                                                                  , ExagramPerCubicMeter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic hectometer. Defined in terms of a(n) petagram per cubic dekameter.
   /// </summary>
   public static readonly Density ExagramPerCubicHectometer = new (
                                                                   "exagram per cubic hectometer"
                                                                 , "Eg/hm^3"
                                                                 , PetagramPerCubicDekameter
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic kilometer. Defined in terms of a(n) teragram per cubic hectometer.
   /// </summary>
   public static readonly Density PetagramPerCubicKilometer = new (
                                                                   "petagram per cubic kilometer"
                                                                 , "Pg/km^3"
                                                                 , TeragramPerCubicHectometer
                                                                 , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic megameter. Defined in terms of a(n) gigagram per cubic kilometer.
   /// </summary>
   public static readonly Density TeragramPerCubicMegameter = new (
                                                                   "teragram per cubic megameter"
                                                                 , "Tg/Mm^3"
                                                                 , GigagramPerCubicKilometer
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic gigameter. Defined in terms of a(n) megagram per cubic megameter.
   /// </summary>
   public static readonly Density GigagramPerCubicGigameter = new (
                                                                   "gigagram per cubic gigameter"
                                                                 , "Gg/Gm^3"
                                                                 , MegagramPerCubicMegameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic terameter. Defined in terms of a(n) kilogram per cubic gigameter.
   /// </summary>
   public static readonly Density MegagramPerCubicTerameter = new (
                                                                   "megagram per cubic terameter"
                                                                 , "Mg/Tm^3"
                                                                 , KilogramPerCubicGigameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic petameter. Defined in terms of a(n) hectogram per cubic terameter.
   /// </summary>
   public static readonly Density KilogramPerCubicPetameter = new (
                                                                   "kilogram per cubic petameter"
                                                                 , "kg/Pm^3"
                                                                 , HectogramPerCubicTerameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) hectogram per cubic exameter. Defined in terms of a(n) dekagram per cubic petameter.
   /// </summary>
   public static readonly Density HectogramPerCubicExameter = new (
                                                                   "hectogram per cubic exameter"
                                                                 , "hg/Em^3"
                                                                 , DekagramPerCubicPetameter
                                                                 , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) dekagram per cubic zettameter. Defined in terms of a(n) gram per cubic exameter.
   /// </summary>
   public static readonly Density DekagramPerCubicZettameter = new (
                                                                    "dekagram per cubic zettameter"
                                                                  , "dag/Zm^3"
                                                                  , GramPerCubicExameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yoctogram per cubic quettameter. Defined in terms of a(n) zeptogram per cubic ronnameter.
   /// </summary>
   public static readonly Density YoctogramPerCubicQuettameter = new (
                                                                      "yoctogram per cubic quettameter"
                                                                    , "yg/Qm^3"
                                                                    , ZeptogramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rontogram per cubic ronnameter. Defined in terms of a(n) yoctogram per cubic yottameter.
   /// </summary>
   public static readonly Density RontogramPerCubicRonnameter = new (
                                                                     "rontogram per cubic ronnameter"
                                                                   , "rg/Rm^3"
                                                                   , YoctogramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quectogram per cubic yottameter. Defined in terms of a(n) rontogram per cubic zettameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicYottameter = new (
                                                                      "quectogram per cubic yottameter"
                                                                    , "qg/Ym^3"
                                                                    , RontogramPerCubicZettameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic rontometer. Defined in terms of a(n) ronnagram per cubic yoctometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicRontometer = new (
                                                                      "quettagram per cubic rontometer"
                                                                    , "Qg/rm^3"
                                                                    , RonnagramPerCubicYoctometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic quectometer. Defined in terms of a(n) yottagram per cubic rontometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicQuectometer = new (
                                                                      "ronnagram per cubic quectometer"
                                                                    , "Rg/qm^3"
                                                                    , YottagramPerCubicRontometer
                                                                    , 1000.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yottagram per cubic dekameter. Defined in terms of a(n) zettagram per cubic meter.
   /// </summary>
   public static readonly Density YottagramPerCubicDekameter = new (
                                                                    "yottagram per cubic dekameter"
                                                                  , "Yg/dam^3"
                                                                  , ZettagramPerCubicMeter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic hectometer. Defined in terms of a(n) exagram per cubic dekameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicHectometer = new (
                                                                     "zettagram per cubic hectometer"
                                                                   , "Zg/hm^3"
                                                                   , ExagramPerCubicDekameter
                                                                   , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic kilometer. Defined in terms of a(n) petagram per cubic hectometer.
   /// </summary>
   public static readonly Density ExagramPerCubicKilometer = new (
                                                                  "exagram per cubic kilometer"
                                                                , "Eg/km^3"
                                                                , PetagramPerCubicHectometer
                                                                , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic megameter. Defined in terms of a(n) teragram per cubic kilometer.
   /// </summary>
   public static readonly Density PetagramPerCubicMegameter = new (
                                                                   "petagram per cubic megameter"
                                                                 , "Pg/Mm^3"
                                                                 , TeragramPerCubicKilometer
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic gigameter. Defined in terms of a(n) gigagram per cubic megameter.
   /// </summary>
   public static readonly Density TeragramPerCubicGigameter = new (
                                                                   "teragram per cubic gigameter"
                                                                 , "Tg/Gm^3"
                                                                 , GigagramPerCubicMegameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic terameter. Defined in terms of a(n) megagram per cubic gigameter.
   /// </summary>
   public static readonly Density GigagramPerCubicTerameter = new (
                                                                   "gigagram per cubic terameter"
                                                                 , "Gg/Tm^3"
                                                                 , MegagramPerCubicGigameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic petameter. Defined in terms of a(n) kilogram per cubic terameter.
   /// </summary>
   public static readonly Density MegagramPerCubicPetameter = new (
                                                                   "megagram per cubic petameter"
                                                                 , "Mg/Pm^3"
                                                                 , KilogramPerCubicTerameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) kilogram per cubic exameter. Defined in terms of a(n) hectogram per cubic petameter.
   /// </summary>
   public static readonly Density KilogramPerCubicExameter = new (
                                                                  "kilogram per cubic exameter"
                                                                , "kg/Em^3"
                                                                , HectogramPerCubicPetameter
                                                                , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) hectogram per cubic zettameter. Defined in terms of a(n) dekagram per cubic exameter.
   /// </summary>
   public static readonly Density HectogramPerCubicZettameter = new (
                                                                     "hectogram per cubic zettameter"
                                                                   , "hg/Zm^3"
                                                                   , DekagramPerCubicExameter
                                                                   , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic yottameter. Defined in terms of a(n) gram per cubic zettameter.
   /// </summary>
   public static readonly Density DekagramPerCubicYottameter = new (
                                                                    "dekagram per cubic yottameter"
                                                                  , "dag/Ym^3"
                                                                  , GramPerCubicZettameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) rontogram per cubic quettameter. Defined in terms of a(n) yoctogram per cubic ronnameter.
   /// </summary>
   public static readonly Density RontogramPerCubicQuettameter = new (
                                                                      "rontogram per cubic quettameter"
                                                                    , "rg/Qm^3"
                                                                    , YoctogramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quectogram per cubic ronnameter. Defined in terms of a(n) rontogram per cubic yottameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicRonnameter = new (
                                                                      "quectogram per cubic ronnameter"
                                                                    , "qg/Rm^3"
                                                                    , RontogramPerCubicYottameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic quectometer. Defined in terms of a(n) ronnagram per cubic rontometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicQuectometer = new (
                                                                       "quettagram per cubic quectometer"
                                                                     , "Qg/qm^3"
                                                                     , RonnagramPerCubicRontometer
                                                                     , 1000.0
                                                                     / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) ronnagram per cubic dekameter. Defined in terms of a(n) yottagram per cubic meter.
   /// </summary>
   public static readonly Density RonnagramPerCubicDekameter = new (
                                                                    "ronnagram per cubic dekameter"
                                                                  , "Rg/dam^3"
                                                                  , YottagramPerCubicMeter
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic hectometer. Defined in terms of a(n) zettagram per cubic dekameter.
   /// </summary>
   public static readonly Density YottagramPerCubicHectometer = new (
                                                                     "yottagram per cubic hectometer"
                                                                   , "Yg/hm^3"
                                                                   , ZettagramPerCubicDekameter
                                                                   , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic kilometer. Defined in terms of a(n) exagram per cubic hectometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicKilometer = new (
                                                                    "zettagram per cubic kilometer"
                                                                  , "Zg/km^3"
                                                                  , ExagramPerCubicHectometer
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic megameter. Defined in terms of a(n) petagram per cubic kilometer.
   /// </summary>
   public static readonly Density ExagramPerCubicMegameter = new (
                                                                  "exagram per cubic megameter"
                                                                , "Eg/Mm^3"
                                                                , PetagramPerCubicKilometer
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic gigameter. Defined in terms of a(n) teragram per cubic megameter.
   /// </summary>
   public static readonly Density PetagramPerCubicGigameter = new (
                                                                   "petagram per cubic gigameter"
                                                                 , "Pg/Gm^3"
                                                                 , TeragramPerCubicMegameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic terameter. Defined in terms of a(n) gigagram per cubic gigameter.
   /// </summary>
   public static readonly Density TeragramPerCubicTerameter = new (
                                                                   "teragram per cubic terameter"
                                                                 , "Tg/Tm^3"
                                                                 , GigagramPerCubicGigameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic petameter. Defined in terms of a(n) megagram per cubic terameter.
   /// </summary>
   public static readonly Density GigagramPerCubicPetameter = new (
                                                                   "gigagram per cubic petameter"
                                                                 , "Gg/Pm^3"
                                                                 , MegagramPerCubicTerameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) megagram per cubic exameter. Defined in terms of a(n) kilogram per cubic petameter.
   /// </summary>
   public static readonly Density MegagramPerCubicExameter = new (
                                                                  "megagram per cubic exameter"
                                                                , "Mg/Em^3"
                                                                , KilogramPerCubicPetameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) kilogram per cubic zettameter. Defined in terms of a(n) hectogram per cubic exameter.
   /// </summary>
   public static readonly Density KilogramPerCubicZettameter = new (
                                                                    "kilogram per cubic zettameter"
                                                                  , "kg/Zm^3"
                                                                  , HectogramPerCubicExameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic yottameter. Defined in terms of a(n) dekagram per cubic zettameter.
   /// </summary>
   public static readonly Density HectogramPerCubicYottameter = new (
                                                                     "hectogram per cubic yottameter"
                                                                   , "hg/Ym^3"
                                                                   , DekagramPerCubicZettameter
                                                                   , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic ronnameter. Defined in terms of a(n) gram per cubic yottameter.
   /// </summary>
   public static readonly Density DekagramPerCubicRonnameter = new (
                                                                    "dekagram per cubic ronnameter"
                                                                  , "dag/Rm^3"
                                                                  , GramPerCubicYottameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quectogram per cubic quettameter. Defined in terms of a(n) rontogram per cubic ronnameter.
   /// </summary>
   public static readonly Density QuectogramPerCubicQuettameter = new (
                                                                       "quectogram per cubic quettameter"
                                                                     , "qg/Qm^3"
                                                                     , RontogramPerCubicRonnameter
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) quettagram per cubic dekameter. Defined in terms of a(n) ronnagram per cubic meter.
   /// </summary>
   public static readonly Density QuettagramPerCubicDekameter = new (
                                                                     "quettagram per cubic dekameter"
                                                                   , "Qg/dam^3"
                                                                   , RonnagramPerCubicMeter
                                                                   , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic hectometer. Defined in terms of a(n) yottagram per cubic dekameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicHectometer = new (
                                                                     "ronnagram per cubic hectometer"
                                                                   , "Rg/hm^3"
                                                                   , YottagramPerCubicDekameter
                                                                   , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic kilometer. Defined in terms of a(n) zettagram per cubic hectometer.
   /// </summary>
   public static readonly Density YottagramPerCubicKilometer = new (
                                                                    "yottagram per cubic kilometer"
                                                                  , "Yg/km^3"
                                                                  , ZettagramPerCubicHectometer
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic megameter. Defined in terms of a(n) exagram per cubic kilometer.
   /// </summary>
   public static readonly Density ZettagramPerCubicMegameter = new (
                                                                    "zettagram per cubic megameter"
                                                                  , "Zg/Mm^3"
                                                                  , ExagramPerCubicKilometer
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic gigameter. Defined in terms of a(n) petagram per cubic megameter.
   /// </summary>
   public static readonly Density ExagramPerCubicGigameter = new (
                                                                  "exagram per cubic gigameter"
                                                                , "Eg/Gm^3"
                                                                , PetagramPerCubicMegameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic terameter. Defined in terms of a(n) teragram per cubic gigameter.
   /// </summary>
   public static readonly Density PetagramPerCubicTerameter = new (
                                                                   "petagram per cubic terameter"
                                                                 , "Pg/Tm^3"
                                                                 , TeragramPerCubicGigameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic petameter. Defined in terms of a(n) gigagram per cubic terameter.
   /// </summary>
   public static readonly Density TeragramPerCubicPetameter = new (
                                                                   "teragram per cubic petameter"
                                                                 , "Tg/Pm^3"
                                                                 , GigagramPerCubicTerameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) gigagram per cubic exameter. Defined in terms of a(n) megagram per cubic petameter.
   /// </summary>
   public static readonly Density GigagramPerCubicExameter = new (
                                                                  "gigagram per cubic exameter"
                                                                , "Gg/Em^3"
                                                                , MegagramPerCubicPetameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) megagram per cubic zettameter. Defined in terms of a(n) kilogram per cubic exameter.
   /// </summary>
   public static readonly Density MegagramPerCubicZettameter = new (
                                                                    "megagram per cubic zettameter"
                                                                  , "Mg/Zm^3"
                                                                  , KilogramPerCubicExameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic yottameter. Defined in terms of a(n) hectogram per cubic zettameter.
   /// </summary>
   public static readonly Density KilogramPerCubicYottameter = new (
                                                                    "kilogram per cubic yottameter"
                                                                  , "kg/Ym^3"
                                                                  , HectogramPerCubicZettameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic ronnameter. Defined in terms of a(n) dekagram per cubic yottameter.
   /// </summary>
   public static readonly Density HectogramPerCubicRonnameter = new (
                                                                     "hectogram per cubic ronnameter"
                                                                   , "hg/Rm^3"
                                                                   , DekagramPerCubicYottameter
                                                                   , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekagram per cubic quettameter. Defined in terms of a(n) gram per cubic ronnameter.
   /// </summary>
   public static readonly Density DekagramPerCubicQuettameter = new (
                                                                     "dekagram per cubic quettameter"
                                                                   , "dag/Qm^3"
                                                                   , GramPerCubicRonnameter
                                                                   , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic hectometer. Defined in terms of a(n) ronnagram per cubic dekameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicHectometer = new (
                                                                      "quettagram per cubic hectometer"
                                                                    , "Qg/hm^3"
                                                                    , RonnagramPerCubicDekameter
                                                                    , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic kilometer. Defined in terms of a(n) yottagram per cubic hectometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicKilometer = new (
                                                                    "ronnagram per cubic kilometer"
                                                                  , "Rg/km^3"
                                                                  , YottagramPerCubicHectometer
                                                                  , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic megameter. Defined in terms of a(n) zettagram per cubic kilometer.
   /// </summary>
   public static readonly Density YottagramPerCubicMegameter = new (
                                                                    "yottagram per cubic megameter"
                                                                  , "Yg/Mm^3"
                                                                  , ZettagramPerCubicKilometer
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic gigameter. Defined in terms of a(n) exagram per cubic megameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicGigameter = new (
                                                                    "zettagram per cubic gigameter"
                                                                  , "Zg/Gm^3"
                                                                  , ExagramPerCubicMegameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic terameter. Defined in terms of a(n) petagram per cubic gigameter.
   /// </summary>
   public static readonly Density ExagramPerCubicTerameter = new (
                                                                  "exagram per cubic terameter"
                                                                , "Eg/Tm^3"
                                                                , PetagramPerCubicGigameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic petameter. Defined in terms of a(n) teragram per cubic terameter.
   /// </summary>
   public static readonly Density PetagramPerCubicPetameter = new (
                                                                   "petagram per cubic petameter"
                                                                 , "Pg/Pm^3"
                                                                 , TeragramPerCubicTerameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) teragram per cubic exameter. Defined in terms of a(n) gigagram per cubic petameter.
   /// </summary>
   public static readonly Density TeragramPerCubicExameter = new (
                                                                  "teragram per cubic exameter"
                                                                , "Tg/Em^3"
                                                                , GigagramPerCubicPetameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) gigagram per cubic zettameter. Defined in terms of a(n) megagram per cubic exameter.
   /// </summary>
   public static readonly Density GigagramPerCubicZettameter = new (
                                                                    "gigagram per cubic zettameter"
                                                                  , "Gg/Zm^3"
                                                                  , MegagramPerCubicExameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic yottameter. Defined in terms of a(n) kilogram per cubic zettameter.
   /// </summary>
   public static readonly Density MegagramPerCubicYottameter = new (
                                                                    "megagram per cubic yottameter"
                                                                  , "Mg/Ym^3"
                                                                  , KilogramPerCubicZettameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic ronnameter. Defined in terms of a(n) hectogram per cubic yottameter.
   /// </summary>
   public static readonly Density KilogramPerCubicRonnameter = new (
                                                                    "kilogram per cubic ronnameter"
                                                                  , "kg/Rm^3"
                                                                  , HectogramPerCubicYottameter
                                                                  , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) hectogram per cubic quettameter. Defined in terms of a(n) dekagram per cubic ronnameter.
   /// </summary>
   public static readonly Density HectogramPerCubicQuettameter = new (
                                                                      "hectogram per cubic quettameter"
                                                                    , "hg/Qm^3"
                                                                    , DekagramPerCubicRonnameter
                                                                    , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic kilometer. Defined in terms of a(n) ronnagram per cubic hectometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicKilometer = new (
                                                                     "quettagram per cubic kilometer"
                                                                   , "Qg/km^3"
                                                                   , RonnagramPerCubicHectometer
                                                                   , 1000.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic megameter. Defined in terms of a(n) yottagram per cubic kilometer.
   /// </summary>
   public static readonly Density RonnagramPerCubicMegameter = new (
                                                                    "ronnagram per cubic megameter"
                                                                  , "Rg/Mm^3"
                                                                  , YottagramPerCubicKilometer
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic gigameter. Defined in terms of a(n) zettagram per cubic megameter.
   /// </summary>
   public static readonly Density YottagramPerCubicGigameter = new (
                                                                    "yottagram per cubic gigameter"
                                                                  , "Yg/Gm^3"
                                                                  , ZettagramPerCubicMegameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic terameter. Defined in terms of a(n) exagram per cubic gigameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicTerameter = new (
                                                                    "zettagram per cubic terameter"
                                                                  , "Zg/Tm^3"
                                                                  , ExagramPerCubicGigameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic petameter. Defined in terms of a(n) petagram per cubic terameter.
   /// </summary>
   public static readonly Density ExagramPerCubicPetameter = new (
                                                                  "exagram per cubic petameter"
                                                                , "Eg/Pm^3"
                                                                , PetagramPerCubicTerameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) petagram per cubic exameter. Defined in terms of a(n) teragram per cubic petameter.
   /// </summary>
   public static readonly Density PetagramPerCubicExameter = new (
                                                                  "petagram per cubic exameter"
                                                                , "Pg/Em^3"
                                                                , TeragramPerCubicPetameter
                                                                , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) teragram per cubic zettameter. Defined in terms of a(n) gigagram per cubic exameter.
   /// </summary>
   public static readonly Density TeragramPerCubicZettameter = new (
                                                                    "teragram per cubic zettameter"
                                                                  , "Tg/Zm^3"
                                                                  , GigagramPerCubicExameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic yottameter. Defined in terms of a(n) megagram per cubic zettameter.
   /// </summary>
   public static readonly Density GigagramPerCubicYottameter = new (
                                                                    "gigagram per cubic yottameter"
                                                                  , "Gg/Ym^3"
                                                                  , MegagramPerCubicZettameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic ronnameter. Defined in terms of a(n) kilogram per cubic yottameter.
   /// </summary>
   public static readonly Density MegagramPerCubicRonnameter = new (
                                                                    "megagram per cubic ronnameter"
                                                                  , "Mg/Rm^3"
                                                                  , KilogramPerCubicYottameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) kilogram per cubic quettameter. Defined in terms of a(n) hectogram per cubic ronnameter.
   /// </summary>
   public static readonly Density KilogramPerCubicQuettameter = new (
                                                                     "kilogram per cubic quettameter"
                                                                   , "kg/Qm^3"
                                                                   , HectogramPerCubicRonnameter
                                                                   , 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic megameter. Defined in terms of a(n) ronnagram per cubic kilometer.
   /// </summary>
   public static readonly Density QuettagramPerCubicMegameter = new (
                                                                     "quettagram per cubic megameter"
                                                                   , "Qg/Mm^3"
                                                                   , RonnagramPerCubicKilometer
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic gigameter. Defined in terms of a(n) yottagram per cubic megameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicGigameter = new (
                                                                    "ronnagram per cubic gigameter"
                                                                  , "Rg/Gm^3"
                                                                  , YottagramPerCubicMegameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic terameter. Defined in terms of a(n) zettagram per cubic gigameter.
   /// </summary>
   public static readonly Density YottagramPerCubicTerameter = new (
                                                                    "yottagram per cubic terameter"
                                                                  , "Yg/Tm^3"
                                                                  , ZettagramPerCubicGigameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic petameter. Defined in terms of a(n) exagram per cubic terameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicPetameter = new (
                                                                    "zettagram per cubic petameter"
                                                                  , "Zg/Pm^3"
                                                                  , ExagramPerCubicTerameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) exagram per cubic exameter. Defined in terms of a(n) petagram per cubic petameter.
   /// </summary>
   public static readonly Density ExagramPerCubicExameter = new (
                                                                 "exagram per cubic exameter"
                                                               , "Eg/Em^3"
                                                               , PetagramPerCubicPetameter
                                                               , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) petagram per cubic zettameter. Defined in terms of a(n) teragram per cubic exameter.
   /// </summary>
   public static readonly Density PetagramPerCubicZettameter = new (
                                                                    "petagram per cubic zettameter"
                                                                  , "Pg/Zm^3"
                                                                  , TeragramPerCubicExameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic yottameter. Defined in terms of a(n) gigagram per cubic zettameter.
   /// </summary>
   public static readonly Density TeragramPerCubicYottameter = new (
                                                                    "teragram per cubic yottameter"
                                                                  , "Tg/Ym^3"
                                                                  , GigagramPerCubicZettameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic ronnameter. Defined in terms of a(n) megagram per cubic yottameter.
   /// </summary>
   public static readonly Density GigagramPerCubicRonnameter = new (
                                                                    "gigagram per cubic ronnameter"
                                                                  , "Gg/Rm^3"
                                                                  , MegagramPerCubicYottameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) megagram per cubic quettameter. Defined in terms of a(n) kilogram per cubic ronnameter.
   /// </summary>
   public static readonly Density MegagramPerCubicQuettameter = new (
                                                                     "megagram per cubic quettameter"
                                                                   , "Mg/Qm^3"
                                                                   , KilogramPerCubicRonnameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic gigameter. Defined in terms of a(n) ronnagram per cubic megameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicGigameter = new (
                                                                     "quettagram per cubic gigameter"
                                                                   , "Qg/Gm^3"
                                                                   , RonnagramPerCubicMegameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic terameter. Defined in terms of a(n) yottagram per cubic gigameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicTerameter = new (
                                                                    "ronnagram per cubic terameter"
                                                                  , "Rg/Tm^3"
                                                                  , YottagramPerCubicGigameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic petameter. Defined in terms of a(n) zettagram per cubic terameter.
   /// </summary>
   public static readonly Density YottagramPerCubicPetameter = new (
                                                                    "yottagram per cubic petameter"
                                                                  , "Yg/Pm^3"
                                                                  , ZettagramPerCubicTerameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) zettagram per cubic exameter. Defined in terms of a(n) exagram per cubic petameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicExameter = new (
                                                                   "zettagram per cubic exameter"
                                                                 , "Zg/Em^3"
                                                                 , ExagramPerCubicPetameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) exagram per cubic zettameter. Defined in terms of a(n) petagram per cubic exameter.
   /// </summary>
   public static readonly Density ExagramPerCubicZettameter = new (
                                                                   "exagram per cubic zettameter"
                                                                 , "Eg/Zm^3"
                                                                 , PetagramPerCubicExameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic yottameter. Defined in terms of a(n) teragram per cubic zettameter.
   /// </summary>
   public static readonly Density PetagramPerCubicYottameter = new (
                                                                    "petagram per cubic yottameter"
                                                                  , "Pg/Ym^3"
                                                                  , TeragramPerCubicZettameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic ronnameter. Defined in terms of a(n) gigagram per cubic yottameter.
   /// </summary>
   public static readonly Density TeragramPerCubicRonnameter = new (
                                                                    "teragram per cubic ronnameter"
                                                                  , "Tg/Rm^3"
                                                                  , GigagramPerCubicYottameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) gigagram per cubic quettameter. Defined in terms of a(n) megagram per cubic ronnameter.
   /// </summary>
   public static readonly Density GigagramPerCubicQuettameter = new (
                                                                     "gigagram per cubic quettameter"
                                                                   , "Gg/Qm^3"
                                                                   , MegagramPerCubicRonnameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic terameter. Defined in terms of a(n) ronnagram per cubic gigameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicTerameter = new (
                                                                     "quettagram per cubic terameter"
                                                                   , "Qg/Tm^3"
                                                                   , RonnagramPerCubicGigameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic petameter. Defined in terms of a(n) yottagram per cubic terameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicPetameter = new (
                                                                    "ronnagram per cubic petameter"
                                                                  , "Rg/Pm^3"
                                                                  , YottagramPerCubicTerameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) yottagram per cubic exameter. Defined in terms of a(n) zettagram per cubic petameter.
   /// </summary>
   public static readonly Density YottagramPerCubicExameter = new (
                                                                   "yottagram per cubic exameter"
                                                                 , "Yg/Em^3"
                                                                 , ZettagramPerCubicPetameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) zettagram per cubic zettameter. Defined in terms of a(n) exagram per cubic exameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicZettameter = new (
                                                                     "zettagram per cubic zettameter"
                                                                   , "Zg/Zm^3"
                                                                   , ExagramPerCubicExameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic yottameter. Defined in terms of a(n) petagram per cubic zettameter.
   /// </summary>
   public static readonly Density ExagramPerCubicYottameter = new (
                                                                   "exagram per cubic yottameter"
                                                                 , "Eg/Ym^3"
                                                                 , PetagramPerCubicZettameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic ronnameter. Defined in terms of a(n) teragram per cubic yottameter.
   /// </summary>
   public static readonly Density PetagramPerCubicRonnameter = new (
                                                                    "petagram per cubic ronnameter"
                                                                  , "Pg/Rm^3"
                                                                  , TeragramPerCubicYottameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) teragram per cubic quettameter. Defined in terms of a(n) gigagram per cubic ronnameter.
   /// </summary>
   public static readonly Density TeragramPerCubicQuettameter = new (
                                                                     "teragram per cubic quettameter"
                                                                   , "Tg/Qm^3"
                                                                   , GigagramPerCubicRonnameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic petameter. Defined in terms of a(n) ronnagram per cubic terameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicPetameter = new (
                                                                     "quettagram per cubic petameter"
                                                                   , "Qg/Pm^3"
                                                                   , RonnagramPerCubicTerameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) ronnagram per cubic exameter. Defined in terms of a(n) yottagram per cubic petameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicExameter = new (
                                                                   "ronnagram per cubic exameter"
                                                                 , "Rg/Em^3"
                                                                 , YottagramPerCubicPetameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) yottagram per cubic zettameter. Defined in terms of a(n) zettagram per cubic exameter.
   /// </summary>
   public static readonly Density YottagramPerCubicZettameter = new (
                                                                     "yottagram per cubic zettameter"
                                                                   , "Yg/Zm^3"
                                                                   , ZettagramPerCubicExameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic yottameter. Defined in terms of a(n) exagram per cubic zettameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicYottameter = new (
                                                                     "zettagram per cubic yottameter"
                                                                   , "Zg/Ym^3"
                                                                   , ExagramPerCubicZettameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic ronnameter. Defined in terms of a(n) petagram per cubic yottameter.
   /// </summary>
   public static readonly Density ExagramPerCubicRonnameter = new (
                                                                   "exagram per cubic ronnameter"
                                                                 , "Eg/Rm^3"
                                                                 , PetagramPerCubicYottameter
                                                                 , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) petagram per cubic quettameter. Defined in terms of a(n) teragram per cubic ronnameter.
   /// </summary>
   public static readonly Density PetagramPerCubicQuettameter = new (
                                                                     "petagram per cubic quettameter"
                                                                   , "Pg/Qm^3"
                                                                   , TeragramPerCubicRonnameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) quettagram per cubic exameter. Defined in terms of a(n) ronnagram per cubic petameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicExameter = new (
                                                                    "quettagram per cubic exameter"
                                                                  , "Qg/Em^3"
                                                                  , RonnagramPerCubicPetameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) ronnagram per cubic zettameter. Defined in terms of a(n) yottagram per cubic exameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicZettameter = new (
                                                                     "ronnagram per cubic zettameter"
                                                                   , "Rg/Zm^3"
                                                                   , YottagramPerCubicExameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic yottameter. Defined in terms of a(n) zettagram per cubic zettameter.
   /// </summary>
   public static readonly Density YottagramPerCubicYottameter = new (
                                                                     "yottagram per cubic yottameter"
                                                                   , "Yg/Ym^3"
                                                                   , ZettagramPerCubicZettameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic ronnameter. Defined in terms of a(n) exagram per cubic yottameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicRonnameter = new (
                                                                     "zettagram per cubic ronnameter"
                                                                   , "Zg/Rm^3"
                                                                   , ExagramPerCubicYottameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) exagram per cubic quettameter. Defined in terms of a(n) petagram per cubic ronnameter.
   /// </summary>
   public static readonly Density ExagramPerCubicQuettameter = new (
                                                                    "exagram per cubic quettameter"
                                                                  , "Eg/Qm^3"
                                                                  , PetagramPerCubicRonnameter
                                                                  , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) quettagram per cubic zettameter. Defined in terms of a(n) ronnagram per cubic exameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicZettameter = new (
                                                                      "quettagram per cubic zettameter"
                                                                    , "Qg/Zm^3"
                                                                    , RonnagramPerCubicExameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic yottameter. Defined in terms of a(n) yottagram per cubic zettameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicYottameter = new (
                                                                     "ronnagram per cubic yottameter"
                                                                   , "Rg/Ym^3"
                                                                   , YottagramPerCubicZettameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic ronnameter. Defined in terms of a(n) zettagram per cubic yottameter.
   /// </summary>
   public static readonly Density YottagramPerCubicRonnameter = new (
                                                                     "yottagram per cubic ronnameter"
                                                                   , "Yg/Rm^3"
                                                                   , ZettagramPerCubicYottameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zettagram per cubic quettameter. Defined in terms of a(n) exagram per cubic ronnameter.
   /// </summary>
   public static readonly Density ZettagramPerCubicQuettameter = new (
                                                                      "zettagram per cubic quettameter"
                                                                    , "Zg/Qm^3"
                                                                    , ExagramPerCubicRonnameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic yottameter. Defined in terms of a(n) ronnagram per cubic zettameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicYottameter = new (
                                                                      "quettagram per cubic yottameter"
                                                                    , "Qg/Ym^3"
                                                                    , RonnagramPerCubicZettameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic ronnameter. Defined in terms of a(n) yottagram per cubic yottameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicRonnameter = new (
                                                                     "ronnagram per cubic ronnameter"
                                                                   , "Rg/Rm^3"
                                                                   , YottagramPerCubicYottameter
                                                                   , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) yottagram per cubic quettameter. Defined in terms of a(n) zettagram per cubic ronnameter.
   /// </summary>
   public static readonly Density YottagramPerCubicQuettameter = new (
                                                                      "yottagram per cubic quettameter"
                                                                    , "Yg/Qm^3"
                                                                    , ZettagramPerCubicRonnameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic ronnameter. Defined in terms of a(n) ronnagram per cubic yottameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicRonnameter = new (
                                                                      "quettagram per cubic ronnameter"
                                                                    , "Qg/Rm^3"
                                                                    , RonnagramPerCubicYottameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) ronnagram per cubic quettameter. Defined in terms of a(n) yottagram per cubic ronnameter.
   /// </summary>
   public static readonly Density RonnagramPerCubicQuettameter = new (
                                                                      "ronnagram per cubic quettameter"
                                                                    , "Rg/Qm^3"
                                                                    , YottagramPerCubicRonnameter
                                                                    , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quettagram per cubic quettameter. Defined in terms of a(n) ronnagram per cubic ronnameter.
   /// </summary>
   public static readonly Density QuettagramPerCubicQuettameter = new (
                                                                       "quettagram per cubic quettameter"
                                                                     , "Qg/Qm^3"
                                                                     , RonnagramPerCubicRonnameter
                                                                     , 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                     , 0
                                                                      );

   /// <summary>
   /// A(n) metric ton per cubic meter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density MetricTonPerCubicMeter = new (
                                                                "metric ton per cubic meter"
                                                              , "mt/m^3"
                                                              , MegagramPerCubicMeter
                                                              , 1.0 / (1.0 * 1.0 * 1.0)
                                                              , 0
                                                               );

   /// <summary>
   /// A(n) metric ton per cubic decimeter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density MetricTonPerCubicDecimeter = new (
                                                                    "metric ton per cubic decimeter"
                                                                  , "mt/dm^3"
                                                                  , MegagramPerCubicMeter
                                                                  , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic centimeter. Defined in terms of a(n) megagram per cubic decimeter.
   /// </summary>
   public static readonly Density MetricTonPerCubicCentimeter = new (
                                                                     "metric ton per cubic centimeter"
                                                                   , "mt/cm^3"
                                                                   , MegagramPerCubicDecimeter
                                                                   , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic millimeter. Defined in terms of a(n) megagram per cubic centimeter.
   /// </summary>
   public static readonly Density MetricTonPerCubicMillimeter = new (
                                                                     "metric ton per cubic millimeter"
                                                                   , "mt/mm^3"
                                                                   , MegagramPerCubicCentimeter
                                                                   , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic micrometer. Defined in terms of a(n) megagram per cubic millimeter.
   /// </summary>
   public static readonly Density MetricTonPerCubicMicrometer = new (
                                                                     "metric ton per cubic micrometer"
                                                                   , "mt/μm^3"
                                                                   , MegagramPerCubicMillimeter
                                                                   , 1.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic nanometer. Defined in terms of a(n) megagram per cubic micrometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicNanometer = new (
                                                                    "metric ton per cubic nanometer"
                                                                  , "mt/nm^3"
                                                                  , MegagramPerCubicMicrometer
                                                                  , 1.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic picometer. Defined in terms of a(n) megagram per cubic nanometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicPicometer = new (
                                                                    "metric ton per cubic picometer"
                                                                  , "mt/pm^3"
                                                                  , MegagramPerCubicNanometer
                                                                  , 1.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic femtometer. Defined in terms of a(n) megagram per cubic picometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicFemtometer = new (
                                                                     "metric ton per cubic femtometer"
                                                                   , "mt/fm^3"
                                                                   , MegagramPerCubicPicometer
                                                                   , 1.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic attometer. Defined in terms of a(n) megagram per cubic femtometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicAttometer = new (
                                                                    "metric ton per cubic attometer"
                                                                  , "mt/am^3"
                                                                  , MegagramPerCubicFemtometer
                                                                  , 1.0
                                                                  / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic zeptometer. Defined in terms of a(n) megagram per cubic attometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicZeptometer = new (
                                                                     "metric ton per cubic zeptometer"
                                                                   , "mt/zm^3"
                                                                   , MegagramPerCubicAttometer
                                                                   , 1.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic yoctometer. Defined in terms of a(n) megagram per cubic zeptometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicYoctometer = new (
                                                                     "metric ton per cubic yoctometer"
                                                                   , "mt/ym^3"
                                                                   , MegagramPerCubicZeptometer
                                                                   , 1.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic rontometer. Defined in terms of a(n) megagram per cubic yoctometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicRontometer = new (
                                                                     "metric ton per cubic rontometer"
                                                                   , "mt/rm^3"
                                                                   , MegagramPerCubicYoctometer
                                                                   , 1.0
                                                                   / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic quectometer. Defined in terms of a(n) megagram per cubic rontometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicQuectometer = new (
                                                                      "metric ton per cubic quectometer"
                                                                    , "mt/qm^3"
                                                                    , MegagramPerCubicRontometer
                                                                    , 1.0
                                                                    / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) metric ton per cubic dekameter. Defined in terms of a(n) megagram per cubic meter.
   /// </summary>
   public static readonly Density MetricTonPerCubicDekameter = new (
                                                                    "metric ton per cubic dekameter"
                                                                  , "mt/dam^3"
                                                                  , MegagramPerCubicMeter
                                                                  , 1.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic hectometer. Defined in terms of a(n) megagram per cubic dekameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicHectometer = new (
                                                                     "metric ton per cubic hectometer"
                                                                   , "mt/hm^3"
                                                                   , MegagramPerCubicDekameter
                                                                   , 1.0 / (10.0 * 10.0 * 10.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic kilometer. Defined in terms of a(n) megagram per cubic hectometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicKilometer = new (
                                                                    "metric ton per cubic kilometer"
                                                                  , "mt/km^3"
                                                                  , MegagramPerCubicHectometer
                                                                  , 1.0 / (10.0 * 10.0 * 10.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic megameter. Defined in terms of a(n) megagram per cubic kilometer.
   /// </summary>
   public static readonly Density MetricTonPerCubicMegameter = new (
                                                                    "metric ton per cubic megameter"
                                                                  , "mt/Mm^3"
                                                                  , MegagramPerCubicKilometer
                                                                  , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic gigameter. Defined in terms of a(n) megagram per cubic megameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicGigameter = new (
                                                                    "metric ton per cubic gigameter"
                                                                  , "mt/Gm^3"
                                                                  , MegagramPerCubicMegameter
                                                                  , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic terameter. Defined in terms of a(n) megagram per cubic gigameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicTerameter = new (
                                                                    "metric ton per cubic terameter"
                                                                  , "mt/Tm^3"
                                                                  , MegagramPerCubicGigameter
                                                                  , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic petameter. Defined in terms of a(n) megagram per cubic terameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicPetameter = new (
                                                                    "metric ton per cubic petameter"
                                                                  , "mt/Pm^3"
                                                                  , MegagramPerCubicTerameter
                                                                  , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , 0
                                                                   );

   /// <summary>
   /// A(n) metric ton per cubic exameter. Defined in terms of a(n) megagram per cubic petameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicExameter = new (
                                                                   "metric ton per cubic exameter"
                                                                 , "mt/Em^3"
                                                                 , MegagramPerCubicPetameter
                                                                 , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , 0
                                                                  );

   /// <summary>
   /// A(n) metric ton per cubic zettameter. Defined in terms of a(n) megagram per cubic exameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicZettameter = new (
                                                                     "metric ton per cubic zettameter"
                                                                   , "mt/Zm^3"
                                                                   , MegagramPerCubicExameter
                                                                   , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic yottameter. Defined in terms of a(n) megagram per cubic zettameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicYottameter = new (
                                                                     "metric ton per cubic yottameter"
                                                                   , "mt/Ym^3"
                                                                   , MegagramPerCubicZettameter
                                                                   , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic ronnameter. Defined in terms of a(n) megagram per cubic yottameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicRonnameter = new (
                                                                     "metric ton per cubic ronnameter"
                                                                   , "mt/Rm^3"
                                                                   , MegagramPerCubicYottameter
                                                                   , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) metric ton per cubic quettameter. Defined in terms of a(n) megagram per cubic ronnameter.
   /// </summary>
   public static readonly Density MetricTonPerCubicQuettameter = new (
                                                                      "metric ton per cubic quettameter"
                                                                    , "mt/Qm^3"
                                                                    , MegagramPerCubicRonnameter
                                                                    , 1.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , 0
                                                                     );
}
