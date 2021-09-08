using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Qu.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;

        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator, ILogger<T> logger)
        {
            _logger = logger;
            _mediator = mediator;
        }
    }
}
