using eventTom.Api.DTO;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<IEnumerable<EventDTO>> GetAllEventsAsync()
        {
            var events = await _eventRepository.GetAllAsync();
            return events.Select(ToDTO);
        }

        public async Task<EventDTO> GetEventByIdAsync(long id)
        {
            var eventEntity = await _eventRepository.GetByIdAsync(id);
            return eventEntity == null ? null : ToDTO(eventEntity);
        }

        private EventDTO ToDTO(Event eventEntity)
        {
            return new EventDTO
            {
                EventId = eventEntity.EventId,
                Title = eventEntity.Title,
                AvailableTickets = eventEntity.TotalTickets - eventEntity.SoldTickets,
                Price = eventEntity.BasePrice
            };
        }
    }

}
