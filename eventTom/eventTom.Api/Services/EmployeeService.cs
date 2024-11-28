using eventTom.Api.DTO;
using eventTom.Api.Repositories.interfaces;
using eventTom.Api.Services.interfaces;

namespace eventTom.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return employees.Select(e => new EmployeeDTO
            {
                EmployeeId = e.EmployeeId,
                Position = e.Position,
                Name = e.Name,
                Email = e.Email
            });
        }

        public async Task<EmployeeDTO> GetByIdAsync(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null) return null;

            return new EmployeeDTO
            {
                EmployeeId = employee.EmployeeId,
                Position = employee.Position,
                Name = employee.Name,
                Email = employee.Email
            };
        }
    }
}
