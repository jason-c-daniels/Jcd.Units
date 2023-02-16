using System.Reflection;

namespace UnitGen.Resources;

public static class ResourceHelper
{
    public static string ReadStringResource(string resourceName)
        => Assembly.GetExecutingAssembly().ReadStringResource(resourceName);
    public static string ReadStringResource(this Assembly assembly, string resourceName)
    {
        var resourcePath = assembly.GetManifestResourceNames()
            .FirstOrDefault(str => str.EndsWith(resourceName));
        if (string.IsNullOrWhiteSpace(resourcePath)) return string.Empty;
        using var stream = assembly.GetManifestResourceStream(resourcePath)!;
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    } 
}

