using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetByIdAsync(long id);
        Task<IEnumerable<Event>> GetAllAsync();
    }
}
