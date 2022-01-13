using EmployeeManage.API.Model;
using EmployeeManagement.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService bookService)
        {
            _employeeService = bookService;
        }

        [HttpGet("GetEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Employee>))]
        public async Task<IActionResult> GetEmployee()
        {
            return Ok(await _employeeService.Get());
        }

        [HttpGet("GetEmployeeById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        public async Task<IActionResult> GetEmployeeById(string id)
        {
            return Ok(await _employeeService.GetById(id));
        }

        [HttpPost("AddEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<IActionResult> AddEmployee(Employee addrequest)
        {
            return Ok(await _employeeService.AddEmployee(addrequest));
        }

        [HttpPatch("UpdateEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<IActionResult> UpdateEmployee(Employee updaterequest)
        {
            return Ok(await _employeeService.UpdateEmployee(updaterequest));
        }

        [HttpDelete("DeleteEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            return Ok(await _employeeService.DeleteEmployee(id));
        }
    }
}
