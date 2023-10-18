namespace gestioneAuto;

public class Company
{
    private static readonly List<Company> companyList= new();
    internal static List<Company> GetCompList => companyList;
    private static int SId = 0;
    public int Id{get; set;}
    public string Name{get; set;}

    internal Company(string name){
        this.Name = name;
        this.Id = ++SId;
        companyList.Add(this);
    }

    public Company(){ }

    public override string ToString(){
        return $"casa automobilistica:\n{this.Name}\n====================";
    } 

    public string Line => $"{this.Name}";
    
}