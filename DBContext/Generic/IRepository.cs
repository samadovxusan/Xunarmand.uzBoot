namespace DBContexts.Generic
{
    public interface IRepository<T> where T : class
    {
            Task<List<T>> GetAllAsync();
            Task<T> GetById(int id);
            Task<T> Create(T entity);
            Task<T> Update(int id, T entity);
            Task<T> Delete(int id);

    }
}
