using static WebApplication1.obj.Person;

namespace WebApplication1.obj
{
    public class Employers : PersonData
    {
        public override string RegisterId { get; set; } = "";
        public override string Nominative { get; set; } = "";
        public string Role { get; set; } = "";
        public string Department { get; set; } = "";
        public override int Age { get; set; }
        public override string Address { get; set; } = "";
        public override string City { get; set; } = "";
        public override string Province { get; set; } = "";
        public override string Cap { get; set; } = "";
        public override int PhoneNumber { get; set; }
        internal static List<EmployersActivity> TotalEmployersActivitiesList { get; private set; } = new();
        public List<EmployersActivity> EmployersActivities { get; set; } = new();

        public Employers() { /*the silent is golden */}
        internal Employers(string RegisterId, string Nominative, string Role, string Department, string Age, string Address, string City, string Province, string Cap, string PhoneNumber)
        {
            this.RegisterId = RegisterId;
            this.Nominative = Nominative;
            this.Role = Role;
            this.Department = Department;
            if (int.TryParse(Age, out int parsedAge)) this.Age = parsedAge;
            this.Address = Address;
            this.City = City;
            this.Province = Province;
            this.Cap = Cap;
            if (int.TryParse(PhoneNumber, out int parsedPhoneNumber)) this.PhoneNumber = parsedPhoneNumber;
        }
    }
}
