using CleanMediatR.Domain.Entities;

namespace CleanMediatR.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<EmployeeEntity> CreateNewEmployeeAsync(EmployeeEntity entity);
        public Task<IEnumerable<EmployeeEntity>> ReadAllEmployeesAsync();
        public Task<EmployeeEntity> UpdateEmployeeAsync(int employeeId, EmployeeEntity entity);
        public Task<bool> DeleteEmployeeAsync(int employeeId);

    }
}
