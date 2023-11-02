namespace gestioneDipendenti.engine;

internal static class Constant
{

    //file 

    internal static string employerPath = "../../../assets/database/Employees.txt";
    internal static string employerActivityPath = "../../../assets/database/EmployeesActivities.txt";
    internal static string employerJson = "../../../assets/output/out.json";
    internal static char sepFile = ';';

    //database

    internal static string connStr = @"Data Source=.\sqlexpress;Initial Catalog=DipendentiAzienda;Integrated Security=True;";

    internal static string getEmployerQuery = @"SELECT * FROM AnagraficaGenerale";
    internal static string getEmployerActivityQuery = @"SELECT * FROM AttivitaDipendenti";

}