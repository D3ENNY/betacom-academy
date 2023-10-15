namespace gestioneAuto;

class DataManager : Engine
{
    private readonly List<Car> cars = new();
    internal bool InsertCliCar(){
        string? tmp, fuel, cubicCapacity;
        string company, model, chassisNumber;
        Console.WriteLine("gli unici dati non obbligatori sono quelli che fanno riferimento all'allestimento:\n-alimentazione\n-anno produzioe\n\n");
        Console.Write("inserisci casa automobilistica: ");
        if(string.IsNullOrEmpty((company = Console.ReadLine() ?? ""))) return false;
        Console.Write("inserisci nome modello: ");
        if(string.IsNullOrEmpty((model = Console.ReadLine() ?? ""))) return false;
        Console.Write("inserisci numero telaio: ");
        if(string.IsNullOrEmpty((chassisNumber = Console.ReadLine() ?? ""))) return false;
        Console.Write("inserici alimentazione: ");
        fuel = (fuel = Console.ReadLine()!) == " " ? null : fuel;
        Console.Write("inserisi anno di inizio produzione: ");
        cubicCapacity = (tmp = Console.ReadLine()!) == " " ? null : tmp;
        cars.Add(new Car(company, model, chassisNumber,fuel, cubicCapacity));

        return true;
    }

    internal void ShowCar(){
        Console.Clear();
        cars.ForEach(x => System.Console.WriteLine(x.ToString()));
        Console.ReadKey();
    }
}