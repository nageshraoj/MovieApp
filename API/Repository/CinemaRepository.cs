using API.Contracts;
using Core.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class CinemaRepository : GenericRepository<Cinema>, ICinemaRepository
{
    private readonly MovieContext _context;

    public CinemaRepository(MovieContext context) : base(context)
    {
        this._context = context;
    }
    public async Task<Cinema> GetCinemaAsync(int id)
    {
        var cinema = await _context.Cinemas.FirstOrDefaultAsync(q => q.Id == id);
        return cinema;
    }
}