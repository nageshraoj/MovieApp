using Core.Models;

namespace API.Contracts;

public interface IProducerRepository : IGenericRepository<Producer>
{
    Task<Producer> GetProducerAsync(int id);
}