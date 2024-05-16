using System.ComponentModel.DataAnnotations;
using LancheControl.Enums;

namespace LancheControl.DTO.Employee
{
    public class EmployeeCreateDto
    {
        [Required(ErrorMessage="O nome do funcionário é obrigatório",AllowEmptyStrings=false)]
        [MaxLength(155, ErrorMessage = "Nome do funcionário não pode ultrapassar 155 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage="O cargo do funcionário é obrigatório")] 
        public Role Role { get; set; }
    }
}