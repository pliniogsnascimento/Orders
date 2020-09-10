using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orders.Application;

namespace Orders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IMediator mediator,
                                ILogger<OrdersController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var commandResult = await _mediator.Send(new GetOrdersCommand());

            _logger.LogInformation("[{Layer}]Getting orders", "Controller");
            return Ok(commandResult);
        }
    }
}
