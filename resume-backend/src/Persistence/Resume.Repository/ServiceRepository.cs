using Microsoft.EntityFrameworkCore;
using Resume.Application.Repositories;
using Resume.Domain.Models.Entities;
using Resume.Infrastructure.Concrates;

namespace Resume.Repository
{
    class ServiceRepository : AsyncRepository<Service>, IServiceRepository
    {
        public ServiceRepository(DbContext db)
            :base(db)
        {
        }
    }
}
