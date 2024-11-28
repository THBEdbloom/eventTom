using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllAsync();
        Task<CustomerDTO> GetByIdAsync(int id);
    }
}
