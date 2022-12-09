using Core.Models;

namespace API.Contracts;

public interface IMovieRepository : IGenericRepository<Movie>
{
    Task<Movie> GetMovieAsync(int id);
}