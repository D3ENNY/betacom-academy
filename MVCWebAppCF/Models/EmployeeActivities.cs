using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class EmployeeActivities
    {
        [Key]
        public int Id { get; private set; }
        public DateTime Date { get; set; }
        public string Activity { get; set; } = "";
        public int AmountHour { get; set; }
        public string EmployerID { get; set; } = "";

    }
}
