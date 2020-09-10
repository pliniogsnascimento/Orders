using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Orders.Application.Handlers
{
    public class GetOrdersHandler : IRequestHandler<GetOrdersCommand, string>
    {
        private readonly ILogger<GetOrdersHandler> _logger;

        public GetOrdersHandler(ILogger<GetOrdersHandler> logger)
        {
            _logger = logger;
        }

        public async Task<string> Handle(GetOrdersCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("[Handler] Executing GetOrdersCommand handler");

            return await Task.Run(() => "Order 1");
        }
    }
}
