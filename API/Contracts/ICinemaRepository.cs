using Core.Models;

namespace API.Contracts;

public interface ICinemaRepository : IGenericRepository<Cinema>
{
    Task<Cinema> GetCinemaAsync(int id);
}