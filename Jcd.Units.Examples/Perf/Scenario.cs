namespace Jcd.Units.Examples.Perf;

public record Scenario(string Description, Action Setup, Action Teardown);
