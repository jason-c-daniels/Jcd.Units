#region

using JetBrains.Annotations;

#endregion

namespace UnitGen.Models;

[UsedImplicitly]
public record System
         (
         string Name
       , string Description
       , bool HasSubnamespace
       , string Subnamespace
         );
