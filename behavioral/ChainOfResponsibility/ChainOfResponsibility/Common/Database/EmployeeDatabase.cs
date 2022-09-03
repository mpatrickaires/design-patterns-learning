using ChainOfResponsibility.Common.Models;

namespace ChainOfResponsibility.Common.Database
{
    public class EmployeeDatabase
    {
        private IList<Employee> _employees = new List<Employee>();

        public EmployeeDatabase()
        {
            var employee = new Employee
            {
                Name = "Walter White",
                Position = "Chemist",
                EmployeeId = 1,
            };
            _employees.Add(employee);

            employee = new Employee
            {
                Name = "Ford Prefect",
                Position = "Writer",
                EmployeeId = 2,
            };
            _employees.Add(employee);
        }

        public Employee GetEmployeeById(uint employeeId) => _employees.FirstOrDefault(e => e.EmployeeId == employeeId);

        public void AddEmployee(Employee employee) => _employees.Add(employee);
    }
}
