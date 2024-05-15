using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LancheControl.Domain
{
    public class OrderItem
    {
        [Key]
        public long Id { get; set; }
        
        [ForeignKey("order_id")]
        public long OrderId { get; set; }

        public Order Order { get; set; }
        
        [ForeignKey("product_id")]
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}