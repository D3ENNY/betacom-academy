namespace gestioneAuto;

class Setup
{
    private static readonly List<Setup> setupList = new();
    internal static  List<Setup> GetSetList => setupList;
    private readonly string chassisNumber;
    internal string GetChassis => chassisNumber;
    private readonly string? fuel;
    private readonly int? cubicCapacity;

    public Setup(string chassisNumber, string? fuel, string? cubicCapacity){
        this.chassisNumber = chassisNumber;
        this.fuel = fuel;
        this.cubicCapacity = int.TryParse(cubicCapacity, out _) ? int.Parse(cubicCapacity) : null;
        setupList.Add(this);
    }

    public override string ToString()
    {
        return $"\nallestimenti:\nnumero telaio: {this.chassisNumber}\nalimentazione: {this.fuel}\ncilindrata: {this.cubicCapacity}CC";
    }

    public string Line => $"{this.fuel}:{this.cubicCapacity}:{this.chassisNumber}";
}