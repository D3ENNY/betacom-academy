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
        MenuManager.viewDataMenu();
        MenuManager.HeaderViewData();
        peopleList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 217));
    }
}