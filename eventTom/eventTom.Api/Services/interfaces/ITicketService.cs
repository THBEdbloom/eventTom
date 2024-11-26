using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface ITicketService
    {
        Task<TicketDTO> GetTicketByIdAsync(long id);
        Task<IEnumerable<TicketDTO>> GetTicketsByCustomerAsync(long customerId);

        Task<IEnumerable<TicketDTO>> GetTicketsByEventAsync(long eventId);
    }
}
