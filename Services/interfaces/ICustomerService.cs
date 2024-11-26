using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomersAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(long id);
    }

}
