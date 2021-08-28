using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Orders.Api
{
    public class HealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var healthCheckResultHealthy = true;

            if(healthCheckResultHealthy)
                return Task.FromResult(
                    HealthCheckResult.Healthy("Healthy"));

            return Task.FromResult(HealthCheckResult.Unhealthy("Unhealthy"));
        }
    }
}