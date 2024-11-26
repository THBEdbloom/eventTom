using eventTom.Api.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eventTom.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("{id:long}")]
        public async Task<IActionResult> GetTicketById(long id)
        {
            var ticket = await _ticketService.GetTicketByIdAsync(id);
            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

        [HttpGet("customer/{customerId:long}")]
        public async Task<IActionResult> GetTicketsByCustomer(long customerId)
        {
            var tickets = await _ticketService.GetTicketsByCustomerAsync(customerId);
            return Ok(tickets);
        }

        [HttpGet("event/{eventId:long}")]
        public async Task<IActionResult> GetTicketsByEvent(long eventId)
        {
            var tickets = await _ticketService.GetTicketsByEventAsync(eventId);

            if (tickets == null || tickets.Count() == 0)
            {
                return NotFound($"No tickets found for event with ID {eventId}");
            }

            return Ok(tickets);
        }
    }
}
