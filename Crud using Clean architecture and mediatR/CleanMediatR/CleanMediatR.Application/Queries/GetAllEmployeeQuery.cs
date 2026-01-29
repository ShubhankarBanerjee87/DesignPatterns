using CleanMediatR.Domain.Entities;
using CleanMediatR.Domain.Interfaces;
using MediatR;

namespace CleanMediatR.Application.Queries
{
    public record GetAllEmployeeQuery() : IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHandeler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.ReadAllEmployeesAsync();
        }
    }
}
