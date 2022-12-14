using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public interface IDepartmentRepo
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartmentByName(string name);

        Task<Department> GetDepartmentById(int id);

        Task<Department> CreateDepartment(Department department);

        Task<Department> EditDepartment(Department department);

        Task<Department> DeleteDepartment(int id);
    }
}
