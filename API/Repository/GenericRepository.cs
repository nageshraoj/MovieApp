using System.Runtime.CompilerServices;
using API.Contracts;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly MovieContext _context;

    public GenericRepository(MovieContext context)
    {
        this._context = context;
    }
    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var results = await _context.Set<T>().ToListAsync();
        return results;
    }

    public async Task<T> GetAsync(int id)
    {
        var result = await _context.Set<T>().FindAsync(id);
        return result;
    }

    public async Task<bool> IsExist(int id)
    {
        var isExists = await _context.Set<T>().FindAsync(id);
        return isExists != null;
    }

    public async Task ModifyAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}