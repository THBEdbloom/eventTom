using eventTom.Api.DTO;
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

        public async Task<IEnumerable<EventDTO>> GetAllAsync()
        {
            var events = await _eventRepository.GetAllAsync();
            return events.Select(e => new EventDTO
            {
                Id = e.Id,
                Title = e.Title,
                Date = e.Date,
                TotalTickets = e.TotalTickets,
                SoldTickets = e.SoldTickets,
                ThresholdValue = e.ThresholdValue,
                BasePrice = e.BasePrice
            });
        }

        public async Task<EventDTO> GetByIdAsync(int id)
        {
            var eventEntity = await _eventRepository.GetByIdAsync(id);
            if (eventEntity == null) return null;

            return new EventDTO
            {
                Id = eventEntity.Id,
                Title = eventEntity.Title,
                Date = eventEntity.Date,
                TotalTickets = eventEntity.TotalTickets,
                SoldTickets = eventEntity.SoldTickets,
                ThresholdValue = eventEntity.ThresholdValue,
                BasePrice = eventEntity.BasePrice
            };
        }
    }
}
