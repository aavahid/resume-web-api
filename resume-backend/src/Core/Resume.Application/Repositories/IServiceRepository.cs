using Resume.Domain.Models.Entities;
using Resume.Infrastructure.Abstracts;

namespace Resume.Application.Repositories
{
    public interface IServiceRepository : IAsyncRepository<Service>
    {
    }
}
