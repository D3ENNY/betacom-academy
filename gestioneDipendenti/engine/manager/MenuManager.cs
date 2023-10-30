using NLog;

namespace gestioneDipendenti.engine;

class MenuManager
{
    private static readonly Logger infoLogger = LogManager.GetLogger("infoLogger");
    private static readonly Logger errorLogger = LogManager.GetLogger("errorLogger"); 
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
    internal static void HeaderViewEmployerData() => Console.WriteLine($"|ID{new string(' ', 5-"ID".Length)} | " + 
                                                $"Nominativo{new string(' ', 35-"Nominativo".Length)} | " +
                                                $"Ruolo{new string(' ', 20-"Ruolo".Length)} | " +
                                                $"Reparto{new string(' ', 35-"Reparto".Length)} | " +
                                                $"Età{new string(' ', 3-"Età".Length)} | " + 
                                                $"Indirizzo{new string(' ', 45-"Indirizzo".Length)} | " +
                                                $"Città{new string(' ',20-"Città".Length)} | " + 
                                                $"Provincia{new string(' ',10-"Provincia".Length)} | " + 
                                                $"Cap{new string(' ',5-"Cap".Length)} | " + 
                                                $"Telefono{new string(' ', 10-"Telefono".ToString().Length)} |\n" + 
                                                new string('=', 218));

    internal static void HeaderViewEmployerActivityData() => Console.WriteLine($"|ID{new string(' ', 5-"ID".Length)} | " + 
                                                                $"Matricola{new string(' ', 9-"matricola".Length)} | " +
                                                                $"Data{new string(' ', 10-"Data".Length)} | " +
                                                                $"Attività{new string(' ', 15-"Attività".Length)} | " +
                                                                $"Ore{new string(' ', 3-"Ore".Length)} |\n" + 
                                                                new string('=', 57));
    private static void EmployeesDataMenu(){
        Console.Clear();
        Console.WriteLine(@"
        ===============================================
                         MENÙ                
        ===============================================
          [1] età media personale
          [2] età media per reparto
          [3] totale ore lavoro reparto
          [4] totale ore lavoro per nominativo
          [5] totale ore straordinarie
          [6] totale ore straordinarie per nominativo
          [7] totale ore ferie
          [8] ore ferie per nominativo
          [9] ore prefestive con data e nominativo 
        ===============================================
        inserire schelta: 
        ");
    }
    internal static void HandleChoise(int choise)
    {
        infoLogger.Info($"l'utente ha inserito il numero: {choise}");
        switch(choise)
        {
            case 1:
                // carica da file
                infoLogger.Info("carica da file");
                DataManager.LoadFromFile();
                break;
            case 2:
                // visualizza dati
                infoLogger.Info("visualizza dati");
                DataManager.ViewData();
                break;
            case 3:
                //estrazione dati
                infoLogger.Info("estrazione dati");
                int n;
                bool flag = true;
                do
                {
                    if(!flag){
                        Console.WriteLine("errore di inserimento\ninserisci un numero.");
                        infoLogger.Warn($"l'utente ha inserito un valore non valido: {choise}");
                    }
                    EmployeesDataMenu();
                    flag = false;
                } while (!int.TryParse(Console.ReadLine(), out n));
                HandleGetDataChoise(n);
                break;
            case 4: 
                //serializzazione in JSON
                break;
            case 5:
                //the silent is golden
                break;
            default:
                Console.Error.WriteLine($"l'input {choise} non è gestito");
                infoLogger.Warn($"l'input {choise} non è gestito");
                break;
        }

        Console.WriteLine("premere un tasto per continuare");
        Console.ReadKey();
    }

    private static void HandleGetDataChoise(int choise)
    {
        switch(choise)
        {
            case 1:
                //età media personale
                infoLogger.Info("calcolo età media personale");
                DataManager.AvgAgeEmployer();
                break;
            case 2:
                //età media per reparto
                infoLogger.Info("calcolo età media per reparto");
                DataManager.avgAgeDepartment();
                break;
            case 3:
                //totale ore lavoro per reparto
                break;
            case 4:
                //totale ore lavoro per nominativo
                break;
            case 5:
                //totale ore straordinarie
                break;
            case 6:
                //totale ore straordinarie per nominativo
                break;
            case 7:
                //totale ore ferie
                break;
            case 8:
                //ore ferie per nominativo
                break;
            case 9:
                //ore prefestive con data e nominativo
                break;
        }
    }
}