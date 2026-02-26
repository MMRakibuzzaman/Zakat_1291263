namespace WebApplication1.Repositories;

public class GenericRepositories<T>:IGenericRepositories<T> where T:class
{
    
    public async Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
    
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Post(T entity)
    {
        throw new NotImplementedException();
    }

    public void Put(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }

    
}