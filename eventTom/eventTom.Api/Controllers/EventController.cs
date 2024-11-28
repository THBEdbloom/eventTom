using Microsoft.AspNetCore.Mvc;

using eventTom.Api.Services.interfaces;
using eventTom.Api.DTO;

namespace eventTom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/Event
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventDTO>>> GetAllEvents()
        {
            var events = await _eventService.GetAllAsync();
            return Ok(events);
        }

        // GET: api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventDTO>> GetEventById(int id)
        {
            var eventDTO = await _eventService.GetByIdAsync(id);
            if (eventDTO == null)
            {
                return NotFound();
            }
            return Ok(eventDTO);
        }
    }
}
