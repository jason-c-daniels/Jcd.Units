#region

using System.Globalization;
using System.Text.RegularExpressions;

#endregion

namespace UnitGen.Services;

public static class CodeGenHelper
{
   public static string MakeSymbolName
            (this string text) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Regex.Replace(text, @"\p{P}", " "))
                                             .Replace(" ", "");
}
