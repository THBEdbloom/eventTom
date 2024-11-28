using Microsoft.EntityFrameworkCore;

using eventTom.Api.Models;
using eventTom.Api.Models.dataContext;
using eventTom.Api.Repositories.interfaces;

namespace eventTom.Api.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Event> GetByIdAsync(int id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
