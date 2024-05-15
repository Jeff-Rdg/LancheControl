using LancheControl.Domain;
using Microsoft.EntityFrameworkCore;

namespace LancheControl.DataContext
{
    public class LancheContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        
        public LancheContext(DbContextOptions options) : base(options) { }
    }
}