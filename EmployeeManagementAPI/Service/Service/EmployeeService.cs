using EmployeeManage.API.Model;
using EmployeeManagement.Service.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeManagement.Service.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> _employee;
        public EmployeeService(IEmployeeDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _employee = database.GetCollection<Employee>(settings.EmployeesCollectionName);

        }

        public async Task<List<Employee>> Get()
        {
            return await _employee.Find(Employee => true).ToListAsync();

        }
        public async Task<string> AddEmployee(Employee addrequest)
        {
            await _employee.InsertOneAsync(addrequest);
            return "Added Successfully";
        }
        public async Task<string> UpdateEmployee(Employee updaterequest)
        {

            await _employee.ReplaceOneAsync(x => x.Id == updaterequest.Id, updaterequest);
            return "Updated Successfully";


        }
        public async Task<string> DeleteEmployee(string id)
        {

            await _employee.DeleteOneAsync(x => x.Id == id);
            return "Deleted Successfully";
        }

        public async Task<Employee> GetById(string id) =>
           await _employee.Find<Employee>(employee => employee.Id == id).FirstOrDefaultAsync();




    }
}
