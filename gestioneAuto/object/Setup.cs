namespace gestioneAuto;

public class Setup
{
    private static readonly List<Setup> setupList = new();
    internal static  List<Setup> GetSetList => setupList;
    public string ChassisNumber{get; private set;}
    public string? Fuel{get; private set;}
    public int? CubicCapacity{get; private set;}

    public Setup(string chassisNumber, string? fuel, string? cubicCapacity){
        this.ChassisNumber = chassisNumber;
        this.Fuel = fuel;
        this.CubicCapacity = int.TryParse(cubicCapacity, out _) ? int.Parse(cubicCapacity) : null;
        setupList.Add(this);
    }

    public Setup() { }
    public override string ToString()
    {
        return $"\nallestimenti:\nnumero telaio: {this.ChassisNumber}\nalimentazione: {this.Fuel}\ncilindrata: {this.CubicCapacity}CC";
    }

    public string Line => $"{this.Fuel}:{this.CubicCapacity}:{this.ChassisNumber}";
}