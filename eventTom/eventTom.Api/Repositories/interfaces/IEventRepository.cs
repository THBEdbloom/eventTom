using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetByIdAsync(int id);                   // Event anhand der ID suchen
        Task<IEnumerable<Event>> GetAllAsync();             // Alle Events abrufen
    }
}
