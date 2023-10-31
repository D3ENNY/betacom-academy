using System.Text.RegularExpressions;
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
        Employers.TotalEmployersActivitiesList.AddRange(fb.ReadTxt<EmployersActivity>(Constant.sepFile.ToString(), Constant.employerActivityPath));
        employersList.ForEach(x => 
            x.EmployersActivities.AddRange(Employers.TotalEmployersActivitiesList.Where(e => e.EmployerID == x.RegisterId))
        );
    }

    internal static void ViewData()
    {
        MenuManager.viewDataMenu();
        MenuManager.HeaderViewEmployerData();
        employersList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 217));
        Console.WriteLine('\n');
        MenuManager.HeaderViewEmployerActivityData();
        Employers.TotalEmployersActivitiesList.ForEach(x => Console.WriteLine(x.GetDataObj()));
        Console.WriteLine(new string('=', 57));
    }

    internal static void AvgAgeEmployer()
    {
        Console.Clear();
        double avg = employersList.Average(x => x.Age);
        Console.Write($"{new string('=', 44)}\n| la media dell'età dei dipendenti è: {avg} |\n{new string('=', 44)}\n");
    }

    internal static void AvgAgeDepartment()
    {
        Console.Clear();
        var avgGroup = (
            from Employer in employersList
            group Employer by Employer.Department 
            into Group select new
            {
                Department = Group.Key,
                avgAge = Group.Average(x => x.Age)
            }
        ).ToList();

        MenuManager.HeaderAvgDepartment();
        avgGroup.ForEach(x => Console.WriteLine($"| {x.Department}{new string(' ', 35-x.Department.Length)} | {x.avgAge}{new string(' ', 10-x.avgAge.ToString().Length)}|"));
        Console.WriteLine(new string('=', 51));
    }

    internal static void HourDepartmenet()
    {
        Console.Clear();
        var hourGroup = (
            from Employer in employersList
            join Activity in Employers.TotalEmployersActivitiesList on
                Employer.RegisterId equals Activity.EmployerID
            where Activity.Activity != "Ferie"
            group Activity by Employer.Department
            into Group select new
            {
                Department = Group.Key,
                hour = Group.Sum(h => h.AmountHour)
            }
        ).ToList();
        MenuManager.HeaderHourDepartment();
        hourGroup.ForEach(x => Console.WriteLine($"| {x.Department}{new string(' ', 35-x.Department.Length)} | {x.hour}{new string(' ', 11-x.hour.ToString().Length)}|"));
        Console.WriteLine(new string('=', 52));
    }

    internal static void HourNominative()
    {
        Console.Clear();

        var totalHour = employersList
        .Where(x => x.EmployersActivities.Count > 0)
        .Select( x => 
        {
            var hours = x.EmployersActivities
            .Where(a => a.Activity != "Ferie")
            .Sum(a => a.AmountHour);
            
            return new
            {
                Nominative = x.Nominative,
                hour = hours
            };
        }).ToList();

        MenuManager.HeaderHourNominative();
        totalHour.ForEach(x => Console.WriteLine($"| {x.Nominative}{new string(' ', 35-x.Nominative.Length)} | {x.hour}{new string(' ', 11-x.hour.ToString().Length)}|"));
        Console.WriteLine(new string('=', 52));

    }

    internal static void OvertimeHour()
    {
        
    }
}