using NLog;

namespace gestioneDipendenti.nlog;

class NlogStartUp
{
    public static void Test1()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Targets where to log to: File and Console
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "assets/log.txt" };
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
                    
        // Rules for mapping loggers to targets            
        config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
                    
        // Apply config           
        NLog.LogManager.Configuration = config;
    }

    public static void Test2()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Targets where to log to: File and Console
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "assets/log.txt" };
        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
                    
        // Rules for mapping loggers to targets            
        config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole);
                    
        // Apply config           
        NLog.LogManager.Configuration = config;
    }
}