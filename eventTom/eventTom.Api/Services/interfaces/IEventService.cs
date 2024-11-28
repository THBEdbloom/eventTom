using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface IEventService
    {
        Task<IEnumerable<EventDTO>> GetAllAsync();
        Task<EventDTO> GetByIdAsync(int id);
    }
}
