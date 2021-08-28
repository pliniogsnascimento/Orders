using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Api.Controllers
{
    public static class Configuration
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            return services;
        }
    }
}
