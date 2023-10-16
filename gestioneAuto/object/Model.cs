namespace gestioneAuto;

class Model
{
    private static readonly List<Model> modelList = new();
    internal static List<Model> GetModList => modelList;
    private static int Sid = 0;
    private readonly int id;
    private readonly string name="";
    private readonly int year;
    internal string getYear => year.ToString();
    internal string GetName => name;


    public Model(string name, string year){
        this.name = name;
        int.TryParse(year, out this.year);
        this.id = ++Sid;
    }

    public override string ToString()
    {
        return $"\nmodello:\n{this.name}\nanno:\n{this.year}\n====================";
    }

}