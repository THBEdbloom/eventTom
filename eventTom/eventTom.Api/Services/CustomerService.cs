using eventTom.Api.DTO;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.Select(c => new CustomerDTO
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Tickets = c.Tickets.Select(t => new TicketDTO
                {
                    TicketId = t.TicketId,
                    FinalPrice = t.FinalPrice,
                    PurchaseDate = t.PurchaseDate,
                    EventId = t.EventId,
                    CustomerId = t.CustomerId
                }).ToList(),
                Vouchers = c.Vouchers.Select(v => new VoucherDTO
                {
                    VoucherId = v.VoucherId,
                    Amount = v.Amount,
                    ValidUntil = v.ValidUntil,
                    CustomerId = v.CustomerId
                }).ToList()
            });
        }

        public async Task<CustomerDTO> GetByIdAsync(int id)
        {
            var customer = await _customerRepository.GetByIdAsync(id);
            if (customer == null) return null;

            return new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Tickets = customer.Tickets.Select(t => new TicketDTO
                {
                    TicketId = t.TicketId,
                    FinalPrice = t.FinalPrice,
                    PurchaseDate = t.PurchaseDate,
                    EventId = t.EventId,
                    CustomerId = t.CustomerId
                }).ToList(),
                Vouchers = customer.Vouchers.Select(v => new VoucherDTO
                {
                    VoucherId = v.VoucherId,
                    Amount = v.Amount,
                    ValidUntil = v.ValidUntil,
                    CustomerId = v.CustomerId
                }).ToList()
            };
        }
    }
}
