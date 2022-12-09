namespace API.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task AddAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetAsync(int id);
    Task ModifyAsync(T entity);
    Task DeleteAsync(T entity);
    Task<bool> IsExist(int id);
}