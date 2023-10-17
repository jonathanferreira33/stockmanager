using StockManager_API.Domains;

namespace StockManager_API.Data
{
    public class EmployeeData
    {
        private readonly AppDbContext _context;

        public EmployeeData(AppDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            employees = _context.Employees.OrderBy(e => e.Name).ToList();
            return employees;
        }

        public Employee GetById(int id)
        {
            var employee = new Employee();
            employee = _context.Employees.Find(id);

            return employee;
        }

        public async void Create(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async void Update(Employee employee)
        {

        }
    }
}
