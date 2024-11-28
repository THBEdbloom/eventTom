using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface IVoucherService
    {
        Task<VoucherDTO> GetByIdAsync(int id);  // Holt einen Gutschein anhand der ID
        Task<IEnumerable<VoucherDTO>> GetByCustomerIdAsync(int customerId);  // Holt alle Gutscheine eines Kunden
    }
}
