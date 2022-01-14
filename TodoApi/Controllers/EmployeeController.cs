using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
namespace TodoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class EmployeeController : ControllerBase
    {
        private readonly jacobgomezContext _context;

        public EmployeeController(jacobgomezContext context)
        {
            _context = context;
        }

        //GET: /Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> CheckIfEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        //GET:Employees/id
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployees(long id)
        {
            var employees = await _context.Employees.FindAsync(id);

            if (employees == null)
            {
                return NotFound();
            }

            return employees;
        }

        // GET: /Employees/valid/{email}
        [HttpGet("valid/{email}")]
        public async Task<ActionResult<bool>> CheckIfEmployees(string email)
        {
            var employees = await _context.Employees.Where(employees => employees.Email == email).ToListAsync();
            var isValid = false;

            foreach (Employee employee in employees)
            {
                if (employee.Email == email)
                {
                    isValid = true;
                }
            }

            return isValid;
        }



        //-----------------------------------------------------------------------------------------\\

        private bool EmployeesExists(string email)
        {
            return _context.Employees.Any(e => e.Email == email);
        }
    }
}