using MediatR;
using Resume.Application.Repositories;
using Resume.Domain.Models.Entities;

namespace Resume.Application.Modules.ServicesModule.Commands.ServiceAddCommand
{
    class ServiceAddRequestHandler : IRequestHandler<ServiceAddRequest,Service>
    {
        private readonly IServiceRepository serviceRepository;
        public ServiceAddRequestHandler(IServiceRepository serviceRepository)
        {
           this.serviceRepository = serviceRepository;
        }

        

        public async Task<Service> Handle(ServiceAddRequest request, CancellationToken cancellationToken)
        {
            var entity = new Service 
            {
                Name = request.Name, 
                CreatedAt = DateTime.UtcNow,
                CreatedBy = 1
                
            };

            await serviceRepository.AddAsync(entity, cancellationToken);
            await serviceRepository.SaveAsync(cancellationToken);

            return entity;
        }

    }
}
