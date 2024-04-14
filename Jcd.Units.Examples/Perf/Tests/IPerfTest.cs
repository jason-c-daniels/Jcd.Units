namespace Jcd.Units.Examples.Perf.Tests;

public interface IPerfTest : IEquatable<IPerfTest>
{
   /// <summary>
   /// The message to display when running the test.
   /// </summary>
   string Description { get; }

   /// <summary>
   /// Perform the necessary setup required to execute the test.
   /// </summary>
   void Setup();

   /// <summary>
   /// Perform the necessary teardown required from executing the test.
   /// </summary>
   void Teardown();

   /// <summary>
   /// Executes the test, returning the total number of operations executed.
   /// </summary>
   /// <param name="iterations">the number of times to repeat the action, useful for performance testing.</param>
   /// <returns>The total number of operations executed.</returns>
   int Execute(int iterations = 1);
}