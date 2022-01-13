using EmployeeManage.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.Interface
{
    public interface IEmployeeService
    {
        Task<List<Employee>> Get();
        Task<string> AddEmployee(Employee addrequest);
        Task<string> UpdateEmployee(Employee updaterequest);
        Task<string> DeleteEmployee(string id);
        Task<Employee> GetById(string id);

    }
}
