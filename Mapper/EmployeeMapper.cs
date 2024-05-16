using LancheControl.Domain;
using LancheControl.DTO;
using LancheControl.DTO.Employee;

namespace LancheControl.Mapper
{
    public static class EmployeeMapper
    {
        public static EmployeeResponseDto EmployeeToResponse(Employee employee)
        {
            return new EmployeeResponseDto
            {
                Id = employee.Id,
                CreatedAt = employee.CreatedAt,
                UpdatedAt = employee.UpdatedAt,
                Name = employee.Name,
                Role = employee.Role
            };
        }

        public static Employee EmployeeCreateToEmployee(EmployeeCreateDto dto)
        {
            return new Employee
            {
                Name = dto.Name,
                Role = dto.Role
            };
        }
    }
}