using CleanMediatR.Domain.Entities;
using CleanMediatR.Domain.Interfaces;
using CleanMediatR.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanMediatR.Infrastructure.Repository
{
    public class EmployeeRepository(CleanMediatRDbContext _dbContext) : IEmployeeRepository
    {
        public async Task<EmployeeEntity> CreateNewEmployeeAsync(EmployeeEntity entity)
        {
            _dbContext.Employees.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public async Task<IEnumerable<EmployeeEntity>> ReadAllEmployeesAsync()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<bool> DeleteEmployeeAsync(int employeeId)
        {
            EmployeeEntity? employee = await _dbContext.Employees.SingleOrDefaultAsync(e => e.Id == employeeId);

            if(employee is not null)
            {
                _dbContext.Employees.Remove(employee);
                return await _dbContext.SaveChangesAsync() > 0; // this returns integer value
            }

            return false;
        }


        public async Task<EmployeeEntity> UpdateEmployeeAsync(int employeeId, EmployeeEntity entity)
        {
            EmployeeEntity? employee = _dbContext.Employees.SingleOrDefault(e => e.Id == employeeId);

            if(employee is not null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.IsActive = entity.IsActive;

                await _dbContext.SaveChangesAsync();
            }

            return entity;
        }
    }
}
