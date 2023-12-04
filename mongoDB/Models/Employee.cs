using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mongoDB.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int OldId { get; set; }
        public string Name { get; set; }
        public string EmployeeEnrolNumber { get; set; }
        public string EmployeeJob { get; set; }
        public string EmployeeDepartment { get; set; }
        public List<calendarEmployees> calendarEmployees { get; set; } = new List<calendarEmployees>();
    }

    public class calendarEmployees
    {
        public int OldId { get; set; }
        public string EmployeeEnrolNumber { get; set; }
        public DateTime DateActivity { get; set; }
        public string Activity { get; set; }
    }
}
