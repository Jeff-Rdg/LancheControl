using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LancheControl.Domain
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        
        [Required(ErrorMessage="O nome do produto é obrigatório",AllowEmptyStrings=false)]
        [MaxLength(100, ErrorMessage = "Nome do produto não pode ultrapassar 100 caracteres.")]
        public string? Name { get; set; }

        public string? Description { get; set; } = string.Empty;

        [Precision(10,2)]
        public decimal Price { get; set; }
    }
}