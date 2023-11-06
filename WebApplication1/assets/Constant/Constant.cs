namespace WebApplication1.Const
{
    internal class Constant
    {
        internal static string dbName = "DipendentiAzienda";
        internal static string dbSource = @".\sqlexpress";

        internal static string getEmployerQuery = @"SELECT * FROM AnagraficaGenerale";
        internal static string getEmployerActivityQuery = @"SELECT * FROM AttivitaDipendenti";
        internal static string getEmployerQueryParam = @"SELECT * FROM AnagraficaGenerale WHERE Nominativo LIKE '%' + @param +'%'";

    }
}
