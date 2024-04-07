using MediatR;
using Resume.Domain.Models.Entities;

namespace Resume.Application.Modules.ServicesModule.Commands.ServiceAddCommand
{
    public class ServiceAddRequest : IRequest<Service>
    {
        public string Name { get; set; }
    }
}
