using API.Contracts;
using Core.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    private readonly MovieContext _context;

    public MovieRepository(MovieContext context) : base(context)
    {
        this._context = context;
    }
    public async Task<Movie> GetMovieAsync(int id)
    {
        var movie = await _context.Movies.FirstOrDefaultAsync(q => q.Id == id);
        return movie;
    }
}