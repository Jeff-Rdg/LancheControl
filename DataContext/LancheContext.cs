using LancheControl.Domain;
using Microsoft.EntityFrameworkCore;

namespace LancheControl.DataContext
{
    public class LancheContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        
        public LancheContext(DbContextOptions options) : base(options) { }
    }
}