using StockManager_API.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager_API.Domains
{
    [Table("TB_Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Functional { get; private set; }
        public DateTime RegistrationDate { get; set; }
        public RoleEmployee Role { get; set; }
        public SystemProfile Profile { get; set; }


        public Employee(string name, RoleEmployee role)
        {
            RegistrationDate = DateTime.Now;
            Functional = SetFunctional(name);
            Role = role;
            Name = name;
        }

        private string SetFunctional(string name)
        {
            string funcional = "a";
            Functional = funcional + char.ToUpper(name[0]);
            return Functional;
        }
    }
}
