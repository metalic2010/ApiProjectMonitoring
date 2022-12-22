using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ApiProjectMenu.HealthChecks
{
    public class APIHealthChecks : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            bool isHealthy = await IsDatabaseConnectionOkAsync();

            return isHealthy
                ? HealthCheckResult.Healthy("API connection is OK")
                : HealthCheckResult.Unhealthy("API connection ERROR");
        }

        private static Task<bool> IsDatabaseConnectionOkAsync()
        {
            return Task.FromResult(DateTime.Now.Millisecond % 2 == 0);
        }
    }
}
