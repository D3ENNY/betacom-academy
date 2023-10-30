using System.ComponentModel.Design;
using gestioneDipendenti.engine;
using gestioneDipendenti.nlog;
using NLog;
 
namespace gestioneDipendenti;
class Program
{
    private static readonly Logger infoLogger = LogManager.GetLogger("infoLogger");
    private static readonly Logger errorLogger = LogManager.GetLogger("errorLogger");   
    static void Main(string[] args)
    {
        NlogStartUp.Instance(); 
        try
        {
            infoLogger.Info("application started");

            int choise = 0;
            do
            {
                MenuManager.Show();
                if(int.TryParse(Console.ReadLine(), out choise))
                    MenuManager.HandleChoise(choise);
            }while(choise != 5);
        }
        catch (Exception ex)
        {
           errorLogger.Error(ex, "generic error was occured");
           Console.Error.WriteLine(ex.StackTrace);
        }finally
        {
            infoLogger.Info("application closed");
        }
    }
}