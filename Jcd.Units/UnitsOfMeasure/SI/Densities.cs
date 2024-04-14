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
public class Densities : UnitOfMeasureEnumeration<Densities, Density>
{
   /// <summary>
   /// kilogram per cubic meter, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for
   /// this type.)
   /// </summary>
   public static readonly Density KilogramPerCubicMeter = new("kilogram per cubic meter", "kg/m³", system: "SI");
   
   /// <summary>
   /// kilogram per cubic decimeter defined such that: kilogram per cubic meter = kg/dm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicDecimeter = new("kilogram per cubic decimeter"
                                                                , "kg/dm³"
                                                                , KilogramPerCubicMeter
                                                                , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// kilogram per cubic centimeter defined such that: kilogram per cubic decimeter = kg/cm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicCentimeter = new("kilogram per cubic centimeter"
                                                                 , "kg/cm³"
                                                                 , KilogramPerCubicDecimeter
                                                                 , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectogram per cubic meter defined such that: kilogram per cubic meter = hg/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicMeter =
      new("hectogram per cubic meter", "hg/m³", KilogramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic millimeter defined such that: kilogram per cubic centimeter = kg/mm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicMillimeter = new("kilogram per cubic millimeter"
                                                                 , "kg/mm³"
                                                                 , KilogramPerCubicCentimeter
                                                                 , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilogram per cubic micrometer defined such that: kilogram per cubic millimeter = kg/μm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicMicrometer = new("kilogram per cubic micrometer"
                                                                 , "kg/μm³"
                                                                 , KilogramPerCubicMillimeter
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectogram per cubic decimeter defined such that: kilogram per cubic meter = hg/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicDecimeter = new("hectogram per cubic decimeter"
                                                                 , "hg/dm³"
                                                                 , KilogramPerCubicMeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic meter defined such that: hectogram per cubic meter = dag/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicMeter =
      new("dekagram per cubic meter", "dag/m³", HectogramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic nanometer defined such that: kilogram per cubic micrometer = kg/nm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicNanometer = new("kilogram per cubic nanometer"
                                                                , "kg/nm³"
                                                                , KilogramPerCubicMicrometer
                                                                , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// kilogram per cubic picometer defined such that: kilogram per cubic nanometer = kg/pm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicPicometer = new("kilogram per cubic picometer"
                                                                , "kg/pm³"
                                                                , KilogramPerCubicNanometer
                                                                , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// hectogram per cubic centimeter defined such that: kilogram per cubic decimeter = hg/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicCentimeter = new("hectogram per cubic centimeter"
                                                                  , "hg/cm³"
                                                                  , KilogramPerCubicDecimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gram per cubic meter defined such that: dekagram per cubic meter = g/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density GramPerCubicMeter = new("gram per cubic meter", "g/m³", DekagramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic femtometer defined such that: kilogram per cubic picometer = kg/fm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicFemtometer = new("kilogram per cubic femtometer"
                                                                 , "kg/fm³"
                                                                 , KilogramPerCubicPicometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic decimeter defined such that: hectogram per cubic meter = dag/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicDecimeter = new("dekagram per cubic decimeter"
                                                                , "dag/dm³"
                                                                , HectogramPerCubicMeter
                                                                , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// kilogram per cubic attometer defined such that: kilogram per cubic femtometer = kg/am³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicAttometer = new("kilogram per cubic attometer"
                                                                , "kg/am³"
                                                                , KilogramPerCubicFemtometer
                                                                , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// hectogram per cubic millimeter defined such that: kilogram per cubic centimeter = hg/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicMillimeter = new("hectogram per cubic millimeter"
                                                                  , "hg/mm³"
                                                                  , KilogramPerCubicCentimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// decigram per cubic meter defined such that: gram per cubic meter = dg/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicMeter = new("decigram per cubic meter", "dg/m³", GramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic zeptometer defined such that: kilogram per cubic attometer = kg/zm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicZeptometer = new("kilogram per cubic zeptometer"
                                                                 , "kg/zm³"
                                                                 , KilogramPerCubicAttometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilogram per cubic yoctometer defined such that: kilogram per cubic zeptometer = kg/ym³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicYoctometer = new("kilogram per cubic yoctometer"
                                                                 , "kg/ym³"
                                                                 , KilogramPerCubicZeptometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectogram per cubic micrometer defined such that: kilogram per cubic millimeter = hg/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicMicrometer = new("hectogram per cubic micrometer"
                                                                  , "hg/μm³"
                                                                  , KilogramPerCubicMillimeter
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekagram per cubic centimeter defined such that: hectogram per cubic decimeter = dag/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicCentimeter = new("dekagram per cubic centimeter"
                                                                 , "dag/cm³"
                                                                 , HectogramPerCubicDecimeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic decimeter defined such that: dekagram per cubic meter = g/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GramPerCubicDecimeter = new("gram per cubic decimeter"
                                                            , "g/dm³"
                                                            , DekagramPerCubicMeter
                                                            , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                            , system: "SI"
                                                             );
   
   /// <summary>
   /// centigram per cubic meter defined such that: decigram per cubic meter = cg/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicMeter =
      new("centigram per cubic meter", "cg/m³", DecigramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic rontometer defined such that: kilogram per cubic yoctometer = kg/rm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicRontometer = new("kilogram per cubic rontometer"
                                                                 , "kg/rm³"
                                                                 , KilogramPerCubicYoctometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilogram per cubic quectometer defined such that: kilogram per cubic rontometer = kg/qm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicQuectometer = new("kilogram per cubic quectometer"
                                                                  , "kg/qm³"
                                                                  , KilogramPerCubicRontometer
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// hectogram per cubic nanometer defined such that: kilogram per cubic micrometer = hg/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicNanometer = new("hectogram per cubic nanometer"
                                                                 , "hg/nm³"
                                                                 , KilogramPerCubicMicrometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// milligram per cubic meter defined such that: centigram per cubic meter = mg/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicMeter =
      new("milligram per cubic meter", "mg/m³", CentigramPerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic dekameter defined such that: kilogram per cubic meter = kg/dam³ × (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicDekameter =
      new("kilogram per cubic dekameter", "kg/dam³", KilogramPerCubicMeter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic millimeter defined such that: hectogram per cubic centimeter = dag/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicMillimeter = new("dekagram per cubic millimeter"
                                                                 , "dag/mm³"
                                                                 , HectogramPerCubicCentimeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic decimeter defined such that: gram per cubic meter = dg/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicDecimeter = new("decigram per cubic decimeter"
                                                                , "dg/dm³"
                                                                , GramPerCubicMeter
                                                                , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// kilogram per cubic hectometer defined such that: kilogram per cubic dekameter = kg/hm³ ×
   /// (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicHectometer =
      new("kilogram per cubic hectometer", "kg/hm³", KilogramPerCubicDekameter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic picometer defined such that: kilogram per cubic nanometer = hg/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicPicometer = new("hectogram per cubic picometer"
                                                                 , "hg/pm³"
                                                                 , KilogramPerCubicNanometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic centimeter defined such that: dekagram per cubic decimeter = g/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GramPerCubicCentimeter = new("gram per cubic centimeter"
                                                             , "g/cm³"
                                                             , DekagramPerCubicDecimeter
                                                             , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// microgram per cubic meter defined such that: milligram per cubic meter = μg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicMeter =
      new("microgram per cubic meter", "μg/m³", MilligramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic kilometer defined such that: kilogram per cubic hectometer = kg/km³ ×
   /// (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicKilometer =
      new("kilogram per cubic kilometer", "kg/km³", KilogramPerCubicHectometer, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic megameter defined such that: kilogram per cubic kilometer = kg/Mm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicMegameter =
      new("kilogram per cubic megameter", "kg/Mm³", KilogramPerCubicKilometer, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic femtometer defined such that: kilogram per cubic picometer = hg/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicFemtometer = new("hectogram per cubic femtometer"
                                                                  , "hg/fm³"
                                                                  , KilogramPerCubicPicometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekagram per cubic micrometer defined such that: hectogram per cubic millimeter = dag/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicMicrometer = new("dekagram per cubic micrometer"
                                                                 , "dag/μm³"
                                                                 , HectogramPerCubicMillimeter
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic decimeter defined such that: decigram per cubic meter = cg/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicDecimeter = new("centigram per cubic decimeter"
                                                                 , "cg/dm³"
                                                                 , DecigramPerCubicMeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic meter defined such that: microgram per cubic meter = ng/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicMeter =
      new("nanogram per cubic meter", "ng/m³", MicrogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic gigameter defined such that: kilogram per cubic megameter = kg/Gm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicGigameter =
      new("kilogram per cubic gigameter", "kg/Gm³", KilogramPerCubicMegameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic terameter defined such that: kilogram per cubic gigameter = kg/Tm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicTerameter =
      new("kilogram per cubic terameter", "kg/Tm³", KilogramPerCubicGigameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic attometer defined such that: kilogram per cubic femtometer = hg/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicAttometer = new("hectogram per cubic attometer"
                                                                 , "hg/am³"
                                                                 , KilogramPerCubicFemtometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic millimeter defined such that: dekagram per cubic centimeter = g/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GramPerCubicMillimeter = new("gram per cubic millimeter"
                                                             , "g/mm³"
                                                             , DekagramPerCubicCentimeter
                                                             , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// decigram per cubic centimeter defined such that: gram per cubic decimeter = dg/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicCentimeter = new("decigram per cubic centimeter"
                                                                 , "dg/cm³"
                                                                 , GramPerCubicDecimeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic meter defined such that: nanogram per cubic meter = pg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicMeter =
      new("picogram per cubic meter", "pg/m³", NanogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic petameter defined such that: kilogram per cubic terameter = kg/Pm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicPetameter =
      new("kilogram per cubic petameter", "kg/Pm³", KilogramPerCubicTerameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic nanometer defined such that: hectogram per cubic micrometer = dag/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicNanometer = new("dekagram per cubic nanometer"
                                                                , "dag/nm³"
                                                                , HectogramPerCubicMicrometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// milligram per cubic decimeter defined such that: centigram per cubic meter = mg/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicDecimeter = new("milligram per cubic decimeter"
                                                                 , "mg/dm³"
                                                                 , CentigramPerCubicMeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilogram per cubic exameter defined such that: kilogram per cubic petameter = kg/Em³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicExameter =
      new("kilogram per cubic exameter", "kg/Em³", KilogramPerCubicPetameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic zeptometer defined such that: kilogram per cubic attometer = hg/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicZeptometer = new("hectogram per cubic zeptometer"
                                                                  , "hg/zm³"
                                                                  , KilogramPerCubicAttometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic meter defined such that: picogram per cubic meter = fg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicMeter =
      new("femtogram per cubic meter", "fg/m³", PicogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic zettameter defined such that: kilogram per cubic exameter = kg/Zm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicZettameter =
      new("kilogram per cubic zettameter", "kg/Zm³", KilogramPerCubicExameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic yottameter defined such that: kilogram per cubic zettameter = kg/Ym³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicYottameter =
      new("kilogram per cubic yottameter", "kg/Ym³", KilogramPerCubicZettameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic yoctometer defined such that: kilogram per cubic zeptometer = hg/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicYoctometer = new("hectogram per cubic yoctometer"
                                                                  , "hg/ym³"
                                                                  , KilogramPerCubicZeptometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekagram per cubic picometer defined such that: hectogram per cubic nanometer = dag/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicPicometer = new("dekagram per cubic picometer"
                                                                , "dag/pm³"
                                                                , HectogramPerCubicNanometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// gram per cubic micrometer defined such that: dekagram per cubic millimeter = g/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicMicrometer = new("gram per cubic micrometer"
                                                             , "g/μm³"
                                                             , DekagramPerCubicMillimeter
                                                             , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// centigram per cubic centimeter defined such that: decigram per cubic decimeter = cg/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicCentimeter = new("centigram per cubic centimeter"
                                                                  , "cg/cm³"
                                                                  , DecigramPerCubicDecimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microgram per cubic decimeter defined such that: milligram per cubic meter = μg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicDecimeter = new("microgram per cubic decimeter"
                                                                 , "μg/dm³"
                                                                 , MilligramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic meter defined such that: femtogram per cubic meter = ag/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicMeter =
      new("attogram per cubic meter", "ag/m³", FemtogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilogram per cubic ronnameter defined such that: kilogram per cubic yottameter = kg/Rm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicRonnameter =
      new("kilogram per cubic ronnameter", "kg/Rm³", KilogramPerCubicYottameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic millimeter defined such that: gram per cubic centimeter = dg/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicMillimeter = new("decigram per cubic millimeter"
                                                                 , "dg/mm³"
                                                                 , GramPerCubicCentimeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilogram per cubic quettameter defined such that: kilogram per cubic ronnameter = kg/Qm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilogramPerCubicQuettameter =
      new("kilogram per cubic quettameter", "kg/Qm³", KilogramPerCubicRonnameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic rontometer defined such that: kilogram per cubic yoctometer = hg/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicRontometer = new("hectogram per cubic rontometer"
                                                                  , "hg/rm³"
                                                                  , KilogramPerCubicYoctometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic meter defined such that: attogram per cubic meter = zg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicMeter =
      new("zeptogram per cubic meter", "zg/m³", AttogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic femtometer defined such that: hectogram per cubic picometer = dag/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicFemtometer = new("dekagram per cubic femtometer"
                                                                 , "dag/fm³"
                                                                 , HectogramPerCubicPicometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic decimeter defined such that: microgram per cubic meter = ng/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicDecimeter = new("nanogram per cubic decimeter"
                                                                , "ng/dm³"
                                                                , MicrogramPerCubicMeter
                                                                , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// hectogram per cubic quectometer defined such that: kilogram per cubic rontometer = hg/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicQuectometer = new("hectogram per cubic quectometer"
                                                                   , "hg/qm³"
                                                                   , KilogramPerCubicRontometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// gram per cubic nanometer defined such that: dekagram per cubic micrometer = g/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicNanometer = new("gram per cubic nanometer"
                                                            , "g/nm³"
                                                            , DekagramPerCubicMicrometer
                                                            , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                            , system: "SI"
                                                             );
   
   /// <summary>
   /// milligram per cubic centimeter defined such that: centigram per cubic decimeter = mg/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicCentimeter = new("milligram per cubic centimeter"
                                                                  , "mg/cm³"
                                                                  , CentigramPerCubicDecimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic meter defined such that: zeptogram per cubic meter = yg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicMeter =
      new("yoctogram per cubic meter", "yg/m³", ZeptogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic dekameter defined such that: kilogram per cubic meter = hg/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicDekameter =
      new("hectogram per cubic dekameter", "hg/dam³", KilogramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic attometer defined such that: hectogram per cubic femtometer = dag/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicAttometer = new("dekagram per cubic attometer"
                                                                , "dag/am³"
                                                                , HectogramPerCubicFemtometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// decigram per cubic micrometer defined such that: gram per cubic millimeter = dg/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicMicrometer = new("decigram per cubic micrometer"
                                                                 , "dg/μm³"
                                                                 , GramPerCubicMillimeter
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic millimeter defined such that: decigram per cubic centimeter = cg/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicMillimeter = new("centigram per cubic millimeter"
                                                                  , "cg/mm³"
                                                                  , DecigramPerCubicCentimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picogram per cubic decimeter defined such that: nanogram per cubic meter = pg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicDecimeter = new("picogram per cubic decimeter"
                                                                , "pg/dm³"
                                                                , NanogramPerCubicMeter
                                                                , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// rontogram per cubic meter defined such that: yoctogram per cubic meter = rg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicMeter =
      new("rontogram per cubic meter", "rg/m³", YoctogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic hectometer defined such that: kilogram per cubic dekameter = hg/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicHectometer =
      new("hectogram per cubic hectometer", "hg/hm³", KilogramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// gram per cubic picometer defined such that: dekagram per cubic nanometer = g/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicPicometer = new("gram per cubic picometer"
                                                            , "g/pm³"
                                                            , DekagramPerCubicNanometer
                                                            , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                            , system: "SI"
                                                             );
   
   /// <summary>
   /// microgram per cubic centimeter defined such that: milligram per cubic decimeter = μg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicCentimeter = new("microgram per cubic centimeter"
                                                                  , "μg/cm³"
                                                                  , MilligramPerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectogram per cubic meter defined such that: rontogram per cubic meter = qg/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicMeter =
      new("quectogram per cubic meter", "qg/m³", RontogramPerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic zeptometer defined such that: hectogram per cubic attometer = dag/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicZeptometer = new("dekagram per cubic zeptometer"
                                                                 , "dag/zm³"
                                                                 , HectogramPerCubicAttometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic decimeter defined such that: picogram per cubic meter = fg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicDecimeter = new("femtogram per cubic decimeter"
                                                                 , "fg/dm³"
                                                                 , PicogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// megagram per cubic meter defined such that: kilogram per cubic meter = Mg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicMeter = new("megagram per cubic meter", "Mg/m³", KilogramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic kilometer defined such that: kilogram per cubic hectometer = hg/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicKilometer =
      new("hectogram per cubic kilometer", "hg/km³", KilogramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic nanometer defined such that: gram per cubic micrometer = dg/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicNanometer = new("decigram per cubic nanometer"
                                                                , "dg/nm³"
                                                                , GramPerCubicMicrometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// milligram per cubic millimeter defined such that: centigram per cubic centimeter = mg/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicMillimeter = new("milligram per cubic millimeter"
                                                                  , "mg/mm³"
                                                                  , CentigramPerCubicCentimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic meter defined such that: megagram per cubic meter = Gg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicMeter = new("gigagram per cubic meter", "Gg/m³", MegagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic megameter defined such that: kilogram per cubic kilometer = hg/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicMegameter =
      new("hectogram per cubic megameter", "hg/Mm³", KilogramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic yoctometer defined such that: hectogram per cubic zeptometer = dag/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicYoctometer = new("dekagram per cubic yoctometer"
                                                                 , "dag/ym³"
                                                                 , HectogramPerCubicZeptometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic femtometer defined such that: dekagram per cubic picometer = g/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicFemtometer = new("gram per cubic femtometer"
                                                             , "g/fm³"
                                                             , DekagramPerCubicPicometer
                                                             , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// centigram per cubic micrometer defined such that: decigram per cubic millimeter = cg/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicMicrometer = new("centigram per cubic micrometer"
                                                                  , "cg/μm³"
                                                                  , DecigramPerCubicMillimeter
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanogram per cubic centimeter defined such that: microgram per cubic decimeter = ng/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicCentimeter = new("nanogram per cubic centimeter"
                                                                 , "ng/cm³"
                                                                 , MicrogramPerCubicDecimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic decimeter defined such that: femtogram per cubic meter = ag/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicDecimeter = new("attogram per cubic decimeter"
                                                                , "ag/dm³"
                                                                , FemtogramPerCubicMeter
                                                                , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// teragram per cubic meter defined such that: gigagram per cubic meter = Tg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicMeter = new("teragram per cubic meter", "Tg/m³", GigagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic gigameter defined such that: kilogram per cubic megameter = hg/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicGigameter =
      new("hectogram per cubic gigameter", "hg/Gm³", KilogramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic rontometer defined such that: hectogram per cubic yoctometer = dag/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicRontometer = new("dekagram per cubic rontometer"
                                                                 , "dag/rm³"
                                                                 , HectogramPerCubicYoctometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic decimeter defined such that: attogram per cubic meter = zg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicDecimeter = new("zeptogram per cubic decimeter"
                                                                 , "zg/dm³"
                                                                 , AttogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// petagram per cubic meter defined such that: teragram per cubic meter = Pg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicMeter = new("petagram per cubic meter", "Pg/m³", TeragramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic terameter defined such that: kilogram per cubic gigameter = hg/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicTerameter =
      new("hectogram per cubic terameter", "hg/Tm³", KilogramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gram per cubic attometer defined such that: dekagram per cubic femtometer = g/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicAttometer = new("gram per cubic attometer"
                                                            , "g/am³"
                                                            , DekagramPerCubicFemtometer
                                                            , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                            , system: "SI"
                                                             );
   
   /// <summary>
   /// decigram per cubic picometer defined such that: gram per cubic nanometer = dg/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicPicometer = new("decigram per cubic picometer"
                                                                , "dg/pm³"
                                                                , GramPerCubicNanometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// microgram per cubic millimeter defined such that: milligram per cubic centimeter = μg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicMillimeter = new("microgram per cubic millimeter"
                                                                  , "μg/mm³"
                                                                  , MilligramPerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picogram per cubic centimeter defined such that: nanogram per cubic decimeter = pg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicCentimeter = new("picogram per cubic centimeter"
                                                                 , "pg/cm³"
                                                                 , NanogramPerCubicDecimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic meter defined such that: petagram per cubic meter = Eg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicMeter = new("exagram per cubic meter", "Eg/m³", PetagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic petameter defined such that: kilogram per cubic terameter = hg/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicPetameter =
      new("hectogram per cubic petameter", "hg/Pm³", KilogramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic quectometer defined such that: hectogram per cubic rontometer = dag/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicQuectometer = new("dekagram per cubic quectometer"
                                                                  , "dag/qm³"
                                                                  , HectogramPerCubicRontometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centigram per cubic nanometer defined such that: decigram per cubic micrometer = cg/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicNanometer = new("centigram per cubic nanometer"
                                                                 , "cg/nm³"
                                                                 , DecigramPerCubicMicrometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// milligram per cubic micrometer defined such that: centigram per cubic millimeter = mg/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicMicrometer = new("milligram per cubic micrometer"
                                                                  , "mg/μm³"
                                                                  , CentigramPerCubicMillimeter
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic decimeter defined such that: zeptogram per cubic meter = yg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicDecimeter = new("yoctogram per cubic decimeter"
                                                                 , "yg/dm³"
                                                                 , ZeptogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zettagram per cubic meter defined such that: exagram per cubic meter = Zg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicMeter = new("zettagram per cubic meter", "Zg/m³", ExagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic exameter defined such that: kilogram per cubic petameter = hg/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicExameter =
      new("hectogram per cubic exameter", "hg/Em³", KilogramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gram per cubic zeptometer defined such that: dekagram per cubic attometer = g/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicZeptometer = new("gram per cubic zeptometer"
                                                             , "g/zm³"
                                                             , DekagramPerCubicAttometer
                                                             , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// femtogram per cubic centimeter defined such that: picogram per cubic decimeter = fg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicCentimeter = new("femtogram per cubic centimeter"
                                                                  , "fg/cm³"
                                                                  , PicogramPerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekagram per cubic dekameter defined such that: hectogram per cubic meter = dag/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicDekameter =
      new("dekagram per cubic dekameter", "dag/dam³", HectogramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic femtometer defined such that: gram per cubic picometer = dg/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicFemtometer = new("decigram per cubic femtometer"
                                                                 , "dg/fm³"
                                                                 , GramPerCubicPicometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic millimeter defined such that: microgram per cubic centimeter = ng/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicMillimeter = new("nanogram per cubic millimeter"
                                                                 , "ng/mm³"
                                                                 , MicrogramPerCubicCentimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontogram per cubic decimeter defined such that: yoctogram per cubic meter = rg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicDecimeter = new("rontogram per cubic decimeter"
                                                                 , "rg/dm³"
                                                                 , YoctogramPerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yottagram per cubic meter defined such that: zettagram per cubic meter = Yg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicMeter =
      new("yottagram per cubic meter", "Yg/m³", ZettagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic zettameter defined such that: kilogram per cubic exameter = hg/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicZettameter =
      new("hectogram per cubic zettameter", "hg/Zm³", KilogramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic meter defined such that: yottagram per cubic meter = Rg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicMeter =
      new("ronnagram per cubic meter", "Rg/m³", YottagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic yottameter defined such that: kilogram per cubic zettameter = hg/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicYottameter =
      new("hectogram per cubic yottameter", "hg/Ym³", KilogramPerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekagram per cubic hectometer defined such that: hectogram per cubic dekameter = dag/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicHectometer =
      new("dekagram per cubic hectometer", "dag/hm³", HectogramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// gram per cubic yoctometer defined such that: dekagram per cubic zeptometer = g/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicYoctometer = new("gram per cubic yoctometer"
                                                             , "g/ym³"
                                                             , DekagramPerCubicZeptometer
                                                             , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// centigram per cubic picometer defined such that: decigram per cubic nanometer = cg/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicPicometer = new("centigram per cubic picometer"
                                                                 , "cg/pm³"
                                                                 , DecigramPerCubicNanometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// microgram per cubic micrometer defined such that: milligram per cubic millimeter = μg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicMicrometer = new("microgram per cubic micrometer"
                                                                  , "μg/μm³"
                                                                  , MilligramPerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic centimeter defined such that: femtogram per cubic decimeter = ag/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicCentimeter = new("attogram per cubic centimeter"
                                                                 , "ag/cm³"
                                                                 , FemtogramPerCubicDecimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectogram per cubic decimeter defined such that: rontogram per cubic meter = qg/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicDecimeter = new("quectogram per cubic decimeter"
                                                                  , "qg/dm³"
                                                                  , RontogramPerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// milligram per cubic nanometer defined such that: centigram per cubic micrometer = mg/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicNanometer = new("milligram per cubic nanometer"
                                                                 , "mg/nm³"
                                                                 , CentigramPerCubicMicrometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quettagram per cubic meter defined such that: ronnagram per cubic meter = Qg/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicMeter =
      new("quettagram per cubic meter", "Qg/m³", RonnagramPerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic ronnameter defined such that: kilogram per cubic yottameter = hg/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicRonnameter =
      new("hectogram per cubic ronnameter", "hg/Rm³", KilogramPerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic attometer defined such that: gram per cubic femtometer = dg/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicAttometer = new("decigram per cubic attometer"
                                                                , "dg/am³"
                                                                , GramPerCubicFemtometer
                                                                , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picogram per cubic millimeter defined such that: nanogram per cubic centimeter = pg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicMillimeter = new("picogram per cubic millimeter"
                                                                 , "pg/mm³"
                                                                 , NanogramPerCubicCentimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// megagram per cubic decimeter defined such that: kilogram per cubic meter = Mg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicDecimeter = new("megagram per cubic decimeter"
                                                                , "Mg/dm³"
                                                                , KilogramPerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// dekagram per cubic kilometer defined such that: hectogram per cubic hectometer = dag/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicKilometer =
      new("dekagram per cubic kilometer", "dag/km³", HectogramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectogram per cubic quettameter defined such that: kilogram per cubic ronnameter = hg/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectogramPerCubicQuettameter =
      new("hectogram per cubic quettameter", "hg/Qm³", KilogramPerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gram per cubic rontometer defined such that: dekagram per cubic yoctometer = g/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicRontometer = new("gram per cubic rontometer"
                                                             , "g/rm³"
                                                             , DekagramPerCubicYoctometer
                                                             , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// zeptogram per cubic centimeter defined such that: attogram per cubic decimeter = zg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicCentimeter = new("zeptogram per cubic centimeter"
                                                                  , "zg/cm³"
                                                                  , AttogramPerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic decimeter defined such that: megagram per cubic meter = Gg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicDecimeter = new("gigagram per cubic decimeter"
                                                                , "Gg/dm³"
                                                                , MegagramPerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// dekagram per cubic megameter defined such that: hectogram per cubic kilometer = dag/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicMegameter =
      new("dekagram per cubic megameter", "dag/Mm³", HectogramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic femtometer defined such that: decigram per cubic picometer = cg/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicFemtometer = new("centigram per cubic femtometer"
                                                                  , "cg/fm³"
                                                                  , DecigramPerCubicPicometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanogram per cubic micrometer defined such that: microgram per cubic millimeter = ng/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicMicrometer = new("nanogram per cubic micrometer"
                                                                 , "ng/μm³"
                                                                 , MicrogramPerCubicMillimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic zeptometer defined such that: gram per cubic attometer = dg/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicZeptometer = new("decigram per cubic zeptometer"
                                                                 , "dg/zm³"
                                                                 , GramPerCubicAttometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic millimeter defined such that: picogram per cubic centimeter = fg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicMillimeter = new("femtogram per cubic millimeter"
                                                                  , "fg/mm³"
                                                                  , PicogramPerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gram per cubic quectometer defined such that: dekagram per cubic rontometer = g/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicQuectometer = new("gram per cubic quectometer"
                                                              , "g/qm³"
                                                              , DekagramPerCubicRontometer
                                                              , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// milligram per cubic picometer defined such that: centigram per cubic nanometer = mg/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicPicometer = new("milligram per cubic picometer"
                                                                 , "mg/pm³"
                                                                 , CentigramPerCubicNanometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// microgram per cubic nanometer defined such that: milligram per cubic micrometer = μg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicNanometer = new("microgram per cubic nanometer"
                                                                 , "μg/nm³"
                                                                 , MilligramPerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yoctogram per cubic centimeter defined such that: zeptogram per cubic decimeter = yg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicCentimeter = new("yoctogram per cubic centimeter"
                                                                  , "yg/cm³"
                                                                  , ZeptogramPerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teragram per cubic decimeter defined such that: gigagram per cubic meter = Tg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicDecimeter = new("teragram per cubic decimeter"
                                                                , "Tg/dm³"
                                                                , GigagramPerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// dekagram per cubic gigameter defined such that: hectogram per cubic megameter = dag/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicGigameter =
      new("dekagram per cubic gigameter", "dag/Gm³", HectogramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic decimeter defined such that: teragram per cubic meter = Pg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicDecimeter = new("petagram per cubic decimeter"
                                                                , "Pg/dm³"
                                                                , TeragramPerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// dekagram per cubic terameter defined such that: hectogram per cubic gigameter = dag/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicTerameter =
      new("dekagram per cubic terameter", "dag/Tm³", HectogramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gram per cubic dekameter defined such that: dekagram per cubic meter = g/dam³ × (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GramPerCubicDekameter =
      new("gram per cubic dekameter", "g/dam³", DekagramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic yoctometer defined such that: gram per cubic zeptometer = dg/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicYoctometer = new("decigram per cubic yoctometer"
                                                                 , "dg/ym³"
                                                                 , GramPerCubicZeptometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic attometer defined such that: decigram per cubic femtometer = cg/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicAttometer = new("centigram per cubic attometer"
                                                                 , "cg/am³"
                                                                 , DecigramPerCubicFemtometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic micrometer defined such that: nanogram per cubic millimeter = pg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicMicrometer = new("picogram per cubic micrometer"
                                                                 , "pg/μm³"
                                                                 , NanogramPerCubicMillimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic millimeter defined such that: femtogram per cubic centimeter = ag/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicMillimeter = new("attogram per cubic millimeter"
                                                                 , "ag/mm³"
                                                                 , FemtogramPerCubicCentimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontogram per cubic centimeter defined such that: yoctogram per cubic decimeter = rg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicCentimeter = new("rontogram per cubic centimeter"
                                                                  , "rg/cm³"
                                                                  , YoctogramPerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exagram per cubic decimeter defined such that: petagram per cubic meter = Eg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicDecimeter = new("exagram per cubic decimeter"
                                                               , "Eg/dm³"
                                                               , PetagramPerCubicMeter
                                                               , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                               , system: "SI"
                                                                );
   
   /// <summary>
   /// dekagram per cubic petameter defined such that: hectogram per cubic terameter = dag/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicPetameter =
      new("dekagram per cubic petameter", "dag/Pm³", HectogramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// milligram per cubic femtometer defined such that: centigram per cubic picometer = mg/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicFemtometer = new("milligram per cubic femtometer"
                                                                  , "mg/fm³"
                                                                  , CentigramPerCubicPicometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanogram per cubic nanometer defined such that: microgram per cubic micrometer = ng/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicNanometer = new("nanogram per cubic nanometer"
                                                                , "ng/nm³"
                                                                , MicrogramPerCubicMicrometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// gram per cubic hectometer defined such that: dekagram per cubic dekameter = g/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GramPerCubicHectometer =
      new("gram per cubic hectometer", "g/hm³", DekagramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic picometer defined such that: milligram per cubic nanometer = μg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicPicometer = new("microgram per cubic picometer"
                                                                 , "μg/pm³"
                                                                 , MilligramPerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectogram per cubic centimeter defined such that: rontogram per cubic decimeter = qg/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicCentimeter = new("quectogram per cubic centimeter"
                                                                   , "qg/cm³"
                                                                   , RontogramPerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// decigram per cubic rontometer defined such that: gram per cubic yoctometer = dg/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicRontometer = new("decigram per cubic rontometer"
                                                                 , "dg/rm³"
                                                                 , GramPerCubicYoctometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic millimeter defined such that: attogram per cubic centimeter = zg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicMillimeter = new("zeptogram per cubic millimeter"
                                                                  , "zg/mm³"
                                                                  , AttogramPerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettagram per cubic decimeter defined such that: exagram per cubic meter = Zg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicDecimeter = new("zettagram per cubic decimeter"
                                                                 , "Zg/dm³"
                                                                 , ExagramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic exameter defined such that: hectogram per cubic petameter = dag/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicExameter =
      new("dekagram per cubic exameter", "dag/Em³", HectogramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic zeptometer defined such that: decigram per cubic attometer = cg/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicZeptometer = new("centigram per cubic zeptometer"
                                                                  , "cg/zm³"
                                                                  , DecigramPerCubicAttometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic micrometer defined such that: picogram per cubic millimeter = fg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicMicrometer = new("femtogram per cubic micrometer"
                                                                  , "fg/μm³"
                                                                  , PicogramPerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic centimeter defined such that: kilogram per cubic decimeter = Mg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicCentimeter = new("megagram per cubic centimeter"
                                                                 , "Mg/cm³"
                                                                 , KilogramPerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic kilometer defined such that: dekagram per cubic hectometer = g/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GramPerCubicKilometer =
      new("gram per cubic kilometer", "g/km³", DekagramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic decimeter defined such that: zettagram per cubic meter = Yg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicDecimeter = new("yottagram per cubic decimeter"
                                                                 , "Yg/dm³"
                                                                 , ZettagramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic zettameter defined such that: hectogram per cubic exameter = dag/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicZettameter =
      new("dekagram per cubic zettameter", "dag/Zm³", HectogramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic quectometer defined such that: gram per cubic rontometer = dg/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicQuectometer = new("decigram per cubic quectometer"
                                                                  , "dg/qm³"
                                                                  , GramPerCubicRontometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// milligram per cubic attometer defined such that: centigram per cubic femtometer = mg/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicAttometer = new("milligram per cubic attometer"
                                                                 , "mg/am³"
                                                                 , CentigramPerCubicFemtometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic nanometer defined such that: nanogram per cubic micrometer = pg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicNanometer = new("picogram per cubic nanometer"
                                                                , "pg/nm³"
                                                                , NanogramPerCubicMicrometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctogram per cubic millimeter defined such that: zeptogram per cubic centimeter = yg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicMillimeter = new("yoctogram per cubic millimeter"
                                                                  , "yg/mm³"
                                                                  , ZeptogramPerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnagram per cubic decimeter defined such that: yottagram per cubic meter = Rg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicDecimeter = new("ronnagram per cubic decimeter"
                                                                 , "Rg/dm³"
                                                                 , YottagramPerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigagram per cubic centimeter defined such that: megagram per cubic decimeter = Gg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicCentimeter = new("gigagram per cubic centimeter"
                                                                 , "Gg/cm³"
                                                                 , MegagramPerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic yottameter defined such that: hectogram per cubic zettameter = dag/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicYottameter = new("dekagram per cubic yottameter"
                                                                 , "dag/Ym³"
                                                                 , HectogramPerCubicZettameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic megameter defined such that: dekagram per cubic kilometer = g/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicMegameter =
      new("gram per cubic megameter", "g/Mm³", DekagramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic yoctometer defined such that: decigram per cubic zeptometer = cg/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicYoctometer = new("centigram per cubic yoctometer"
                                                                  , "cg/ym³"
                                                                  , DecigramPerCubicZeptometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microgram per cubic femtometer defined such that: milligram per cubic picometer = μg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicFemtometer = new("microgram per cubic femtometer"
                                                                  , "μg/fm³"
                                                                  , MilligramPerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanogram per cubic picometer defined such that: microgram per cubic nanometer = ng/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicPicometer = new("nanogram per cubic picometer"
                                                                , "ng/pm³"
                                                                , MicrogramPerCubicNanometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// attogram per cubic micrometer defined such that: femtogram per cubic millimeter = ag/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicMicrometer = new("attogram per cubic micrometer"
                                                                 , "ag/μm³"
                                                                 , FemtogramPerCubicMillimeter
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quettagram per cubic decimeter defined such that: ronnagram per cubic meter = Qg/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicDecimeter = new("quettagram per cubic decimeter"
                                                                  , "Qg/dm³"
                                                                  , RonnagramPerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekagram per cubic ronnameter defined such that: hectogram per cubic yottameter = dag/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicRonnameter = new("dekagram per cubic ronnameter"
                                                                 , "dag/Rm³"
                                                                 , HectogramPerCubicYottameter
                                                                 , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic dekameter defined such that: gram per cubic meter = dg/dam³ × (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicDekameter =
      new("decigram per cubic dekameter", "dg/dam³", GramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic millimeter defined such that: yoctogram per cubic centimeter = rg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicMillimeter = new("rontogram per cubic millimeter"
                                                                  , "rg/mm³"
                                                                  , YoctogramPerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teragram per cubic centimeter defined such that: gigagram per cubic decimeter = Tg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicCentimeter = new("teragram per cubic centimeter"
                                                                 , "Tg/cm³"
                                                                 , GigagramPerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic gigameter defined such that: dekagram per cubic megameter = g/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicGigameter =
      new("gram per cubic gigameter", "g/Gm³", DekagramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// milligram per cubic zeptometer defined such that: centigram per cubic attometer = mg/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicZeptometer = new("milligram per cubic zeptometer"
                                                                  , "mg/zm³"
                                                                  , CentigramPerCubicAttometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic nanometer defined such that: picogram per cubic micrometer = fg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicNanometer = new("femtogram per cubic nanometer"
                                                                 , "fg/nm³"
                                                                 , PicogramPerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekagram per cubic quettameter defined such that: hectogram per cubic ronnameter = dag/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekagramPerCubicQuettameter = new("dekagram per cubic quettameter"
                                                                  , "dag/Qm³"
                                                                  , HectogramPerCubicRonnameter
                                                                  , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centigram per cubic rontometer defined such that: decigram per cubic yoctometer = cg/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicRontometer = new("centigram per cubic rontometer"
                                                                  , "cg/rm³"
                                                                  , DecigramPerCubicYoctometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic micrometer defined such that: attogram per cubic millimeter = zg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicMicrometer = new("zeptogram per cubic micrometer"
                                                                  , "zg/μm³"
                                                                  , AttogramPerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petagram per cubic centimeter defined such that: teragram per cubic decimeter = Pg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicCentimeter = new("petagram per cubic centimeter"
                                                                 , "Pg/cm³"
                                                                 , TeragramPerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic terameter defined such that: dekagram per cubic gigameter = g/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicTerameter =
      new("gram per cubic terameter", "g/Tm³", DekagramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic hectometer defined such that: gram per cubic dekameter = dg/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicHectometer =
      new("decigram per cubic hectometer", "dg/hm³", GramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic attometer defined such that: milligram per cubic femtometer = μg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicAttometer = new("microgram per cubic attometer"
                                                                 , "μg/am³"
                                                                 , MilligramPerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic picometer defined such that: nanogram per cubic nanometer = pg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicPicometer = new("picogram per cubic picometer"
                                                                , "pg/pm³"
                                                                , NanogramPerCubicNanometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// quectogram per cubic millimeter defined such that: rontogram per cubic centimeter = qg/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicMillimeter = new("quectogram per cubic millimeter"
                                                                   , "qg/mm³"
                                                                   , RontogramPerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanogram per cubic femtometer defined such that: microgram per cubic picometer = ng/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicFemtometer = new("nanogram per cubic femtometer"
                                                                 , "ng/fm³"
                                                                 , MicrogramPerCubicPicometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic centimeter defined such that: petagram per cubic decimeter = Eg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicCentimeter = new("exagram per cubic centimeter"
                                                                , "Eg/cm³"
                                                                , PetagramPerCubicDecimeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// gram per cubic petameter defined such that: dekagram per cubic terameter = g/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicPetameter =
      new("gram per cubic petameter", "g/Pm³", DekagramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic quectometer defined such that: decigram per cubic rontometer = cg/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicQuectometer = new("centigram per cubic quectometer"
                                                                   , "cg/qm³"
                                                                   , DecigramPerCubicRontometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// milligram per cubic yoctometer defined such that: centigram per cubic zeptometer = mg/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicYoctometer = new("milligram per cubic yoctometer"
                                                                  , "mg/ym³"
                                                                  , CentigramPerCubicZeptometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic nanometer defined such that: femtogram per cubic micrometer = ag/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicNanometer = new("attogram per cubic nanometer"
                                                                , "ag/nm³"
                                                                , FemtogramPerCubicMicrometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctogram per cubic micrometer defined such that: zeptogram per cubic millimeter = yg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicMicrometer = new("yoctogram per cubic micrometer"
                                                                  , "yg/μm³"
                                                                  , ZeptogramPerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic millimeter defined such that: kilogram per cubic centimeter = Mg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicMillimeter = new("megagram per cubic millimeter"
                                                                 , "Mg/mm³"
                                                                 , KilogramPerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic kilometer defined such that: gram per cubic hectometer = dg/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicKilometer =
      new("decigram per cubic kilometer", "dg/km³", GramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic centimeter defined such that: exagram per cubic decimeter = Zg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicCentimeter = new("zettagram per cubic centimeter"
                                                                  , "Zg/cm³"
                                                                  , ExagramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gram per cubic exameter defined such that: dekagram per cubic petameter = g/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicExameter =
      new("gram per cubic exameter", "g/Em³", DekagramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic zeptometer defined such that: milligram per cubic attometer = μg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicZeptometer = new("microgram per cubic zeptometer"
                                                                  , "μg/zm³"
                                                                  , MilligramPerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic picometer defined such that: picogram per cubic nanometer = fg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicPicometer = new("femtogram per cubic picometer"
                                                                 , "fg/pm³"
                                                                 , PicogramPerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigagram per cubic millimeter defined such that: megagram per cubic centimeter = Gg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicMillimeter = new("gigagram per cubic millimeter"
                                                                 , "Gg/mm³"
                                                                 , MegagramPerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic megameter defined such that: gram per cubic kilometer = dg/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicMegameter =
      new("decigram per cubic megameter", "dg/Mm³", GramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic dekameter defined such that: decigram per cubic meter = cg/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicDekameter =
      new("centigram per cubic dekameter", "cg/dam³", DecigramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// nanogram per cubic attometer defined such that: microgram per cubic femtometer = ng/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicAttometer = new("nanogram per cubic attometer"
                                                                , "ng/am³"
                                                                , MicrogramPerCubicFemtometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picogram per cubic femtometer defined such that: nanogram per cubic picometer = pg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicFemtometer = new("picogram per cubic femtometer"
                                                                 , "pg/fm³"
                                                                 , NanogramPerCubicPicometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontogram per cubic micrometer defined such that: yoctogram per cubic millimeter = rg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicMicrometer = new("rontogram per cubic micrometer"
                                                                  , "rg/μm³"
                                                                  , YoctogramPerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// milligram per cubic rontometer defined such that: centigram per cubic yoctometer = mg/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicRontometer = new("milligram per cubic rontometer"
                                                                  , "mg/rm³"
                                                                  , CentigramPerCubicYoctometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic nanometer defined such that: attogram per cubic micrometer = zg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicNanometer = new("zeptogram per cubic nanometer"
                                                                 , "zg/nm³"
                                                                 , AttogramPerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yottagram per cubic centimeter defined such that: zettagram per cubic decimeter = Yg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicCentimeter = new("yottagram per cubic centimeter"
                                                                  , "Yg/cm³"
                                                                  , ZettagramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gram per cubic zettameter defined such that: dekagram per cubic exameter = g/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicZettameter =
      new("gram per cubic zettameter", "g/Zm³", DekagramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic millimeter defined such that: gigagram per cubic centimeter = Tg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicMillimeter = new("teragram per cubic millimeter"
                                                                 , "Tg/mm³"
                                                                 , GigagramPerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic gigameter defined such that: gram per cubic megameter = dg/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicGigameter =
      new("decigram per cubic gigameter", "dg/Gm³", GramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic centimeter defined such that: yottagram per cubic decimeter = Rg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicCentimeter = new("ronnagram per cubic centimeter"
                                                                  , "Rg/cm³"
                                                                  , YottagramPerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gram per cubic yottameter defined such that: dekagram per cubic zettameter = g/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicYottameter =
      new("gram per cubic yottameter", "g/Ym³", DekagramPerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic hectometer defined such that: decigram per cubic dekameter = cg/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicHectometer =
      new("centigram per cubic hectometer", "cg/hm³", DecigramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic yoctometer defined such that: milligram per cubic zeptometer = μg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicYoctometer = new("microgram per cubic yoctometer"
                                                                  , "μg/ym³"
                                                                  , MilligramPerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic picometer defined such that: femtogram per cubic nanometer = ag/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicPicometer = new("attogram per cubic picometer"
                                                                , "ag/pm³"
                                                                , FemtogramPerCubicNanometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// quectogram per cubic micrometer defined such that: rontogram per cubic millimeter = qg/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicMicrometer = new("quectogram per cubic micrometer"
                                                                   , "qg/μm³"
                                                                   , RontogramPerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// milligram per cubic quectometer defined such that: centigram per cubic rontometer = mg/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicQuectometer = new("milligram per cubic quectometer"
                                                                   , "mg/qm³"
                                                                   , CentigramPerCubicRontometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic nanometer defined such that: zeptogram per cubic micrometer = yg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicNanometer = new("yoctogram per cubic nanometer"
                                                                 , "yg/nm³"
                                                                 , ZeptogramPerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic zeptometer defined such that: microgram per cubic attometer = ng/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicZeptometer = new("nanogram per cubic zeptometer"
                                                                 , "ng/zm³"
                                                                 , MicrogramPerCubicAttometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic femtometer defined such that: picogram per cubic picometer = fg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicFemtometer = new("femtogram per cubic femtometer"
                                                                  , "fg/fm³"
                                                                  , PicogramPerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quettagram per cubic centimeter defined such that: ronnagram per cubic decimeter = Qg/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicCentimeter = new("quettagram per cubic centimeter"
                                                                   , "Qg/cm³"
                                                                   , RonnagramPerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petagram per cubic millimeter defined such that: teragram per cubic centimeter = Pg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicMillimeter = new("petagram per cubic millimeter"
                                                                 , "Pg/mm³"
                                                                 , TeragramPerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gram per cubic ronnameter defined such that: dekagram per cubic yottameter = g/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicRonnameter =
      new("gram per cubic ronnameter", "g/Rm³", DekagramPerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decigram per cubic terameter defined such that: gram per cubic gigameter = dg/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicTerameter =
      new("decigram per cubic terameter", "dg/Tm³", GramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic attometer defined such that: nanogram per cubic femtometer = pg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicAttometer = new("picogram per cubic attometer"
                                                                , "pg/am³"
                                                                , NanogramPerCubicFemtometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// megagram per cubic micrometer defined such that: kilogram per cubic millimeter = Mg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicMicrometer = new("megagram per cubic micrometer"
                                                                 , "Mg/μm³"
                                                                 , KilogramPerCubicMillimeter
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic kilometer defined such that: decigram per cubic hectometer = cg/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicKilometer =
      new("centigram per cubic kilometer", "cg/km³", DecigramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// gram per cubic quettameter defined such that: dekagram per cubic ronnameter = g/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GramPerCubicQuettameter =
      new("gram per cubic quettameter", "g/Qm³", DekagramPerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic rontometer defined such that: milligram per cubic yoctometer = μg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicRontometer = new("microgram per cubic rontometer"
                                                                  , "μg/rm³"
                                                                  , MilligramPerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic picometer defined such that: attogram per cubic nanometer = zg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicPicometer = new("zeptogram per cubic picometer"
                                                                 , "zg/pm³"
                                                                 , AttogramPerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic millimeter defined such that: petagram per cubic centimeter = Eg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicMillimeter = new("exagram per cubic millimeter"
                                                                , "Eg/mm³"
                                                                , PetagramPerCubicCentimeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// decigram per cubic petameter defined such that: gram per cubic terameter = dg/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicPetameter =
      new("decigram per cubic petameter", "dg/Pm³", GramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// milligram per cubic dekameter defined such that: centigram per cubic meter = mg/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicDekameter =
      new("milligram per cubic dekameter", "mg/dam³", CentigramPerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic nanometer defined such that: yoctogram per cubic micrometer = rg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicNanometer = new("rontogram per cubic nanometer"
                                                                 , "rg/nm³"
                                                                 , YoctogramPerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigagram per cubic micrometer defined such that: megagram per cubic millimeter = Gg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicMicrometer = new("gigagram per cubic micrometer"
                                                                 , "Gg/μm³"
                                                                 , MegagramPerCubicMillimeter
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic megameter defined such that: decigram per cubic kilometer = cg/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicMegameter =
      new("centigram per cubic megameter", "cg/Mm³", DecigramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanogram per cubic yoctometer defined such that: microgram per cubic zeptometer = ng/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicYoctometer = new("nanogram per cubic yoctometer"
                                                                 , "ng/ym³"
                                                                 , MicrogramPerCubicZeptometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic femtometer defined such that: femtogram per cubic picometer = ag/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicFemtometer = new("attogram per cubic femtometer"
                                                                 , "ag/fm³"
                                                                 , FemtogramPerCubicPicometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zettagram per cubic millimeter defined such that: exagram per cubic centimeter = Zg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicMillimeter = new("zettagram per cubic millimeter"
                                                                  , "Zg/mm³"
                                                                  , ExagramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// decigram per cubic exameter defined such that: gram per cubic petameter = dg/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicExameter =
      new("decigram per cubic exameter", "dg/Em³", GramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic zeptometer defined such that: nanogram per cubic attometer = pg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicZeptometer = new("picogram per cubic zeptometer"
                                                                 , "pg/zm³"
                                                                 , NanogramPerCubicAttometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic attometer defined such that: picogram per cubic femtometer = fg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicAttometer = new("femtogram per cubic attometer"
                                                                 , "fg/am³"
                                                                 , PicogramPerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// milligram per cubic hectometer defined such that: centigram per cubic dekameter = mg/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicHectometer =
      new("milligram per cubic hectometer", "mg/hm³", CentigramPerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic quectometer defined such that: milligram per cubic rontometer = μg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicQuectometer = new("microgram per cubic quectometer"
                                                                   , "μg/qm³"
                                                                   , MilligramPerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic picometer defined such that: zeptogram per cubic nanometer = yg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicPicometer = new("yoctogram per cubic picometer"
                                                                 , "yg/pm³"
                                                                 , ZeptogramPerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectogram per cubic nanometer defined such that: rontogram per cubic micrometer = qg/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicNanometer = new("quectogram per cubic nanometer"
                                                                  , "qg/nm³"
                                                                  , RontogramPerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teragram per cubic micrometer defined such that: gigagram per cubic millimeter = Tg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicMicrometer = new("teragram per cubic micrometer"
                                                                 , "Tg/μm³"
                                                                 , GigagramPerCubicMillimeter
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centigram per cubic gigameter defined such that: decigram per cubic megameter = cg/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicGigameter =
      new("centigram per cubic gigameter", "cg/Gm³", DecigramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic millimeter defined such that: zettagram per cubic centimeter = Yg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicMillimeter = new("yottagram per cubic millimeter"
                                                                  , "Yg/mm³"
                                                                  , ZettagramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// decigram per cubic zettameter defined such that: gram per cubic exameter = dg/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicZettameter =
      new("decigram per cubic zettameter", "dg/Zm³", GramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanogram per cubic rontometer defined such that: microgram per cubic yoctometer = ng/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicRontometer = new("nanogram per cubic rontometer"
                                                                 , "ng/rm³"
                                                                 , MicrogramPerCubicYoctometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic femtometer defined such that: attogram per cubic picometer = zg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicFemtometer = new("zeptogram per cubic femtometer"
                                                                  , "zg/fm³"
                                                                  , AttogramPerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic nanometer defined such that: kilogram per cubic micrometer = Mg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicNanometer = new("megagram per cubic nanometer"
                                                                , "Mg/nm³"
                                                                , KilogramPerCubicMicrometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// milligram per cubic kilometer defined such that: centigram per cubic hectometer = mg/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicKilometer =
      new("milligram per cubic kilometer", "mg/km³", CentigramPerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic millimeter defined such that: yottagram per cubic centimeter = Rg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicMillimeter = new("ronnagram per cubic millimeter"
                                                                  , "Rg/mm³"
                                                                  , YottagramPerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petagram per cubic micrometer defined such that: teragram per cubic millimeter = Pg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicMicrometer = new("petagram per cubic micrometer"
                                                                 , "Pg/μm³"
                                                                 , TeragramPerCubicMillimeter
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decigram per cubic yottameter defined such that: gram per cubic zettameter = dg/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicYottameter =
      new("decigram per cubic yottameter", "dg/Ym³", GramPerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centigram per cubic terameter defined such that: decigram per cubic gigameter = cg/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicTerameter =
      new("centigram per cubic terameter", "cg/Tm³", DecigramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic dekameter defined such that: milligram per cubic meter = μg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicDekameter =
      new("microgram per cubic dekameter", "μg/dam³", MilligramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic yoctometer defined such that: nanogram per cubic zeptometer = pg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicYoctometer = new("picogram per cubic yoctometer"
                                                                 , "pg/ym³"
                                                                 , NanogramPerCubicZeptometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic attometer defined such that: femtogram per cubic femtometer = ag/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicAttometer = new("attogram per cubic attometer"
                                                                , "ag/am³"
                                                                , FemtogramPerCubicFemtometer
                                                                , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// rontogram per cubic picometer defined such that: yoctogram per cubic nanometer = rg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicPicometer = new("rontogram per cubic picometer"
                                                                 , "rg/pm³"
                                                                 , YoctogramPerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic zeptometer defined such that: picogram per cubic attometer = fg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicZeptometer = new("femtogram per cubic zeptometer"
                                                                  , "fg/zm³"
                                                                  , PicogramPerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quettagram per cubic millimeter defined such that: ronnagram per cubic centimeter = Qg/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicMillimeter = new("quettagram per cubic millimeter"
                                                                   , "Qg/mm³"
                                                                   , RonnagramPerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// decigram per cubic ronnameter defined such that: gram per cubic yottameter = dg/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicRonnameter =
      new("decigram per cubic ronnameter", "dg/Rm³", GramPerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic micrometer defined such that: petagram per cubic millimeter = Eg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicMicrometer = new("exagram per cubic micrometer"
                                                                , "Eg/μm³"
                                                                , PetagramPerCubicMillimeter
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// gigagram per cubic nanometer defined such that: megagram per cubic micrometer = Gg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicNanometer = new("gigagram per cubic nanometer"
                                                                , "Gg/nm³"
                                                                , MegagramPerCubicMicrometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// centigram per cubic petameter defined such that: decigram per cubic terameter = cg/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicPetameter =
      new("centigram per cubic petameter", "cg/Pm³", DecigramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// milligram per cubic megameter defined such that: centigram per cubic kilometer = mg/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicMegameter =
      new("milligram per cubic megameter", "mg/Mm³", CentigramPerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanogram per cubic quectometer defined such that: microgram per cubic rontometer = ng/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicQuectometer = new("nanogram per cubic quectometer"
                                                                  , "ng/qm³"
                                                                  , MicrogramPerCubicRontometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic femtometer defined such that: zeptogram per cubic picometer = yg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicFemtometer = new("yoctogram per cubic femtometer"
                                                                  , "yg/fm³"
                                                                  , ZeptogramPerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microgram per cubic hectometer defined such that: milligram per cubic dekameter = μg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicHectometer =
      new("microgram per cubic hectometer", "μg/hm³", MilligramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic picometer defined such that: rontogram per cubic nanometer = qg/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicPicometer = new("quectogram per cubic picometer"
                                                                  , "qg/pm³"
                                                                  , RontogramPerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// decigram per cubic quettameter defined such that: gram per cubic ronnameter = dg/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecigramPerCubicQuettameter =
      new("decigram per cubic quettameter", "dg/Qm³", GramPerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic rontometer defined such that: nanogram per cubic yoctometer = pg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicRontometer = new("picogram per cubic rontometer"
                                                                 , "pg/rm³"
                                                                 , NanogramPerCubicYoctometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic attometer defined such that: attogram per cubic femtometer = zg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicAttometer = new("zeptogram per cubic attometer"
                                                                 , "zg/am³"
                                                                 , AttogramPerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zettagram per cubic micrometer defined such that: exagram per cubic millimeter = Zg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicMicrometer = new("zettagram per cubic micrometer"
                                                                  , "Zg/μm³"
                                                                  , ExagramPerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centigram per cubic exameter defined such that: decigram per cubic petameter = cg/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicExameter =
      new("centigram per cubic exameter", "cg/Em³", DecigramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// femtogram per cubic yoctometer defined such that: picogram per cubic zeptometer = fg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicYoctometer = new("femtogram per cubic yoctometer"
                                                                  , "fg/ym³"
                                                                  , PicogramPerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic zeptometer defined such that: femtogram per cubic attometer = ag/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicZeptometer = new("attogram per cubic zeptometer"
                                                                 , "ag/zm³"
                                                                 , FemtogramPerCubicAttometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teragram per cubic nanometer defined such that: gigagram per cubic micrometer = Tg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicNanometer = new("teragram per cubic nanometer"
                                                                , "Tg/nm³"
                                                                , GigagramPerCubicMicrometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// milligram per cubic gigameter defined such that: centigram per cubic megameter = mg/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicGigameter =
      new("milligram per cubic gigameter", "mg/Gm³", CentigramPerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanogram per cubic dekameter defined such that: microgram per cubic meter = ng/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicDekameter =
      new("nanogram per cubic dekameter", "ng/dam³", MicrogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic femtometer defined such that: yoctogram per cubic picometer = rg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicFemtometer = new("rontogram per cubic femtometer"
                                                                  , "rg/fm³"
                                                                  , YoctogramPerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic picometer defined such that: kilogram per cubic nanometer = Mg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicPicometer = new("megagram per cubic picometer"
                                                                , "Mg/pm³"
                                                                , KilogramPerCubicNanometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// microgram per cubic kilometer defined such that: milligram per cubic hectometer = μg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicKilometer =
      new("microgram per cubic kilometer", "μg/km³", MilligramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic micrometer defined such that: zettagram per cubic millimeter = Yg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicMicrometer = new("yottagram per cubic micrometer"
                                                                  , "Yg/μm³"
                                                                  , ZettagramPerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centigram per cubic zettameter defined such that: decigram per cubic exameter = cg/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicZettameter =
      new("centigram per cubic zettameter", "cg/Zm³", DecigramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic nanometer defined such that: teragram per cubic micrometer = Pg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicNanometer = new("petagram per cubic nanometer"
                                                                , "Pg/nm³"
                                                                , TeragramPerCubicMicrometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// milligram per cubic terameter defined such that: centigram per cubic gigameter = mg/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicTerameter =
      new("milligram per cubic terameter", "mg/Tm³", CentigramPerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic quectometer defined such that: nanogram per cubic rontometer = pg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicQuectometer = new("picogram per cubic quectometer"
                                                                  , "pg/qm³"
                                                                  , NanogramPerCubicRontometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic attometer defined such that: zeptogram per cubic femtometer = yg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicAttometer = new("yoctogram per cubic attometer"
                                                                 , "yg/am³"
                                                                 , ZeptogramPerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic rontometer defined such that: picogram per cubic yoctometer = fg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicRontometer = new("femtogram per cubic rontometer"
                                                                  , "fg/rm³"
                                                                  , PicogramPerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic zeptometer defined such that: attogram per cubic attometer = zg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicZeptometer = new("zeptogram per cubic zeptometer"
                                                                  , "zg/zm³"
                                                                  , AttogramPerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnagram per cubic micrometer defined such that: yottagram per cubic millimeter = Rg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicMicrometer = new("ronnagram per cubic micrometer"
                                                                  , "Rg/μm³"
                                                                  , YottagramPerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic picometer defined such that: megagram per cubic nanometer = Gg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicPicometer = new("gigagram per cubic picometer"
                                                                , "Gg/pm³"
                                                                , MegagramPerCubicNanometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// centigram per cubic yottameter defined such that: decigram per cubic zettameter = cg/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicYottameter =
      new("centigram per cubic yottameter", "cg/Ym³", DecigramPerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic megameter defined such that: milligram per cubic kilometer = μg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicMegameter = new("microgram per cubic megameter"
                                                                 , "μg/Mm³"
                                                                 , MilligramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic hectometer defined such that: microgram per cubic dekameter = ng/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicHectometer =
      new("nanogram per cubic hectometer", "ng/hm³", MicrogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// attogram per cubic yoctometer defined such that: femtogram per cubic zeptometer = ag/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicYoctometer = new("attogram per cubic yoctometer"
                                                                 , "ag/ym³"
                                                                 , FemtogramPerCubicZeptometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectogram per cubic femtometer defined such that: rontogram per cubic picometer = qg/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicFemtometer = new("quectogram per cubic femtometer"
                                                                   , "qg/fm³"
                                                                   , RontogramPerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exagram per cubic nanometer defined such that: petagram per cubic micrometer = Eg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicNanometer = new("exagram per cubic nanometer"
                                                               , "Eg/nm³"
                                                               , PetagramPerCubicMicrometer
                                                               , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                               , system: "SI"
                                                                );
   
   /// <summary>
   /// milligram per cubic petameter defined such that: centigram per cubic terameter = mg/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicPetameter =
      new("milligram per cubic petameter", "mg/Pm³", CentigramPerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic micrometer defined such that: ronnagram per cubic millimeter = Qg/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicMicrometer = new("quettagram per cubic micrometer"
                                                                   , "Qg/μm³"
                                                                   , RonnagramPerCubicMillimeter
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// centigram per cubic ronnameter defined such that: decigram per cubic yottameter = cg/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicRonnameter =
      new("centigram per cubic ronnameter", "cg/Rm³", DecigramPerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picogram per cubic dekameter defined such that: nanogram per cubic meter = pg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicDekameter =
      new("picogram per cubic dekameter", "pg/dam³", NanogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic attometer defined such that: yoctogram per cubic femtometer = rg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicAttometer = new("rontogram per cubic attometer"
                                                                 , "rg/am³"
                                                                 , YoctogramPerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teragram per cubic picometer defined such that: gigagram per cubic nanometer = Tg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicPicometer = new("teragram per cubic picometer"
                                                                , "Tg/pm³"
                                                                , GigagramPerCubicNanometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// microgram per cubic gigameter defined such that: milligram per cubic megameter = μg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicGigameter = new("microgram per cubic gigameter"
                                                                 , "μg/Gm³"
                                                                 , MilligramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// megagram per cubic femtometer defined such that: kilogram per cubic picometer = Mg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicFemtometer = new("megagram per cubic femtometer"
                                                                 , "Mg/fm³"
                                                                 , KilogramPerCubicPicometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic kilometer defined such that: microgram per cubic hectometer = ng/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicKilometer =
      new("nanogram per cubic kilometer", "ng/km³", MicrogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic nanometer defined such that: exagram per cubic micrometer = Zg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicNanometer = new("zettagram per cubic nanometer"
                                                                 , "Zg/nm³"
                                                                 , ExagramPerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// milligram per cubic exameter defined such that: centigram per cubic petameter = mg/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicExameter =
      new("milligram per cubic exameter", "mg/Em³", CentigramPerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// femtogram per cubic quectometer defined such that: picogram per cubic rontometer = fg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicQuectometer = new("femtogram per cubic quectometer"
                                                                   , "fg/qm³"
                                                                   , PicogramPerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic zeptometer defined such that: zeptogram per cubic attometer = yg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicZeptometer = new("yoctogram per cubic zeptometer"
                                                                  , "yg/zm³"
                                                                  , ZeptogramPerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centigram per cubic quettameter defined such that: decigram per cubic ronnameter = cg/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentigramPerCubicQuettameter =
      new("centigram per cubic quettameter", "cg/Qm³", DecigramPerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// attogram per cubic rontometer defined such that: femtogram per cubic yoctometer = ag/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicRontometer = new("attogram per cubic rontometer"
                                                                 , "ag/rm³"
                                                                 , FemtogramPerCubicYoctometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic yoctometer defined such that: attogram per cubic zeptometer = zg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicYoctometer = new("zeptogram per cubic yoctometer"
                                                                  , "zg/ym³"
                                                                  , AttogramPerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petagram per cubic picometer defined such that: teragram per cubic nanometer = Pg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicPicometer = new("petagram per cubic picometer"
                                                                , "Pg/pm³"
                                                                , TeragramPerCubicNanometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// microgram per cubic terameter defined such that: milligram per cubic gigameter = μg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicTerameter = new("microgram per cubic terameter"
                                                                 , "μg/Tm³"
                                                                 , MilligramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic hectometer defined such that: nanogram per cubic dekameter = pg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicHectometer =
      new("picogram per cubic hectometer", "pg/hm³", NanogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic attometer defined such that: rontogram per cubic femtometer = qg/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicAttometer = new("quectogram per cubic attometer"
                                                                  , "qg/am³"
                                                                  , RontogramPerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottagram per cubic nanometer defined such that: zettagram per cubic micrometer = Yg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicNanometer = new("yottagram per cubic nanometer"
                                                                 , "Yg/nm³"
                                                                 , ZettagramPerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// milligram per cubic zettameter defined such that: centigram per cubic exameter = mg/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicZettameter =
      new("milligram per cubic zettameter", "mg/Zm³", CentigramPerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic femtometer defined such that: megagram per cubic picometer = Gg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicFemtometer = new("gigagram per cubic femtometer"
                                                                 , "Gg/fm³"
                                                                 , MegagramPerCubicPicometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic megameter defined such that: microgram per cubic kilometer = ng/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicMegameter = new("nanogram per cubic megameter"
                                                                , "ng/Mm³"
                                                                , MicrogramPerCubicKilometer
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// femtogram per cubic dekameter defined such that: picogram per cubic meter = fg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicDekameter =
      new("femtogram per cubic dekameter", "fg/dam³", PicogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic zeptometer defined such that: yoctogram per cubic attometer = rg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicZeptometer = new("rontogram per cubic zeptometer"
                                                                  , "rg/zm³"
                                                                  , YoctogramPerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnagram per cubic nanometer defined such that: yottagram per cubic micrometer = Rg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicNanometer = new("ronnagram per cubic nanometer"
                                                                 , "Rg/nm³"
                                                                 , YottagramPerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic picometer defined such that: petagram per cubic nanometer = Eg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicPicometer = new("exagram per cubic picometer"
                                                               , "Eg/pm³"
                                                               , PetagramPerCubicNanometer
                                                               , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                               , system: "SI"
                                                                );
   
   /// <summary>
   /// milligram per cubic yottameter defined such that: centigram per cubic zettameter = mg/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicYottameter =
      new("milligram per cubic yottameter", "mg/Ym³", CentigramPerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic petameter defined such that: milligram per cubic terameter = μg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicPetameter = new("microgram per cubic petameter"
                                                                 , "μg/Pm³"
                                                                 , MilligramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic quectometer defined such that: femtogram per cubic rontometer = ag/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicQuectometer = new("attogram per cubic quectometer"
                                                                  , "ag/qm³"
                                                                  , FemtogramPerCubicRontometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic yoctometer defined such that: zeptogram per cubic zeptometer = yg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicYoctometer = new("yoctogram per cubic yoctometer"
                                                                  , "yg/ym³"
                                                                  , ZeptogramPerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic rontometer defined such that: attogram per cubic yoctometer = zg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicRontometer = new("zeptogram per cubic rontometer"
                                                                  , "zg/rm³"
                                                                  , AttogramPerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic attometer defined such that: kilogram per cubic femtometer = Mg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicAttometer = new("megagram per cubic attometer"
                                                                , "Mg/am³"
                                                                , KilogramPerCubicFemtometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picogram per cubic kilometer defined such that: nanogram per cubic hectometer = pg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicKilometer =
      new("picogram per cubic kilometer", "pg/km³", NanogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic femtometer defined such that: gigagram per cubic picometer = Tg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicFemtometer = new("teragram per cubic femtometer"
                                                                 , "Tg/fm³"
                                                                 , GigagramPerCubicPicometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic gigameter defined such that: microgram per cubic megameter = ng/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicGigameter = new("nanogram per cubic gigameter"
                                                                , "ng/Gm³"
                                                                , MicrogramPerCubicMegameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// quettagram per cubic nanometer defined such that: ronnagram per cubic micrometer = Qg/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicNanometer = new("quettagram per cubic nanometer"
                                                                  , "Qg/nm³"
                                                                  , RonnagramPerCubicMicrometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// milligram per cubic ronnameter defined such that: centigram per cubic yottameter = mg/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicRonnameter =
      new("milligram per cubic ronnameter", "mg/Rm³", CentigramPerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic picometer defined such that: exagram per cubic nanometer = Zg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicPicometer = new("zettagram per cubic picometer"
                                                                 , "Zg/pm³"
                                                                 , ExagramPerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// microgram per cubic exameter defined such that: milligram per cubic petameter = μg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicExameter = new("microgram per cubic exameter"
                                                                , "μg/Em³"
                                                                , MilligramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// femtogram per cubic hectometer defined such that: picogram per cubic dekameter = fg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicHectometer =
      new("femtogram per cubic hectometer", "fg/hm³", PicogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic zeptometer defined such that: rontogram per cubic attometer = qg/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicZeptometer = new("quectogram per cubic zeptometer"
                                                                   , "qg/zm³"
                                                                   , RontogramPerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petagram per cubic femtometer defined such that: teragram per cubic picometer = Pg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicFemtometer = new("petagram per cubic femtometer"
                                                                 , "Pg/fm³"
                                                                 , TeragramPerCubicPicometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigagram per cubic attometer defined such that: megagram per cubic femtometer = Gg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicAttometer = new("gigagram per cubic attometer"
                                                                , "Gg/am³"
                                                                , MegagramPerCubicFemtometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// nanogram per cubic terameter defined such that: microgram per cubic gigameter = ng/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicTerameter = new("nanogram per cubic terameter"
                                                                , "ng/Tm³"
                                                                , MicrogramPerCubicGigameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picogram per cubic megameter defined such that: nanogram per cubic kilometer = pg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicMegameter =
      new("picogram per cubic megameter", "pg/Mm³", NanogramPerCubicKilometer, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// attogram per cubic dekameter defined such that: femtogram per cubic meter = ag/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicDekameter =
      new("attogram per cubic dekameter", "ag/dam³", FemtogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic yoctometer defined such that: yoctogram per cubic zeptometer = rg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicYoctometer = new("rontogram per cubic yoctometer"
                                                                  , "rg/ym³"
                                                                  , YoctogramPerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// milligram per cubic quettameter defined such that: centigram per cubic ronnameter = mg/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MilligramPerCubicQuettameter =
      new("milligram per cubic quettameter", "mg/Qm³", CentigramPerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zeptogram per cubic quectometer defined such that: attogram per cubic rontometer = zg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicQuectometer = new("zeptogram per cubic quectometer"
                                                                   , "zg/qm³"
                                                                   , AttogramPerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic rontometer defined such that: zeptogram per cubic yoctometer = yg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicRontometer = new("yoctogram per cubic rontometer"
                                                                  , "yg/rm³"
                                                                  , ZeptogramPerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottagram per cubic picometer defined such that: zettagram per cubic nanometer = Yg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicPicometer = new("yottagram per cubic picometer"
                                                                 , "Yg/pm³"
                                                                 , ZettagramPerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// microgram per cubic zettameter defined such that: milligram per cubic exameter = μg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicZettameter =
      new("microgram per cubic zettameter", "μg/Zm³", MilligramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic zeptometer defined such that: kilogram per cubic attometer = Mg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicZeptometer = new("megagram per cubic zeptometer"
                                                                 , "Mg/zm³"
                                                                 , KilogramPerCubicAttometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic kilometer defined such that: picogram per cubic hectometer = fg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicKilometer =
      new("femtogram per cubic kilometer", "fg/km³", PicogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic femtometer defined such that: petagram per cubic picometer = Eg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicFemtometer = new("exagram per cubic femtometer"
                                                                , "Eg/fm³"
                                                                , PetagramPerCubicPicometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// nanogram per cubic petameter defined such that: microgram per cubic terameter = ng/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicPetameter = new("nanogram per cubic petameter"
                                                                , "ng/Pm³"
                                                                , MicrogramPerCubicTerameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// teragram per cubic attometer defined such that: gigagram per cubic femtometer = Tg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicAttometer = new("teragram per cubic attometer"
                                                                , "Tg/am³"
                                                                , GigagramPerCubicFemtometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picogram per cubic gigameter defined such that: nanogram per cubic megameter = pg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicGigameter =
      new("picogram per cubic gigameter", "pg/Gm³", NanogramPerCubicMegameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic picometer defined such that: yottagram per cubic nanometer = Rg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicPicometer = new("ronnagram per cubic picometer"
                                                                 , "Rg/pm³"
                                                                 , YottagramPerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// microgram per cubic yottameter defined such that: milligram per cubic zettameter = μg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicYottameter = new("microgram per cubic yottameter"
                                                                  , "μg/Ym³"
                                                                  , MilligramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic hectometer defined such that: femtogram per cubic dekameter = ag/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicHectometer =
      new("attogram per cubic hectometer", "ag/hm³", FemtogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic yoctometer defined such that: rontogram per cubic zeptometer = qg/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicYoctometer = new("quectogram per cubic yoctometer"
                                                                   , "qg/ym³"
                                                                   , RontogramPerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptogram per cubic dekameter defined such that: attogram per cubic meter = zg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicDekameter =
      new("zeptogram per cubic dekameter", "zg/dam³", AttogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic rontometer defined such that: yoctogram per cubic yoctometer = rg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicRontometer = new("rontogram per cubic rontometer"
                                                                  , "rg/rm³"
                                                                  , YoctogramPerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic quectometer defined such that: zeptogram per cubic rontometer = yg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicQuectometer = new("yoctogram per cubic quectometer"
                                                                   , "yg/qm³"
                                                                   , ZeptogramPerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zettagram per cubic femtometer defined such that: exagram per cubic picometer = Zg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicFemtometer = new("zettagram per cubic femtometer"
                                                                  , "Zg/fm³"
                                                                  , ExagramPerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic zeptometer defined such that: megagram per cubic attometer = Gg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicZeptometer = new("gigagram per cubic zeptometer"
                                                                 , "Gg/zm³"
                                                                 , MegagramPerCubicAttometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic exameter defined such that: microgram per cubic petameter = ng/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicExameter =
      new("nanogram per cubic exameter", "ng/Em³", MicrogramPerCubicPetameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// femtogram per cubic megameter defined such that: picogram per cubic kilometer = fg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicMegameter =
      new("femtogram per cubic megameter", "fg/Mm³", PicogramPerCubicKilometer, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic picometer defined such that: ronnagram per cubic nanometer = Qg/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicPicometer = new("quettagram per cubic picometer"
                                                                  , "Qg/pm³"
                                                                  , RonnagramPerCubicNanometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petagram per cubic attometer defined such that: teragram per cubic femtometer = Pg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicAttometer = new("petagram per cubic attometer"
                                                                , "Pg/am³"
                                                                , TeragramPerCubicFemtometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// microgram per cubic ronnameter defined such that: milligram per cubic yottameter = μg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicRonnameter = new("microgram per cubic ronnameter"
                                                                  , "μg/Rm³"
                                                                  , MilligramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picogram per cubic terameter defined such that: nanogram per cubic gigameter = pg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicTerameter =
      new("picogram per cubic terameter", "pg/Tm³", NanogramPerCubicGigameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic yoctometer defined such that: kilogram per cubic zeptometer = Mg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicYoctometer = new("megagram per cubic yoctometer"
                                                                 , "Mg/ym³"
                                                                 , KilogramPerCubicZeptometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic kilometer defined such that: femtogram per cubic hectometer = ag/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicKilometer =
      new("attogram per cubic kilometer", "ag/km³", FemtogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic femtometer defined such that: zettagram per cubic picometer = Yg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicFemtometer = new("yottagram per cubic femtometer"
                                                                  , "Yg/fm³"
                                                                  , ZettagramPerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanogram per cubic zettameter defined such that: microgram per cubic exameter = ng/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicZettameter =
      new("nanogram per cubic zettameter", "ng/Zm³", MicrogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microgram per cubic quettameter defined such that: milligram per cubic ronnameter = μg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrogramPerCubicQuettameter = new("microgram per cubic quettameter"
                                                                   , "μg/Qm³"
                                                                   , MilligramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptogram per cubic hectometer defined such that: attogram per cubic dekameter = zg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicHectometer =
      new("zeptogram per cubic hectometer", "zg/hm³", AttogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic rontometer defined such that: rontogram per cubic yoctometer = qg/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicRontometer = new("quectogram per cubic rontometer"
                                                                   , "qg/rm³"
                                                                   , RontogramPerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// teragram per cubic zeptometer defined such that: gigagram per cubic attometer = Tg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicZeptometer = new("teragram per cubic zeptometer"
                                                                 , "Tg/zm³"
                                                                 , GigagramPerCubicAttometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtogram per cubic gigameter defined such that: picogram per cubic megameter = fg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicGigameter =
      new("femtogram per cubic gigameter", "fg/Gm³", PicogramPerCubicMegameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic attometer defined such that: petagram per cubic femtometer = Eg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicAttometer = new("exagram per cubic attometer"
                                                               , "Eg/am³"
                                                               , PetagramPerCubicFemtometer
                                                               , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                               , system: "SI"
                                                                );
   
   /// <summary>
   /// picogram per cubic petameter defined such that: nanogram per cubic terameter = pg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicPetameter =
      new("picogram per cubic petameter", "pg/Pm³", NanogramPerCubicTerameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yoctogram per cubic dekameter defined such that: zeptogram per cubic meter = yg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicDekameter =
      new("yoctogram per cubic dekameter", "yg/dam³", ZeptogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic quectometer defined such that: yoctogram per cubic rontometer = rg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicQuectometer = new("rontogram per cubic quectometer"
                                                                   , "rg/qm³"
                                                                   , YoctogramPerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// ronnagram per cubic femtometer defined such that: yottagram per cubic picometer = Rg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicFemtometer = new("ronnagram per cubic femtometer"
                                                                  , "Rg/fm³"
                                                                  , YottagramPerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic yoctometer defined such that: megagram per cubic zeptometer = Gg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicYoctometer = new("gigagram per cubic yoctometer"
                                                                 , "Gg/ym³"
                                                                 , MegagramPerCubicZeptometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic yottameter defined such that: microgram per cubic zettameter = ng/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicYottameter = new("nanogram per cubic yottameter"
                                                                 , "ng/Ym³"
                                                                 , MicrogramPerCubicZettameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic megameter defined such that: femtogram per cubic kilometer = ag/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicMegameter = new("attogram per cubic megameter"
                                                                , "ag/Mm³"
                                                                , FemtogramPerCubicKilometer
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// zettagram per cubic attometer defined such that: exagram per cubic femtometer = Zg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicAttometer = new("zettagram per cubic attometer"
                                                                 , "Zg/am³"
                                                                 , ExagramPerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// petagram per cubic zeptometer defined such that: teragram per cubic attometer = Pg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicZeptometer = new("petagram per cubic zeptometer"
                                                                 , "Pg/zm³"
                                                                 , TeragramPerCubicAttometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic exameter defined such that: nanogram per cubic petameter = pg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicExameter =
      new("picogram per cubic exameter", "pg/Em³", NanogramPerCubicPetameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// femtogram per cubic terameter defined such that: picogram per cubic gigameter = fg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicTerameter =
      new("femtogram per cubic terameter", "fg/Tm³", PicogramPerCubicGigameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic rontometer defined such that: kilogram per cubic yoctometer = Mg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicRontometer = new("megagram per cubic rontometer"
                                                                 , "Mg/rm³"
                                                                 , KilogramPerCubicYoctometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic kilometer defined such that: attogram per cubic hectometer = zg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicKilometer =
      new("zeptogram per cubic kilometer", "zg/km³", AttogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yoctogram per cubic hectometer defined such that: zeptogram per cubic dekameter = yg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicHectometer =
      new("yoctogram per cubic hectometer", "yg/hm³", ZeptogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic quectometer defined such that: rontogram per cubic rontometer = qg/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicQuectometer = new("quectogram per cubic quectometer"
                                                                    , "qg/qm³"
                                                                    , RontogramPerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quettagram per cubic femtometer defined such that: ronnagram per cubic picometer = Qg/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicFemtometer = new("quettagram per cubic femtometer"
                                                                   , "Qg/fm³"
                                                                   , RonnagramPerCubicPicometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanogram per cubic ronnameter defined such that: microgram per cubic yottameter = ng/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicRonnameter = new("nanogram per cubic ronnameter"
                                                                 , "ng/Rm³"
                                                                 , MicrogramPerCubicYottameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontogram per cubic dekameter defined such that: yoctogram per cubic meter = rg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicDekameter =
      new("rontogram per cubic dekameter", "rg/dam³", YoctogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic yoctometer defined such that: gigagram per cubic zeptometer = Tg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicYoctometer = new("teragram per cubic yoctometer"
                                                                 , "Tg/ym³"
                                                                 , GigagramPerCubicZeptometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic gigameter defined such that: femtogram per cubic megameter = ag/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicGigameter = new("attogram per cubic gigameter"
                                                                , "ag/Gm³"
                                                                , FemtogramPerCubicMegameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yottagram per cubic attometer defined such that: zettagram per cubic femtometer = Yg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicAttometer = new("yottagram per cubic attometer"
                                                                 , "Yg/am³"
                                                                 , ZettagramPerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic zettameter defined such that: nanogram per cubic exameter = pg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicZettameter =
      new("picogram per cubic zettameter", "pg/Zm³", NanogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic zeptometer defined such that: petagram per cubic attometer = Eg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicZeptometer = new("exagram per cubic zeptometer"
                                                                , "Eg/zm³"
                                                                , PetagramPerCubicAttometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// femtogram per cubic petameter defined such that: picogram per cubic terameter = fg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicPetameter =
      new("femtogram per cubic petameter", "fg/Pm³", PicogramPerCubicTerameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic rontometer defined such that: megagram per cubic yoctometer = Gg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicRontometer = new("gigagram per cubic rontometer"
                                                                 , "Gg/rm³"
                                                                 , MegagramPerCubicYoctometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// nanogram per cubic quettameter defined such that: microgram per cubic ronnameter = ng/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanogramPerCubicQuettameter = new("nanogram per cubic quettameter"
                                                                  , "ng/Qm³"
                                                                  , MicrogramPerCubicRonnameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic megameter defined such that: attogram per cubic kilometer = zg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicMegameter =
      new("zeptogram per cubic megameter", "zg/Mm³", AttogramPerCubicKilometer, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic quectometer defined such that: kilogram per cubic rontometer = Mg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicQuectometer = new("megagram per cubic quectometer"
                                                                  , "Mg/qm³"
                                                                  , KilogramPerCubicRontometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic kilometer defined such that: zeptogram per cubic hectometer = yg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicKilometer =
      new("yoctogram per cubic kilometer", "yg/km³", ZeptogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic attometer defined such that: yottagram per cubic femtometer = Rg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicAttometer = new("ronnagram per cubic attometer"
                                                                 , "Rg/am³"
                                                                 , YottagramPerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// petagram per cubic yoctometer defined such that: teragram per cubic zeptometer = Pg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicYoctometer = new("petagram per cubic yoctometer"
                                                                 , "Pg/ym³"
                                                                 , TeragramPerCubicZeptometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic yottameter defined such that: nanogram per cubic zettameter = pg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicYottameter = new("picogram per cubic yottameter"
                                                                 , "pg/Ym³"
                                                                 , NanogramPerCubicZettameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attogram per cubic terameter defined such that: femtogram per cubic gigameter = ag/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicTerameter = new("attogram per cubic terameter"
                                                                , "ag/Tm³"
                                                                , FemtogramPerCubicGigameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// rontogram per cubic hectometer defined such that: yoctogram per cubic dekameter = rg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicHectometer =
      new("rontogram per cubic hectometer", "rg/hm³", YoctogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic dekameter defined such that: rontogram per cubic meter = qg/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicDekameter =
      new("quectogram per cubic dekameter", "qg/dam³", RontogramPerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic zeptometer defined such that: exagram per cubic attometer = Zg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicZeptometer = new("zettagram per cubic zeptometer"
                                                                  , "Zg/zm³"
                                                                  , ExagramPerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic exameter defined such that: picogram per cubic petameter = fg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicExameter =
      new("femtogram per cubic exameter", "fg/Em³", PicogramPerCubicPetameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic rontometer defined such that: gigagram per cubic yoctometer = Tg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicRontometer = new("teragram per cubic rontometer"
                                                                 , "Tg/rm³"
                                                                 , GigagramPerCubicYoctometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptogram per cubic gigameter defined such that: attogram per cubic megameter = zg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicGigameter =
      new("zeptogram per cubic gigameter", "zg/Gm³", AttogramPerCubicMegameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic attometer defined such that: ronnagram per cubic femtometer = Qg/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicAttometer = new("quettagram per cubic attometer"
                                                                  , "Qg/am³"
                                                                  , RonnagramPerCubicFemtometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picogram per cubic ronnameter defined such that: nanogram per cubic yottameter = pg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicRonnameter = new("picogram per cubic ronnameter"
                                                                 , "pg/Rm³"
                                                                 , NanogramPerCubicYottameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic yoctometer defined such that: petagram per cubic zeptometer = Eg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicYoctometer = new("exagram per cubic yoctometer"
                                                                , "Eg/ym³"
                                                                , PetagramPerCubicZeptometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// gigagram per cubic quectometer defined such that: megagram per cubic rontometer = Gg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicQuectometer = new("gigagram per cubic quectometer"
                                                                  , "Gg/qm³"
                                                                  , MegagramPerCubicRontometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic petameter defined such that: femtogram per cubic terameter = ag/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicPetameter = new("attogram per cubic petameter"
                                                                , "ag/Pm³"
                                                                , FemtogramPerCubicTerameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctogram per cubic megameter defined such that: zeptogram per cubic kilometer = yg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicMegameter = new("yoctogram per cubic megameter"
                                                                 , "yg/Mm³"
                                                                 , ZeptogramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yottagram per cubic zeptometer defined such that: zettagram per cubic attometer = Yg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicZeptometer = new("yottagram per cubic zeptometer"
                                                                  , "Yg/zm³"
                                                                  , ZettagramPerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic zettameter defined such that: picogram per cubic exameter = fg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicZettameter =
      new("femtogram per cubic zettameter", "fg/Zm³", PicogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic dekameter defined such that: kilogram per cubic meter = Mg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicDekameter =
      new("megagram per cubic dekameter", "Mg/dam³", KilogramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic kilometer defined such that: yoctogram per cubic hectometer = rg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicKilometer =
      new("rontogram per cubic kilometer", "rg/km³", YoctogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic hectometer defined such that: rontogram per cubic dekameter = qg/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicHectometer =
      new("quectogram per cubic hectometer", "qg/hm³", RontogramPerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic rontometer defined such that: teragram per cubic yoctometer = Pg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicRontometer = new("petagram per cubic rontometer"
                                                                 , "Pg/rm³"
                                                                 , TeragramPerCubicYoctometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picogram per cubic quettameter defined such that: nanogram per cubic ronnameter = pg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicogramPerCubicQuettameter = new("picogram per cubic quettameter"
                                                                  , "pg/Qm³"
                                                                  , NanogramPerCubicRonnameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic terameter defined such that: attogram per cubic gigameter = zg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicTerameter =
      new("zeptogram per cubic terameter", "zg/Tm³", AttogramPerCubicGigameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic zeptometer defined such that: yottagram per cubic attometer = Rg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicZeptometer = new("ronnagram per cubic zeptometer"
                                                                  , "Rg/zm³"
                                                                  , YottagramPerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettagram per cubic yoctometer defined such that: exagram per cubic zeptometer = Zg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicYoctometer = new("zettagram per cubic yoctometer"
                                                                  , "Zg/ym³"
                                                                  , ExagramPerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic yottameter defined such that: picogram per cubic zettameter = fg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicYottameter = new("femtogram per cubic yottameter"
                                                                  , "fg/Ym³"
                                                                  , PicogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic exameter defined such that: femtogram per cubic petameter = ag/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicExameter =
      new("attogram per cubic exameter", "ag/Em³", FemtogramPerCubicPetameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic quectometer defined such that: gigagram per cubic rontometer = Tg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicQuectometer = new("teragram per cubic quectometer"
                                                                  , "Tg/qm³"
                                                                  , GigagramPerCubicRontometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic gigameter defined such that: zeptogram per cubic megameter = yg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicGigameter = new("yoctogram per cubic gigameter"
                                                                 , "yg/Gm³"
                                                                 , ZeptogramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigagram per cubic dekameter defined such that: megagram per cubic meter = Gg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicDekameter =
      new("gigagram per cubic dekameter", "Gg/dam³", MegagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic megameter defined such that: yoctogram per cubic kilometer = rg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicMegameter = new("rontogram per cubic megameter"
                                                                 , "rg/Mm³"
                                                                 , YoctogramPerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// megagram per cubic hectometer defined such that: kilogram per cubic dekameter = Mg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicHectometer =
      new("megagram per cubic hectometer", "Mg/hm³", KilogramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic kilometer defined such that: rontogram per cubic hectometer = qg/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicKilometer =
      new("quectogram per cubic kilometer", "qg/km³", RontogramPerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic rontometer defined such that: petagram per cubic yoctometer = Eg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicRontometer = new("exagram per cubic rontometer"
                                                                , "Eg/rm³"
                                                                , PetagramPerCubicYoctometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// zeptogram per cubic petameter defined such that: attogram per cubic terameter = zg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicPetameter =
      new("zeptogram per cubic petameter", "zg/Pm³", AttogramPerCubicTerameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic zeptometer defined such that: ronnagram per cubic attometer = Qg/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicZeptometer = new("quettagram per cubic zeptometer"
                                                                   , "Qg/zm³"
                                                                   , RonnagramPerCubicAttometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// femtogram per cubic ronnameter defined such that: picogram per cubic yottameter = fg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicRonnameter = new("femtogram per cubic ronnameter"
                                                                  , "fg/Rm³"
                                                                  , PicogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottagram per cubic yoctometer defined such that: zettagram per cubic zeptometer = Yg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicYoctometer = new("yottagram per cubic yoctometer"
                                                                  , "Yg/ym³"
                                                                  , ZettagramPerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic zettameter defined such that: femtogram per cubic exameter = ag/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicZettameter =
      new("attogram per cubic zettameter", "ag/Zm³", FemtogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic quectometer defined such that: teragram per cubic rontometer = Pg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicQuectometer = new("petagram per cubic quectometer"
                                                                  , "Pg/qm³"
                                                                  , TeragramPerCubicRontometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctogram per cubic terameter defined such that: zeptogram per cubic gigameter = yg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicTerameter = new("yoctogram per cubic terameter"
                                                                 , "yg/Tm³"
                                                                 , ZeptogramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teragram per cubic dekameter defined such that: gigagram per cubic meter = Tg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicDekameter =
      new("teragram per cubic dekameter", "Tg/dam³", GigagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic gigameter defined such that: yoctogram per cubic megameter = rg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicGigameter = new("rontogram per cubic gigameter"
                                                                 , "rg/Gm³"
                                                                 , YoctogramPerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zettagram per cubic rontometer defined such that: exagram per cubic yoctometer = Zg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicRontometer = new("zettagram per cubic rontometer"
                                                                  , "Zg/rm³"
                                                                  , ExagramPerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtogram per cubic quettameter defined such that: picogram per cubic ronnameter = fg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtogramPerCubicQuettameter = new("femtogram per cubic quettameter"
                                                                   , "fg/Qm³"
                                                                   , PicogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptogram per cubic exameter defined such that: attogram per cubic petameter = zg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicExameter =
      new("zeptogram per cubic exameter", "zg/Em³", AttogramPerCubicPetameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic yoctometer defined such that: yottagram per cubic zeptometer = Rg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicYoctometer = new("ronnagram per cubic yoctometer"
                                                                  , "Rg/ym³"
                                                                  , YottagramPerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic hectometer defined such that: megagram per cubic dekameter = Gg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicHectometer =
      new("gigagram per cubic hectometer", "Gg/hm³", MegagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// attogram per cubic yottameter defined such that: femtogram per cubic zettameter = ag/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicYottameter = new("attogram per cubic yottameter"
                                                                 , "ag/Ym³"
                                                                 , FemtogramPerCubicZettameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectogram per cubic megameter defined such that: rontogram per cubic kilometer = qg/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicMegameter = new("quectogram per cubic megameter"
                                                                  , "qg/Mm³"
                                                                  , RontogramPerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megagram per cubic kilometer defined such that: kilogram per cubic hectometer = Mg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicKilometer =
      new("megagram per cubic kilometer", "Mg/km³", KilogramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic quectometer defined such that: petagram per cubic rontometer = Eg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicQuectometer = new("exagram per cubic quectometer"
                                                                 , "Eg/qm³"
                                                                 , PetagramPerCubicRontometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yoctogram per cubic petameter defined such that: zeptogram per cubic terameter = yg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicPetameter = new("yoctogram per cubic petameter"
                                                                 , "yg/Pm³"
                                                                 , ZeptogramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yottagram per cubic rontometer defined such that: zettagram per cubic yoctometer = Yg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicRontometer = new("yottagram per cubic rontometer"
                                                                  , "Yg/rm³"
                                                                  , ZettagramPerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic zettameter defined such that: attogram per cubic exameter = zg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicZettameter =
      new("zeptogram per cubic zettameter", "zg/Zm³", AttogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic yoctometer defined such that: ronnagram per cubic zeptometer = Qg/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicYoctometer = new("quettagram per cubic yoctometer"
                                                                   , "Qg/ym³"
                                                                   , RonnagramPerCubicZeptometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petagram per cubic dekameter defined such that: teragram per cubic meter = Pg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicDekameter =
      new("petagram per cubic dekameter", "Pg/dam³", TeragramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// attogram per cubic ronnameter defined such that: femtogram per cubic yottameter = ag/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicRonnameter = new("attogram per cubic ronnameter"
                                                                 , "ag/Rm³"
                                                                 , FemtogramPerCubicYottameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontogram per cubic terameter defined such that: yoctogram per cubic gigameter = rg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicTerameter = new("rontogram per cubic terameter"
                                                                 , "rg/Tm³"
                                                                 , YoctogramPerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teragram per cubic hectometer defined such that: gigagram per cubic dekameter = Tg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicHectometer =
      new("teragram per cubic hectometer", "Tg/hm³", GigagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic gigameter defined such that: rontogram per cubic megameter = qg/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicGigameter = new("quectogram per cubic gigameter"
                                                                  , "qg/Gm³"
                                                                  , RontogramPerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigagram per cubic kilometer defined such that: megagram per cubic hectometer = Gg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicKilometer =
      new("gigagram per cubic kilometer", "Gg/km³", MegagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic megameter defined such that: kilogram per cubic kilometer = Mg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicMegameter =
      new("megagram per cubic megameter", "Mg/Mm³", KilogramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic quectometer defined such that: exagram per cubic rontometer = Zg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicQuectometer = new("zettagram per cubic quectometer"
                                                                   , "Zg/qm³"
                                                                   , ExagramPerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic exameter defined such that: zeptogram per cubic petameter = yg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicExameter = new("yoctogram per cubic exameter"
                                                                , "yg/Em³"
                                                                , ZeptogramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// ronnagram per cubic rontometer defined such that: yottagram per cubic yoctometer = Rg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicRontometer = new("ronnagram per cubic rontometer"
                                                                  , "Rg/rm³"
                                                                  , YottagramPerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attogram per cubic quettameter defined such that: femtogram per cubic ronnameter = ag/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttogramPerCubicQuettameter = new("attogram per cubic quettameter"
                                                                  , "ag/Qm³"
                                                                  , FemtogramPerCubicRonnameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic yottameter defined such that: attogram per cubic zettameter = zg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicYottameter = new("zeptogram per cubic yottameter"
                                                                  , "zg/Ym³"
                                                                  , AttogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exagram per cubic dekameter defined such that: petagram per cubic meter = Eg/dam³ × (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicDekameter =
      new("exagram per cubic dekameter", "Eg/dam³", PetagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic petameter defined such that: yoctogram per cubic terameter = rg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicPetameter = new("rontogram per cubic petameter"
                                                                 , "rg/Pm³"
                                                                 , YoctogramPerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// petagram per cubic hectometer defined such that: teragram per cubic dekameter = Pg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicHectometer =
      new("petagram per cubic hectometer", "Pg/hm³", TeragramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic terameter defined such that: rontogram per cubic gigameter = qg/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicTerameter = new("quectogram per cubic terameter"
                                                                  , "qg/Tm³"
                                                                  , RontogramPerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottagram per cubic quectometer defined such that: zettagram per cubic rontometer = Yg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicQuectometer = new("yottagram per cubic quectometer"
                                                                   , "Yg/qm³"
                                                                   , ZettagramPerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctogram per cubic zettameter defined such that: zeptogram per cubic exameter = yg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicZettameter =
      new("yoctogram per cubic zettameter", "yg/Zm³", ZeptogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic kilometer defined such that: gigagram per cubic hectometer = Tg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicKilometer =
      new("teragram per cubic kilometer", "Tg/km³", GigagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic gigameter defined such that: kilogram per cubic megameter = Mg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicGigameter =
      new("megagram per cubic gigameter", "Mg/Gm³", KilogramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic megameter defined such that: megagram per cubic kilometer = Gg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicMegameter =
      new("gigagram per cubic megameter", "Gg/Mm³", MegagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic rontometer defined such that: ronnagram per cubic yoctometer = Qg/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicRontometer = new("quettagram per cubic rontometer"
                                                                   , "Qg/rm³"
                                                                   , RonnagramPerCubicYoctometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptogram per cubic ronnameter defined such that: attogram per cubic yottameter = zg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicRonnameter = new("zeptogram per cubic ronnameter"
                                                                  , "zg/Rm³"
                                                                  , AttogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettagram per cubic dekameter defined such that: exagram per cubic meter = Zg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicDekameter =
      new("zettagram per cubic dekameter", "Zg/dam³", ExagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic exameter defined such that: yoctogram per cubic petameter = rg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicExameter = new("rontogram per cubic exameter"
                                                                , "rg/Em³"
                                                                , YoctogramPerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// ronnagram per cubic quectometer defined such that: yottagram per cubic rontometer = Rg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicQuectometer = new("ronnagram per cubic quectometer"
                                                                   , "Rg/qm³"
                                                                   , YottagramPerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exagram per cubic hectometer defined such that: petagram per cubic dekameter = Eg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicHectometer =
      new("exagram per cubic hectometer", "Eg/hm³", PetagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yoctogram per cubic yottameter defined such that: zeptogram per cubic zettameter = yg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicYottameter = new("yoctogram per cubic yottameter"
                                                                  , "yg/Ym³"
                                                                  , ZeptogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectogram per cubic petameter defined such that: rontogram per cubic terameter = qg/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicPetameter = new("quectogram per cubic petameter"
                                                                  , "qg/Pm³"
                                                                  , RontogramPerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptogram per cubic quettameter defined such that: attogram per cubic ronnameter = zg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptogramPerCubicQuettameter = new("zeptogram per cubic quettameter"
                                                                   , "zg/Qm³"
                                                                   , AttogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petagram per cubic kilometer defined such that: teragram per cubic hectometer = Pg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicKilometer =
      new("petagram per cubic kilometer", "Pg/km³", TeragramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic terameter defined such that: kilogram per cubic gigameter = Mg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicTerameter =
      new("megagram per cubic terameter", "Mg/Tm³", KilogramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic megameter defined such that: gigagram per cubic kilometer = Tg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicMegameter =
      new("teragram per cubic megameter", "Tg/Mm³", GigagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic gigameter defined such that: megagram per cubic megameter = Gg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicGigameter =
      new("gigagram per cubic gigameter", "Gg/Gm³", MegagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic dekameter defined such that: zettagram per cubic meter = Yg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicDekameter =
      new("yottagram per cubic dekameter", "Yg/dam³", ZettagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic zettameter defined such that: yoctogram per cubic exameter = rg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicZettameter =
      new("rontogram per cubic zettameter", "rg/Zm³", YoctogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic quectometer defined such that: ronnagram per cubic rontometer = Qg/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicQuectometer = new("quettagram per cubic quectometer"
                                                                    , "Qg/qm³"
                                                                    , RonnagramPerCubicRontometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// yoctogram per cubic ronnameter defined such that: zeptogram per cubic yottameter = yg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicRonnameter = new("yoctogram per cubic ronnameter"
                                                                  , "yg/Rm³"
                                                                  , ZeptogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettagram per cubic hectometer defined such that: exagram per cubic dekameter = Zg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicHectometer =
      new("zettagram per cubic hectometer", "Zg/hm³", ExagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic exameter defined such that: rontogram per cubic petameter = qg/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicExameter = new("quectogram per cubic exameter"
                                                                 , "qg/Em³"
                                                                 , RontogramPerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// exagram per cubic kilometer defined such that: petagram per cubic hectometer = Eg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicKilometer =
      new("exagram per cubic kilometer", "Eg/km³", PetagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic petameter defined such that: kilogram per cubic terameter = Mg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicPetameter =
      new("megagram per cubic petameter", "Mg/Pm³", KilogramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic dekameter defined such that: yottagram per cubic meter = Rg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicDekameter =
      new("ronnagram per cubic dekameter", "Rg/dam³", YottagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic megameter defined such that: teragram per cubic kilometer = Pg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicMegameter =
      new("petagram per cubic megameter", "Pg/Mm³", TeragramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic terameter defined such that: megagram per cubic gigameter = Gg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicTerameter =
      new("gigagram per cubic terameter", "Gg/Tm³", MegagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic yottameter defined such that: yoctogram per cubic zettameter = rg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicYottameter = new("rontogram per cubic yottameter"
                                                                  , "rg/Ym³"
                                                                  , YoctogramPerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teragram per cubic gigameter defined such that: gigagram per cubic megameter = Tg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicGigameter =
      new("teragram per cubic gigameter", "Tg/Gm³", GigagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yoctogram per cubic quettameter defined such that: zeptogram per cubic ronnameter = yg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctogramPerCubicQuettameter = new("yoctogram per cubic quettameter"
                                                                   , "yg/Qm³"
                                                                   , ZeptogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yottagram per cubic hectometer defined such that: zettagram per cubic dekameter = Yg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicHectometer =
      new("yottagram per cubic hectometer", "Yg/hm³", ZettagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic zettameter defined such that: rontogram per cubic exameter = qg/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicZettameter =
      new("quectogram per cubic zettameter", "qg/Zm³", RontogramPerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic kilometer defined such that: exagram per cubic hectometer = Zg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicKilometer =
      new("zettagram per cubic kilometer", "Zg/km³", ExagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic exameter defined such that: kilogram per cubic petameter = Mg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicExameter =
      new("megagram per cubic exameter", "Mg/Em³", KilogramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic dekameter defined such that: ronnagram per cubic meter = Qg/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicDekameter =
      new("quettagram per cubic dekameter", "Qg/dam³", RonnagramPerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontogram per cubic ronnameter defined such that: yoctogram per cubic yottameter = rg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicRonnameter = new("rontogram per cubic ronnameter"
                                                                  , "rg/Rm³"
                                                                  , YoctogramPerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exagram per cubic megameter defined such that: petagram per cubic kilometer = Eg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicMegameter =
      new("exagram per cubic megameter", "Eg/Mm³", PetagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic petameter defined such that: megagram per cubic terameter = Gg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicPetameter =
      new("gigagram per cubic petameter", "Gg/Pm³", MegagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic gigameter defined such that: teragram per cubic megameter = Pg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicGigameter =
      new("petagram per cubic gigameter", "Pg/Gm³", TeragramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic terameter defined such that: gigagram per cubic gigameter = Tg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicTerameter =
      new("teragram per cubic terameter", "Tg/Tm³", GigagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic hectometer defined such that: yottagram per cubic dekameter = Rg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicHectometer =
      new("ronnagram per cubic hectometer", "Rg/hm³", YottagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic yottameter defined such that: rontogram per cubic zettameter = qg/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicYottameter = new("quectogram per cubic yottameter"
                                                                   , "qg/Ym³"
                                                                   , RontogramPerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontogram per cubic quettameter defined such that: yoctogram per cubic ronnameter = rg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontogramPerCubicQuettameter = new("rontogram per cubic quettameter"
                                                                   , "rg/Qm³"
                                                                   , YoctogramPerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yottagram per cubic kilometer defined such that: zettagram per cubic hectometer = Yg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicKilometer =
      new("yottagram per cubic kilometer", "Yg/km³", ZettagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic zettameter defined such that: kilogram per cubic exameter = Mg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicZettameter =
      new("megagram per cubic zettameter", "Mg/Zm³", KilogramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic megameter defined such that: exagram per cubic kilometer = Zg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicMegameter =
      new("zettagram per cubic megameter", "Zg/Mm³", ExagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic exameter defined such that: megagram per cubic petameter = Gg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicExameter =
      new("gigagram per cubic exameter", "Gg/Em³", MegagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic gigameter defined such that: petagram per cubic megameter = Eg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicGigameter =
      new("exagram per cubic gigameter", "Eg/Gm³", PetagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic petameter defined such that: gigagram per cubic terameter = Tg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicPetameter =
      new("teragram per cubic petameter", "Tg/Pm³", GigagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic hectometer defined such that: ronnagram per cubic dekameter = Qg/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicHectometer =
      new("quettagram per cubic hectometer", "Qg/hm³", RonnagramPerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic terameter defined such that: teragram per cubic gigameter = Pg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicTerameter =
      new("petagram per cubic terameter", "Pg/Tm³", TeragramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic ronnameter defined such that: rontogram per cubic yottameter = qg/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicRonnameter = new("quectogram per cubic ronnameter"
                                                                   , "qg/Rm³"
                                                                   , RontogramPerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// ronnagram per cubic kilometer defined such that: yottagram per cubic hectometer = Rg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicKilometer =
      new("ronnagram per cubic kilometer", "Rg/km³", YottagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic yottameter defined such that: kilogram per cubic zettameter = Mg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicYottameter =
      new("megagram per cubic yottameter", "Mg/Ym³", KilogramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic megameter defined such that: zettagram per cubic kilometer = Yg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicMegameter =
      new("yottagram per cubic megameter", "Yg/Mm³", ZettagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic zettameter defined such that: megagram per cubic exameter = Gg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicZettameter =
      new("gigagram per cubic zettameter", "Gg/Zm³", MegagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quectogram per cubic quettameter defined such that: rontogram per cubic ronnameter = qg/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectogramPerCubicQuettameter = new("quectogram per cubic quettameter"
                                                                    , "qg/Qm³"
                                                                    , RontogramPerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// zettagram per cubic gigameter defined such that: exagram per cubic megameter = Zg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicGigameter =
      new("zettagram per cubic gigameter", "Zg/Gm³", ExagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic exameter defined such that: gigagram per cubic petameter = Tg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicExameter =
      new("teragram per cubic exameter", "Tg/Em³", GigagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic terameter defined such that: petagram per cubic gigameter = Eg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicTerameter =
      new("exagram per cubic terameter", "Eg/Tm³", PetagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic petameter defined such that: teragram per cubic terameter = Pg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicPetameter =
      new("petagram per cubic petameter", "Pg/Pm³", TeragramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic kilometer defined such that: ronnagram per cubic hectometer = Qg/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicKilometer =
      new("quettagram per cubic kilometer", "Qg/km³", RonnagramPerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic ronnameter defined such that: kilogram per cubic yottameter = Mg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicRonnameter =
      new("megagram per cubic ronnameter", "Mg/Rm³", KilogramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic megameter defined such that: yottagram per cubic kilometer = Rg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicMegameter =
      new("ronnagram per cubic megameter", "Rg/Mm³", YottagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic yottameter defined such that: megagram per cubic zettameter = Gg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicYottameter =
      new("gigagram per cubic yottameter", "Gg/Ym³", MegagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic gigameter defined such that: zettagram per cubic megameter = Yg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicGigameter =
      new("yottagram per cubic gigameter", "Yg/Gm³", ZettagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic zettameter defined such that: gigagram per cubic exameter = Tg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicZettameter =
      new("teragram per cubic zettameter", "Tg/Zm³", GigagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic terameter defined such that: exagram per cubic gigameter = Zg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicTerameter =
      new("zettagram per cubic terameter", "Zg/Tm³", ExagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic exameter defined such that: teragram per cubic petameter = Pg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicExameter =
      new("petagram per cubic exameter", "Pg/Em³", TeragramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic petameter defined such that: petagram per cubic terameter = Eg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicPetameter =
      new("exagram per cubic petameter", "Eg/Pm³", PetagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megagram per cubic quettameter defined such that: kilogram per cubic ronnameter = Mg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegagramPerCubicQuettameter =
      new("megagram per cubic quettameter", "Mg/Qm³", KilogramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic megameter defined such that: ronnagram per cubic kilometer = Qg/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicMegameter =
      new("quettagram per cubic megameter", "Qg/Mm³", RonnagramPerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic ronnameter defined such that: megagram per cubic yottameter = Gg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicRonnameter =
      new("gigagram per cubic ronnameter", "Gg/Rm³", MegagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic gigameter defined such that: yottagram per cubic megameter = Rg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicGigameter =
      new("ronnagram per cubic gigameter", "Rg/Gm³", YottagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic yottameter defined such that: gigagram per cubic zettameter = Tg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicYottameter =
      new("teragram per cubic yottameter", "Tg/Ym³", GigagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic terameter defined such that: zettagram per cubic gigameter = Yg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicTerameter =
      new("yottagram per cubic terameter", "Yg/Tm³", ZettagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic zettameter defined such that: teragram per cubic exameter = Pg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicZettameter =
      new("petagram per cubic zettameter", "Pg/Zm³", TeragramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic petameter defined such that: exagram per cubic terameter = Zg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicPetameter =
      new("zettagram per cubic petameter", "Zg/Pm³", ExagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic exameter defined such that: petagram per cubic petameter = Eg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicExameter =
      new("exagram per cubic exameter", "Eg/Em³", PetagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigagram per cubic quettameter defined such that: megagram per cubic ronnameter = Gg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigagramPerCubicQuettameter =
      new("gigagram per cubic quettameter", "Gg/Qm³", MegagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic gigameter defined such that: ronnagram per cubic megameter = Qg/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicGigameter =
      new("quettagram per cubic gigameter", "Qg/Gm³", RonnagramPerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic ronnameter defined such that: gigagram per cubic yottameter = Tg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicRonnameter =
      new("teragram per cubic ronnameter", "Tg/Rm³", GigagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic terameter defined such that: yottagram per cubic gigameter = Rg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicTerameter =
      new("ronnagram per cubic terameter", "Rg/Tm³", YottagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic yottameter defined such that: teragram per cubic zettameter = Pg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicYottameter =
      new("petagram per cubic yottameter", "Pg/Ym³", TeragramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic petameter defined such that: zettagram per cubic terameter = Yg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicPetameter =
      new("yottagram per cubic petameter", "Yg/Pm³", ZettagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic zettameter defined such that: petagram per cubic exameter = Eg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicZettameter =
      new("exagram per cubic zettameter", "Eg/Zm³", PetagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic exameter defined such that: exagram per cubic petameter = Zg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicExameter =
      new("zettagram per cubic exameter", "Zg/Em³", ExagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teragram per cubic quettameter defined such that: gigagram per cubic ronnameter = Tg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeragramPerCubicQuettameter =
      new("teragram per cubic quettameter", "Tg/Qm³", GigagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic terameter defined such that: ronnagram per cubic gigameter = Qg/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicTerameter =
      new("quettagram per cubic terameter", "Qg/Tm³", RonnagramPerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic ronnameter defined such that: teragram per cubic yottameter = Pg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicRonnameter =
      new("petagram per cubic ronnameter", "Pg/Rm³", TeragramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic petameter defined such that: yottagram per cubic terameter = Rg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicPetameter =
      new("ronnagram per cubic petameter", "Rg/Pm³", YottagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic yottameter defined such that: petagram per cubic zettameter = Eg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicYottameter =
      new("exagram per cubic yottameter", "Eg/Ym³", PetagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic exameter defined such that: zettagram per cubic petameter = Yg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicExameter =
      new("yottagram per cubic exameter", "Yg/Em³", ZettagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic zettameter defined such that: exagram per cubic exameter = Zg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicZettameter =
      new("zettagram per cubic zettameter", "Zg/Zm³", ExagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petagram per cubic quettameter defined such that: teragram per cubic ronnameter = Pg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetagramPerCubicQuettameter =
      new("petagram per cubic quettameter", "Pg/Qm³", TeragramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic petameter defined such that: ronnagram per cubic terameter = Qg/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicPetameter =
      new("quettagram per cubic petameter", "Qg/Pm³", RonnagramPerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic ronnameter defined such that: petagram per cubic yottameter = Eg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicRonnameter =
      new("exagram per cubic ronnameter", "Eg/Rm³", PetagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic exameter defined such that: yottagram per cubic petameter = Rg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicExameter =
      new("ronnagram per cubic exameter", "Rg/Em³", YottagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic yottameter defined such that: exagram per cubic zettameter = Zg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicYottameter =
      new("zettagram per cubic yottameter", "Zg/Ym³", ExagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic zettameter defined such that: zettagram per cubic exameter = Yg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicZettameter =
      new("yottagram per cubic zettameter", "Yg/Zm³", ZettagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exagram per cubic quettameter defined such that: petagram per cubic ronnameter = Eg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExagramPerCubicQuettameter =
      new("exagram per cubic quettameter", "Eg/Qm³", PetagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic exameter defined such that: ronnagram per cubic petameter = Qg/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicExameter =
      new("quettagram per cubic exameter", "Qg/Em³", RonnagramPerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic ronnameter defined such that: exagram per cubic yottameter = Zg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicRonnameter =
      new("zettagram per cubic ronnameter", "Zg/Rm³", ExagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic zettameter defined such that: yottagram per cubic exameter = Rg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicZettameter =
      new("ronnagram per cubic zettameter", "Rg/Zm³", YottagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic yottameter defined such that: zettagram per cubic zettameter = Yg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicYottameter =
      new("yottagram per cubic yottameter", "Yg/Ym³", ZettagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettagram per cubic quettameter defined such that: exagram per cubic ronnameter = Zg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettagramPerCubicQuettameter =
      new("zettagram per cubic quettameter", "Zg/Qm³", ExagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic zettameter defined such that: ronnagram per cubic exameter = Qg/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicZettameter =
      new("quettagram per cubic zettameter", "Qg/Zm³", RonnagramPerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic ronnameter defined such that: zettagram per cubic yottameter = Yg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicRonnameter =
      new("yottagram per cubic ronnameter", "Yg/Rm³", ZettagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic yottameter defined such that: yottagram per cubic zettameter = Rg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicYottameter =
      new("ronnagram per cubic yottameter", "Rg/Ym³", YottagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottagram per cubic quettameter defined such that: zettagram per cubic ronnameter = Yg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottagramPerCubicQuettameter =
      new("yottagram per cubic quettameter", "Yg/Qm³", ZettagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic yottameter defined such that: ronnagram per cubic zettameter = Qg/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicYottameter =
      new("quettagram per cubic yottameter", "Qg/Ym³", RonnagramPerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic ronnameter defined such that: yottagram per cubic yottameter = Rg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicRonnameter =
      new("ronnagram per cubic ronnameter", "Rg/Rm³", YottagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnagram per cubic quettameter defined such that: yottagram per cubic ronnameter = Rg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnagramPerCubicQuettameter =
      new("ronnagram per cubic quettameter", "Rg/Qm³", YottagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic ronnameter defined such that: ronnagram per cubic yottameter = Qg/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicRonnameter =
      new("quettagram per cubic ronnameter", "Qg/Rm³", RonnagramPerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettagram per cubic quettameter defined such that: ronnagram per cubic ronnameter = Qg/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettagramPerCubicQuettameter =
      new("quettagram per cubic quettameter", "Qg/Qm³", RonnagramPerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic meter defined such that: megagram per cubic meter = mt/m³ × (1.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicMeter = new("metric ton per cubic meter", "mt/m³", MegagramPerCubicMeter, 1.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic decimeter defined such that: megagram per cubic meter = mt/dm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicDecimeter = new("metric ton per cubic decimeter"
                                                                 , "mt/dm³"
                                                                 , MegagramPerCubicMeter
                                                                 , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// tonne per cubic meter defined such that: megagram per cubic meter = t/m³ × (1.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density TonnePerCubicMeter = new("tonne per cubic meter", "t/m³", MegagramPerCubicMeter, 1.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic centimeter defined such that: megagram per cubic decimeter = mt/cm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicCentimeter = new("metric ton per cubic centimeter"
                                                                  , "mt/cm³"
                                                                  , MegagramPerCubicDecimeter
                                                                  , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// metric ton per cubic millimeter defined such that: megagram per cubic centimeter = mt/mm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicMillimeter = new("metric ton per cubic millimeter"
                                                                  , "mt/mm³"
                                                                  , MegagramPerCubicCentimeter
                                                                  , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// tonne per cubic decimeter defined such that: megagram per cubic meter = t/dm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicDecimeter =
      new("tonne per cubic decimeter", "t/dm³", MegagramPerCubicMeter, 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)), system: "SI");
   
   /// <summary>
   /// metric ton per cubic micrometer defined such that: megagram per cubic millimeter = mt/μm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicMicrometer = new("metric ton per cubic micrometer"
                                                                  , "mt/μm³"
                                                                  , MegagramPerCubicMillimeter
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// metric ton per cubic nanometer defined such that: megagram per cubic micrometer = mt/nm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicNanometer = new("metric ton per cubic nanometer"
                                                                 , "mt/nm³"
                                                                 , MegagramPerCubicMicrometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// tonne per cubic centimeter defined such that: megagram per cubic decimeter = t/cm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicCentimeter = new("tonne per cubic centimeter"
                                                              , "t/cm³"
                                                              , MegagramPerCubicDecimeter
                                                              , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// decitonne per cubic meter defined such that: tonne per cubic meter = dt/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicMeter =
      new("decitonne per cubic meter", "dt/m³", TonnePerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic picometer defined such that: megagram per cubic nanometer = mt/pm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicPicometer = new("metric ton per cubic picometer"
                                                                 , "mt/pm³"
                                                                 , MegagramPerCubicNanometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// metric ton per cubic femtometer defined such that: megagram per cubic picometer = mt/fm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicFemtometer = new("metric ton per cubic femtometer"
                                                                  , "mt/fm³"
                                                                  , MegagramPerCubicPicometer
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// tonne per cubic millimeter defined such that: megagram per cubic centimeter = t/mm³ ×
   /// (1.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicMillimeter = new("tonne per cubic millimeter"
                                                              , "t/mm³"
                                                              , MegagramPerCubicCentimeter
                                                              , 1.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// metric ton per cubic attometer defined such that: megagram per cubic femtometer = mt/am³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicAttometer = new("metric ton per cubic attometer"
                                                                 , "mt/am³"
                                                                 , MegagramPerCubicFemtometer
                                                                 , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// metric ton per cubic zeptometer defined such that: megagram per cubic attometer = mt/zm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicZeptometer = new("metric ton per cubic zeptometer"
                                                                  , "mt/zm³"
                                                                  , MegagramPerCubicAttometer
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// tonne per cubic micrometer defined such that: megagram per cubic millimeter = t/μm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicMicrometer = new("tonne per cubic micrometer"
                                                              , "t/μm³"
                                                              , MegagramPerCubicMillimeter
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// decitonne per cubic decimeter defined such that: tonne per cubic meter = dt/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicDecimeter = new("decitonne per cubic decimeter"
                                                                 , "dt/dm³"
                                                                 , TonnePerCubicMeter
                                                                 , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centitonne per cubic meter defined such that: decitonne per cubic meter = ct/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicMeter =
      new("centitonne per cubic meter", "ct/m³", DecitonnePerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic yoctometer defined such that: megagram per cubic zeptometer = mt/ym³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicYoctometer = new("metric ton per cubic yoctometer"
                                                                  , "mt/ym³"
                                                                  , MegagramPerCubicZeptometer
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// metric ton per cubic rontometer defined such that: megagram per cubic yoctometer = mt/rm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicRontometer = new("metric ton per cubic rontometer"
                                                                  , "mt/rm³"
                                                                  , MegagramPerCubicYoctometer
                                                                  , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// tonne per cubic nanometer defined such that: megagram per cubic micrometer = t/nm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicNanometer = new("tonne per cubic nanometer"
                                                             , "t/nm³"
                                                             , MegagramPerCubicMicrometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// metric ton per cubic quectometer defined such that: megagram per cubic rontometer = mt/qm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicQuectometer = new("metric ton per cubic quectometer"
                                                                   , "mt/qm³"
                                                                   , MegagramPerCubicRontometer
                                                                   , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// metric ton per cubic dekameter defined such that: megagram per cubic meter = mt/dam³ × (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicDekameter =
      new("metric ton per cubic dekameter", "mt/dam³", MegagramPerCubicMeter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic picometer defined such that: megagram per cubic nanometer = t/pm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicPicometer = new("tonne per cubic picometer"
                                                             , "t/pm³"
                                                             , MegagramPerCubicNanometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// decitonne per cubic centimeter defined such that: tonne per cubic decimeter = dt/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicCentimeter = new("decitonne per cubic centimeter"
                                                                  , "dt/cm³"
                                                                  , TonnePerCubicDecimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic meter defined such that: centitonne per cubic meter = mt/m³ × (1.0/10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicMeter =
      new("millitonne per cubic meter", "mt/m³", CentitonnePerCubicMeter, 1.0 / 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic hectometer defined such that: megagram per cubic dekameter = mt/hm³ ×
   /// (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicHectometer =
      new("metric ton per cubic hectometer", "mt/hm³", MegagramPerCubicDekameter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic kilometer defined such that: megagram per cubic hectometer = mt/km³ ×
   /// (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicKilometer =
      new("metric ton per cubic kilometer", "mt/km³", MegagramPerCubicHectometer, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic femtometer defined such that: megagram per cubic picometer = t/fm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicFemtometer = new("tonne per cubic femtometer"
                                                              , "t/fm³"
                                                              , MegagramPerCubicPicometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// centitonne per cubic decimeter defined such that: decitonne per cubic meter = ct/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicDecimeter = new("centitonne per cubic decimeter"
                                                                  , "ct/dm³"
                                                                  , DecitonnePerCubicMeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// metric ton per cubic megameter defined such that: megagram per cubic kilometer = mt/Mm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicMegameter =
      new("metric ton per cubic megameter", "mt/Mm³", MegagramPerCubicKilometer, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic gigameter defined such that: megagram per cubic megameter = mt/Gm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicGigameter =
      new("metric ton per cubic gigameter", "mt/Gm³", MegagramPerCubicMegameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic attometer defined such that: megagram per cubic femtometer = t/am³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicAttometer = new("tonne per cubic attometer"
                                                             , "t/am³"
                                                             , MegagramPerCubicFemtometer
                                                             , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                             , system: "SI"
                                                              );
   
   /// <summary>
   /// decitonne per cubic millimeter defined such that: tonne per cubic centimeter = dt/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicMillimeter = new("decitonne per cubic millimeter"
                                                                  , "dt/mm³"
                                                                  , TonnePerCubicCentimeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic meter defined such that: millitonne per cubic meter = μt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicMeter =
      new("microtonne per cubic meter", "μt/m³", MillitonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic terameter defined such that: megagram per cubic gigameter = mt/Tm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicTerameter =
      new("metric ton per cubic terameter", "mt/Tm³", MegagramPerCubicGigameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic petameter defined such that: megagram per cubic terameter = mt/Pm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicPetameter =
      new("metric ton per cubic petameter", "mt/Pm³", MegagramPerCubicTerameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic zeptometer defined such that: megagram per cubic attometer = t/zm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicZeptometer = new("tonne per cubic zeptometer"
                                                              , "t/zm³"
                                                              , MegagramPerCubicAttometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// metric ton per cubic exameter defined such that: megagram per cubic petameter = mt/Em³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicExameter =
      new("metric ton per cubic exameter", "mt/Em³", MegagramPerCubicPetameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic zettameter defined such that: megagram per cubic exameter = mt/Zm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicZettameter =
      new("metric ton per cubic zettameter", "mt/Zm³", MegagramPerCubicExameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic yoctometer defined such that: megagram per cubic zeptometer = t/ym³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicYoctometer = new("tonne per cubic yoctometer"
                                                              , "t/ym³"
                                                              , MegagramPerCubicZeptometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// decitonne per cubic micrometer defined such that: tonne per cubic millimeter = dt/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicMicrometer = new("decitonne per cubic micrometer"
                                                                  , "dt/μm³"
                                                                  , TonnePerCubicMillimeter
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic centimeter defined such that: decitonne per cubic decimeter = ct/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicCentimeter = new("centitonne per cubic centimeter"
                                                                   , "ct/cm³"
                                                                   , DecitonnePerCubicDecimeter
                                                                   , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// millitonne per cubic decimeter defined such that: centitonne per cubic meter = mt/dm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicDecimeter = new("millitonne per cubic decimeter"
                                                                  , "mt/dm³"
                                                                  , CentitonnePerCubicMeter
                                                                  , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic meter defined such that: microtonne per cubic meter = nt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicMeter =
      new("nanotonne per cubic meter", "nt/m³", MicrotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic yottameter defined such that: megagram per cubic zettameter = mt/Ym³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicYottameter =
      new("metric ton per cubic yottameter", "mt/Ym³", MegagramPerCubicZettameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// metric ton per cubic ronnameter defined such that: megagram per cubic yottameter = mt/Rm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicRonnameter =
      new("metric ton per cubic ronnameter", "mt/Rm³", MegagramPerCubicYottameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic rontometer defined such that: megagram per cubic yoctometer = t/rm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicRontometer = new("tonne per cubic rontometer"
                                                              , "t/rm³"
                                                              , MegagramPerCubicYoctometer
                                                              , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                              , system: "SI"
                                                               );
   
   /// <summary>
   /// metric ton per cubic quettameter defined such that: megagram per cubic ronnameter = mt/Qm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MetricTonPerCubicQuettameter =
      new("metric ton per cubic quettameter", "mt/Qm³", MegagramPerCubicRonnameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic quectometer defined such that: megagram per cubic rontometer = t/qm³ ×
   /// (1.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicQuectometer = new("tonne per cubic quectometer"
                                                               , "t/qm³"
                                                               , MegagramPerCubicRontometer
                                                               , 1.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                               , system: "SI"
                                                                );
   
   /// <summary>
   /// decitonne per cubic nanometer defined such that: tonne per cubic micrometer = dt/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicNanometer = new("decitonne per cubic nanometer"
                                                                 , "dt/nm³"
                                                                 , TonnePerCubicMicrometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic meter defined such that: nanotonne per cubic meter = pt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicMeter =
      new("picotonne per cubic meter", "pt/m³", NanotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic dekameter defined such that: megagram per cubic meter = t/dam³ × (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicDekameter =
      new("tonne per cubic dekameter", "t/dam³", MegagramPerCubicMeter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic millimeter defined such that: decitonne per cubic centimeter = ct/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicMillimeter = new("centitonne per cubic millimeter"
                                                                   , "ct/mm³"
                                                                   , DecitonnePerCubicCentimeter
                                                                   , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic decimeter defined such that: millitonne per cubic meter = μt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicDecimeter = new("microtonne per cubic decimeter"
                                                                  , "μt/dm³"
                                                                  , MillitonnePerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// tonne per cubic hectometer defined such that: megagram per cubic dekameter = t/hm³ × (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicHectometer =
      new("tonne per cubic hectometer", "t/hm³", MegagramPerCubicDekameter, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic picometer defined such that: tonne per cubic nanometer = dt/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicPicometer = new("decitonne per cubic picometer"
                                                                 , "dt/pm³"
                                                                 , TonnePerCubicNanometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// millitonne per cubic centimeter defined such that: centitonne per cubic decimeter = mt/cm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicCentimeter = new("millitonne per cubic centimeter"
                                                                   , "mt/cm³"
                                                                   , CentitonnePerCubicDecimeter
                                                                   , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// femtotonne per cubic meter defined such that: picotonne per cubic meter = ft/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicMeter =
      new("femtotonne per cubic meter", "ft/m³", PicotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic kilometer defined such that: megagram per cubic hectometer = t/km³ × (1.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TonnePerCubicKilometer =
      new("tonne per cubic kilometer", "t/km³", MegagramPerCubicHectometer, 1.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic megameter defined such that: megagram per cubic kilometer = t/Mm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicMegameter =
      new("tonne per cubic megameter", "t/Mm³", MegagramPerCubicKilometer, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic femtometer defined such that: tonne per cubic picometer = dt/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicFemtometer = new("decitonne per cubic femtometer"
                                                                  , "dt/fm³"
                                                                  , TonnePerCubicPicometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic micrometer defined such that: decitonne per cubic millimeter = ct/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicMicrometer = new("centitonne per cubic micrometer"
                                                                   , "ct/μm³"
                                                                   , DecitonnePerCubicMillimeter
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic decimeter defined such that: microtonne per cubic meter = nt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicDecimeter = new("nanotonne per cubic decimeter"
                                                                 , "nt/dm³"
                                                                 , MicrotonnePerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attotonne per cubic meter defined such that: femtotonne per cubic meter = at/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicMeter =
      new("attotonne per cubic meter", "at/m³", FemtotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic gigameter defined such that: megagram per cubic megameter = t/Gm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicGigameter =
      new("tonne per cubic gigameter", "t/Gm³", MegagramPerCubicMegameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic terameter defined such that: megagram per cubic gigameter = t/Tm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicTerameter =
      new("tonne per cubic terameter", "t/Tm³", MegagramPerCubicGigameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic attometer defined such that: tonne per cubic femtometer = dt/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicAttometer = new("decitonne per cubic attometer"
                                                                 , "dt/am³"
                                                                 , TonnePerCubicFemtometer
                                                                 , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// millitonne per cubic millimeter defined such that: centitonne per cubic centimeter = mt/mm³ ×
   /// (1.0/10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicMillimeter = new("millitonne per cubic millimeter"
                                                                   , "mt/mm³"
                                                                   , CentitonnePerCubicCentimeter
                                                                   , 1.0 / 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic centimeter defined such that: millitonne per cubic decimeter = μt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicCentimeter = new("microtonne per cubic centimeter"
                                                                   , "μt/cm³"
                                                                   , MillitonnePerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptotonne per cubic meter defined such that: attotonne per cubic meter = zt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicMeter =
      new("zeptotonne per cubic meter", "zt/m³", AttotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic petameter defined such that: megagram per cubic terameter = t/Pm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicPetameter =
      new("tonne per cubic petameter", "t/Pm³", MegagramPerCubicTerameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic nanometer defined such that: decitonne per cubic micrometer = ct/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicNanometer = new("centitonne per cubic nanometer"
                                                                  , "ct/nm³"
                                                                  , DecitonnePerCubicMicrometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic decimeter defined such that: nanotonne per cubic meter = pt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicDecimeter = new("picotonne per cubic decimeter"
                                                                 , "pt/dm³"
                                                                 , NanotonnePerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// tonne per cubic exameter defined such that: megagram per cubic petameter = t/Em³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicExameter =
      new("tonne per cubic exameter", "t/Em³", MegagramPerCubicPetameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic zeptometer defined such that: tonne per cubic attometer = dt/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicZeptometer = new("decitonne per cubic zeptometer"
                                                                  , "dt/zm³"
                                                                  , TonnePerCubicAttometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic meter defined such that: zeptotonne per cubic meter = yt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicMeter =
      new("yoctotonne per cubic meter", "yt/m³", ZeptotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic zettameter defined such that: megagram per cubic exameter = t/Zm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicZettameter =
      new("tonne per cubic zettameter", "t/Zm³", MegagramPerCubicExameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic yottameter defined such that: megagram per cubic zettameter = t/Ym³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicYottameter =
      new("tonne per cubic yottameter", "t/Ym³", MegagramPerCubicZettameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic yoctometer defined such that: tonne per cubic zeptometer = dt/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicYoctometer = new("decitonne per cubic yoctometer"
                                                                  , "dt/ym³"
                                                                  , TonnePerCubicZeptometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic picometer defined such that: decitonne per cubic nanometer = ct/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicPicometer = new("centitonne per cubic picometer"
                                                                  , "ct/pm³"
                                                                  , DecitonnePerCubicNanometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic micrometer defined such that: centitonne per cubic millimeter = mt/μm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicMicrometer = new("millitonne per cubic micrometer"
                                                                   , "mt/μm³"
                                                                   , CentitonnePerCubicMillimeter
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic centimeter defined such that: microtonne per cubic decimeter = nt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicCentimeter = new("nanotonne per cubic centimeter"
                                                                  , "nt/cm³"
                                                                  , MicrotonnePerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic decimeter defined such that: picotonne per cubic meter = ft/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicDecimeter = new("femtotonne per cubic decimeter"
                                                                  , "ft/dm³"
                                                                  , PicotonnePerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic meter defined such that: yoctotonne per cubic meter = rt/m³ × (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicMeter =
      new("rontotonne per cubic meter", "rt/m³", YoctotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// tonne per cubic ronnameter defined such that: megagram per cubic yottameter = t/Rm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicRonnameter =
      new("tonne per cubic ronnameter", "t/Rm³", MegagramPerCubicYottameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic millimeter defined such that: millitonne per cubic centimeter = μt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicMillimeter = new("microtonne per cubic millimeter"
                                                                   , "μt/mm³"
                                                                   , MillitonnePerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// tonne per cubic quettameter defined such that: megagram per cubic ronnameter = t/Qm³ ×
   /// (1.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TonnePerCubicQuettameter =
      new("tonne per cubic quettameter", "t/Qm³", MegagramPerCubicRonnameter, 1.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic rontometer defined such that: tonne per cubic yoctometer = dt/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicRontometer = new("decitonne per cubic rontometer"
                                                                  , "dt/rm³"
                                                                  , TonnePerCubicYoctometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic meter defined such that: rontotonne per cubic meter = qt/m³ ×
   /// (1.0/1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicMeter =
      new("quectotonne per cubic meter", "qt/m³", RontotonnePerCubicMeter, 1.0 / 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic femtometer defined such that: decitonne per cubic picometer = ct/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicFemtometer = new("centitonne per cubic femtometer"
                                                                   , "ct/fm³"
                                                                   , DecitonnePerCubicPicometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic decimeter defined such that: femtotonne per cubic meter = at/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicDecimeter = new("attotonne per cubic decimeter"
                                                                 , "at/dm³"
                                                                 , FemtotonnePerCubicMeter
                                                                 , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekatonne per cubic meter defined such that: tonne per cubic meter = dat/m³ × (10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicMeter = new("dekatonne per cubic meter", "dat/m³", TonnePerCubicMeter, 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic quectometer defined such that: tonne per cubic rontometer = dt/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicQuectometer = new("decitonne per cubic quectometer"
                                                                   , "dt/qm³"
                                                                   , TonnePerCubicRontometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// millitonne per cubic nanometer defined such that: centitonne per cubic micrometer = mt/nm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicNanometer = new("millitonne per cubic nanometer"
                                                                  , "mt/nm³"
                                                                  , CentitonnePerCubicMicrometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic centimeter defined such that: nanotonne per cubic decimeter = pt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicCentimeter = new("picotonne per cubic centimeter"
                                                                  , "pt/cm³"
                                                                  , NanotonnePerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// hectotonne per cubic meter defined such that: dekatonne per cubic meter = ht/m³ × (10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicMeter =
      new("hectotonne per cubic meter", "ht/m³", DekatonnePerCubicMeter, 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic dekameter defined such that: tonne per cubic meter = dt/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicDekameter =
      new("decitonne per cubic dekameter", "dt/dam³", TonnePerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic attometer defined such that: decitonne per cubic femtometer = ct/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicAttometer = new("centitonne per cubic attometer"
                                                                  , "ct/am³"
                                                                  , DecitonnePerCubicFemtometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic micrometer defined such that: millitonne per cubic millimeter = μt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicMicrometer = new("microtonne per cubic micrometer"
                                                                   , "μt/μm³"
                                                                   , MillitonnePerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic millimeter defined such that: microtonne per cubic centimeter = nt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicMillimeter = new("nanotonne per cubic millimeter"
                                                                  , "nt/mm³"
                                                                  , MicrotonnePerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic decimeter defined such that: attotonne per cubic meter = zt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicDecimeter = new("zeptotonne per cubic decimeter"
                                                                  , "zt/dm³"
                                                                  , AttotonnePerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic meter defined such that: hectotonne per cubic meter = kt/m³ × (10.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicMeter =
      new("kilotonne per cubic meter", "kt/m³", HectotonnePerCubicMeter, 10.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic hectometer defined such that: tonne per cubic dekameter = dt/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicHectometer =
      new("decitonne per cubic hectometer", "dt/hm³", TonnePerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic picometer defined such that: centitonne per cubic nanometer = mt/pm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicPicometer = new("millitonne per cubic picometer"
                                                                  , "mt/pm³"
                                                                  , CentitonnePerCubicNanometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic centimeter defined such that: picotonne per cubic decimeter = ft/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicCentimeter = new("femtotonne per cubic centimeter"
                                                                   , "ft/cm³"
                                                                   , PicotonnePerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// centitonne per cubic zeptometer defined such that: decitonne per cubic attometer = ct/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicZeptometer = new("centitonne per cubic zeptometer"
                                                                   , "ct/zm³"
                                                                   , DecitonnePerCubicAttometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic decimeter defined such that: zeptotonne per cubic meter = yt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicDecimeter = new("yoctotonne per cubic decimeter"
                                                                  , "yt/dm³"
                                                                  , ZeptotonnePerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic meter defined such that: kilotonne per cubic meter = Mt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicMeter =
      new("megatonne per cubic meter", "Mt/m³", KilotonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic kilometer defined such that: tonne per cubic hectometer = dt/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicKilometer =
      new("decitonne per cubic kilometer", "dt/km³", TonnePerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic nanometer defined such that: millitonne per cubic micrometer = μt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicNanometer = new("microtonne per cubic nanometer"
                                                                  , "μt/nm³"
                                                                  , MillitonnePerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic millimeter defined such that: nanotonne per cubic centimeter = pt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicMillimeter = new("picotonne per cubic millimeter"
                                                                  , "pt/mm³"
                                                                  , NanotonnePerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigatonne per cubic meter defined such that: megatonne per cubic meter = Gt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicMeter =
      new("gigatonne per cubic meter", "Gt/m³", MegatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic megameter defined such that: tonne per cubic kilometer = dt/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicMegameter =
      new("decitonne per cubic megameter", "dt/Mm³", TonnePerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic yoctometer defined such that: decitonne per cubic zeptometer = ct/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicYoctometer = new("centitonne per cubic yoctometer"
                                                                   , "ct/ym³"
                                                                   , DecitonnePerCubicZeptometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// millitonne per cubic femtometer defined such that: centitonne per cubic picometer = mt/fm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicFemtometer = new("millitonne per cubic femtometer"
                                                                   , "mt/fm³"
                                                                   , CentitonnePerCubicPicometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic micrometer defined such that: microtonne per cubic millimeter = nt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicMicrometer = new("nanotonne per cubic micrometer"
                                                                  , "nt/μm³"
                                                                  , MicrotonnePerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic centimeter defined such that: femtotonne per cubic decimeter = at/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicCentimeter = new("attotonne per cubic centimeter"
                                                                  , "at/cm³"
                                                                  , FemtotonnePerCubicDecimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic decimeter defined such that: yoctotonne per cubic meter = rt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicDecimeter = new("rontotonne per cubic decimeter"
                                                                  , "rt/dm³"
                                                                  , YoctotonnePerCubicMeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teratonne per cubic meter defined such that: gigatonne per cubic meter = Tt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicMeter =
      new("teratonne per cubic meter", "Tt/m³", GigatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic gigameter defined such that: tonne per cubic megameter = dt/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicGigameter =
      new("decitonne per cubic gigameter", "dt/Gm³", TonnePerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic rontometer defined such that: decitonne per cubic yoctometer = ct/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicRontometer = new("centitonne per cubic rontometer"
                                                                   , "ct/rm³"
                                                                   , DecitonnePerCubicYoctometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic decimeter defined such that: rontotonne per cubic meter = qt/dm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicDecimeter = new("quectotonne per cubic decimeter"
                                                                   , "qt/dm³"
                                                                   , RontotonnePerCubicMeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petatonne per cubic meter defined such that: teratonne per cubic meter = Pt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicMeter =
      new("petatonne per cubic meter", "Pt/m³", TeratonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic terameter defined such that: tonne per cubic gigameter = dt/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicTerameter =
      new("decitonne per cubic terameter", "dt/Tm³", TonnePerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic attometer defined such that: centitonne per cubic femtometer = mt/am³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicAttometer = new("millitonne per cubic attometer"
                                                                  , "mt/am³"
                                                                  , CentitonnePerCubicFemtometer
                                                                  , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic picometer defined such that: millitonne per cubic nanometer = μt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicPicometer = new("microtonne per cubic picometer"
                                                                  , "μt/pm³"
                                                                  , MillitonnePerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic millimeter defined such that: picotonne per cubic centimeter = ft/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicMillimeter = new("femtotonne per cubic millimeter"
                                                                   , "ft/mm³"
                                                                   , PicotonnePerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptotonne per cubic centimeter defined such that: attotonne per cubic decimeter = zt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicCentimeter = new("zeptotonne per cubic centimeter"
                                                                   , "zt/cm³"
                                                                   , AttotonnePerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic meter defined such that: petatonne per cubic meter = Et/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicMeter = new("exatonne per cubic meter", "Et/m³", PetatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic decimeter defined such that: tonne per cubic meter = dat/dm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicDecimeter = new("dekatonne per cubic decimeter"
                                                                 , "dat/dm³"
                                                                 , TonnePerCubicMeter
                                                                 , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decitonne per cubic petameter defined such that: tonne per cubic terameter = dt/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicPetameter =
      new("decitonne per cubic petameter", "dt/Pm³", TonnePerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic quectometer defined such that: decitonne per cubic rontometer = ct/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicQuectometer = new("centitonne per cubic quectometer"
                                                                    , "ct/qm³"
                                                                    , DecitonnePerCubicRontometer
                                                                    , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// nanotonne per cubic nanometer defined such that: microtonne per cubic micrometer = nt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicNanometer = new("nanotonne per cubic nanometer"
                                                                 , "nt/nm³"
                                                                 , MicrotonnePerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic micrometer defined such that: nanotonne per cubic millimeter = pt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicMicrometer = new("picotonne per cubic micrometer"
                                                                  , "pt/μm³"
                                                                  , NanotonnePerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettatonne per cubic meter defined such that: exatonne per cubic meter = Zt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicMeter =
      new("zettatonne per cubic meter", "Zt/m³", ExatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic exameter defined such that: tonne per cubic petameter = dt/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicExameter =
      new("decitonne per cubic exameter", "dt/Em³", TonnePerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic zeptometer defined such that: centitonne per cubic attometer = mt/zm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicZeptometer = new("millitonne per cubic zeptometer"
                                                                   , "mt/zm³"
                                                                   , CentitonnePerCubicAttometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic centimeter defined such that: zeptotonne per cubic decimeter = yt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicCentimeter = new("yoctotonne per cubic centimeter"
                                                                   , "yt/cm³"
                                                                   , ZeptotonnePerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// hectotonne per cubic decimeter defined such that: dekatonne per cubic meter = ht/dm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicDecimeter = new("hectotonne per cubic decimeter"
                                                                  , "ht/dm³"
                                                                  , DekatonnePerCubicMeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic dekameter defined such that: decitonne per cubic meter = ct/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicDekameter =
      new("centitonne per cubic dekameter", "ct/dam³", DecitonnePerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic femtometer defined such that: millitonne per cubic picometer = μt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicFemtometer = new("microtonne per cubic femtometer"
                                                                   , "μt/fm³"
                                                                   , MillitonnePerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic millimeter defined such that: femtotonne per cubic centimeter = at/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicMillimeter = new("attotonne per cubic millimeter"
                                                                  , "at/mm³"
                                                                  , FemtotonnePerCubicCentimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottatonne per cubic meter defined such that: zettatonne per cubic meter = Yt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicMeter =
      new("yottatonne per cubic meter", "Yt/m³", ZettatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic zettameter defined such that: tonne per cubic exameter = dt/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicZettameter =
      new("decitonne per cubic zettameter", "dt/Zm³", TonnePerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic meter defined such that: yottatonne per cubic meter = Rt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicMeter =
      new("ronnatonne per cubic meter", "Rt/m³", YottatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic decimeter defined such that: hectotonne per cubic meter = kt/dm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicDecimeter = new("kilotonne per cubic decimeter"
                                                                 , "kt/dm³"
                                                                 , HectotonnePerCubicMeter
                                                                 , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// decitonne per cubic yottameter defined such that: tonne per cubic zettameter = dt/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicYottameter =
      new("decitonne per cubic yottameter", "dt/Ym³", TonnePerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// centitonne per cubic hectometer defined such that: decitonne per cubic dekameter = ct/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicHectometer =
      new("centitonne per cubic hectometer", "ct/hm³", DecitonnePerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic yoctometer defined such that: centitonne per cubic zeptometer = mt/ym³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicYoctometer = new("millitonne per cubic yoctometer"
                                                                   , "mt/ym³"
                                                                   , CentitonnePerCubicZeptometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic picometer defined such that: microtonne per cubic nanometer = nt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicPicometer = new("nanotonne per cubic picometer"
                                                                 , "nt/pm³"
                                                                 , MicrotonnePerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic micrometer defined such that: picotonne per cubic millimeter = ft/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicMicrometer = new("femtotonne per cubic micrometer"
                                                                   , "ft/μm³"
                                                                   , PicotonnePerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic centimeter defined such that: yoctotonne per cubic decimeter = rt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicCentimeter = new("rontotonne per cubic centimeter"
                                                                   , "rt/cm³"
                                                                   , YoctotonnePerCubicDecimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// picotonne per cubic nanometer defined such that: nanotonne per cubic micrometer = pt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicNanometer = new("picotonne per cubic nanometer"
                                                                 , "pt/nm³"
                                                                 , NanotonnePerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quettatonne per cubic meter defined such that: ronnatonne per cubic meter = Qt/m³ × (1000.0)/((1.0)*(1.0)*(1.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicMeter =
      new("quettatonne per cubic meter", "Qt/m³", RonnatonnePerCubicMeter, 1000.0 / (1.0 * 1.0 * 1.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic ronnameter defined such that: tonne per cubic yottameter = dt/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicRonnameter =
      new("decitonne per cubic ronnameter", "dt/Rm³", TonnePerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic attometer defined such that: millitonne per cubic femtometer = μt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicAttometer = new("microtonne per cubic attometer"
                                                                  , "μt/am³"
                                                                  , MillitonnePerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic millimeter defined such that: attotonne per cubic centimeter = zt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicMillimeter = new("zeptotonne per cubic millimeter"
                                                                   , "zt/mm³"
                                                                   , AttotonnePerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// megatonne per cubic decimeter defined such that: kilotonne per cubic meter = Mt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicDecimeter = new("megatonne per cubic decimeter"
                                                                 , "Mt/dm³"
                                                                 , KilotonnePerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centitonne per cubic kilometer defined such that: decitonne per cubic hectometer = ct/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicKilometer =
      new("centitonne per cubic kilometer", "ct/km³", DecitonnePerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// decitonne per cubic quettameter defined such that: tonne per cubic ronnameter = dt/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DecitonnePerCubicQuettameter =
      new("decitonne per cubic quettameter", "dt/Qm³", TonnePerCubicRonnameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic rontometer defined such that: centitonne per cubic yoctometer = mt/rm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicRontometer = new("millitonne per cubic rontometer"
                                                                   , "mt/rm³"
                                                                   , CentitonnePerCubicYoctometer
                                                                   , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic centimeter defined such that: rontotonne per cubic decimeter = qt/cm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicCentimeter = new("quectotonne per cubic centimeter"
                                                                    , "qt/cm³"
                                                                    , RontotonnePerCubicDecimeter
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// gigatonne per cubic decimeter defined such that: megatonne per cubic meter = Gt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicDecimeter = new("gigatonne per cubic decimeter"
                                                                 , "Gt/dm³"
                                                                 , MegatonnePerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centitonne per cubic megameter defined such that: decitonne per cubic kilometer = ct/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicMegameter =
      new("centitonne per cubic megameter", "ct/Mm³", DecitonnePerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanotonne per cubic femtometer defined such that: microtonne per cubic picometer = nt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicFemtometer = new("nanotonne per cubic femtometer"
                                                                  , "nt/fm³"
                                                                  , MicrotonnePerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic micrometer defined such that: femtotonne per cubic millimeter = at/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicMicrometer = new("attotonne per cubic micrometer"
                                                                  , "at/μm³"
                                                                  , FemtotonnePerCubicMillimeter
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic zeptometer defined such that: millitonne per cubic attometer = μt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicZeptometer = new("microtonne per cubic zeptometer"
                                                                   , "μt/zm³"
                                                                   , MillitonnePerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic millimeter defined such that: zeptotonne per cubic centimeter = yt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicMillimeter = new("yoctotonne per cubic millimeter"
                                                                   , "yt/mm³"
                                                                   , ZeptotonnePerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic centimeter defined such that: tonne per cubic decimeter = dat/cm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicCentimeter = new("dekatonne per cubic centimeter"
                                                                  , "dat/cm³"
                                                                  , TonnePerCubicDecimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic quectometer defined such that: centitonne per cubic rontometer = mt/qm³ ×
   /// (1.0/10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicQuectometer = new("millitonne per cubic quectometer"
                                                                    , "mt/qm³"
                                                                    , CentitonnePerCubicRontometer
                                                                    , 1.0 / 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// picotonne per cubic picometer defined such that: nanotonne per cubic nanometer = pt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicPicometer = new("picotonne per cubic picometer"
                                                                 , "pt/pm³"
                                                                 , NanotonnePerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic nanometer defined such that: picotonne per cubic micrometer = ft/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicNanometer = new("femtotonne per cubic nanometer"
                                                                  , "ft/nm³"
                                                                  , PicotonnePerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teratonne per cubic decimeter defined such that: gigatonne per cubic meter = Tt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicDecimeter = new("teratonne per cubic decimeter"
                                                                 , "Tt/dm³"
                                                                 , GigatonnePerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// centitonne per cubic gigameter defined such that: decitonne per cubic megameter = ct/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicGigameter =
      new("centitonne per cubic gigameter", "ct/Gm³", DecitonnePerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic decimeter defined such that: teratonne per cubic meter = Pt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicDecimeter = new("petatonne per cubic decimeter"
                                                                 , "Pt/dm³"
                                                                 , TeratonnePerCubicMeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectotonne per cubic centimeter defined such that: dekatonne per cubic decimeter = ht/cm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicCentimeter = new("hectotonne per cubic centimeter"
                                                                   , "ht/cm³"
                                                                   , DekatonnePerCubicDecimeter
                                                                   , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// centitonne per cubic terameter defined such that: decitonne per cubic gigameter = ct/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicTerameter =
      new("centitonne per cubic terameter", "ct/Tm³", DecitonnePerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic dekameter defined such that: centitonne per cubic meter = mt/dam³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicDekameter =
      new("millitonne per cubic dekameter", "mt/dam³", CentitonnePerCubicMeter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic yoctometer defined such that: millitonne per cubic zeptometer = μt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicYoctometer = new("microtonne per cubic yoctometer"
                                                                   , "μt/ym³"
                                                                   , MillitonnePerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic attometer defined such that: microtonne per cubic femtometer = nt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicAttometer = new("nanotonne per cubic attometer"
                                                                 , "nt/am³"
                                                                 , MicrotonnePerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic micrometer defined such that: attotonne per cubic millimeter = zt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicMicrometer = new("zeptotonne per cubic micrometer"
                                                                   , "zt/μm³"
                                                                   , AttotonnePerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic millimeter defined such that: yoctotonne per cubic centimeter = rt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicMillimeter = new("rontotonne per cubic millimeter"
                                                                   , "rt/mm³"
                                                                   , YoctotonnePerCubicCentimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic decimeter defined such that: petatonne per cubic meter = Et/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicDecimeter = new("exatonne per cubic decimeter"
                                                                , "Et/dm³"
                                                                , PetatonnePerCubicMeter
                                                                , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// centitonne per cubic petameter defined such that: decitonne per cubic terameter = ct/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicPetameter =
      new("centitonne per cubic petameter", "ct/Pm³", DecitonnePerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picotonne per cubic femtometer defined such that: nanotonne per cubic picometer = pt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicFemtometer = new("picotonne per cubic femtometer"
                                                                  , "pt/fm³"
                                                                  , NanotonnePerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic nanometer defined such that: femtotonne per cubic micrometer = at/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicNanometer = new("attotonne per cubic nanometer"
                                                                 , "at/nm³"
                                                                 , FemtotonnePerCubicMicrometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilotonne per cubic centimeter defined such that: hectotonne per cubic decimeter = kt/cm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicCentimeter = new("kilotonne per cubic centimeter"
                                                                  , "kt/cm³"
                                                                  , HectotonnePerCubicDecimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic hectometer defined such that: centitonne per cubic dekameter = mt/hm³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicHectometer =
      new("millitonne per cubic hectometer", "mt/hm³", CentitonnePerCubicDekameter, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// femtotonne per cubic picometer defined such that: picotonne per cubic nanometer = ft/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicPicometer = new("femtotonne per cubic picometer"
                                                                  , "ft/pm³"
                                                                  , PicotonnePerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic rontometer defined such that: millitonne per cubic yoctometer = μt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicRontometer = new("microtonne per cubic rontometer"
                                                                   , "μt/rm³"
                                                                   , MillitonnePerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic millimeter defined such that: rontotonne per cubic centimeter = qt/mm³ ×
   /// (1.0/1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicMillimeter = new("quectotonne per cubic millimeter"
                                                                    , "qt/mm³"
                                                                    , RontotonnePerCubicCentimeter
                                                                    , 1.0 / 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// zettatonne per cubic decimeter defined such that: exatonne per cubic meter = Zt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicDecimeter = new("zettatonne per cubic decimeter"
                                                                  , "Zt/dm³"
                                                                  , ExatonnePerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic exameter defined such that: decitonne per cubic petameter = ct/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicExameter =
      new("centitonne per cubic exameter", "ct/Em³", DecitonnePerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanotonne per cubic zeptometer defined such that: microtonne per cubic attometer = nt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicZeptometer = new("nanotonne per cubic zeptometer"
                                                                  , "nt/zm³"
                                                                  , MicrotonnePerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic micrometer defined such that: zeptotonne per cubic millimeter = yt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicMicrometer = new("yoctotonne per cubic micrometer"
                                                                   , "yt/μm³"
                                                                   , ZeptotonnePerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// megatonne per cubic centimeter defined such that: kilotonne per cubic decimeter = Mt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicCentimeter = new("megatonne per cubic centimeter"
                                                                  , "Mt/cm³"
                                                                  , KilotonnePerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic kilometer defined such that: centitonne per cubic hectometer = mt/km³ ×
   /// (1.0/10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicKilometer =
      new("millitonne per cubic kilometer", "mt/km³", CentitonnePerCubicHectometer, 1.0 / 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic decimeter defined such that: zettatonne per cubic meter = Yt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicDecimeter = new("yottatonne per cubic decimeter"
                                                                  , "Yt/dm³"
                                                                  , ZettatonnePerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic zettameter defined such that: decitonne per cubic exameter = ct/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicZettameter =
      new("centitonne per cubic zettameter", "ct/Zm³", DecitonnePerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic millimeter defined such that: tonne per cubic centimeter = dat/mm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicMillimeter = new("dekatonne per cubic millimeter"
                                                                  , "dat/mm³"
                                                                  , TonnePerCubicCentimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic quectometer defined such that: millitonne per cubic rontometer = μt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicQuectometer = new("microtonne per cubic quectometer"
                                                                    , "μt/qm³"
                                                                    , MillitonnePerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// picotonne per cubic attometer defined such that: nanotonne per cubic femtometer = pt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicAttometer = new("picotonne per cubic attometer"
                                                                 , "pt/am³"
                                                                 , NanotonnePerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic nanometer defined such that: attotonne per cubic micrometer = zt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicNanometer = new("zeptotonne per cubic nanometer"
                                                                  , "zt/nm³"
                                                                  , AttotonnePerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnatonne per cubic decimeter defined such that: yottatonne per cubic meter = Rt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicDecimeter = new("ronnatonne per cubic decimeter"
                                                                  , "Rt/dm³"
                                                                  , YottatonnePerCubicMeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigatonne per cubic centimeter defined such that: megatonne per cubic decimeter = Gt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicCentimeter = new("gigatonne per cubic centimeter"
                                                                  , "Gt/cm³"
                                                                  , MegatonnePerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic yottameter defined such that: decitonne per cubic zettameter = ct/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicYottameter =
      new("centitonne per cubic yottameter", "ct/Ym³", DecitonnePerCubicZettameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic megameter defined such that: centitonne per cubic kilometer = mt/Mm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicMegameter =
      new("millitonne per cubic megameter", "mt/Mm³", CentitonnePerCubicKilometer, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanotonne per cubic yoctometer defined such that: microtonne per cubic zeptometer = nt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicYoctometer = new("nanotonne per cubic yoctometer"
                                                                  , "nt/ym³"
                                                                  , MicrotonnePerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic femtometer defined such that: picotonne per cubic picometer = ft/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicFemtometer = new("femtotonne per cubic femtometer"
                                                                   , "ft/fm³"
                                                                   , PicotonnePerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic picometer defined such that: femtotonne per cubic nanometer = at/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicPicometer = new("attotonne per cubic picometer"
                                                                 , "at/pm³"
                                                                 , FemtotonnePerCubicNanometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// rontotonne per cubic micrometer defined such that: yoctotonne per cubic millimeter = rt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicMicrometer = new("rontotonne per cubic micrometer"
                                                                   , "rt/μm³"
                                                                   , YoctotonnePerCubicMillimeter
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quettatonne per cubic decimeter defined such that: ronnatonne per cubic meter = Qt/dm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicDecimeter = new("quettatonne per cubic decimeter"
                                                                   , "Qt/dm³"
                                                                   , RonnatonnePerCubicMeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// hectotonne per cubic millimeter defined such that: dekatonne per cubic centimeter = ht/mm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicMillimeter = new("hectotonne per cubic millimeter"
                                                                   , "ht/mm³"
                                                                   , DekatonnePerCubicCentimeter
                                                                   , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// centitonne per cubic ronnameter defined such that: decitonne per cubic yottameter = ct/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicRonnameter =
      new("centitonne per cubic ronnameter", "ct/Rm³", DecitonnePerCubicYottameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic dekameter defined such that: millitonne per cubic meter = μt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicDekameter =
      new("microtonne per cubic dekameter", "μt/dam³", MillitonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic centimeter defined such that: gigatonne per cubic decimeter = Tt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicCentimeter = new("teratonne per cubic centimeter"
                                                                  , "Tt/cm³"
                                                                  , GigatonnePerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic gigameter defined such that: centitonne per cubic megameter = mt/Gm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicGigameter =
      new("millitonne per cubic gigameter", "mt/Gm³", CentitonnePerCubicMegameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// picotonne per cubic zeptometer defined such that: nanotonne per cubic attometer = pt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicZeptometer = new("picotonne per cubic zeptometer"
                                                                  , "pt/zm³"
                                                                  , NanotonnePerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic nanometer defined such that: zeptotonne per cubic micrometer = yt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicNanometer = new("yoctotonne per cubic nanometer"
                                                                  , "yt/nm³"
                                                                  , ZeptotonnePerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// centitonne per cubic quettameter defined such that: decitonne per cubic ronnameter = ct/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density CentitonnePerCubicQuettameter = new("centitonne per cubic quettameter"
                                                                    , "ct/Qm³"
                                                                    , DecitonnePerCubicRonnameter
                                                                    , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// nanotonne per cubic rontometer defined such that: microtonne per cubic yoctometer = nt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicRontometer = new("nanotonne per cubic rontometer"
                                                                  , "nt/rm³"
                                                                  , MicrotonnePerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic micrometer defined such that: rontotonne per cubic millimeter = qt/μm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicMicrometer = new("quectotonne per cubic micrometer"
                                                                    , "qt/μm³"
                                                                    , RontotonnePerCubicMillimeter
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// petatonne per cubic centimeter defined such that: teratonne per cubic decimeter = Pt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicCentimeter = new("petatonne per cubic centimeter"
                                                                  , "Pt/cm³"
                                                                  , TeratonnePerCubicDecimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic millimeter defined such that: hectotonne per cubic centimeter = kt/mm³ ×
   /// (10.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicMillimeter = new("kilotonne per cubic millimeter"
                                                                  , "kt/mm³"
                                                                  , HectotonnePerCubicCentimeter
                                                                  , 10.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic terameter defined such that: centitonne per cubic gigameter = mt/Tm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicTerameter =
      new("millitonne per cubic terameter", "mt/Tm³", CentitonnePerCubicGigameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic hectometer defined such that: millitonne per cubic dekameter = μt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicHectometer =
      new("microtonne per cubic hectometer", "μt/hm³", MillitonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// femtotonne per cubic attometer defined such that: picotonne per cubic femtometer = ft/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicAttometer = new("femtotonne per cubic attometer"
                                                                  , "ft/am³"
                                                                  , PicotonnePerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic picometer defined such that: attotonne per cubic nanometer = zt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicPicometer = new("zeptotonne per cubic picometer"
                                                                  , "zt/pm³"
                                                                  , AttotonnePerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic femtometer defined such that: femtotonne per cubic picometer = at/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicFemtometer = new("attotonne per cubic femtometer"
                                                                  , "at/fm³"
                                                                  , FemtotonnePerCubicPicometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exatonne per cubic centimeter defined such that: petatonne per cubic decimeter = Et/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicCentimeter = new("exatonne per cubic centimeter"
                                                                 , "Et/cm³"
                                                                 , PetatonnePerCubicDecimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekatonne per cubic micrometer defined such that: tonne per cubic millimeter = dat/μm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicMicrometer = new("dekatonne per cubic micrometer"
                                                                  , "dat/μm³"
                                                                  , TonnePerCubicMillimeter
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic petameter defined such that: centitonne per cubic terameter = mt/Pm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicPetameter =
      new("millitonne per cubic petameter", "mt/Pm³", CentitonnePerCubicTerameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// nanotonne per cubic quectometer defined such that: microtonne per cubic rontometer = nt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicQuectometer = new("nanotonne per cubic quectometer"
                                                                   , "nt/qm³"
                                                                   , MicrotonnePerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// picotonne per cubic yoctometer defined such that: nanotonne per cubic zeptometer = pt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicYoctometer = new("picotonne per cubic yoctometer"
                                                                  , "pt/ym³"
                                                                  , NanotonnePerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic nanometer defined such that: yoctotonne per cubic micrometer = rt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicNanometer = new("rontotonne per cubic nanometer"
                                                                  , "rt/nm³"
                                                                  , YoctotonnePerCubicMicrometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic millimeter defined such that: kilotonne per cubic centimeter = Mt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicMillimeter = new("megatonne per cubic millimeter"
                                                                  , "Mt/mm³"
                                                                  , KilotonnePerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic kilometer defined such that: millitonne per cubic hectometer = μt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicKilometer =
      new("microtonne per cubic kilometer", "μt/km³", MillitonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic centimeter defined such that: exatonne per cubic decimeter = Zt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicCentimeter = new("zettatonne per cubic centimeter"
                                                                   , "Zt/cm³"
                                                                   , ExatonnePerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// millitonne per cubic exameter defined such that: centitonne per cubic petameter = mt/Em³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicExameter =
      new("millitonne per cubic exameter", "mt/Em³", CentitonnePerCubicPetameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// femtotonne per cubic zeptometer defined such that: picotonne per cubic attometer = ft/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicZeptometer = new("femtotonne per cubic zeptometer"
                                                                   , "ft/zm³"
                                                                   , PicotonnePerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic picometer defined such that: zeptotonne per cubic nanometer = yt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicPicometer = new("yoctotonne per cubic picometer"
                                                                  , "yt/pm³"
                                                                  , ZeptotonnePerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigatonne per cubic millimeter defined such that: megatonne per cubic centimeter = Gt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicMillimeter = new("gigatonne per cubic millimeter"
                                                                  , "Gt/mm³"
                                                                  , MegatonnePerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// hectotonne per cubic micrometer defined such that: dekatonne per cubic millimeter = ht/μm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicMicrometer = new("hectotonne per cubic micrometer"
                                                                   , "ht/μm³"
                                                                   , DekatonnePerCubicMillimeter
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic megameter defined such that: millitonne per cubic kilometer = μt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicMegameter = new("microtonne per cubic megameter"
                                                                  , "μt/Mm³"
                                                                  , MillitonnePerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic dekameter defined such that: microtonne per cubic meter = nt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicDekameter =
      new("nanotonne per cubic dekameter", "nt/dam³", MicrotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// attotonne per cubic attometer defined such that: femtotonne per cubic femtometer = at/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicAttometer = new("attotonne per cubic attometer"
                                                                 , "at/am³"
                                                                 , FemtotonnePerCubicFemtometer
                                                                 , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic femtometer defined such that: attotonne per cubic picometer = zt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicFemtometer = new("zeptotonne per cubic femtometer"
                                                                   , "zt/fm³"
                                                                   , AttotonnePerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// picotonne per cubic rontometer defined such that: nanotonne per cubic yoctometer = pt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicRontometer = new("picotonne per cubic rontometer"
                                                                  , "pt/rm³"
                                                                  , NanotonnePerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic nanometer defined such that: rontotonne per cubic micrometer = qt/nm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicNanometer = new("quectotonne per cubic nanometer"
                                                                   , "qt/nm³"
                                                                   , RontotonnePerCubicMicrometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yottatonne per cubic centimeter defined such that: zettatonne per cubic decimeter = Yt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicCentimeter = new("yottatonne per cubic centimeter"
                                                                   , "Yt/cm³"
                                                                   , ZettatonnePerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// millitonne per cubic zettameter defined such that: centitonne per cubic exameter = mt/Zm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicZettameter =
      new("millitonne per cubic zettameter", "mt/Zm³", CentitonnePerCubicExameter, 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic millimeter defined such that: gigatonne per cubic centimeter = Tt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicMillimeter = new("teratonne per cubic millimeter"
                                                                  , "Tt/mm³"
                                                                  , GigatonnePerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic gigameter defined such that: millitonne per cubic megameter = μt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicGigameter = new("microtonne per cubic gigameter"
                                                                  , "μt/Gm³"
                                                                  , MillitonnePerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnatonne per cubic centimeter defined such that: yottatonne per cubic decimeter = Rt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicCentimeter = new("ronnatonne per cubic centimeter"
                                                                   , "Rt/cm³"
                                                                   , YottatonnePerCubicDecimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// kilotonne per cubic micrometer defined such that: hectotonne per cubic millimeter = kt/μm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicMicrometer = new("kilotonne per cubic micrometer"
                                                                  , "kt/μm³"
                                                                  , HectotonnePerCubicMillimeter
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic yottameter defined such that: centitonne per cubic zettameter = mt/Ym³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicYottameter = new("millitonne per cubic yottameter"
                                                                   , "mt/Ym³"
                                                                   , CentitonnePerCubicZettameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic hectometer defined such that: microtonne per cubic dekameter = nt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicHectometer =
      new("nanotonne per cubic hectometer", "nt/hm³", MicrotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// femtotonne per cubic yoctometer defined such that: picotonne per cubic zeptometer = ft/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicYoctometer = new("femtotonne per cubic yoctometer"
                                                                   , "ft/ym³"
                                                                   , PicotonnePerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic picometer defined such that: yoctotonne per cubic nanometer = rt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicPicometer = new("rontotonne per cubic picometer"
                                                                  , "rt/pm³"
                                                                  , YoctotonnePerCubicNanometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekatonne per cubic nanometer defined such that: tonne per cubic micrometer = dat/nm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicNanometer = new("dekatonne per cubic nanometer"
                                                                 , "dat/nm³"
                                                                 , TonnePerCubicMicrometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic quectometer defined such that: nanotonne per cubic rontometer = pt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicQuectometer = new("picotonne per cubic quectometer"
                                                                   , "pt/qm³"
                                                                   , NanotonnePerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic zeptometer defined such that: femtotonne per cubic attometer = at/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicZeptometer = new("attotonne per cubic zeptometer"
                                                                  , "at/zm³"
                                                                  , FemtotonnePerCubicAttometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic femtometer defined such that: zeptotonne per cubic picometer = yt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicFemtometer = new("yoctotonne per cubic femtometer"
                                                                   , "yt/fm³"
                                                                   , ZeptotonnePerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quettatonne per cubic centimeter defined such that: ronnatonne per cubic decimeter = Qt/cm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicCentimeter = new("quettatonne per cubic centimeter"
                                                                    , "Qt/cm³"
                                                                    , RonnatonnePerCubicDecimeter
                                                                    , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// petatonne per cubic millimeter defined such that: teratonne per cubic centimeter = Pt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicMillimeter = new("petatonne per cubic millimeter"
                                                                  , "Pt/mm³"
                                                                  , TeratonnePerCubicCentimeter
                                                                  , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// millitonne per cubic ronnameter defined such that: centitonne per cubic yottameter = mt/Rm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicRonnameter = new("millitonne per cubic ronnameter"
                                                                   , "mt/Rm³"
                                                                   , CentitonnePerCubicYottameter
                                                                   , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic terameter defined such that: millitonne per cubic gigameter = μt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicTerameter = new("microtonne per cubic terameter"
                                                                  , "μt/Tm³"
                                                                  , MillitonnePerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic attometer defined such that: attotonne per cubic femtometer = zt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicAttometer = new("zeptotonne per cubic attometer"
                                                                  , "zt/am³"
                                                                  , AttotonnePerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic micrometer defined such that: kilotonne per cubic millimeter = Mt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicMicrometer = new("megatonne per cubic micrometer"
                                                                  , "Mt/μm³"
                                                                  , KilotonnePerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic kilometer defined such that: microtonne per cubic hectometer = nt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicKilometer =
      new("nanotonne per cubic kilometer", "nt/km³", MicrotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// millitonne per cubic quettameter defined such that: centitonne per cubic ronnameter = mt/Qm³ ×
   /// (1.0/10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MillitonnePerCubicQuettameter = new("millitonne per cubic quettameter"
                                                                    , "mt/Qm³"
                                                                    , CentitonnePerCubicRonnameter
                                                                    , 1.0 / 10.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// femtotonne per cubic rontometer defined such that: picotonne per cubic yoctometer = ft/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicRontometer = new("femtotonne per cubic rontometer"
                                                                   , "ft/rm³"
                                                                   , PicotonnePerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic picometer defined such that: rontotonne per cubic nanometer = qt/pm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicPicometer = new("quectotonne per cubic picometer"
                                                                   , "qt/pm³"
                                                                   , RontotonnePerCubicNanometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic millimeter defined such that: petatonne per cubic centimeter = Et/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicMillimeter = new("exatonne per cubic millimeter"
                                                                 , "Et/mm³"
                                                                 , PetatonnePerCubicCentimeter
                                                                 , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectotonne per cubic nanometer defined such that: dekatonne per cubic micrometer = ht/nm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicNanometer = new("hectotonne per cubic nanometer"
                                                                  , "ht/nm³"
                                                                  , DekatonnePerCubicMicrometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic petameter defined such that: millitonne per cubic terameter = μt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicPetameter = new("microtonne per cubic petameter"
                                                                  , "μt/Pm³"
                                                                  , MillitonnePerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic dekameter defined such that: nanotonne per cubic meter = pt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicDekameter =
      new("picotonne per cubic dekameter", "pt/dam³", NanotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic micrometer defined such that: megatonne per cubic millimeter = Gt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicMicrometer = new("gigatonne per cubic micrometer"
                                                                  , "Gt/μm³"
                                                                  , MegatonnePerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic megameter defined such that: microtonne per cubic kilometer = nt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicMegameter = new("nanotonne per cubic megameter"
                                                                 , "nt/Mm³"
                                                                 , MicrotonnePerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attotonne per cubic yoctometer defined such that: femtotonne per cubic zeptometer = at/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicYoctometer = new("attotonne per cubic yoctometer"
                                                                  , "at/ym³"
                                                                  , FemtotonnePerCubicZeptometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic femtometer defined such that: yoctotonne per cubic picometer = rt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicFemtometer = new("rontotonne per cubic femtometer"
                                                                   , "rt/fm³"
                                                                   , YoctotonnePerCubicPicometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zettatonne per cubic millimeter defined such that: exatonne per cubic centimeter = Zt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicMillimeter = new("zettatonne per cubic millimeter"
                                                                   , "Zt/mm³"
                                                                   , ExatonnePerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic exameter defined such that: millitonne per cubic petameter = μt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicExameter = new("microtonne per cubic exameter"
                                                                 , "μt/Em³"
                                                                 , MillitonnePerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic zeptometer defined such that: attotonne per cubic attometer = zt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicZeptometer = new("zeptotonne per cubic zeptometer"
                                                                   , "zt/zm³"
                                                                   , AttotonnePerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic attometer defined such that: zeptotonne per cubic femtometer = yt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicAttometer = new("yoctotonne per cubic attometer"
                                                                  , "yt/am³"
                                                                  , ZeptotonnePerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic nanometer defined such that: hectotonne per cubic micrometer = kt/nm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicNanometer = new("kilotonne per cubic nanometer"
                                                                 , "kt/nm³"
                                                                 , HectotonnePerCubicMicrometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekatonne per cubic picometer defined such that: tonne per cubic nanometer = dat/pm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicPicometer = new("dekatonne per cubic picometer"
                                                                 , "dat/pm³"
                                                                 , TonnePerCubicNanometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic hectometer defined such that: nanotonne per cubic dekameter = pt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicHectometer =
      new("picotonne per cubic hectometer", "pt/hm³", NanotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// femtotonne per cubic quectometer defined such that: picotonne per cubic rontometer = ft/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicQuectometer = new("femtotonne per cubic quectometer"
                                                                    , "ft/qm³"
                                                                    , PicotonnePerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// teratonne per cubic micrometer defined such that: gigatonne per cubic millimeter = Tt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicMicrometer = new("teratonne per cubic micrometer"
                                                                  , "Tt/μm³"
                                                                  , GigatonnePerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic gigameter defined such that: microtonne per cubic megameter = nt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicGigameter = new("nanotonne per cubic gigameter"
                                                                 , "nt/Gm³"
                                                                 , MicrotonnePerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yottatonne per cubic millimeter defined such that: zettatonne per cubic centimeter = Yt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicMillimeter = new("yottatonne per cubic millimeter"
                                                                   , "Yt/mm³"
                                                                   , ZettatonnePerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// microtonne per cubic zettameter defined such that: millitonne per cubic exameter = μt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicZettameter = new("microtonne per cubic zettameter"
                                                                   , "μt/Zm³"
                                                                   , MillitonnePerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic rontometer defined such that: femtotonne per cubic yoctometer = at/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicRontometer = new("attotonne per cubic rontometer"
                                                                  , "at/rm³"
                                                                  , FemtotonnePerCubicYoctometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic femtometer defined such that: rontotonne per cubic picometer = qt/fm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicFemtometer = new("quectotonne per cubic femtometer"
                                                                    , "qt/fm³"
                                                                    , RontotonnePerCubicPicometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// megatonne per cubic nanometer defined such that: kilotonne per cubic micrometer = Mt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicNanometer = new("megatonne per cubic nanometer"
                                                                 , "Mt/nm³"
                                                                 , KilotonnePerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic kilometer defined such that: nanotonne per cubic hectometer = pt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicKilometer =
      new("picotonne per cubic kilometer", "pt/km³", NanotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic millimeter defined such that: yottatonne per cubic centimeter = Rt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicMillimeter = new("ronnatonne per cubic millimeter"
                                                                   , "Rt/mm³"
                                                                   , YottatonnePerCubicCentimeter
                                                                   , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petatonne per cubic micrometer defined such that: teratonne per cubic millimeter = Pt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicMicrometer = new("petatonne per cubic micrometer"
                                                                  , "Pt/μm³"
                                                                  , TeratonnePerCubicMillimeter
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// hectotonne per cubic picometer defined such that: dekatonne per cubic nanometer = ht/pm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicPicometer = new("hectotonne per cubic picometer"
                                                                  , "ht/pm³"
                                                                  , DekatonnePerCubicNanometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// microtonne per cubic yottameter defined such that: millitonne per cubic zettameter = μt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicYottameter = new("microtonne per cubic yottameter"
                                                                   , "μt/Ym³"
                                                                   , MillitonnePerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic terameter defined such that: microtonne per cubic gigameter = nt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicTerameter = new("nanotonne per cubic terameter"
                                                                 , "nt/Tm³"
                                                                 , MicrotonnePerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic dekameter defined such that: picotonne per cubic meter = ft/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicDekameter =
      new("femtotonne per cubic dekameter", "ft/dam³", PicotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zeptotonne per cubic yoctometer defined such that: attotonne per cubic zeptometer = zt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicYoctometer = new("zeptotonne per cubic yoctometer"
                                                                   , "zt/ym³"
                                                                   , AttotonnePerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic attometer defined such that: yoctotonne per cubic femtometer = rt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicAttometer = new("rontotonne per cubic attometer"
                                                                  , "rt/am³"
                                                                  , YoctotonnePerCubicFemtometer
                                                                  , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic zeptometer defined such that: zeptotonne per cubic attometer = yt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicZeptometer = new("yoctotonne per cubic zeptometer"
                                                                   , "yt/zm³"
                                                                   , ZeptotonnePerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quettatonne per cubic millimeter defined such that: ronnatonne per cubic centimeter = Qt/mm³ ×
   /// (1000.0)/((1.0/10.0)*(1.0/10.0)*(1.0/10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicMillimeter = new("quettatonne per cubic millimeter"
                                                                    , "Qt/mm³"
                                                                    , RonnatonnePerCubicCentimeter
                                                                    , 1000.0 / (1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// microtonne per cubic ronnameter defined such that: millitonne per cubic yottameter = μt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicRonnameter = new("microtonne per cubic ronnameter"
                                                                   , "μt/Rm³"
                                                                   , MillitonnePerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic micrometer defined such that: petatonne per cubic millimeter = Et/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicMicrometer = new("exatonne per cubic micrometer"
                                                                 , "Et/μm³"
                                                                 , PetatonnePerCubicMillimeter
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigatonne per cubic nanometer defined such that: megatonne per cubic micrometer = Gt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicNanometer = new("gigatonne per cubic nanometer"
                                                                 , "Gt/nm³"
                                                                 , MegatonnePerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekatonne per cubic femtometer defined such that: tonne per cubic picometer = dat/fm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicFemtometer = new("dekatonne per cubic femtometer"
                                                                  , "dat/fm³"
                                                                  , TonnePerCubicPicometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic petameter defined such that: microtonne per cubic terameter = nt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicPetameter = new("nanotonne per cubic petameter"
                                                                 , "nt/Pm³"
                                                                 , MicrotonnePerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic megameter defined such that: nanotonne per cubic kilometer = pt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicMegameter = new("picotonne per cubic megameter"
                                                                 , "pt/Mm³"
                                                                 , NanotonnePerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attotonne per cubic quectometer defined such that: femtotonne per cubic rontometer = at/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicQuectometer = new("attotonne per cubic quectometer"
                                                                   , "at/qm³"
                                                                   , FemtotonnePerCubicRontometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// kilotonne per cubic picometer defined such that: hectotonne per cubic nanometer = kt/pm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicPicometer = new("kilotonne per cubic picometer"
                                                                 , "kt/pm³"
                                                                 , HectotonnePerCubicNanometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic hectometer defined such that: picotonne per cubic dekameter = ft/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicHectometer =
      new("femtotonne per cubic hectometer", "ft/hm³", PicotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// microtonne per cubic quettameter defined such that: millitonne per cubic ronnameter = μt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MicrotonnePerCubicQuettameter = new("microtonne per cubic quettameter"
                                                                    , "μt/Qm³"
                                                                    , MillitonnePerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// zeptotonne per cubic rontometer defined such that: attotonne per cubic yoctometer = zt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicRontometer = new("zeptotonne per cubic rontometer"
                                                                   , "zt/rm³"
                                                                   , AttotonnePerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic attometer defined such that: rontotonne per cubic femtometer = qt/am³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicAttometer = new("quectotonne per cubic attometer"
                                                                   , "qt/am³"
                                                                   , RontotonnePerCubicFemtometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zettatonne per cubic micrometer defined such that: exatonne per cubic millimeter = Zt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicMicrometer = new("zettatonne per cubic micrometer"
                                                                   , "Zt/μm³"
                                                                   , ExatonnePerCubicMillimeter
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic exameter defined such that: microtonne per cubic petameter = nt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicExameter = new("nanotonne per cubic exameter"
                                                                , "nt/Em³"
                                                                , MicrotonnePerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctotonne per cubic yoctometer defined such that: zeptotonne per cubic zeptometer = yt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicYoctometer = new("yoctotonne per cubic yoctometer"
                                                                   , "yt/ym³"
                                                                   , ZeptotonnePerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic zeptometer defined such that: yoctotonne per cubic attometer = rt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicZeptometer = new("rontotonne per cubic zeptometer"
                                                                   , "rt/zm³"
                                                                   , YoctotonnePerCubicAttometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// teratonne per cubic nanometer defined such that: gigatonne per cubic micrometer = Tt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicNanometer = new("teratonne per cubic nanometer"
                                                                 , "Tt/nm³"
                                                                 , GigatonnePerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic gigameter defined such that: nanotonne per cubic megameter = pt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicGigameter = new("picotonne per cubic gigameter"
                                                                 , "pt/Gm³"
                                                                 , NanotonnePerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectotonne per cubic femtometer defined such that: dekatonne per cubic picometer = ht/fm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicFemtometer = new("hectotonne per cubic femtometer"
                                                                   , "ht/fm³"
                                                                   , DekatonnePerCubicPicometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic dekameter defined such that: femtotonne per cubic meter = at/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicDekameter =
      new("attotonne per cubic dekameter", "at/dam³", FemtotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic picometer defined such that: kilotonne per cubic nanometer = Mt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicPicometer = new("megatonne per cubic picometer"
                                                                 , "Mt/pm³"
                                                                 , KilotonnePerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic kilometer defined such that: picotonne per cubic hectometer = ft/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicKilometer =
      new("femtotonne per cubic kilometer", "ft/km³", PicotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic micrometer defined such that: zettatonne per cubic millimeter = Yt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicMicrometer = new("yottatonne per cubic micrometer"
                                                                   , "Yt/μm³"
                                                                   , ZettatonnePerCubicMillimeter
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// nanotonne per cubic zettameter defined such that: microtonne per cubic exameter = nt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicZettameter = new("nanotonne per cubic zettameter"
                                                                  , "nt/Zm³"
                                                                  , MicrotonnePerCubicExameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petatonne per cubic nanometer defined such that: teratonne per cubic micrometer = Pt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicNanometer = new("petatonne per cubic nanometer"
                                                                 , "Pt/nm³"
                                                                 , TeratonnePerCubicMicrometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// dekatonne per cubic attometer defined such that: tonne per cubic femtometer = dat/am³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicAttometer = new("dekatonne per cubic attometer"
                                                                 , "dat/am³"
                                                                 , TonnePerCubicFemtometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// picotonne per cubic terameter defined such that: nanotonne per cubic gigameter = pt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicTerameter = new("picotonne per cubic terameter"
                                                                 , "pt/Tm³"
                                                                 , NanotonnePerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic quectometer defined such that: attotonne per cubic rontometer = zt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicQuectometer = new("zeptotonne per cubic quectometer"
                                                                    , "zt/qm³"
                                                                    , AttotonnePerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// yoctotonne per cubic rontometer defined such that: zeptotonne per cubic yoctometer = yt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicRontometer = new("yoctotonne per cubic rontometer"
                                                                   , "yt/rm³"
                                                                   , ZeptotonnePerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic zeptometer defined such that: rontotonne per cubic attometer = qt/zm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicZeptometer = new("quectotonne per cubic zeptometer"
                                                                    , "qt/zm³"
                                                                    , RontotonnePerCubicAttometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// ronnatonne per cubic micrometer defined such that: yottatonne per cubic millimeter = Rt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicMicrometer = new("ronnatonne per cubic micrometer"
                                                                   , "Rt/μm³"
                                                                   , YottatonnePerCubicMillimeter
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// gigatonne per cubic picometer defined such that: megatonne per cubic nanometer = Gt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicPicometer = new("gigatonne per cubic picometer"
                                                                 , "Gt/pm³"
                                                                 , MegatonnePerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilotonne per cubic femtometer defined such that: hectotonne per cubic picometer = kt/fm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicFemtometer = new("kilotonne per cubic femtometer"
                                                                  , "kt/fm³"
                                                                  , HectotonnePerCubicPicometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic yottameter defined such that: microtonne per cubic zettameter = nt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicYottameter = new("nanotonne per cubic yottameter"
                                                                  , "nt/Ym³"
                                                                  , MicrotonnePerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic megameter defined such that: picotonne per cubic kilometer = ft/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicMegameter = new("femtotonne per cubic megameter"
                                                                  , "ft/Mm³"
                                                                  , PicotonnePerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic hectometer defined such that: femtotonne per cubic dekameter = at/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicHectometer =
      new("attotonne per cubic hectometer", "at/hm³", FemtotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// rontotonne per cubic yoctometer defined such that: yoctotonne per cubic zeptometer = rt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicYoctometer = new("rontotonne per cubic yoctometer"
                                                                   , "rt/ym³"
                                                                   , YoctotonnePerCubicZeptometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic nanometer defined such that: petatonne per cubic micrometer = Et/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicNanometer = new("exatonne per cubic nanometer"
                                                                , "Et/nm³"
                                                                , PetatonnePerCubicMicrometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// picotonne per cubic petameter defined such that: nanotonne per cubic terameter = pt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicPetameter = new("picotonne per cubic petameter"
                                                                 , "pt/Pm³"
                                                                 , NanotonnePerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quettatonne per cubic micrometer defined such that: ronnatonne per cubic millimeter = Qt/μm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicMicrometer = new("quettatonne per cubic micrometer"
                                                                    , "Qt/μm³"
                                                                    , RonnatonnePerCubicMillimeter
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// hectotonne per cubic attometer defined such that: dekatonne per cubic femtometer = ht/am³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicAttometer = new("hectotonne per cubic attometer"
                                                                  , "ht/am³"
                                                                  , DekatonnePerCubicFemtometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// nanotonne per cubic ronnameter defined such that: microtonne per cubic yottameter = nt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicRonnameter = new("nanotonne per cubic ronnameter"
                                                                  , "nt/Rm³"
                                                                  , MicrotonnePerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic dekameter defined such that: attotonne per cubic meter = zt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicDekameter =
      new("zeptotonne per cubic dekameter", "zt/dam³", AttotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic picometer defined such that: gigatonne per cubic nanometer = Tt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicPicometer = new("teratonne per cubic picometer"
                                                                 , "Tt/pm³"
                                                                 , GigatonnePerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic gigameter defined such that: picotonne per cubic megameter = ft/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicGigameter = new("femtotonne per cubic gigameter"
                                                                  , "ft/Gm³"
                                                                  , PicotonnePerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic femtometer defined such that: kilotonne per cubic picometer = Mt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicFemtometer = new("megatonne per cubic femtometer"
                                                                  , "Mt/fm³"
                                                                  , KilotonnePerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic kilometer defined such that: femtotonne per cubic hectometer = at/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicKilometer =
      new("attotonne per cubic kilometer", "at/km³", FemtotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic nanometer defined such that: exatonne per cubic micrometer = Zt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicNanometer = new("zettatonne per cubic nanometer"
                                                                  , "Zt/nm³"
                                                                  , ExatonnePerCubicMicrometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekatonne per cubic zeptometer defined such that: tonne per cubic attometer = dat/zm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicZeptometer = new("dekatonne per cubic zeptometer"
                                                                  , "dat/zm³"
                                                                  , TonnePerCubicAttometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic exameter defined such that: nanotonne per cubic petameter = pt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicExameter = new("picotonne per cubic exameter"
                                                                , "pt/Em³"
                                                                , NanotonnePerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctotonne per cubic quectometer defined such that: zeptotonne per cubic rontometer = yt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicQuectometer = new("yoctotonne per cubic quectometer"
                                                                    , "yt/qm³"
                                                                    , ZeptotonnePerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// nanotonne per cubic quettameter defined such that: microtonne per cubic ronnameter = nt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density NanotonnePerCubicQuettameter = new("nanotonne per cubic quettameter"
                                                                   , "nt/Qm³"
                                                                   , MicrotonnePerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic rontometer defined such that: yoctotonne per cubic yoctometer = rt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicRontometer = new("rontotonne per cubic rontometer"
                                                                   , "rt/rm³"
                                                                   , YoctotonnePerCubicYoctometer
                                                                   , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic yoctometer defined such that: rontotonne per cubic zeptometer = qt/ym³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicYoctometer = new("quectotonne per cubic yoctometer"
                                                                    , "qt/ym³"
                                                                    , RontotonnePerCubicZeptometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// petatonne per cubic picometer defined such that: teratonne per cubic nanometer = Pt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicPicometer = new("petatonne per cubic picometer"
                                                                 , "Pt/pm³"
                                                                 , TeratonnePerCubicNanometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// kilotonne per cubic attometer defined such that: hectotonne per cubic femtometer = kt/am³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicAttometer = new("kilotonne per cubic attometer"
                                                                 , "kt/am³"
                                                                 , HectotonnePerCubicFemtometer
                                                                 , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic terameter defined such that: picotonne per cubic gigameter = ft/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicTerameter = new("femtotonne per cubic terameter"
                                                                  , "ft/Tm³"
                                                                  , PicotonnePerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic hectometer defined such that: attotonne per cubic dekameter = zt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicHectometer =
      new("zeptotonne per cubic hectometer", "zt/hm³", AttotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic nanometer defined such that: zettatonne per cubic micrometer = Yt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicNanometer = new("yottatonne per cubic nanometer"
                                                                  , "Yt/nm³"
                                                                  , ZettatonnePerCubicMicrometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic zettameter defined such that: nanotonne per cubic exameter = pt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicZettameter =
      new("picotonne per cubic zettameter", "pt/Zm³", NanotonnePerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic femtometer defined such that: megatonne per cubic picometer = Gt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicFemtometer = new("gigatonne per cubic femtometer"
                                                                  , "Gt/fm³"
                                                                  , MegatonnePerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic megameter defined such that: femtotonne per cubic kilometer = at/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicMegameter = new("attotonne per cubic megameter"
                                                                 , "at/Mm³"
                                                                 , FemtotonnePerCubicKilometer
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectotonne per cubic zeptometer defined such that: dekatonne per cubic attometer = ht/zm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicZeptometer = new("hectotonne per cubic zeptometer"
                                                                   , "ht/zm³"
                                                                   , DekatonnePerCubicAttometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic dekameter defined such that: zeptotonne per cubic meter = yt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicDekameter =
      new("yoctotonne per cubic dekameter", "yt/dam³", ZeptotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic nanometer defined such that: yottatonne per cubic micrometer = Rt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicNanometer = new("ronnatonne per cubic nanometer"
                                                                  , "Rt/nm³"
                                                                  , YottatonnePerCubicMicrometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exatonne per cubic picometer defined such that: petatonne per cubic nanometer = Et/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicPicometer = new("exatonne per cubic picometer"
                                                                , "Et/pm³"
                                                                , PetatonnePerCubicNanometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// dekatonne per cubic yoctometer defined such that: tonne per cubic zeptometer = dat/ym³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicYoctometer = new("dekatonne per cubic yoctometer"
                                                                  , "dat/ym³"
                                                                  , TonnePerCubicZeptometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic yottameter defined such that: nanotonne per cubic zettameter = pt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicYottameter = new("picotonne per cubic yottameter"
                                                                  , "pt/Ym³"
                                                                  , NanotonnePerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic petameter defined such that: picotonne per cubic terameter = ft/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicPetameter = new("femtotonne per cubic petameter"
                                                                  , "ft/Pm³"
                                                                  , PicotonnePerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic quectometer defined such that: yoctotonne per cubic rontometer = rt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicQuectometer = new("rontotonne per cubic quectometer"
                                                                    , "rt/qm³"
                                                                    , YoctotonnePerCubicRontometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic rontometer defined such that: rontotonne per cubic yoctometer = qt/rm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicRontometer = new("quectotonne per cubic rontometer"
                                                                    , "qt/rm³"
                                                                    , RontotonnePerCubicYoctometer
                                                                    , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// megatonne per cubic attometer defined such that: kilotonne per cubic femtometer = Mt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicAttometer = new("megatonne per cubic attometer"
                                                                 , "Mt/am³"
                                                                 , KilotonnePerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic kilometer defined such that: attotonne per cubic hectometer = zt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicKilometer =
      new("zeptotonne per cubic kilometer", "zt/km³", AttotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic femtometer defined such that: gigatonne per cubic picometer = Tt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicFemtometer = new("teratonne per cubic femtometer"
                                                                  , "Tt/fm³"
                                                                  , GigatonnePerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic gigameter defined such that: femtotonne per cubic megameter = at/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicGigameter = new("attotonne per cubic gigameter"
                                                                 , "at/Gm³"
                                                                 , FemtotonnePerCubicMegameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quettatonne per cubic nanometer defined such that: ronnatonne per cubic micrometer = Qt/nm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicNanometer = new("quettatonne per cubic nanometer"
                                                                   , "Qt/nm³"
                                                                   , RonnatonnePerCubicMicrometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// picotonne per cubic ronnameter defined such that: nanotonne per cubic yottameter = pt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicRonnameter = new("picotonne per cubic ronnameter"
                                                                  , "pt/Rm³"
                                                                  , NanotonnePerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettatonne per cubic picometer defined such that: exatonne per cubic nanometer = Zt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicPicometer = new("zettatonne per cubic picometer"
                                                                  , "Zt/pm³"
                                                                  , ExatonnePerCubicNanometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic zeptometer defined such that: hectotonne per cubic attometer = kt/zm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicZeptometer = new("kilotonne per cubic zeptometer"
                                                                  , "kt/zm³"
                                                                  , HectotonnePerCubicAttometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic exameter defined such that: picotonne per cubic petameter = ft/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicExameter = new("femtotonne per cubic exameter"
                                                                 , "ft/Em³"
                                                                 , PicotonnePerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yoctotonne per cubic hectometer defined such that: zeptotonne per cubic dekameter = yt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicHectometer =
      new("yoctotonne per cubic hectometer", "yt/hm³", ZeptotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic femtometer defined such that: teratonne per cubic picometer = Pt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicFemtometer = new("petatonne per cubic femtometer"
                                                                  , "Pt/fm³"
                                                                  , TeratonnePerCubicPicometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigatonne per cubic attometer defined such that: megatonne per cubic femtometer = Gt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicAttometer = new("gigatonne per cubic attometer"
                                                                 , "Gt/am³"
                                                                 , MegatonnePerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// hectotonne per cubic yoctometer defined such that: dekatonne per cubic zeptometer = ht/ym³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicYoctometer = new("hectotonne per cubic yoctometer"
                                                                   , "ht/ym³"
                                                                   , DekatonnePerCubicZeptometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic terameter defined such that: femtotonne per cubic gigameter = at/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicTerameter = new("attotonne per cubic terameter"
                                                                 , "at/Tm³"
                                                                 , FemtotonnePerCubicGigameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic megameter defined such that: attotonne per cubic kilometer = zt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicMegameter = new("zeptotonne per cubic megameter"
                                                                  , "zt/Mm³"
                                                                  , AttotonnePerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic dekameter defined such that: yoctotonne per cubic meter = rt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicDekameter =
      new("rontotonne per cubic dekameter", "rt/dam³", YoctotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic rontometer defined such that: tonne per cubic yoctometer = dat/rm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicRontometer = new("dekatonne per cubic rontometer"
                                                                  , "dat/rm³"
                                                                  , TonnePerCubicYoctometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// picotonne per cubic quettameter defined such that: nanotonne per cubic ronnameter = pt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PicotonnePerCubicQuettameter = new("picotonne per cubic quettameter"
                                                                   , "pt/Qm³"
                                                                   , NanotonnePerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic quectometer defined such that: rontotonne per cubic rontometer = qt/qm³ ×
   /// (1.0/1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicQuectometer = new("quectotonne per cubic quectometer"
                                                                     , "qt/qm³"
                                                                     , RontotonnePerCubicRontometer
                                                                     , 1.0 / 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                     , system: "SI"
                                                                      );
   
   /// <summary>
   /// yottatonne per cubic picometer defined such that: zettatonne per cubic nanometer = Yt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicPicometer = new("yottatonne per cubic picometer"
                                                                  , "Yt/pm³"
                                                                  , ZettatonnePerCubicNanometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic zettameter defined such that: picotonne per cubic exameter = ft/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicZettameter =
      new("femtotonne per cubic zettameter", "ft/Zm³", PicotonnePerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic zeptometer defined such that: kilotonne per cubic attometer = Mt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicZeptometer = new("megatonne per cubic zeptometer"
                                                                  , "Mt/zm³"
                                                                  , KilotonnePerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic kilometer defined such that: zeptotonne per cubic hectometer = yt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicKilometer =
      new("yoctotonne per cubic kilometer", "yt/km³", ZeptotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic femtometer defined such that: petatonne per cubic picometer = Et/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicFemtometer = new("exatonne per cubic femtometer"
                                                                 , "Et/fm³"
                                                                 , PetatonnePerCubicPicometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// attotonne per cubic petameter defined such that: femtotonne per cubic terameter = at/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicPetameter = new("attotonne per cubic petameter"
                                                                 , "at/Pm³"
                                                                 , FemtotonnePerCubicTerameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teratonne per cubic attometer defined such that: gigatonne per cubic femtometer = Tt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicAttometer = new("teratonne per cubic attometer"
                                                                 , "Tt/am³"
                                                                 , GigatonnePerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// zeptotonne per cubic gigameter defined such that: attotonne per cubic megameter = zt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicGigameter = new("zeptotonne per cubic gigameter"
                                                                  , "zt/Gm³"
                                                                  , AttotonnePerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnatonne per cubic picometer defined such that: yottatonne per cubic nanometer = Rt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicPicometer = new("ronnatonne per cubic picometer"
                                                                  , "Rt/pm³"
                                                                  , YottatonnePerCubicNanometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic yoctometer defined such that: hectotonne per cubic zeptometer = kt/ym³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicYoctometer = new("kilotonne per cubic yoctometer"
                                                                  , "kt/ym³"
                                                                  , HectotonnePerCubicZeptometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic yottameter defined such that: picotonne per cubic zettameter = ft/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicYottameter = new("femtotonne per cubic yottameter"
                                                                   , "ft/Ym³"
                                                                   , PicotonnePerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic hectometer defined such that: yoctotonne per cubic dekameter = rt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicHectometer =
      new("rontotonne per cubic hectometer", "rt/hm³", YoctotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic rontometer defined such that: dekatonne per cubic yoctometer = ht/rm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicRontometer = new("hectotonne per cubic rontometer"
                                                                   , "ht/rm³"
                                                                   , DekatonnePerCubicYoctometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic dekameter defined such that: rontotonne per cubic meter = qt/dam³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicDekameter =
      new("quectotonne per cubic dekameter", "qt/dam³", RontotonnePerCubicMeter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic quectometer defined such that: tonne per cubic rontometer = dat/qm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicQuectometer = new("dekatonne per cubic quectometer"
                                                                   , "dat/qm³"
                                                                   , TonnePerCubicRontometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zettatonne per cubic femtometer defined such that: exatonne per cubic picometer = Zt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicFemtometer = new("zettatonne per cubic femtometer"
                                                                   , "Zt/fm³"
                                                                   , ExatonnePerCubicPicometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// gigatonne per cubic zeptometer defined such that: megatonne per cubic attometer = Gt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicZeptometer = new("gigatonne per cubic zeptometer"
                                                                  , "Gt/zm³"
                                                                  , MegatonnePerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic exameter defined such that: femtotonne per cubic petameter = at/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicExameter = new("attotonne per cubic exameter"
                                                                , "at/Em³"
                                                                , FemtotonnePerCubicPetameter
                                                                , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// yoctotonne per cubic megameter defined such that: zeptotonne per cubic kilometer = yt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicMegameter = new("yoctotonne per cubic megameter"
                                                                  , "yt/Mm³"
                                                                  , ZeptotonnePerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quettatonne per cubic picometer defined such that: ronnatonne per cubic nanometer = Qt/pm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicPicometer = new("quettatonne per cubic picometer"
                                                                   , "Qt/pm³"
                                                                   , RonnatonnePerCubicNanometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petatonne per cubic attometer defined such that: teratonne per cubic femtometer = Pt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicAttometer = new("petatonne per cubic attometer"
                                                                 , "Pt/am³"
                                                                 , TeratonnePerCubicFemtometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// femtotonne per cubic ronnameter defined such that: picotonne per cubic yottameter = ft/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicRonnameter = new("femtotonne per cubic ronnameter"
                                                                   , "ft/Rm³"
                                                                   , PicotonnePerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptotonne per cubic terameter defined such that: attotonne per cubic gigameter = zt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicTerameter = new("zeptotonne per cubic terameter"
                                                                  , "zt/Tm³"
                                                                  , AttotonnePerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic yoctometer defined such that: kilotonne per cubic zeptometer = Mt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicYoctometer = new("megatonne per cubic yoctometer"
                                                                  , "Mt/ym³"
                                                                  , KilotonnePerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic kilometer defined such that: yoctotonne per cubic hectometer = rt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicKilometer =
      new("rontotonne per cubic kilometer", "rt/km³", YoctotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic femtometer defined such that: zettatonne per cubic picometer = Yt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicFemtometer = new("yottatonne per cubic femtometer"
                                                                   , "Yt/fm³"
                                                                   , ZettatonnePerCubicPicometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// attotonne per cubic zettameter defined such that: femtotonne per cubic exameter = at/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicZettameter = new("attotonne per cubic zettameter"
                                                                  , "at/Zm³"
                                                                  , FemtotonnePerCubicExameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic rontometer defined such that: hectotonne per cubic yoctometer = kt/rm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicRontometer = new("kilotonne per cubic rontometer"
                                                                  , "kt/rm³"
                                                                  , HectotonnePerCubicYoctometer
                                                                  , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// femtotonne per cubic quettameter defined such that: picotonne per cubic ronnameter = ft/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density FemtotonnePerCubicQuettameter = new("femtotonne per cubic quettameter"
                                                                    , "ft/Qm³"
                                                                    , PicotonnePerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic hectometer defined such that: rontotonne per cubic dekameter = qt/hm³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicHectometer =
      new("quectotonne per cubic hectometer", "qt/hm³", RontotonnePerCubicDekameter, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic zeptometer defined such that: gigatonne per cubic attometer = Tt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicZeptometer = new("teratonne per cubic zeptometer"
                                                                  , "Tt/zm³"
                                                                  , GigatonnePerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yoctotonne per cubic gigameter defined such that: zeptotonne per cubic megameter = yt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicGigameter = new("yoctotonne per cubic gigameter"
                                                                  , "yt/Gm³"
                                                                  , ZeptotonnePerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// exatonne per cubic attometer defined such that: petatonne per cubic femtometer = Et/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicAttometer = new("exatonne per cubic attometer"
                                                                , "Et/am³"
                                                                , PetatonnePerCubicFemtometer
                                                                , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                , system: "SI"
                                                                 );
   
   /// <summary>
   /// hectotonne per cubic quectometer defined such that: dekatonne per cubic rontometer = ht/qm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicQuectometer = new("hectotonne per cubic quectometer"
                                                                    , "ht/qm³"
                                                                    , DekatonnePerCubicRontometer
                                                                    , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// dekatonne per cubic dekameter defined such that: tonne per cubic meter = dat/dam³ × (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicDekameter =
      new("dekatonne per cubic dekameter", "dat/dam³", TonnePerCubicMeter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zeptotonne per cubic petameter defined such that: attotonne per cubic terameter = zt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicPetameter = new("zeptotonne per cubic petameter"
                                                                  , "zt/Pm³"
                                                                  , AttotonnePerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnatonne per cubic femtometer defined such that: yottatonne per cubic picometer = Rt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicFemtometer = new("ronnatonne per cubic femtometer"
                                                                   , "Rt/fm³"
                                                                   , YottatonnePerCubicPicometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// gigatonne per cubic yoctometer defined such that: megatonne per cubic zeptometer = Gt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicYoctometer = new("gigatonne per cubic yoctometer"
                                                                  , "Gt/ym³"
                                                                  , MegatonnePerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic yottameter defined such that: femtotonne per cubic zettameter = at/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicYottameter = new("attotonne per cubic yottameter"
                                                                  , "at/Ym³"
                                                                  , FemtotonnePerCubicZettameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic megameter defined such that: yoctotonne per cubic kilometer = rt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicMegameter = new("rontotonne per cubic megameter"
                                                                  , "rt/Mm³"
                                                                  , YoctotonnePerCubicKilometer
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettatonne per cubic attometer defined such that: exatonne per cubic femtometer = Zt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicAttometer = new("zettatonne per cubic attometer"
                                                                  , "Zt/am³"
                                                                  , ExatonnePerCubicFemtometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petatonne per cubic zeptometer defined such that: teratonne per cubic attometer = Pt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicZeptometer = new("petatonne per cubic zeptometer"
                                                                  , "Pt/zm³"
                                                                  , TeratonnePerCubicAttometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic exameter defined such that: attotonne per cubic petameter = zt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicExameter = new("zeptotonne per cubic exameter"
                                                                 , "zt/Em³"
                                                                 , AttotonnePerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yoctotonne per cubic terameter defined such that: zeptotonne per cubic gigameter = yt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicTerameter = new("yoctotonne per cubic terameter"
                                                                  , "yt/Tm³"
                                                                  , ZeptotonnePerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// megatonne per cubic rontometer defined such that: kilotonne per cubic yoctometer = Mt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicRontometer = new("megatonne per cubic rontometer"
                                                                  , "Mt/rm³"
                                                                  , KilotonnePerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic kilometer defined such that: rontotonne per cubic hectometer = qt/km³ ×
   /// (1.0/1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicKilometer =
      new("quectotonne per cubic kilometer", "qt/km³", RontotonnePerCubicHectometer, 1.0 / 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic quectometer defined such that: hectotonne per cubic rontometer = kt/qm³ ×
   /// (10.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicQuectometer = new("kilotonne per cubic quectometer"
                                                                   , "kt/qm³"
                                                                   , HectotonnePerCubicRontometer
                                                                   , 10.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic hectometer defined such that: tonne per cubic dekameter = dat/hm³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicHectometer =
      new("dekatonne per cubic hectometer", "dat/hm³", TonnePerCubicDekameter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic femtometer defined such that: ronnatonne per cubic picometer = Qt/fm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicFemtometer = new("quettatonne per cubic femtometer"
                                                                    , "Qt/fm³"
                                                                    , RonnatonnePerCubicPicometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// hectotonne per cubic dekameter defined such that: dekatonne per cubic meter = ht/dam³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicDekameter =
      new("hectotonne per cubic dekameter", "ht/dam³", DekatonnePerCubicMeter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// attotonne per cubic ronnameter defined such that: femtotonne per cubic yottameter = at/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicRonnameter = new("attotonne per cubic ronnameter"
                                                                  , "at/Rm³"
                                                                  , FemtotonnePerCubicYottameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// teratonne per cubic yoctometer defined such that: gigatonne per cubic zeptometer = Tt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicYoctometer = new("teratonne per cubic yoctometer"
                                                                  , "Tt/ym³"
                                                                  , GigatonnePerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// rontotonne per cubic gigameter defined such that: yoctotonne per cubic megameter = rt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicGigameter = new("rontotonne per cubic gigameter"
                                                                  , "rt/Gm³"
                                                                  , YoctotonnePerCubicMegameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottatonne per cubic attometer defined such that: zettatonne per cubic femtometer = Yt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicAttometer = new("yottatonne per cubic attometer"
                                                                  , "Yt/am³"
                                                                  , ZettatonnePerCubicFemtometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic zettameter defined such that: attotonne per cubic exameter = zt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicZettameter =
      new("zeptotonne per cubic zettameter", "zt/Zm³", AttotonnePerCubicExameter, 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic zeptometer defined such that: petatonne per cubic attometer = Et/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicZeptometer = new("exatonne per cubic zeptometer"
                                                                 , "Et/zm³"
                                                                 , PetatonnePerCubicAttometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// yoctotonne per cubic petameter defined such that: zeptotonne per cubic terameter = yt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicPetameter = new("yoctotonne per cubic petameter"
                                                                  , "yt/Pm³"
                                                                  , ZeptotonnePerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// gigatonne per cubic rontometer defined such that: megatonne per cubic yoctometer = Gt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicRontometer = new("gigatonne per cubic rontometer"
                                                                  , "Gt/rm³"
                                                                  , MegatonnePerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// attotonne per cubic quettameter defined such that: femtotonne per cubic ronnameter = at/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density AttotonnePerCubicQuettameter = new("attotonne per cubic quettameter"
                                                                   , "at/Qm³"
                                                                   , FemtotonnePerCubicRonnameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic megameter defined such that: rontotonne per cubic kilometer = qt/Mm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicMegameter = new("quectotonne per cubic megameter"
                                                                   , "qt/Mm³"
                                                                   , RontotonnePerCubicKilometer
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// megatonne per cubic quectometer defined such that: kilotonne per cubic rontometer = Mt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicQuectometer = new("megatonne per cubic quectometer"
                                                                   , "Mt/qm³"
                                                                   , KilotonnePerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic kilometer defined such that: tonne per cubic hectometer = dat/km³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicKilometer =
      new("dekatonne per cubic kilometer", "dat/km³", TonnePerCubicHectometer, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic attometer defined such that: yottatonne per cubic femtometer = Rt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicAttometer = new("ronnatonne per cubic attometer"
                                                                  , "Rt/am³"
                                                                  , YottatonnePerCubicFemtometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// petatonne per cubic yoctometer defined such that: teratonne per cubic zeptometer = Pt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicYoctometer = new("petatonne per cubic yoctometer"
                                                                  , "Pt/ym³"
                                                                  , TeratonnePerCubicZeptometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// kilotonne per cubic dekameter defined such that: hectotonne per cubic meter = kt/dam³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicDekameter =
      new("kilotonne per cubic dekameter", "kt/dam³", HectotonnePerCubicMeter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic hectometer defined such that: dekatonne per cubic dekameter = ht/hm³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicHectometer =
      new("hectotonne per cubic hectometer", "ht/hm³", DekatonnePerCubicDekameter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// zeptotonne per cubic yottameter defined such that: attotonne per cubic zettameter = zt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicYottameter = new("zeptotonne per cubic yottameter"
                                                                   , "zt/Ym³"
                                                                   , AttotonnePerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic terameter defined such that: yoctotonne per cubic gigameter = rt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicTerameter = new("rontotonne per cubic terameter"
                                                                  , "rt/Tm³"
                                                                  , YoctotonnePerCubicGigameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zettatonne per cubic zeptometer defined such that: exatonne per cubic attometer = Zt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicZeptometer = new("zettatonne per cubic zeptometer"
                                                                   , "Zt/zm³"
                                                                   , ExatonnePerCubicAttometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic exameter defined such that: zeptotonne per cubic petameter = yt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicExameter = new("yoctotonne per cubic exameter"
                                                                 , "yt/Em³"
                                                                 , ZeptotonnePerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teratonne per cubic rontometer defined such that: gigatonne per cubic yoctometer = Tt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicRontometer = new("teratonne per cubic rontometer"
                                                                  , "Tt/rm³"
                                                                  , GigatonnePerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// quectotonne per cubic gigameter defined such that: rontotonne per cubic megameter = qt/Gm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicGigameter = new("quectotonne per cubic gigameter"
                                                                   , "qt/Gm³"
                                                                   , RontotonnePerCubicMegameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quettatonne per cubic attometer defined such that: ronnatonne per cubic femtometer = Qt/am³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicAttometer = new("quettatonne per cubic attometer"
                                                                   , "Qt/am³"
                                                                   , RonnatonnePerCubicFemtometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zeptotonne per cubic ronnameter defined such that: attotonne per cubic yottameter = zt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicRonnameter = new("zeptotonne per cubic ronnameter"
                                                                   , "zt/Rm³"
                                                                   , AttotonnePerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// exatonne per cubic yoctometer defined such that: petatonne per cubic zeptometer = Et/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicYoctometer = new("exatonne per cubic yoctometer"
                                                                 , "Et/ym³"
                                                                 , PetatonnePerCubicZeptometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// gigatonne per cubic quectometer defined such that: megatonne per cubic rontometer = Gt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicQuectometer = new("gigatonne per cubic quectometer"
                                                                   , "Gt/qm³"
                                                                   , MegatonnePerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic megameter defined such that: tonne per cubic kilometer = dat/Mm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicMegameter =
      new("dekatonne per cubic megameter", "dat/Mm³", TonnePerCubicKilometer, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// rontotonne per cubic petameter defined such that: yoctotonne per cubic terameter = rt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicPetameter = new("rontotonne per cubic petameter"
                                                                  , "rt/Pm³"
                                                                  , YoctotonnePerCubicTerameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// yottatonne per cubic zeptometer defined such that: zettatonne per cubic attometer = Yt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicZeptometer = new("yottatonne per cubic zeptometer"
                                                                   , "Yt/zm³"
                                                                   , ZettatonnePerCubicAttometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic zettameter defined such that: zeptotonne per cubic exameter = yt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicZettameter = new("yoctotonne per cubic zettameter"
                                                                   , "yt/Zm³"
                                                                   , ZeptotonnePerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// megatonne per cubic dekameter defined such that: kilotonne per cubic meter = Mt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicDekameter =
      new("megatonne per cubic dekameter", "Mt/dam³", KilotonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic kilometer defined such that: dekatonne per cubic hectometer = ht/km³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicKilometer =
      new("hectotonne per cubic kilometer", "ht/km³", DekatonnePerCubicHectometer, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic hectometer defined such that: hectotonne per cubic dekameter = kt/hm³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicHectometer =
      new("kilotonne per cubic hectometer", "kt/hm³", HectotonnePerCubicDekameter, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic rontometer defined such that: teratonne per cubic yoctometer = Pt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicRontometer = new("petatonne per cubic rontometer"
                                                                  , "Pt/rm³"
                                                                  , TeratonnePerCubicYoctometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// zeptotonne per cubic quettameter defined such that: attotonne per cubic ronnameter = zt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZeptotonnePerCubicQuettameter = new("zeptotonne per cubic quettameter"
                                                                    , "zt/Qm³"
                                                                    , AttotonnePerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic terameter defined such that: rontotonne per cubic gigameter = qt/Tm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicTerameter = new("quectotonne per cubic terameter"
                                                                   , "qt/Tm³"
                                                                   , RontotonnePerCubicGigameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// ronnatonne per cubic zeptometer defined such that: yottatonne per cubic attometer = Rt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicZeptometer = new("ronnatonne per cubic zeptometer"
                                                                   , "Rt/zm³"
                                                                   , YottatonnePerCubicAttometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// zettatonne per cubic yoctometer defined such that: exatonne per cubic zeptometer = Zt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicYoctometer = new("zettatonne per cubic yoctometer"
                                                                   , "Zt/ym³"
                                                                   , ExatonnePerCubicZeptometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic yottameter defined such that: zeptotonne per cubic zettameter = yt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicYottameter = new("yoctotonne per cubic yottameter"
                                                                   , "yt/Ym³"
                                                                   , ZeptotonnePerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic exameter defined such that: yoctotonne per cubic petameter = rt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicExameter = new("rontotonne per cubic exameter"
                                                                 , "rt/Em³"
                                                                 , YoctotonnePerCubicPetameter
                                                                 , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// teratonne per cubic quectometer defined such that: gigatonne per cubic rontometer = Tt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicQuectometer = new("teratonne per cubic quectometer"
                                                                   , "Tt/qm³"
                                                                   , GigatonnePerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic gigameter defined such that: tonne per cubic megameter = dat/Gm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicGigameter =
      new("dekatonne per cubic gigameter", "dat/Gm³", TonnePerCubicMegameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic dekameter defined such that: megatonne per cubic meter = Gt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicDekameter =
      new("gigatonne per cubic dekameter", "Gt/dam³", MegatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic megameter defined such that: dekatonne per cubic kilometer = ht/Mm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicMegameter =
      new("hectotonne per cubic megameter", "ht/Mm³", DekatonnePerCubicKilometer, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic hectometer defined such that: kilotonne per cubic dekameter = Mt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicHectometer =
      new("megatonne per cubic hectometer", "Mt/hm³", KilotonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic kilometer defined such that: hectotonne per cubic hectometer = kt/km³ ×
   /// (10.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicKilometer =
      new("kilotonne per cubic kilometer", "kt/km³", HectotonnePerCubicHectometer, 10.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic rontometer defined such that: petatonne per cubic yoctometer = Et/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicRontometer = new("exatonne per cubic rontometer"
                                                                 , "Et/rm³"
                                                                 , PetatonnePerCubicYoctometer
                                                                 , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                 , system: "SI"
                                                                  );
   
   /// <summary>
   /// quectotonne per cubic petameter defined such that: rontotonne per cubic terameter = qt/Pm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicPetameter = new("quectotonne per cubic petameter"
                                                                   , "qt/Pm³"
                                                                   , RontotonnePerCubicTerameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quettatonne per cubic zeptometer defined such that: ronnatonne per cubic attometer = Qt/zm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicZeptometer = new("quettatonne per cubic zeptometer"
                                                                    , "Qt/zm³"
                                                                    , RonnatonnePerCubicAttometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// yoctotonne per cubic ronnameter defined such that: zeptotonne per cubic yottameter = yt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicRonnameter = new("yoctotonne per cubic ronnameter"
                                                                   , "yt/Rm³"
                                                                   , ZeptotonnePerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yottatonne per cubic yoctometer defined such that: zettatonne per cubic zeptometer = Yt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicYoctometer = new("yottatonne per cubic yoctometer"
                                                                   , "Yt/ym³"
                                                                   , ZettatonnePerCubicZeptometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic zettameter defined such that: yoctotonne per cubic exameter = rt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicZettameter = new("rontotonne per cubic zettameter"
                                                                   , "rt/Zm³"
                                                                   , YoctotonnePerCubicExameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// petatonne per cubic quectometer defined such that: teratonne per cubic rontometer = Pt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicQuectometer = new("petatonne per cubic quectometer"
                                                                   , "Pt/qm³"
                                                                   , TeratonnePerCubicRontometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// dekatonne per cubic terameter defined such that: tonne per cubic gigameter = dat/Tm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicTerameter =
      new("dekatonne per cubic terameter", "dat/Tm³", TonnePerCubicGigameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic dekameter defined such that: gigatonne per cubic meter = Tt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicDekameter =
      new("teratonne per cubic dekameter", "Tt/dam³", GigatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic gigameter defined such that: dekatonne per cubic megameter = ht/Gm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicGigameter =
      new("hectotonne per cubic gigameter", "ht/Gm³", DekatonnePerCubicMegameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic rontometer defined such that: exatonne per cubic yoctometer = Zt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicRontometer = new("zettatonne per cubic rontometer"
                                                                   , "Zt/rm³"
                                                                   , ExatonnePerCubicYoctometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// yoctotonne per cubic quettameter defined such that: zeptotonne per cubic ronnameter = yt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YoctotonnePerCubicQuettameter = new("yoctotonne per cubic quettameter"
                                                                    , "yt/Qm³"
                                                                    , ZeptotonnePerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic exameter defined such that: rontotonne per cubic petameter = qt/Em³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicExameter = new("quectotonne per cubic exameter"
                                                                  , "qt/Em³"
                                                                  , RontotonnePerCubicPetameter
                                                                  , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// ronnatonne per cubic yoctometer defined such that: yottatonne per cubic zeptometer = Rt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicYoctometer = new("ronnatonne per cubic yoctometer"
                                                                   , "Rt/ym³"
                                                                   , YottatonnePerCubicZeptometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// gigatonne per cubic hectometer defined such that: megatonne per cubic dekameter = Gt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicHectometer =
      new("gigatonne per cubic hectometer", "Gt/hm³", MegatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic megameter defined such that: hectotonne per cubic kilometer = kt/Mm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicMegameter =
      new("kilotonne per cubic megameter", "kt/Mm³", HectotonnePerCubicKilometer, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// rontotonne per cubic yottameter defined such that: yoctotonne per cubic zettameter = rt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicYottameter = new("rontotonne per cubic yottameter"
                                                                   , "rt/Ym³"
                                                                   , YoctotonnePerCubicZettameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// megatonne per cubic kilometer defined such that: kilotonne per cubic hectometer = Mt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicKilometer =
      new("megatonne per cubic kilometer", "Mt/km³", KilotonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic quectometer defined such that: petatonne per cubic rontometer = Et/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicQuectometer = new("exatonne per cubic quectometer"
                                                                  , "Et/qm³"
                                                                  , PetatonnePerCubicRontometer
                                                                  , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                  , system: "SI"
                                                                   );
   
   /// <summary>
   /// dekatonne per cubic petameter defined such that: tonne per cubic terameter = dat/Pm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicPetameter =
      new("dekatonne per cubic petameter", "dat/Pm³", TonnePerCubicTerameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic rontometer defined such that: zettatonne per cubic yoctometer = Yt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicRontometer = new("yottatonne per cubic rontometer"
                                                                   , "Yt/rm³"
                                                                   , ZettatonnePerCubicYoctometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// quectotonne per cubic zettameter defined such that: rontotonne per cubic exameter = qt/Zm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicZettameter = new("quectotonne per cubic zettameter"
                                                                    , "qt/Zm³"
                                                                    , RontotonnePerCubicExameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quettatonne per cubic yoctometer defined such that: ronnatonne per cubic zeptometer = Qt/ym³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicYoctometer = new("quettatonne per cubic yoctometer"
                                                                    , "Qt/ym³"
                                                                    , RonnatonnePerCubicZeptometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// petatonne per cubic dekameter defined such that: teratonne per cubic meter = Pt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicDekameter =
      new("petatonne per cubic dekameter", "Pt/dam³", TeratonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic terameter defined such that: dekatonne per cubic gigameter = ht/Tm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicTerameter =
      new("hectotonne per cubic terameter", "ht/Tm³", DekatonnePerCubicGigameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// rontotonne per cubic ronnameter defined such that: yoctotonne per cubic yottameter = rt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicRonnameter = new("rontotonne per cubic ronnameter"
                                                                   , "rt/Rm³"
                                                                   , YoctotonnePerCubicYottameter
                                                                   , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// teratonne per cubic hectometer defined such that: gigatonne per cubic dekameter = Tt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicHectometer =
      new("teratonne per cubic hectometer", "Tt/hm³", GigatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic gigameter defined such that: hectotonne per cubic megameter = kt/Gm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicGigameter =
      new("kilotonne per cubic gigameter", "kt/Gm³", HectotonnePerCubicMegameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic kilometer defined such that: megatonne per cubic hectometer = Gt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicKilometer =
      new("gigatonne per cubic kilometer", "Gt/km³", MegatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic megameter defined such that: kilotonne per cubic kilometer = Mt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicMegameter =
      new("megatonne per cubic megameter", "Mt/Mm³", KilotonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic quectometer defined such that: exatonne per cubic rontometer = Zt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicQuectometer = new("zettatonne per cubic quectometer"
                                                                    , "Zt/qm³"
                                                                    , ExatonnePerCubicRontometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// dekatonne per cubic exameter defined such that: tonne per cubic petameter = dat/Em³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicExameter =
      new("dekatonne per cubic exameter", "dat/Em³", TonnePerCubicPetameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic rontometer defined such that: yottatonne per cubic yoctometer = Rt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicRontometer = new("ronnatonne per cubic rontometer"
                                                                   , "Rt/rm³"
                                                                   , YottatonnePerCubicYoctometer
                                                                   , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                   , system: "SI"
                                                                    );
   
   /// <summary>
   /// rontotonne per cubic quettameter defined such that: yoctotonne per cubic ronnameter = rt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RontotonnePerCubicQuettameter = new("rontotonne per cubic quettameter"
                                                                    , "rt/Qm³"
                                                                    , YoctotonnePerCubicRonnameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic yottameter defined such that: rontotonne per cubic zettameter = qt/Ym³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicYottameter = new("quectotonne per cubic yottameter"
                                                                    , "qt/Ym³"
                                                                    , RontotonnePerCubicZettameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// exatonne per cubic dekameter defined such that: petatonne per cubic meter = Et/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicDekameter =
      new("exatonne per cubic dekameter", "Et/dam³", PetatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic petameter defined such that: dekatonne per cubic terameter = ht/Pm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicPetameter =
      new("hectotonne per cubic petameter", "ht/Pm³", DekatonnePerCubicTerameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic hectometer defined such that: teratonne per cubic dekameter = Pt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicHectometer =
      new("petatonne per cubic hectometer", "Pt/hm³", TeratonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic terameter defined such that: hectotonne per cubic gigameter = kt/Tm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicTerameter =
      new("kilotonne per cubic terameter", "kt/Tm³", HectotonnePerCubicGigameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic quectometer defined such that: zettatonne per cubic rontometer = Yt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicQuectometer = new("yottatonne per cubic quectometer"
                                                                    , "Yt/qm³"
                                                                    , ZettatonnePerCubicRontometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// dekatonne per cubic zettameter defined such that: tonne per cubic exameter = dat/Zm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicZettameter =
      new("dekatonne per cubic zettameter", "dat/Zm³", TonnePerCubicExameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic kilometer defined such that: gigatonne per cubic hectometer = Tt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicKilometer =
      new("teratonne per cubic kilometer", "Tt/km³", GigatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic gigameter defined such that: kilotonne per cubic megameter = Mt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicGigameter =
      new("megatonne per cubic gigameter", "Mt/Gm³", KilotonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic megameter defined such that: megatonne per cubic kilometer = Gt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicMegameter =
      new("gigatonne per cubic megameter", "Gt/Mm³", MegatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic rontometer defined such that: ronnatonne per cubic yoctometer = Qt/rm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicRontometer = new("quettatonne per cubic rontometer"
                                                                    , "Qt/rm³"
                                                                    , RonnatonnePerCubicYoctometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// quectotonne per cubic ronnameter defined such that: rontotonne per cubic yottameter = qt/Rm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicRonnameter = new("quectotonne per cubic ronnameter"
                                                                    , "qt/Rm³"
                                                                    , RontotonnePerCubicYottameter
                                                                    , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// zettatonne per cubic dekameter defined such that: exatonne per cubic meter = Zt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicDekameter =
      new("zettatonne per cubic dekameter", "Zt/dam³", ExatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic exameter defined such that: dekatonne per cubic petameter = ht/Em³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicExameter =
      new("hectotonne per cubic exameter", "ht/Em³", DekatonnePerCubicPetameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic quectometer defined such that: yottatonne per cubic rontometer = Rt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicQuectometer = new("ronnatonne per cubic quectometer"
                                                                    , "Rt/qm³"
                                                                    , YottatonnePerCubicRontometer
                                                                    , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                    , system: "SI"
                                                                     );
   
   /// <summary>
   /// exatonne per cubic hectometer defined such that: petatonne per cubic dekameter = Et/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicHectometer =
      new("exatonne per cubic hectometer", "Et/hm³", PetatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic petameter defined such that: hectotonne per cubic terameter = kt/Pm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicPetameter =
      new("kilotonne per cubic petameter", "kt/Pm³", HectotonnePerCubicTerameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic yottameter defined such that: tonne per cubic zettameter = dat/Ym³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicYottameter =
      new("dekatonne per cubic yottameter", "dat/Ym³", TonnePerCubicZettameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quectotonne per cubic quettameter defined such that: rontotonne per cubic ronnameter = qt/Qm³ ×
   /// (1.0/1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuectotonnePerCubicQuettameter = new("quectotonne per cubic quettameter"
                                                                     , "qt/Qm³"
                                                                     , RontotonnePerCubicRonnameter
                                                                     , 1.0 / 1000.0 / (1000.0 * 1000.0 * 1000.0)
                                                                     , system: "SI"
                                                                      );
   
   /// <summary>
   /// petatonne per cubic kilometer defined such that: teratonne per cubic hectometer = Pt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicKilometer =
      new("petatonne per cubic kilometer", "Pt/km³", TeratonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic terameter defined such that: kilotonne per cubic gigameter = Mt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicTerameter =
      new("megatonne per cubic terameter", "Mt/Tm³", KilotonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic megameter defined such that: gigatonne per cubic kilometer = Tt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicMegameter =
      new("teratonne per cubic megameter", "Tt/Mm³", GigatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic gigameter defined such that: megatonne per cubic megameter = Gt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicGigameter =
      new("gigatonne per cubic gigameter", "Gt/Gm³", MegatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic dekameter defined such that: zettatonne per cubic meter = Yt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicDekameter =
      new("yottatonne per cubic dekameter", "Yt/dam³", ZettatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic zettameter defined such that: dekatonne per cubic exameter = ht/Zm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicZettameter =
      new("hectotonne per cubic zettameter", "ht/Zm³", DekatonnePerCubicExameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic quectometer defined such that: ronnatonne per cubic rontometer = Qt/qm³ ×
   /// (1000.0)/((1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicQuectometer = new("quettatonne per cubic quectometer"
                                                                     , "Qt/qm³"
                                                                     , RonnatonnePerCubicRontometer
                                                                     , 1000.0 / (1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0))
                                                                     , system: "SI"
                                                                      );
   
   /// <summary>
   /// dekatonne per cubic ronnameter defined such that: tonne per cubic yottameter = dat/Rm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicRonnameter =
      new("dekatonne per cubic ronnameter", "dat/Rm³", TonnePerCubicYottameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic hectometer defined such that: exatonne per cubic dekameter = Zt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicHectometer =
      new("zettatonne per cubic hectometer", "Zt/hm³", ExatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic exameter defined such that: hectotonne per cubic petameter = kt/Em³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicExameter =
      new("kilotonne per cubic exameter", "kt/Em³", HectotonnePerCubicPetameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic kilometer defined such that: petatonne per cubic hectometer = Et/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicKilometer =
      new("exatonne per cubic kilometer", "Et/km³", PetatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic petameter defined such that: kilotonne per cubic terameter = Mt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicPetameter =
      new("megatonne per cubic petameter", "Mt/Pm³", KilotonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic dekameter defined such that: yottatonne per cubic meter = Rt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicDekameter =
      new("ronnatonne per cubic dekameter", "Rt/dam³", YottatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic megameter defined such that: teratonne per cubic kilometer = Pt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicMegameter =
      new("petatonne per cubic megameter", "Pt/Mm³", TeratonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic terameter defined such that: megatonne per cubic gigameter = Gt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicTerameter =
      new("gigatonne per cubic terameter", "Gt/Tm³", MegatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic yottameter defined such that: dekatonne per cubic zettameter = ht/Ym³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicYottameter =
      new("hectotonne per cubic yottameter", "ht/Ym³", DekatonnePerCubicZettameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic gigameter defined such that: gigatonne per cubic megameter = Tt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicGigameter =
      new("teratonne per cubic gigameter", "Tt/Gm³", GigatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// dekatonne per cubic quettameter defined such that: tonne per cubic ronnameter = dat/Qm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density DekatonnePerCubicQuettameter =
      new("dekatonne per cubic quettameter", "dat/Qm³", TonnePerCubicRonnameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic hectometer defined such that: zettatonne per cubic dekameter = Yt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicHectometer =
      new("yottatonne per cubic hectometer", "Yt/hm³", ZettatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic zettameter defined such that: hectotonne per cubic exameter = kt/Zm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicZettameter =
      new("kilotonne per cubic zettameter", "kt/Zm³", HectotonnePerCubicExameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic kilometer defined such that: exatonne per cubic hectometer = Zt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicKilometer =
      new("zettatonne per cubic kilometer", "Zt/km³", ExatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic exameter defined such that: kilotonne per cubic petameter = Mt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicExameter =
      new("megatonne per cubic exameter", "Mt/Em³", KilotonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic dekameter defined such that: ronnatonne per cubic meter = Qt/dam³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicDekameter =
      new("quettatonne per cubic dekameter", "Qt/dam³", RonnatonnePerCubicMeter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic ronnameter defined such that: dekatonne per cubic yottameter = ht/Rm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicRonnameter =
      new("hectotonne per cubic ronnameter", "ht/Rm³", DekatonnePerCubicYottameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic megameter defined such that: petatonne per cubic kilometer = Et/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicMegameter =
      new("exatonne per cubic megameter", "Et/Mm³", PetatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic petameter defined such that: megatonne per cubic terameter = Gt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicPetameter =
      new("gigatonne per cubic petameter", "Gt/Pm³", MegatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic gigameter defined such that: teratonne per cubic megameter = Pt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicGigameter =
      new("petatonne per cubic gigameter", "Pt/Gm³", TeratonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic terameter defined such that: gigatonne per cubic gigameter = Tt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicTerameter =
      new("teratonne per cubic terameter", "Tt/Tm³", GigatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic hectometer defined such that: yottatonne per cubic dekameter = Rt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicHectometer =
      new("ronnatonne per cubic hectometer", "Rt/hm³", YottatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic yottameter defined such that: hectotonne per cubic zettameter = kt/Ym³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicYottameter =
      new("kilotonne per cubic yottameter", "kt/Ym³", HectotonnePerCubicZettameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// hectotonne per cubic quettameter defined such that: dekatonne per cubic ronnameter = ht/Qm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density HectotonnePerCubicQuettameter =
      new("hectotonne per cubic quettameter", "ht/Qm³", DekatonnePerCubicRonnameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic kilometer defined such that: zettatonne per cubic hectometer = Yt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicKilometer =
      new("yottatonne per cubic kilometer", "Yt/km³", ZettatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic zettameter defined such that: kilotonne per cubic exameter = Mt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicZettameter =
      new("megatonne per cubic zettameter", "Mt/Zm³", KilotonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic megameter defined such that: exatonne per cubic kilometer = Zt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicMegameter =
      new("zettatonne per cubic megameter", "Zt/Mm³", ExatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic exameter defined such that: megatonne per cubic petameter = Gt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicExameter =
      new("gigatonne per cubic exameter", "Gt/Em³", MegatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic gigameter defined such that: petatonne per cubic megameter = Et/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicGigameter =
      new("exatonne per cubic gigameter", "Et/Gm³", PetatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic petameter defined such that: gigatonne per cubic terameter = Tt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicPetameter =
      new("teratonne per cubic petameter", "Tt/Pm³", GigatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic hectometer defined such that: ronnatonne per cubic dekameter = Qt/hm³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicHectometer =
      new("quettatonne per cubic hectometer", "Qt/hm³", RonnatonnePerCubicDekameter, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic terameter defined such that: teratonne per cubic gigameter = Pt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicTerameter =
      new("petatonne per cubic terameter", "Pt/Tm³", TeratonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic ronnameter defined such that: hectotonne per cubic yottameter = kt/Rm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicRonnameter =
      new("kilotonne per cubic ronnameter", "kt/Rm³", HectotonnePerCubicYottameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic kilometer defined such that: yottatonne per cubic hectometer = Rt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicKilometer =
      new("ronnatonne per cubic kilometer", "Rt/km³", YottatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic yottameter defined such that: kilotonne per cubic zettameter = Mt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicYottameter =
      new("megatonne per cubic yottameter", "Mt/Ym³", KilotonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic megameter defined such that: zettatonne per cubic kilometer = Yt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicMegameter =
      new("yottatonne per cubic megameter", "Yt/Mm³", ZettatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic zettameter defined such that: megatonne per cubic exameter = Gt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicZettameter =
      new("gigatonne per cubic zettameter", "Gt/Zm³", MegatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// kilotonne per cubic quettameter defined such that: hectotonne per cubic ronnameter = kt/Qm³ ×
   /// (10.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density KilotonnePerCubicQuettameter =
      new("kilotonne per cubic quettameter", "kt/Qm³", HectotonnePerCubicRonnameter, 10.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic gigameter defined such that: exatonne per cubic megameter = Zt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicGigameter =
      new("zettatonne per cubic gigameter", "Zt/Gm³", ExatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic exameter defined such that: gigatonne per cubic petameter = Tt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicExameter =
      new("teratonne per cubic exameter", "Tt/Em³", GigatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic terameter defined such that: petatonne per cubic gigameter = Et/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicTerameter =
      new("exatonne per cubic terameter", "Et/Tm³", PetatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic petameter defined such that: teratonne per cubic terameter = Pt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicPetameter =
      new("petatonne per cubic petameter", "Pt/Pm³", TeratonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic kilometer defined such that: ronnatonne per cubic hectometer = Qt/km³ ×
   /// (1000.0)/((10.0)*(10.0)*(10.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicKilometer =
      new("quettatonne per cubic kilometer", "Qt/km³", RonnatonnePerCubicHectometer, 1000.0 / (10.0 * 10.0 * 10.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic ronnameter defined such that: kilotonne per cubic yottameter = Mt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicRonnameter =
      new("megatonne per cubic ronnameter", "Mt/Rm³", KilotonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic megameter defined such that: yottatonne per cubic kilometer = Rt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicMegameter =
      new("ronnatonne per cubic megameter", "Rt/Mm³", YottatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic yottameter defined such that: megatonne per cubic zettameter = Gt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicYottameter =
      new("gigatonne per cubic yottameter", "Gt/Ym³", MegatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic gigameter defined such that: zettatonne per cubic megameter = Yt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicGigameter =
      new("yottatonne per cubic gigameter", "Yt/Gm³", ZettatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic zettameter defined such that: gigatonne per cubic exameter = Tt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicZettameter =
      new("teratonne per cubic zettameter", "Tt/Zm³", GigatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic terameter defined such that: exatonne per cubic gigameter = Zt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicTerameter =
      new("zettatonne per cubic terameter", "Zt/Tm³", ExatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic exameter defined such that: teratonne per cubic petameter = Pt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicExameter =
      new("petatonne per cubic exameter", "Pt/Em³", TeratonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic petameter defined such that: petatonne per cubic terameter = Et/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicPetameter =
      new("exatonne per cubic petameter", "Et/Pm³", PetatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// megatonne per cubic quettameter defined such that: kilotonne per cubic ronnameter = Mt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density MegatonnePerCubicQuettameter =
      new("megatonne per cubic quettameter", "Mt/Qm³", KilotonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic megameter defined such that: ronnatonne per cubic kilometer = Qt/Mm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicMegameter =
      new("quettatonne per cubic megameter", "Qt/Mm³", RonnatonnePerCubicKilometer, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic ronnameter defined such that: megatonne per cubic yottameter = Gt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicRonnameter =
      new("gigatonne per cubic ronnameter", "Gt/Rm³", MegatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic gigameter defined such that: yottatonne per cubic megameter = Rt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicGigameter =
      new("ronnatonne per cubic gigameter", "Rt/Gm³", YottatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic yottameter defined such that: gigatonne per cubic zettameter = Tt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicYottameter =
      new("teratonne per cubic yottameter", "Tt/Ym³", GigatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic terameter defined such that: zettatonne per cubic gigameter = Yt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicTerameter =
      new("yottatonne per cubic terameter", "Yt/Tm³", ZettatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic zettameter defined such that: teratonne per cubic exameter = Pt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicZettameter =
      new("petatonne per cubic zettameter", "Pt/Zm³", TeratonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic petameter defined such that: exatonne per cubic terameter = Zt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicPetameter =
      new("zettatonne per cubic petameter", "Zt/Pm³", ExatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic exameter defined such that: petatonne per cubic petameter = Et/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicExameter =
      new("exatonne per cubic exameter", "Et/Em³", PetatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// gigatonne per cubic quettameter defined such that: megatonne per cubic ronnameter = Gt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density GigatonnePerCubicQuettameter =
      new("gigatonne per cubic quettameter", "Gt/Qm³", MegatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic gigameter defined such that: ronnatonne per cubic megameter = Qt/Gm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicGigameter =
      new("quettatonne per cubic gigameter", "Qt/Gm³", RonnatonnePerCubicMegameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic ronnameter defined such that: gigatonne per cubic yottameter = Tt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicRonnameter =
      new("teratonne per cubic ronnameter", "Tt/Rm³", GigatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic terameter defined such that: yottatonne per cubic gigameter = Rt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicTerameter =
      new("ronnatonne per cubic terameter", "Rt/Tm³", YottatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic yottameter defined such that: teratonne per cubic zettameter = Pt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicYottameter =
      new("petatonne per cubic yottameter", "Pt/Ym³", TeratonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic petameter defined such that: zettatonne per cubic terameter = Yt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicPetameter =
      new("yottatonne per cubic petameter", "Yt/Pm³", ZettatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic zettameter defined such that: petatonne per cubic exameter = Et/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicZettameter =
      new("exatonne per cubic zettameter", "Et/Zm³", PetatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic exameter defined such that: exatonne per cubic petameter = Zt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicExameter =
      new("zettatonne per cubic exameter", "Zt/Em³", ExatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// teratonne per cubic quettameter defined such that: gigatonne per cubic ronnameter = Tt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density TeratonnePerCubicQuettameter =
      new("teratonne per cubic quettameter", "Tt/Qm³", GigatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic terameter defined such that: ronnatonne per cubic gigameter = Qt/Tm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicTerameter =
      new("quettatonne per cubic terameter", "Qt/Tm³", RonnatonnePerCubicGigameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic ronnameter defined such that: teratonne per cubic yottameter = Pt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicRonnameter =
      new("petatonne per cubic ronnameter", "Pt/Rm³", TeratonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic petameter defined such that: yottatonne per cubic terameter = Rt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicPetameter =
      new("ronnatonne per cubic petameter", "Rt/Pm³", YottatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic yottameter defined such that: petatonne per cubic zettameter = Et/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicYottameter =
      new("exatonne per cubic yottameter", "Et/Ym³", PetatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic exameter defined such that: zettatonne per cubic petameter = Yt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicExameter =
      new("yottatonne per cubic exameter", "Yt/Em³", ZettatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic zettameter defined such that: exatonne per cubic exameter = Zt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicZettameter =
      new("zettatonne per cubic zettameter", "Zt/Zm³", ExatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// petatonne per cubic quettameter defined such that: teratonne per cubic ronnameter = Pt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density PetatonnePerCubicQuettameter =
      new("petatonne per cubic quettameter", "Pt/Qm³", TeratonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic petameter defined such that: ronnatonne per cubic terameter = Qt/Pm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicPetameter =
      new("quettatonne per cubic petameter", "Qt/Pm³", RonnatonnePerCubicTerameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic ronnameter defined such that: petatonne per cubic yottameter = Et/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicRonnameter =
      new("exatonne per cubic ronnameter", "Et/Rm³", PetatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic exameter defined such that: yottatonne per cubic petameter = Rt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicExameter =
      new("ronnatonne per cubic exameter", "Rt/Em³", YottatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic yottameter defined such that: exatonne per cubic zettameter = Zt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicYottameter =
      new("zettatonne per cubic yottameter", "Zt/Ym³", ExatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic zettameter defined such that: zettatonne per cubic exameter = Yt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicZettameter =
      new("yottatonne per cubic zettameter", "Yt/Zm³", ZettatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// exatonne per cubic quettameter defined such that: petatonne per cubic ronnameter = Et/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ExatonnePerCubicQuettameter =
      new("exatonne per cubic quettameter", "Et/Qm³", PetatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic exameter defined such that: ronnatonne per cubic petameter = Qt/Em³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicExameter =
      new("quettatonne per cubic exameter", "Qt/Em³", RonnatonnePerCubicPetameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic ronnameter defined such that: exatonne per cubic yottameter = Zt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicRonnameter =
      new("zettatonne per cubic ronnameter", "Zt/Rm³", ExatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic zettameter defined such that: yottatonne per cubic exameter = Rt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicZettameter =
      new("ronnatonne per cubic zettameter", "Rt/Zm³", YottatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic yottameter defined such that: zettatonne per cubic zettameter = Yt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicYottameter =
      new("yottatonne per cubic yottameter", "Yt/Ym³", ZettatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// zettatonne per cubic quettameter defined such that: exatonne per cubic ronnameter = Zt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density ZettatonnePerCubicQuettameter =
      new("zettatonne per cubic quettameter", "Zt/Qm³", ExatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic zettameter defined such that: ronnatonne per cubic exameter = Qt/Zm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicZettameter =
      new("quettatonne per cubic zettameter", "Qt/Zm³", RonnatonnePerCubicExameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic ronnameter defined such that: zettatonne per cubic yottameter = Yt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicRonnameter =
      new("yottatonne per cubic ronnameter", "Yt/Rm³", ZettatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic yottameter defined such that: yottatonne per cubic zettameter = Rt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicYottameter =
      new("ronnatonne per cubic yottameter", "Rt/Ym³", YottatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// yottatonne per cubic quettameter defined such that: zettatonne per cubic ronnameter = Yt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density YottatonnePerCubicQuettameter =
      new("yottatonne per cubic quettameter", "Yt/Qm³", ZettatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic yottameter defined such that: ronnatonne per cubic zettameter = Qt/Ym³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicYottameter =
      new("quettatonne per cubic yottameter", "Qt/Ym³", RonnatonnePerCubicZettameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic ronnameter defined such that: yottatonne per cubic yottameter = Rt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicRonnameter =
      new("ronnatonne per cubic ronnameter", "Rt/Rm³", YottatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// ronnatonne per cubic quettameter defined such that: yottatonne per cubic ronnameter = Rt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density RonnatonnePerCubicQuettameter =
      new("ronnatonne per cubic quettameter", "Rt/Qm³", YottatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic ronnameter defined such that: ronnatonne per cubic yottameter = Qt/Rm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicRonnameter =
      new("quettatonne per cubic ronnameter", "Qt/Rm³", RonnatonnePerCubicYottameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
   
   /// <summary>
   /// quettatonne per cubic quettameter defined such that: ronnatonne per cubic ronnameter = Qt/Qm³ ×
   /// (1000.0)/((1000.0)*(1000.0)*(1000.0)).
   /// </summary>
   public static readonly Density QuettatonnePerCubicQuettameter =
      new("quettatonne per cubic quettameter", "Qt/Qm³", RonnatonnePerCubicRonnameter, 1000.0 / (1000.0 * 1000.0 * 1000.0), system: "SI");
}