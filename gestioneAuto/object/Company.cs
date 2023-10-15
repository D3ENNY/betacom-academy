using System.Security.Principal;

namespace gestioneAuto;

class Company
{
    private static readonly List<Company> companyList= new();
    internal static List<Company> GetCompList => companyList;
    private static int SId = 0;
    private readonly int id;
    private readonly string name="";
    internal string GetName => name;


    internal Company(string name){
        this.name = name;
        this.id = ++SId;
        companyList.Add(this);
    }

    public override string ToString(){
        return $"modello:\n{this.name}\n====================";
    } 
    
}