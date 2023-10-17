namespace gestioneAuto;

class Car 
{   
    private readonly Company company;
    private readonly Model model;
    private readonly Setup setup;
    internal Setup GetSetup => setup;
    internal Model GetModel => model;
    //internal Model
    public Car(string companyName, string modelName,string year, string chassisNumber, string? fuel, string? cubicCapacity){
        this.company = Company.GetCompList.Find(x => x.GetName.Equals(companyName)) ?? new(companyName);
        this.model = Model.GetModList.Find(x => x.GetName.Equals(modelName) && x.getYear.Equals(year)) ?? new(modelName, year);
        this.setup = Setup.GetSetList.Find(x => x.GetChassis.Equals(chassisNumber)) ?? new(chassisNumber, fuel, cubicCapacity);
    }

    public Car(Company company, Model model, Setup setup){
        this.company = company;
        this.model = model;
        this.setup = setup;
    }

    public Car() { 
        //the silents is golden
    }

    public override string ToString()
    {
        return $"{this.company}{this.model}{this.setup}";
    }

    public string GetLine => $"{this.company.Line}{this.model.Line}{this.setup.Line}";
    
}