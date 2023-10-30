namespace gestioneDipendenti.obj;
class Person
{
    public string RegisterId{get;set;} = "";
    public string Nominative{get;set;} = "";
    public string Role{get;set;} = "";
    public string Department{get;set;} = "";
    public int Age{get;set;}
    public string Address{get;set;} = "";
    public string City{get;set;} = "";
    public string Province{get;set;} = "";
    public string Cap{get;set;} = "";
    public int PhoneNumber{get;set;}

    internal string GetDataObj() => $"{RegisterId}{new string(' ', 5-RegisterId.Length)} | " + 
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