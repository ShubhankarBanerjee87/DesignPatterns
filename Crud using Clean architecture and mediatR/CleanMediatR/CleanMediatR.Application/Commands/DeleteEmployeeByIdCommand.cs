using CleanMediatR.Domain.Interfaces;
using MediatR;

namespace CleanMediatR.Application.Commands
{
    public record DeleteEmployeeByIdCommand(int employeeId) : IRequest<bool>;
    public class DeleteEmployeeByIdCommandHandeler(IEmployeeRepository employeeRepository) : IRequestHandler<DeleteEmployeeByIdCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeByIdCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeeAsync(request.employeeId);
        }
    }
}
