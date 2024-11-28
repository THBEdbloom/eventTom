using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface IVoucherRepository
    {
        Task<Voucher> GetByIdAsync(int id);                  // Gutschein anhand der ID suchen
        Task<IEnumerable<Voucher>> GetByCustomerIdAsync(int customerId); // Alle Gutscheine eines Kunden suchen
    }
}
