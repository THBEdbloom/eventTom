using eventTom.Api.DTO;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly IVoucherRepository _voucherRepository;

        public VoucherService(IVoucherRepository voucherRepository)
        {
            _voucherRepository = voucherRepository;
        }

        // Get Voucher by Id
        public async Task<VoucherDTO> GetByIdAsync(int id)
        {
            var voucher = await _voucherRepository.GetByIdAsync(id);
            if (voucher == null) return null;

            return new VoucherDTO
            {
                VoucherId = voucher.VoucherId,
                Amount = voucher.Amount,
                ValidUntil = voucher.ValidUntil,
                CustomerId = voucher.CustomerId
            };
        }

        // Get all Vouchers by CustomerId
        public async Task<IEnumerable<VoucherDTO>> GetByCustomerIdAsync(int customerId)
        {
            var vouchers = await _voucherRepository.GetByCustomerIdAsync(customerId);
            return vouchers.Select(v => new VoucherDTO
            {
                VoucherId = v.VoucherId,
                Amount = v.Amount,
                ValidUntil = v.ValidUntil,
                CustomerId = v.CustomerId
            });
        }
    }
}
