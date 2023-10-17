namespace gestioneAuto;

public class Car 
{   
    public Company Company{get; private set;}
    public Model Model{get; private set;}
    public Setup Setup{get; private set;}
    public Car(string companyName, string modelName,string year, string chassisNumber, string? fuel, string? cubicCapacity){
        this.Company = Company.GetCompList.Find(x => x.Name.Equals(companyName)) ?? new(companyName);
        this.Model = Model.GetModList.Find(x => x.Name.Equals(modelName) && x.getYear.Equals(year)) ?? new(modelName, year);
        this.Setup = Setup.GetSetList.Find(x => x.ChassisNumber.Equals(chassisNumber)) ?? new(chassisNumber, fuel, cubicCapacity);
    }

    public Car(Company company, Model model, Setup setup){
        this.Company = company;
        this.Model = model;
        this.Setup = setup;
    }

    public Car() { 
        //the silents is golden
    }

    public override string ToString()
    {
        return $"{this.Company}{this.Model}{this.Setup}";
    }

    public string GetLine => $"{this.Company.Line}{this.Model.Line}{this.Setup.Line}";
    
}