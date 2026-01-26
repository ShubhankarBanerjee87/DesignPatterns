using CleanMediatR.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanMediatR.Infrastructure.Data
{
    public class CleanMediatRDbContext(DbContextOptions<CleanMediatRDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
