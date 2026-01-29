using CleanMediatR.Domain.Interfaces;
using CleanMediatR.Infrastructure.Data;
using CleanMediatR.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMediatR.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services)
        {
            services.AddDbContext<CleanMediatRDbContext>(options => 
                options.UseSqlServer("connection string goes here")
            );

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }

    }
}
