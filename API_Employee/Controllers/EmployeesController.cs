using API_Employee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepo employeerepo;
        public EmployeesController(IEmployeeRepo employeerepo)
        {
            this.employeerepo = employeerepo;
        }

        [HttpGet]

        public async Task<ActionResult>GetEmployees()
        {
            return Ok(await employeerepo.GetEmployees());
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult> GetEmployeeById(int id)
        {
            return Ok(await employeerepo.GetEmployee(id));
        }


        [HttpGet("{name}")]

        public async Task<ActionResult> GetEmployeeByName(string name)
        {
            return Ok(await employeerepo.GetEmployeeByName(name));
        }

        [HttpPost]

        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            var CreatedEmployee = await employeerepo.CreateEmployee(employee);

            return CreatedAtAction(nameof(GetEmployeeById), new { id = CreatedEmployee.EmployeeID }, CreatedEmployee);

        }

        [HttpPut("{id:int}")]

        public async Task<ActionResult<Employee>> EditEmployee(int id,Employee employee)
        {
            var updatedEmployee = await employeerepo.GetEmployee(id);

            return await employeerepo.EditEmployee(employee);

        }

        [HttpDelete("{id:int}")]

        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            var deleteEmployee = await employeerepo.GetEmployee(id);

            return await employeerepo.DeleteEmployee(id);

        }



    }
}
