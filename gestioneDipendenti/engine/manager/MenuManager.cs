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

    internal static void viewDataMenu(){ 
        Console.Clear(); 
        Console.WriteLine(@"
        ======================================
                    VISUALIZZA DATI                
        ======================================
        ");
    }
    internal static void HeaderViewData() =>  Console.WriteLine($"ID{new string(' ', 5-"ID".Length)} | " + 
                                                $"Nominativo{new string(' ', 35-"Nominativo".Length)} | " +
                                                $"Ruolo{new string(' ', 20-"Ruolo".Length)} | " +
                                                $"Dipartimento{new string(' ', 35-"Dipartimento".Length)} | " +
                                                $"Età{new string(' ', 3-"Età".Length)} | " + 
                                                $"Indirizzo{new string(' ', 45-"Indirizzo".Length)} | " +
                                                $"Città{new string(' ',20-"Città".Length)} | " + 
                                                $"Provincia{new string(' ',10-"Provincia".Length)} | " + 
                                                $"Cap{new string(' ',5-"Cap".Length)} | " + 
                                                $"Telefono{new string(' ', 10-"Telefono".ToString().Length)}\n" + 
                                                new string('=', 217));

    // private static void EmployeesDataMenu(){

    // }
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
                data.ViewData();
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