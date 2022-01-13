using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManage.API.Model
{
    public class EmployeeDatabaseSettings : IEmployeeDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string EmployeesCollectionName { get; set; }
    }
    public interface IEmployeeDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string EmployeesCollectionName { get; set; }


    }
}
