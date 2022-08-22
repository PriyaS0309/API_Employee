using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public interface IEmployeeRepo
    {
         Task<IEnumerable<Employee>> GetEmployees();
         Task<Employee> GetEmployee(int id);
         Task<Employee> GetEmployeeByName(string name);
        Task<Employee> CreateEmployee(Employee employee);
         Task<Employee> EditEmployee(Employee employee);
         Task<Employee> DeleteEmployee(int id);
      
    }
}
