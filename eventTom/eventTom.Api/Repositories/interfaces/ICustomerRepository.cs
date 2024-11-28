using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(int id);              // Kunden anhand der ID suchen
        Task<IEnumerable<Customer>> GetAllAsync();        // Alle Kunden abrufen
    }
}
