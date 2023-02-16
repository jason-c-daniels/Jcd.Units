namespace UnitGen.Data;

public interface IReadOnlyRepository<T>
{
    IList<T> GetAll();
}