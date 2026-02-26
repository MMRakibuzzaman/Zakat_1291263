namespace WebApplication1.Repositories;

public interface IGenericRepositories<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    void Post(T entity);
    void Put(T entity);
    void Delete(T entity);
    Task SaveChangesAsync();
}