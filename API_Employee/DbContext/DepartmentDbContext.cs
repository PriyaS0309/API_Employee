using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public class DepartmentDbContext:DbContext
    {
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext>options):base(options)
        {

        }

        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
