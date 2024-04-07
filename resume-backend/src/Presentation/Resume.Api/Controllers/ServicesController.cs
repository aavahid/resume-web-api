using MediatR;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Modules.ServicesModule.Commands.ServiceAddCommand;

namespace Resume.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ServicesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceAddRequest request)
        {
            var entity = await mediator.Send(request);
            return Ok(entity);
        }
    }
}
