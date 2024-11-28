using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface ITicketRepository
    {
        Task<Ticket> GetByIdAsync(int id);                  // Ticket anhand der ID suchen
        Task<IEnumerable<Ticket>> GetByEventIdAsync(int eventId); // Alle Tickets für ein Event suchen
        Task<IEnumerable<Ticket>> GetByCustomerIdAsync(int customerId); // Alle Tickets eines Kunden suchen
    }
}
