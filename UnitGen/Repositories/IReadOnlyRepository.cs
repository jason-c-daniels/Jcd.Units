namespace UnitGen.Repositories;

public interface IReadOnlyRepository<out T>
{
   // ReSharper disable once UnusedMemberInSuper.Global
   IReadOnlyList<T> GetAll();
}