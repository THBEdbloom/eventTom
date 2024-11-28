using eventTom.Api.DTO;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        // Get All Tickets for a specific Event
        public async Task<IEnumerable<TicketDTO>> GetByEventIdAsync(int eventId)
        {
            var tickets = await _ticketRepository.GetByEventIdAsync(eventId);
            return tickets.Select(t => new TicketDTO
            {
                TicketId = t.TicketId,
                FinalPrice = t.FinalPrice,
                PurchaseDate = t.PurchaseDate,
                Used = t.Used,
                EventId = t.EventId,
                CustomerId = t.CustomerId
            });
        }

        // Get Ticket by Id
        public async Task<TicketDTO> GetByIdAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);
            if (ticket == null) return null;

            return new TicketDTO
            {
                TicketId = ticket.TicketId,
                FinalPrice = ticket.FinalPrice,
                PurchaseDate = ticket.PurchaseDate,
                Used = ticket.Used,
                EventId = ticket.EventId,
                CustomerId = ticket.CustomerId
            };
        }

        // Get All Tickets for a specific Customer
        public async Task<IEnumerable<TicketDTO>> GetByCustomerIdAsync(int customerId)
        {
            var tickets = await _ticketRepository.GetByCustomerIdAsync(customerId);
            return tickets.Select(t => new TicketDTO
            {
                TicketId = t.TicketId,
                FinalPrice = t.FinalPrice,
                PurchaseDate = t.PurchaseDate,
                Used = t.Used,
                EventId = t.EventId,
                CustomerId = t.CustomerId
            });
        }
    }
}
