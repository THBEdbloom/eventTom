using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface ITicketRepository
    {
        Task<Ticket> GetByIdAsync(long id);
        Task<IEnumerable<Ticket>> GetByCustomerIdAsync(long customerId);
        Task<IEnumerable<Ticket>> GetByEventIdAsync(long eventId);
    }
}
