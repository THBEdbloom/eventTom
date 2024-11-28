using Microsoft.EntityFrameworkCore;

using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;

namespace eventTom.Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
