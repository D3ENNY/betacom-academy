using NLog;
namespace startaccademynet4;

class NloggerSetUp
{
    public NloggerSetUp()
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