using CleanMediatR.Domain.Entities;
using CleanMediatR.Domain.Interfaces;
using MediatR;

namespace CleanMediatR.Application.Commands
{
    public record UpdateEmployeeByIdCommand(int employeeId, EmployeeEntity employee) : IRequest<EmployeeEntity>;

    public class UpdateEmployeeByIdCommandHandeler(IEmployeeRepository employeeRepository) : IRequestHandler<UpdateEmployeeByIdCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeByIdCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeeAsync(request.employeeId, request.employee);
        }
    }
}
