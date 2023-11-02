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
          [5] carica da database
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

    internal static void HeaderAvgDepartment() => Console.WriteLine($"| Reparto{new string(' ', 35-"Reparto".Length)} | " +
                                             $"Età media{new string(' ', 10-"Età media".Length)} |\n" +
                                             new string('=', 51));     

    internal static void HeaderHourDepartment() => Console.WriteLine($"| Reparto{new string(' ', 35-"Reparto".Length)} | " +
                                             $"ore totali{new string(' ', 10-"ore totali".Length)} |\n" +
                                             new string('=', 52));                      

    internal static void HeaderHourNominative() => Console.WriteLine($"| Dipendente{new string(' ', 35-"Dipendente".Length)} | " +
                                             $"ore totali{new string(' ', 10-"ore totali".Length)} |\n" +
                                             new string('=', 52));   

    internal static void HeaderOvertimeHourNominative() => Console.WriteLine($"| Dipendente{new string(' ', 35-"Dipendente".Length)} | " +
                                             $"ore straordinarie totali{new string(' ', 25-"ore straordinarie totali".Length)} |\n" +
                                             new string('=', 67));    

    internal static void HeaderHoldidayNominative() => Console.WriteLine($"| Dipendente{new string(' ', 35-"Dipendente".Length)} | " +
                                             $"ore ferie totali{new string(' ', 17-"ore ferie totali".Length)} |\n" +
                                             new string('=', 59));     

    internal static void HeaderPreHoldidayNominative() => Console.WriteLine($"| Dipendente{new string(' ', 35-"Dipendente".Length)} | " +
                                         $"data{new string(' ', 10-"data".Length)} | " +
                                         $"ore preferie totali{new string(' ', 20-"ore ferie totali".Length)} |\n" +
                                         new string('=', 78));                   
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
                infoLogger.Info("l'utente ha serializzato il database in un file json");
                if(DataManager.employersList.Count > 0)
                    DataManager.WriteOnJson();
                break;
            case 5:
                DataManager.LoadFromDatabase();
                break;
            case 6:
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
                DataManager.AvgAgeDepartment();
                break;
            case 3:
                //totale ore lavoro per reparto
                infoLogger.Info("calcolo ore lavoro per reparto");
                DataManager.HourDepartmenet();
                break;
            case 4:
                //totale ore lavoro per nominativo
                infoLogger.Info("totale ore lavoro per nominativo");
                DataManager.HourNominative();
                break;
            case 5:
                //totale ore straordinarie
                infoLogger.Info("totale ore straordinarie");
                DataManager.OvertimeHour();
                break;
            case 6:
                //totale ore straordinarie per nominativo
                infoLogger.Info("totale ore straordinarie per nominativo");
                DataManager.OvertimeHourNominative();
                break;
            case 7:
                //totale ore ferie
                infoLogger.Info("totale ore ferie");
                DataManager.HolidayHour();
                break;
            case 8:
                //ore ferie per nominativo
                infoLogger.Info("totale ore ferie per nominativo");
                DataManager.HolidayHourNominative();
                break;
            case 9:
                //ore prefestive con data e nominativo
                infoLogger.Info("ore prefestive con data e nominativo");
                DataManager.PreHolidayHour();
                break;
        }
    }
}