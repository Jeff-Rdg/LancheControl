using LancheControl.Enums;

namespace LancheControl.Domain
{
    public class Employee
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public Role Role { get; set; }
    }
}