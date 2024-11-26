using eventTom.Api.Models;
using eventTom.Api.Models.dataContext;
using eventTom.Api.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace eventTom.Api.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Event> GetByIdAsync(long id)
        {
            return await _context.Events.FindAsync(id);
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await _context.Events.ToListAsync();
        }
    }
}
