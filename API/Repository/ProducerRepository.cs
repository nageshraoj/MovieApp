using API.Contracts;
using Core.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
{
    private readonly MovieContext _context;

    public ProducerRepository(MovieContext context) : base(context)
    {
        this._context = context;
    }
    public async Task<Producer> GetProducerAsync(int id)
    {
        var producer = await _context.Producers.FirstOrDefaultAsync(q => q.Id == id);
        return producer;
    }
}