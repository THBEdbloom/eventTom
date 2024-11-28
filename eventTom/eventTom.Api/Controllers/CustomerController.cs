using eventTom.Api.DTO;
using eventTom.Api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eventTom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomerById(int id)
        {
            var customerDTO = await _customerService.GetByIdAsync(id);
            if (customerDTO == null)
            {
                return NotFound();
            }
            return Ok(customerDTO);
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetAllCustomers()
        {
            var customers = await _customerService.GetAllAsync();
            return Ok(customers);
        }
    }
}
