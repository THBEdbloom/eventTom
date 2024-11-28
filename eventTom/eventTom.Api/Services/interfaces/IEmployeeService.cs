using eventTom.Api.DTO;

namespace eventTom.Api.Services.interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetAllAsync();
        Task<EmployeeDTO> GetByIdAsync(int id);
    }
}
