using System.Security.Authentication;
using NLog;
namespace startaccademynet4;

class NloggerSetUp
{
    // public NloggerSetUp()
    // {
    //     var config = new NLog.Config.LoggingConfiguration();

    //     // Targets where to log to: File and Console
    //     var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "assets/log.txt" };
    //     var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
                    
    //     // Rules for mapping loggers to targets            
    //     config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
    //     config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
                    
    //     // Apply config           
    //     NLog.LogManager.Configuration = config;
    // }

    public NloggerSetUp()
    {
        NLog.LogManager.Setup().LoadConfiguration(builder => {
        builder.ForLogger().FilterMinLevel(LogLevel.Info).WriteToFile(fileName: "assets/log.txt");
        builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToFile(fileName: "assets/log.txt");
        });
    }
}