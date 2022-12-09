using Core.Models;

namespace API.Contracts;

public interface IActorRepository : IGenericRepository<Actor>
{
    Task<Actor> GetActorAsync(int id);
}