using static gestioneDipendenti.obj.Person;

namespace gestioneDipendenti.obj;

class Employers : PersonData
{
    public override string RegisterId { get; set; } = "";
    public override string Nominative { get; set; } = "";
    public string Role{get;set;} = "";
    public string Department{get;set;} = "";
    public override int Age { get; set; }
    public override string Address { get; set; } = "";
    public override string City { get; set; } = "";
    public override string Province { get; set; } = "";
    public override string Cap { get; set; } = "";
    public override int PhoneNumber { get; set; }
    internal static List<EmployersActivity> TotalEmployersActivitiesList{get; private set;} = new();
    internal List<EmployersActivity> EmployersActivities{get; private set;} = new();

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