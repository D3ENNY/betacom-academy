using static gestioneDipendenti.obj.Person;
using ToolBoxLibrary.Attr;

namespace gestioneDipendenti.obj;

class Employers : PersonData
{
    [TXTReader]
    public override string RegisterId { get; set; } = "";
    [TXTReader]
    public override string Nominative { get; set; } = "";
    [TXTReader]
    public string Role{get;set;} = "";
    [TXTReader]
    public string Department{get;set;} = "";
    [TXTReader]
    public override int Age { get; set; }
    [TXTReader]
    public override string Address { get; set; } = "";
    [TXTReader]
    public override string City { get; set; } = "";
    [TXTReader]
    public override string Province { get; set; } = "";
    [TXTReader]
    public override string Cap { get; set; } = "";
    [TXTReader]
    public override int PhoneNumber { get; set; }
    [TXTReader]
    internal static List<EmployersActivity> TotalEmployersActivitiesList{get; private set;} = new();
    public List<EmployersActivity> EmployersActivities{get; set;} = new();

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
        if(int.TryParse(PhoneNumber, out int parsedPhoneNumber)) this.PhoneNumber = parsedPhoneNumber;
    }

    internal string GetDataObj() => $"|{RegisterId}{new string(' ', 5-RegisterId.Length)} | " + 
                                    $"{Nominative}{new string(' ', 35-Nominative.Length)} | " +
                                    $"{Role}{new string(' ', 20-Role.Length)} | " +
                                    $"{Department}{new string(' ', 35-Department.Length)} | " +
                                    $"{Age}{new string(' ', 3-Age.ToString().Length)} | " + 
                                    $"{Address}{new string(' ', 45-Address.Length)} | " +
                                    $"{City}{new string(' ',20-City.Length)} | " + 
                                    $"{Province}{new string(' ',10-Province.Length)} | " + 
                                    $"{Cap} | " + 
                                    $"{PhoneNumber}{new string(' ', 10-PhoneNumber.ToString().Length)} |";

    public override string ToString() => $@"matricola: {RegisterId}
    nominativo: {Nominative}
    ruolo: {Role}
    reparto: {Department}
    età: {Age}
    indirizzo: {Address}
    city: {City}
    province: {Province}
    cap: {Cap}
    numero di telefono: {PhoneNumber}";

}