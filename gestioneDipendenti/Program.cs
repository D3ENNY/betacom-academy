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
           infoLogger.Info("Hello world final test");
           throw new Exception("hehehe");
        }
        catch (Exception ex)
        {
           errorLogger.Error(ex, "Goodbye cruel world");
        }   
    }
}
 
 