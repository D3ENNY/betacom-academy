using gestioneDipendenti.nlog;
using NLog;

namespace gestioneDipendenti;
class Program
{
    private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    static void Main(string[] args)
    {
        NlogStartUp.Test1(); 
        try
        {
           Logger.Info("Hello world");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }  

        System.Console.WriteLine("test 2");
        NlogStartUp.Test2();

        try
        {
           Logger.Info("Hello world");
           System.Console.ReadKey();
        }
        catch (Exception ex)
        {
           Logger.Error(ex, "Goodbye cruel world");
        }  


    }
}
