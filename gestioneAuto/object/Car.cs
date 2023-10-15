namespace gestioneAuto;

class Car 
{   
    private readonly Company company;
    private readonly Model model;
    private readonly Setup setup;

    public Car(Company company, Model model, Setup setup){
        this.company = company;
        this.model = model;
        this.setup = setup;
    }

    public Car(string companyName, string modelName, string chassisNumber, string? fuel, string? cubicCapacity){
        this.company = Company.GetCompList.Find(x => x.GetName.Equals(companyName)) ?? new(companyName);
        this.model = Model.GetModList.Find(x => x.GetName.Equals(modelName)) ?? new(modelName);
        this.setup = Setup.GetSetList.Find(x => x.GetChassis.Equals(chassisNumber)) ?? new(chassisNumber, fuel, cubicCapacity);
    }

    public override string ToString()
    {
        return $"{this.company.ToString()}{this.model.ToString()}{this.setup.ToString()}";
    }
}