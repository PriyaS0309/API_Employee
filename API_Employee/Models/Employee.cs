using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }


        
        public virtual Gender Gender  { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]

        public virtual IEnumerable<Department> Department { get; set; }

    }
}
