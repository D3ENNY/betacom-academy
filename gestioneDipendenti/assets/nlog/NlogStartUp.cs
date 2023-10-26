using NLog;

namespace gestioneDipendenti.nlog;

class NlogStartUp
{

    private static NlogStartUp? _Instance;

    private NlogStartUp()
    {
        LogManager.Setup().LoadConfiguration(builder => {
            builder.ForLogger("infoLogger").FilterMinLevel(LogLevel.Info).WriteToFile(fileName: "../../../assets/log/info.txt");
            builder.ForLogger("errorLogger").FilterMinLevel(LogLevel.Error).WriteToFile(fileName: "../../../assets/log/log.txt");
        });
    }

    internal static NlogStartUp Instance() => _Instance ??= new();
    
}