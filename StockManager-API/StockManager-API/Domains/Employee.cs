using StockManager_API.Enums;

namespace StockManager_API.Domains
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Functional { get; set; }
        public DateTime RegistrationDate { get; set; }
        public RoleEmployee Role { get; set; }


        public Employee()
        {
            RegistrationDate = DateTime.Now;
        }
    }
}
