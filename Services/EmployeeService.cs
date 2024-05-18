using LancheControl.DataContext;
using LancheControl.Domain;
using LancheControl.DTO;
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

        public EmployeeResponseDto Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();

            return EmployeeMap.ToResponse(employee);
        }

        public EmployeeResponseDto? GetById(long id)
        {
            var result = _context.Employees.Find(id);
            if (result != null)
                return EmployeeMap.ToResponse(result);
            return null;
        }
    }
}