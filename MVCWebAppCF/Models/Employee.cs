using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class Employee
    {
        [Key]
        public string RegisterId { get; set; } = "";
        public string Nominative { get; set; } = "";
        public string Role { get; set; } = "";
        public string Department { get; set; } = "";
        public int Age { get; set; }
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Province { get; set; } = "";
        public string Cap { get; set; } = "";
        public int PhoneNumber { get; set; }
        public List<EmployeeActivities> EmployersActivities { get; set; } = new();

    }
}
