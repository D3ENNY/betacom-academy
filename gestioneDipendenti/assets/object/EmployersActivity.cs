namespace gestioneDipendenti.obj;

class EmployersActivity{
    public DateTime Date{get;set;}
    public string Activity{get;set;} = "";
    public int AmountHour{get;set;}
    public string EmployerID{get;set;} = "";
    internal int Id{get; private set;}
    private static int IdCnt = 0;

    public EmployersActivity() => this.Id = ++IdCnt;

    public override string ToString() => $@"id: {Id}
    matricola: {EmployerID}
    data: {Date}
    attività: {Activity}
    ore: {AmountHour}";

    internal string GetDataObj() => $"|{Id}{new string(' ', 5-Id.ToString().Length)} | " + 
                                    $"{EmployerID}{new string(' ', 9-EmployerID.Length)} | " +
                                    $"{Date.ToString("dd/MM/yyyy")}{new string(' ', 10-Date.ToString("dd/MM/yyyy").Length)} | " +
                                    $"{Activity}{new string(' ', 15-Activity.Length)} | " +
                                    $"{AmountHour}{new string(' ', 3-AmountHour.ToString().Length)} | ";
}