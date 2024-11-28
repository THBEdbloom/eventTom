using Microsoft.EntityFrameworkCore;

using eventTom.Api.Models.dataContext;
using eventTom.Api.Models;
using eventTom.Api.Repositories.interfaces;

namespace eventTom.Api.Repositories
{
    public class VoucherRepository : IVoucherRepository
    {
        private readonly ApplicationDbContext _context;

        public VoucherRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Voucher> GetByIdAsync(int id)
        {
            return await _context.Vouchers.FindAsync(id);
        }

        public async Task<IEnumerable<Voucher>> GetByCustomerIdAsync(int customerId)
        {
            return await _context.Vouchers
                .Where(v => v.CustomerId == customerId)
                .ToListAsync();
        }
    }
}
