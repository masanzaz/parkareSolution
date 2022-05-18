namespace parkareSolution.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Save(T item);
    }
}
