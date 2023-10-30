using gestioneDipendenti.obj;
using ToolBoxLibrary.FileBox;
namespace gestioneDipendenti.engine;

class DataManager
{
    internal static List<Person> peopleList = new();
    internal void LoadFromFile()
    {
        FileBox fb = new();
        peopleList.AddRange(fb.ReadTxt<Person>(Constant.sepFile.ToString(), Constant.employerPath));
    }

    internal void ViewData()
    {
        Console.WriteLine(@"
        ======================================
                    VISUALIZZA DATI                
        ======================================
        ");
        Console.WriteLine($"ID{new string(' ', 5-"ID".Length)} | " + 
                          $"Nominativo{new string(' ', 35-"Nominativo".Length)} | " +
                          $"Ruolo{new string(' ', 20-"Ruolo".Length)} | " +
                          $"Dipartimento{new string(' ', 35-"Dipartimento".Length)} | " +
                          $"Età{new string(' ', 3-"Età".Length)} | " + 
                          $"Indirizzo{new string(' ', 45-"Indirizzo".Length)} | " +
                          $"Città{new string(' ',20-"Città".Length)} | " + 
                          $"Provincia{new string(' ',10-"Provincia".Length)} | " + 
                          $"Cap{new string(' ',5-"Cap".Length)} | " + 
                          $"Telefono{new string(' ', 10-"Telefono".ToString().Length)}\n" + 
                          new string('=', 217)
                        );
        peopleList.ForEach(x => System.Console.WriteLine(x.GetDataObj()));
    }
}