using System.Globalization;
using System.Text.RegularExpressions;

namespace UnitGen.CodeGenerators;

public static class CodeGenHelper
{
    public static string MakeCodeName(this string text) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Regex.Replace(text, @"\p{P}", " ")).Replace(" ","");
}