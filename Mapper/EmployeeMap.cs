using LancheControl.Domain;
using LancheControl.DTO;

namespace LancheControl.Mapper
{
    public static class EmployeeMap
    {
        public static EmployeeResponseDto ToResponse(Employee employee)
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
    }
}