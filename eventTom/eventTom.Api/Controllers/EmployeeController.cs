using eventTom.Api.DTO;
using eventTom.Api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eventTom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployeeById(int id)
        {
            var employeeDTO = await _employeeService.GetByIdAsync(id);
            if (employeeDTO == null)
            {
                return NotFound();
            }
            return Ok(employeeDTO);
        }

        // GET: api/Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDTO>>> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllAsync();
            return Ok(employees);
        }
    }
}
