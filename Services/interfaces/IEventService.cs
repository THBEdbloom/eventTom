using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetAllEventsAsync();
        Task<EventDTO> GetEventByIdAsync(long id);
    }
}
