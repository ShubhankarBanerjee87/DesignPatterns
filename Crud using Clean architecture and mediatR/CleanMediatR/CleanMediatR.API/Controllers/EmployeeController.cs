using CleanMediatR.Application.Commands;
using CleanMediatR.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanMediatR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> CreateEmployeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok();
        }
    }
}
