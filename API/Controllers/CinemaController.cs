using API.Contracts;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CinemaController : ControllerBase
{
    private readonly ICinemaRepository _cinemaRepository;

    public CinemaController(ICinemaRepository cinemaRepository)
    {
        this._cinemaRepository = cinemaRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cinema>>> GetCinemasAsync()
    {
        var cinemas = await _cinemaRepository.GetAllAsync();
        return Ok(cinemas);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Cinema>> GetCinemaAsync(int id)
    {
        var cinema = await _cinemaRepository.GetCinemaAsync(id);
        return Ok(cinema);
    }
}