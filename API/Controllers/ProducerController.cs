using API.Contracts;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProducerController : ControllerBase
{
    private readonly IProducerRepository _producerRepository;

    public ProducerController(IProducerRepository producerRepository)
    {
        this._producerRepository = producerRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Producer>>> GetProducersAsync()
    {
        var producers = await _producerRepository.GetAllAsync();
        return Ok(producers);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Producer>> GetProducerAsync(int id)
    {
        var producer = await _producerRepository.GetProducerAsync(id);
        return Ok(producer);
    }
}