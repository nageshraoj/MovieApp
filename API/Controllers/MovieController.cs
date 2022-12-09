using API.Contracts;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieRepository _movieRepository;

    public MovieController(IMovieRepository movieRepository)
    {
        this._movieRepository = movieRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Movie>>> GetMoviesAsync()
    {
        var movies = await _movieRepository.GetAllAsync();
        return Ok(movies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetMovieAsync(int id)
    {
        var movie = await _movieRepository.GetMovieAsync(id);
        return Ok(movie);
    }
}