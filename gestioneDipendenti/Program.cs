using gestioneDipendenti.nlog;
using NLog;
using NLog.Fluent;

class Program
{
    public static void Main(string[]args)
    {
        var logger = LogManager.GetCurrentClassLogger();
         
        NlogStartUp.Test2();
        LogEventBuilder infoEvent = logger.ForInfoEvent();
        LogEventBuilder errorEvent = logger.ForErrorEvent();
        try
        {
            //ex 1
            infoEvent.Property("id", 123).Property("category", "test");
        }
        catch (Exception ex)
        {
            //ex 2(
            errorEvent.Exception(ex).Message("log a message with {0} parameter", 1);
            throw;
        }
    }
}