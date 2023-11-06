namespace WebApplication1.obj;

public class EmployersActivity
{
    public DateTime Date { get; set; }
    public string Activity { get; set; } = "";
    public int AmountHour { get; set; }
    public string EmployerID { get; set; } = "";
    internal int Id { get; private set; }
    private static int IdCnt = 0;

    public EmployersActivity() => this.Id = ++IdCnt;

    public EmployersActivity(string Date, string Activity, string AmountHour, string EmployerID)
    {
        this.Id = ++IdCnt;
        this.Date = Convert.ToDateTime(Date);
        this.Activity = Activity;
        if (int.TryParse(AmountHour, out int parsedAmountHour)) this.AmountHour = parsedAmountHour;
        this.EmployerID = EmployerID;
    }
}