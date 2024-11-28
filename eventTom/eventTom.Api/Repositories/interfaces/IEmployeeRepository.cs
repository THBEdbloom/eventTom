using eventTom.Api.Models;

namespace eventTom.Api.Repositories.interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);                // Mitarbeiter anhand der ID suchen
        Task<IEnumerable<Employee>> GetAllAsync();          // Alle Mitarbeiter abrufen
    }
}
