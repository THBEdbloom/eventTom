using Microsoft.EntityFrameworkCore;

using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;

namespace eventTom.Api.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await _context.Tickets.FindAsync(id);
        }

        public async Task<IEnumerable<Ticket>> GetByEventIdAsync(int eventId)
        {
            return await _context.Tickets
                .Where(t => t.EventId == eventId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByCustomerIdAsync(int customerId)
        {
            return await _context.Tickets
                .Where(t => t.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
