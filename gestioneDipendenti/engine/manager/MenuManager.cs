using NLog;

namespace gestioneDipendenti.engine;

class MenuManager
{
    private static readonly Logger infoLogger = LogManager.GetLogger("infoLogger");
    private static readonly Logger errorLogger = LogManager.GetLogger("errorLogger"); 
    private static readonly DataManager data = new();
    internal static void Show()
    {
        Console.Clear();
        Console.WriteLine(@"
        ======================================
                         MENÙ                
        ======================================
          [1] carica da file
          [2] visualizza dati
          [3] estrazione dati
          [4] serializzazione dati in JSON
          [5] esci
        ======================================
        ");
    }

    internal static void HandleChoise(int n)
    {
        infoLogger.Info($"l'utente ha inserito il numero: {n}");
        switch(n)
        {
            case 1:
                // carica da file
                data.LoadFromFile();
                break;
            case 2:
                // visualizza dati
                break;
            case 3:
                //estrazione dati
                break;
            case 4: 
                //serializzazione in JSON
                break;
            case 5:
                //the silent is golden
                break;
            default:
                Console.Error.WriteLine($"l'input {n} non è gestito");
                infoLogger.Warn($"l'input {n} non è gestito");
                break;
        }

        Console.WriteLine("premere un tasto per continuare");
        Console.ReadKey();
    }
}