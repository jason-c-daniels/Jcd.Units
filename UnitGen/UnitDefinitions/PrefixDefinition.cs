namespace UnitGen;

public record PrefixDefinition
(
    string Prefix,
    string Symbol,
    string BasePrefix,
    string Coefficient,
    int SortIndex
)
{
    public bool IsBasePrefix => string.IsNullOrWhiteSpace(Prefix);
}