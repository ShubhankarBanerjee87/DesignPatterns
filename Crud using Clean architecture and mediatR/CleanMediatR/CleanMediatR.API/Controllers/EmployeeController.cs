using CleanMediatR.Application.Commands;
using CleanMediatR.Application.Queries;
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

        [HttpGet("")]
        public async Task<IActionResult> GetAllEmployeesAsync()
        {
            var result = await sender.Send(new GetAllEmployeeQuery());

            if (result == null)
                return NoContent();

            return Ok(result);
        }
    }
}
