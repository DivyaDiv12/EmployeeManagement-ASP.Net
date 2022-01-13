using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManage.API.Model
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string EmployeeId { get; set; }

        [BsonElement("Name")]
        public string EmployeeName { get; set; }

        public string Department { get; set; }

        public string DateOfJoining { get; set; }


    }
}
