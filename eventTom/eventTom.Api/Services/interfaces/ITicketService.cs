using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface ITicketService
    {
        Task<TicketDTO> GetByIdAsync(int id);
        Task<IEnumerable<TicketDTO>> GetByEventIdAsync(int eventId);
        Task<IEnumerable<TicketDTO>> GetByCustomerIdAsync(int customerId);
    }
}
