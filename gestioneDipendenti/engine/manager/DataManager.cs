using gestioneDipendenti.obj;
using NLog;
using ToolBoxLibrary.FileBox;
namespace gestioneDipendenti.engine;

class DataManager
{
    internal static List<Employers> employersList = new();
    private static readonly FileBox fb = new();
    private static readonly Logger errorLogger = LogManager.GetLogger("errorLogger"); 

    internal static void LoadFromFile()
    {
        try{
            employersList.AddRange(fb.ReadTxt<Employers>(Constant.sepFile.ToString(), Constant.employerPath));
            Employers.TotalEmployersActivitiesList.AddRange(fb.ReadTxt<EmployersActivity>(Constant.sepFile.ToString(), Constant.employerActivityPath));
            employersList.ForEach(x => 
                x.EmployersActivities.AddRange(Employers.TotalEmployersActivitiesList.Where(e => e.EmployerID == x.RegisterId))
            );
        }catch(Exception ex)
        {
            errorLogger.Error("laodFromFile function\n"+ex);
        }
    }

    internal static void ViewData()
    {
        try
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
        catch (Exception ex)
        {
            errorLogger.Error("ViewData function\n", ex);
        }

    }

    internal static void AvgAgeEmployer()
    {
        Console.Clear();
        try
        {
            double avg = employersList.Average(x => x.Age);
            Console.Write($"{new string('=', 44)}\n| la media dell'età dei dipendenti è: {avg} |\n{new string('=', 44)}\n");
        }
        catch (Exception ex)
        {
            errorLogger.Error("AvgAgeEmployer Function\n" + ex);
        }
        
    }

    internal static void AvgAgeDepartment()
    {
        Console.Clear();
        try
        {
            var avgGroup = (
            from Employer in employersList
            group Employer by Employer.Department 
            into Group select new
            {
                Department = Group.Key,
                avgAge = Group.Average(x => x.Age)
            }).ToList();

            MenuManager.HeaderAvgDepartment();
            avgGroup.ForEach(x => Console.WriteLine($"| {x.Department}{new string(' ', 35-x.Department.Length)} | {x.avgAge}{new string(' ', 10-x.avgAge.ToString().Length)}|"));
            Console.WriteLine(new string('=', 51));
        }
        catch (Exception ex)
        {
            errorLogger.Error("AvgAgeDepartment Function\n" + ex);
        }
    }

    internal static void HourDepartmenet()
    {
        Console.Clear();
        try
        {
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
            }).ToList();
            MenuManager.HeaderHourDepartment();
            hourGroup.ForEach(x => Console.WriteLine($"| {x.Department}{new string(' ', 35-x.Department.Length)} | {x.hour}{new string(' ', 11-x.hour.ToString().Length)}|"));
            Console.WriteLine(new string('=', 52));
        }
        catch (Exception ex)
        {
            errorLogger.Error("HourDepartment function\n"+ ex);
        }
    }

    internal static void HourNominative()
    {
        Console.Clear();
        try
        {
            var totalHour = employersList
            .Where(x => x.EmployersActivities.Count > 0)
            .Select( x => 
            {
                var hours = x.EmployersActivities
                .Where(a => !a.Activity.Equals("Ferie"))
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
        catch (Exception ex)
        {
            errorLogger.Error("HourNominative function\n" + ex);
        }
    }

    internal static void OvertimeHour()
    {
        Console.Clear();
        try
        {
            int hour = Employers.TotalEmployersActivitiesList
            .Where(x => x.AmountHour > 8)
            .Sum(x => x.AmountHour-8);

            Console.Write($"{new string('=', 45)}\n| totale delle ore di straordinari sono: {hour} |\n{new string('=', 45)}\n");
        }
        catch (Exception ex)
        {
            errorLogger.Error("OvertimeHour function\n" + ex);
        }
    }

    internal static void OvertimeHourNominative()
    {
        Console.Clear();
        try
        {
            var hourGroup = (
            from Activity in Employers.TotalEmployersActivitiesList
            join Employer in employersList on
                Activity.EmployerID equals Employer.RegisterId
            where Activity.AmountHour > 8
            group Activity by Activity.EmployerID
            into Group select new
            {
                Nominative = employersList.First(x => x.RegisterId.Equals(Group.Key)).Nominative,
                hour = Group.Sum(x => x.AmountHour - 8)
            }).ToList();

        MenuManager.HeaderOvertimeHourNominative();
        hourGroup.ForEach(x => Console.WriteLine($"| {x.Nominative}{new string(' ', 35-x.Nominative.Length)} | {x.hour}{new string(' ', 26-x.hour.ToString().Length)}|"));
        Console.WriteLine(new string('=', 67));
        }
        catch (Exception ex)
        {
            errorLogger.Error("OvertimeHourNominative function\n" + ex);
        }
    }

    internal static void HolidayHour()
    {
        Console.Clear();
        try
        {
            int HolidayHour = Employers.TotalEmployersActivitiesList
            .Where(x => x.Activity.Equals("Ferie"))
            .Sum(x => x.AmountHour);

            Console.Write($"{new string('=', 38)}\n| totale delle ore di ferie sono: {HolidayHour} |\n{new string('=', 38)}\n");
        }
        catch (Exception ex)
        {
            errorLogger.Error("HolidayHour function\n" + ex);
        }
    }

    internal static void HolidayHourNominative()
    {
        Console.Clear();        
        try
        {
            var HolidayGroup = (
            from Activity in Employers.TotalEmployersActivitiesList
            join Employer in employersList on
                Activity.EmployerID equals Employer.RegisterId
            where Activity.Activity == "Ferie"
            group Activity by Activity.EmployerID
            into Group select new
            {
                Nominative = employersList.First(x => x.RegisterId.Equals(Group.Key)).Nominative,
                hour = Group.Sum(x => x.AmountHour)
            }).ToList();

            MenuManager.HeaderHoldidayNominative();
            HolidayGroup.ForEach(x => Console.WriteLine($"| {x.Nominative}{new string(' ', 35-x.Nominative.Length)} | {x.hour}{new string(' ', 18-x.hour.ToString().Length)}|"));
            Console.WriteLine(new string('=', 59));
        }
        catch (Exception ex)
        {
            errorLogger.Error("HolidayHourNominative function" + ex);
        }
    }

    internal static void PreHolidayHour()
    {
        Console.Clear();
        try
        {
            var preHolidayGroup = Employers.TotalEmployersActivitiesList
            .Where(x => x.Activity.Equals("Pre Festivo"))
            .Select(x =>
            {
                string nominative = employersList.First(e => e.RegisterId.Equals(x.EmployerID)).Nominative;

                return new
                {
                    Nominative = nominative,
                    Data = x.Date,
                    Hour = x.AmountHour
                };
            }).ToList();

            MenuManager.HeaderPreHoldidayNominative();
            preHolidayGroup.ForEach(x => Console.WriteLine($"| {x.Nominative}{new string(' ', 35-x.Nominative.Length)} | {x.Data.ToString("dd/MM/yyyy")}{new string(' ', 10-x.Data.ToString("dd/MM/yyyy").Length)} | {x.Hour}{new string(' ', 24-x.Hour.ToString().Length)}|"));
            Console.WriteLine(new string('=', 78));
        }
        catch (Exception ex)
        {
            errorLogger.Error("PreHolidayHour function\n" + ex);
        }
    }

    internal static void WriteOnJson()
    {
        try
        {
            fb.writeJson(employersList, Constant.employerJson);
        }
        catch (Exception ex)
        {
            errorLogger.Error("WriteOnJson function\n" + ex);
        }
    }
}