using API.Contracts;
using Core.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class ActorRepository : GenericRepository<Actor>, IActorRepository
{
    private readonly MovieContext _context;

    public ActorRepository(MovieContext context) : base(context)
    {
        this._context = context;
    }
    public async Task<Actor> GetActorAsync(int id)
    {
        // var actor = await _context.Actors.FirstOrDefaultAsync(q => q.Id == id);
        var actor = from act in _context.Actors
                    join mov in _context.MovieActors on act.Id equals mov.ActorId
                    where act.Id == id
                    select act;
        var result = await actor.FirstOrDefaultAsync();
        return result;
    }
}