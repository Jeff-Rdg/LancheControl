using LancheControl.DataContext;
using LancheControl.Domain;
using LancheControl.DTO;
using LancheControl.Mapper;
using Microsoft.EntityFrameworkCore;

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

        public PagedResponseDto<List<EmployeeResponseDto>> List(int pageNumber, int pageSize)
        {
            
            var totalRecords = _context.Employees.AsNoTracking().Count();
            
            var employees = _context.Employees.AsNoTracking()
                .OrderBy(x => x.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            
            List<EmployeeResponseDto> employeeResponses = new ();
            employees.ForEach(x => employeeResponses.Add(EmployeeMap.ToResponse(x)));
            
            var pagedResponse = new PagedResponseDto<List<EmployeeResponseDto>>()
            {
                Data = employeeResponses,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalRecords
            };
            return pagedResponse;
        }
    }
}