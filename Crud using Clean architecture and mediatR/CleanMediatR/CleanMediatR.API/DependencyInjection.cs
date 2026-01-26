using CleanMediatR.Application;
using CleanMediatR.Infrastructure;

namespace CleanMediatR.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIDependency(this IServiceCollection services)
        {
            services.AddApplicationDependency()
                .AddInfrastructureDependency();
            return services;
        }
    }
}
