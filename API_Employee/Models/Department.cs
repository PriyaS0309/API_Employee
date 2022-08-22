using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string  DepartmentName { get; set; }
    }
}
