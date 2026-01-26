using Microsoft.Extensions.DependencyInjection;

namespace CleanMediatR.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDependency(this IServiceCollection services)
        {
            return services;
        }
    }
}
