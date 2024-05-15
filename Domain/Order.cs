using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancheControl.Domain
{
    public class Order
    {
        [Key]
        public long Id { get; set; }
        
        [ForeignKey("employee_id")]
        public long EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalOrderPrice { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new();

    }
}