namespace UnitGen.Repositories;

public interface IReadOnlyRepository<T>
{
    IReadOnlyList<T> GetAll();
}