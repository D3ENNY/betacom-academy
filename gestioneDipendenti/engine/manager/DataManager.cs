using gestioneDipendenti.obj;
using ToolBoxLibrary.FileBox;
namespace gestioneDipendenti.engine;

class DataManager
{
    internal static List<Employers> employersList = new();

    internal static void LoadFromFile()
    {
        FileBox fb = new();
        employersList.AddRange(fb.ReadTxt<Employers>(Constant.sepFile.ToString(), Constant.employerPath));
        Employers.EmployersActivitiesList.AddRange(fb.ReadTxt<EmployersActivity>(Constant.sepFile.ToString(), Constant.employerActivityPath));
    }

    internal static void ViewData()
    {
        MenuManager.viewDataMenu();
        MenuManager.HeaderViewEmployerData();
        employersList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 217));
        Console.WriteLine('\n');
        MenuManager.HeaderViewEmployerActivityData();
        Employers.EmployersActivitiesList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 57));
    }

    internal static void AvgAgeEmployer()
    {
        Console.Clear();
        double avg = employersList.Average(x => x.Age);
        Console.Write($"{new string('=', 44)}\n| la media dell'età dei dipendenti è: {avg} |\n{new string('=', 44)}\n");
    }

    internal static void avgAgeDepartment()
    {
        throw new NotImplementedException();
    }
}