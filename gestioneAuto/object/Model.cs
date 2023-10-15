namespace gestioneAuto;

class Model
{
    private static readonly List<Model> modelList = new();
    internal static List<Model> GetModList => modelList;
    private static int Sid = 0;
    private readonly int id;
    private readonly string name="";
    internal string GetName => name;


    public Model(string name){
        this.name = name;
        this.id = ++Sid;
    }

    public override string ToString()
    {
        return $"\nmodello:\n{this.name}\n====================";
    }

}