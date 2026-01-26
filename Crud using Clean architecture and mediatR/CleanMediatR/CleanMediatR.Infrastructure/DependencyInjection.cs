using Microsoft.Extensions.DependencyInjection;

namespace CleanMediatR.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
        {
            return services;
        }

    }
}
