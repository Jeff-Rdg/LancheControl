using LancheControl.Enums;

namespace LancheControl.DTO
{
    public class EmployeeResponseDto
    {
        public long Id { get; set; }
        
        public string? Name { get; set; }
        
        public Role Role { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}