using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(long id);
    }

}
