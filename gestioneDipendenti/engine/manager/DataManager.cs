using gestioneDipendenti.obj;
using ToolBoxLibrary.FileBox;
namespace gestioneDipendenti.engine;

class DataManager
{
    internal static List<Employers> employersList = new();
    internal void LoadFromFile()
    {
        FileBox fb = new();
        employersList.AddRange(fb.ReadTxt<Employers>(Constant.sepFile.ToString(), Constant.employerPath));
    }

    internal void ViewData()
    {
        MenuManager.viewDataMenu();
        MenuManager.HeaderViewData();
        employersList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 217));
    }
}