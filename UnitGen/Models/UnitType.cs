using JetBrains.Annotations;

namespace UnitGen.Models;

[UsedImplicitly]
public record UnitType
(
    string Name,
    string UnitTypeName,
    string EnumerationName,
    string Description
);