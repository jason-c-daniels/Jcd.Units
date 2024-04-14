namespace Jcd.Units.Examples.Perf.Tests;

internal abstract record PerfTestBase(string Description) : IPerfTest
{
   #region IPerfTest Members

   public virtual bool Equals(IPerfTest? other)
   {
      return other != null && Description == other.Description;
   }

   public virtual void Setup()
   {
   }

   public virtual void Teardown()
   {
   }

   public abstract int Execute(int iterations = 1);

   #endregion
}