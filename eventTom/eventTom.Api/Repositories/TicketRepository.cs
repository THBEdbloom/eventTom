using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace eventTom.Api.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _context;

        public TicketRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Ticket> GetByIdAsync(long id)
        {
            return await _context.Tickets
                .Include(t => t.Event)
                .Include(t => t.Customer)
                .FirstOrDefaultAsync(t => t.TicketId == id);
        }

        public async Task<IEnumerable<Ticket>> GetByCustomerIdAsync(long customerId)
        {
            return await _context.Tickets
                .Include(t => t.Event)
                .Where(t => t.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByEventIdAsync(long eventId)
        {
            return await _context.Tickets
                .Include(t => t.Customer)
                .Where(t => t.EventId == eventId)
                .ToListAsync();
        }
    }
}
