using eventTom.Api.DTO;
using eventTom.Api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eventTom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }

        // GET: api/Voucher/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoucherDTO>> GetVoucherById(int id)
        {
            var voucherDTO = await _voucherService.GetByIdAsync(id);
            if (voucherDTO == null)
            {
                return NotFound();
            }
            return Ok(voucherDTO);
        }

        // GET: api/Voucher/Customer/5
        [HttpGet("Customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<VoucherDTO>>> GetVouchersByCustomerId(int customerId)
        {
            var vouchers = await _voucherService.GetByCustomerIdAsync(customerId);
            return Ok(vouchers);
        }
    }
}
