using System;
using MediatR;

namespace Orders.Application
{
    public class GetOrdersCommand : IRequest<string>
    {
    }
}
