using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;
using LancheControl.Domain;
using LancheControl.Enums;

namespace LancheControl.DTO
{
    public class EmployeeCreateDto : Notifiable<Notification>
    {
        public string? Name { get; set; }
        public Role Role { get; set; }

        public Employee MapTo()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNullOrEmpty(Name, "name", "O nome do funcionário é obrigatório")
                .IsLowerOrEqualsThan(Name, 155, "name", "Nome do funcionário não pode ultrapassar 155 caracteres.")
                .IsNotNull(Role, "role", "O cargo do funcionário é obrigatório"));

            return new Employee()
            {
                Name = Name,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now, 
                Role = Role,
            };
        }
    }
}