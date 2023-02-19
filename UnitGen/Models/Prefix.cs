namespace UnitGen.Models;

public record Prefix
(
    string Name,
    string Symbol,
    string BasePrefix,
    string Coefficient,
    int SortIndex
)
{
    public bool IsBasePrefix => string.IsNullOrWhiteSpace(Name);
}