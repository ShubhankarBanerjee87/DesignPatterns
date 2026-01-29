using CleanMediatR.Domain.Entities;
using CleanMediatR.Domain.Interfaces;
using MediatR;

namespace CleanMediatR.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee) : IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandeler(IEmployeeRepository employeeRepository) : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.CreateNewEmployeeAsync(request.Employee);
        }
    }
}
