using eventTom.Api.DTO;
using eventTom.Api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eventTom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDTO>> GetTicketById(int id)
        {
            var ticketDTO = await _ticketService.GetByIdAsync(id);
            if (ticketDTO == null)
            {
                return NotFound();
            }
            return Ok(ticketDTO);
        }

        // GET: api/Ticket/Event/5
        [HttpGet("Event/{eventId}")]
        public async Task<ActionResult<IEnumerable<TicketDTO>>> GetTicketsByEventId(int eventId)
        {
            var tickets = await _ticketService.GetByEventIdAsync(eventId);
            return Ok(tickets);
        }

        // GET: api/Ticket/Customer/5
        [HttpGet("Customer/{customerId}")]
        public async Task<ActionResult<IEnumerable<TicketDTO>>> GetTicketsByCustomerId(int customerId)
        {
            var tickets = await _ticketService.GetByCustomerIdAsync(customerId);
            return Ok(tickets);
        }
    }
}
