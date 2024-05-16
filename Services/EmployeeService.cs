using LancheControl.DataContext;
using LancheControl.DTO;
using LancheControl.DTO.Employee;
using LancheControl.Mapper;

namespace LancheControl.Services
{
    public class EmployeeService
    {
        private readonly LancheContext _context;

        public EmployeeService(LancheContext context)
        {
            _context = context;
        }

        public EmployeeResponseDto Create(EmployeeCreateDto body)
        {
            var employee = EmployeeMapper.EmployeeCreateToEmployee(body);

            _context.Add(employee);
            _context.SaveChanges();

            return EmployeeMapper.EmployeeToResponse(employee);
        }
    }
}