using WorkerManagement.Models;
using WorkerManagement.Services;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

namespace WorkerManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly  EmployeeService _service;
        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }
        [HttpPost("Register Employee")]
        public async Task<IActionResult> RegisterEmployee(Employee employee)
        {
            try
            {
                await _service.RegisterEmployee(employee);
                return CreatedAtAction(nameof(GetEmployees), new { id = employee.Id}, employee);

            }
            catch (Exception ex)
            {
                StatusCode(500, ex.Message);
            }
            return Ok(""); 
        }
        [HttpGet("Get Employees")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employees = await _service.GetEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                StatusCode(500, ex.Message);

            }
            return Ok("");     
        }  
    }
}

