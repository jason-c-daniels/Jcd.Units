#region

using System.Reflection;

#endregion

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace UnitGen.Resources;

public static class EmbeddedResource
{
   public static string? ReadString(string resourceName)
      => Assembly.GetExecutingAssembly()
                 .ReadString(resourceName);

   public static string? ReadString(this Assembly assembly, string resourceName)
   {
      using var stream = assembly.GetStream(resourceName);

      if (stream is null) return null;

      using var reader = new StreamReader(stream);

      return reader.ReadToEnd();
   }

   public static byte[]? ReadBytes(string resourceName)
      => Assembly.GetExecutingAssembly()
                 .ReadBytes(resourceName);

   public static byte[]? ReadBytes(this Assembly assembly, string resourceName)
   {
      using var stream = assembly.GetStream(resourceName);

      if (stream is null) return null;

      using var reader = new BinaryReader(stream);

      return reader.ReadBytes((int)stream.Length);
   }

   public static Stream? GetStream(string resourceName)
      => Assembly.GetExecutingAssembly()
                 .GetStream(resourceName);

   public static Stream? GetStream(this Assembly assembly, string resourceName)
   {
      var resourcePath = assembly.GetFullName(resourceName);

      return string.IsNullOrWhiteSpace(resourcePath)
               ? null
               : assembly.GetManifestResourceStream(resourcePath)!;
   }

   public static string? GetFullName(string resourceName) =>
            Assembly.GetExecutingAssembly()
                    .GetFullName(resourceName);

   public static string? GetFullName(this Assembly assembly, string resourceName) =>
            assembly.GetManifestResourceNames()
                    .FirstOrDefault(str => str.EndsWith(resourceName));
}
