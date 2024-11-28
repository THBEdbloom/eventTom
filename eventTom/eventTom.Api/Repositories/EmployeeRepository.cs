using Microsoft.EntityFrameworkCore;

using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;

namespace eventTom.Api.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
