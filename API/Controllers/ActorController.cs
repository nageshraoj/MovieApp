using API.Contracts;
using Core.Models;
using Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorController : ControllerBase
{
    private readonly IActorRepository _actorRepository;

    public ActorController(IActorRepository actorRepository)
    {
        this._actorRepository = actorRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> GetActorsAsync()
    {
        var actors = await _actorRepository.GetAllAsync();
        return Ok(actors);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Actor>> GetActorAsync(int id)
    {
        var result = await _actorRepository.GetActorAsync(id);
        return Ok(result);
    }
}