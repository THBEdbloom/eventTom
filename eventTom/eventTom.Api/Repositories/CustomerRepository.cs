using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace eventTom.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers
                .Include(c => c.Vouchers)
                .Include(c => c.Tickets)
                .ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(long id)
        {
            return await _context.Customers
                .Include(c => c.Vouchers)
                .Include(c => c.Tickets)
                .FirstOrDefaultAsync(c => c.CustomerId == id);
        }
    }
}
