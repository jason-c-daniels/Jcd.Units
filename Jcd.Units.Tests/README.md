# Jcd.Units.Tests

This is the unit test project. The goal is to get as
close to 100% of both branch and line coverage.

## Running The Tests

Given the library provides some global static hooks to allow the
user to easily use different unit selection and/or double value
comparisons, the tests must run in sequence, NEVER in parallel,
as some tests set/reset these values.

To facilitate this `XUnit` is in use and `xunit.runner.json`
is included in the project, configured to be part of the build output
and has been setup to prevent parallel test runs.

Its content should be as follows:

```json
{
   "parallelizeAssembly": false,
   "parallelizeTestCollections": false
}
```

The `csproj` for the tests should contain the following XML:

```xml
   <ItemGroup>
      <None Update="xunit.runner.json">
         <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
      </None>
   </ItemGroup>
```

This also shows in the IDE as `Copy if newer`.

## Maintaining the Tests

`TestBase` implements a constructor that resets the
values to their library provided defaults. If those change,
update the impacted unit tests and this class, as appropriate.

If `UnitOfMeasure` or `Quantity` derived
types will be used, your test class must derive from `TestBase`.
Additionally, if you add or use another `UnitOfMeasure` apart from
`Jcd.Units.UnitOfMeasure.Distance` or `Jcd.Units.Tests._Fakes.UnitOfMeasure1`
you must updated `TestBase` to reset values to their defaults for all
test runs. (i.e. the expected starting point, which should be the
same as the library provided defaults.)

## Test Performance

To alleviate any concerns about the time it takes to run the
hundreds of tests, the command line execution of `Debug` mode
comes in at just over 100ms, the `Release` mode executes in
just under 100ms.

## Running Performance Tests

