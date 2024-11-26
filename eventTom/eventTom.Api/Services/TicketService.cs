using eventTom.Api.DTO;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IEventRepository _eventRepository;
        private readonly ICustomerRepository _customerRepository;

        public TicketService(
            ITicketRepository ticketRepository,
            IEventRepository eventRepository,
            ICustomerRepository customerRepository)
        {
            _ticketRepository = ticketRepository;
            _eventRepository = eventRepository;
            _customerRepository = customerRepository;
        }

        public async Task<TicketDTO> GetTicketByIdAsync(long id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);
            if (ticket == null)
                return null;

            return ToDTO(ticket);
        }

        public async Task<IEnumerable<TicketDTO>> GetTicketsByCustomerAsync(long customerId)
        {
            var tickets = await _ticketRepository.GetByCustomerIdAsync(customerId);
            return tickets.Select(ToDTO);
        }

        public async Task<IEnumerable<TicketDTO>> GetTicketsByEventAsync(long eventId)
        {
            var tickets = await _ticketRepository.GetByEventIdAsync(eventId);
            return tickets.Select(ToDTO);
        }

        private TicketDTO ToDTO(Ticket ticket)
        {
            return new TicketDTO
            {
                TicketId = ticket.TicketId,
                EventTitle = ticket.Event?.Title ?? "Unknown Event",
                OwnerName = ticket.Customer != null
                    ? $"{ticket.Customer.FirstName} {ticket.Customer.LastName}"
                    : "Unknown Customer",
                FinalPrice = ticket.FinalPrice,
                PurchaseDate = ticket.PurchaseDate,
                TicketNumber = ticket.TicketNumber
            };
        }
    }

}
