namespace gestioneAuto;

public class Model
{
    private static readonly List<Model> modelList = new();
    internal static List<Model> GetModList => modelList;
    private static int Sid = 0;
    public int Id{get; set;}
    public string Name{get; set;}
    public int Year{get; set;}
    public string getYear => Year.ToString();


    public Model(string name, string year){
        this.Name = name;
        if (int.TryParse(year, out int tmp))
            this.Year = tmp;
        this.Id = ++Sid;
    }

    public Model(){ }

    public override string ToString()
    {
        return $"\nmodello:\n{this.Name}\nanno:\n{this.Year}\n====================";
    }

    public string Line => $"{this.Name}:{this.Year}";

}