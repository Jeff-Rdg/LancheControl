using System.ComponentModel.DataAnnotations;
using LancheControl.Enums;

namespace LancheControl.Domain
{
    public class Employee
    {
        [Key]
        public long Id { get; set; }
        
        [Required(ErrorMessage="O nome do funcionário é obrigatório",AllowEmptyStrings=false)]
        public string? Name { get; set; }

        [Required(ErrorMessage="O cargo do funcionário é obrigatório")] 
        public Role Role { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
    }
}