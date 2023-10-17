
namespace gestioneAuto;

class DataManager : Validate
{
    private static List<Car> cars = new();
    internal List<Car> getCarList => cars;
    private readonly MenuManager menu = new();

    internal static bool InsertFileCar(string carPath, string setuPath){
        List<string[]> carList= ManipulateFileList(Engine.ReadFile(carPath), 4);
        List<string[]> setupList = ManipulateFileList(Engine.ReadFile(setuPath), 4);
        cars = carList.Select(x => {
            string[]? carData = setupList.Find(y => y[1] == x[0]);
            return new Car(companyName: x[1],
                        modelName: x[2],
                        year: x[3],
                        chassisNumber: x[0],
                        fuel: carData?[3],
                        cubicCapacity: carData?[2]);
        }).ToList();
        return true;
    }
    internal bool InsertCliCar(){
        string? fuel, cubicCapacity;
        string company, model, chassisNumber, year;
        Console.Clear();
        Console.WriteLine("gli unici dati non obbligatori sono quelli che fanno riferimento all'allestimento:\n-alimentazione\n-anno produzioe\n\n");
        if(string.IsNullOrEmpty((company = InputText("inserisci casa automobilistica: ") ?? ""))) return false;
        if(string.IsNullOrEmpty((model = InputText("inserisci nome modello: ") ?? ""))) return false;
        if(string.IsNullOrEmpty((year = InputYear("inserisci anno di produzione: ") ?? ""))) return false;
        if(string.IsNullOrEmpty((chassisNumber = InputChssisNumber("inserisci numero telaio: ") ?? ""))) return false;
        fuel = (fuel = InputNullText("inserici alimentazione: ")) == " " ? null : fuel;
        cubicCapacity = (cubicCapacity = InputCubiCapacity("inserisi cilindrata: ")) == "" ? null : cubicCapacity;
        cars.Add(new Car(company, model, year, chassisNumber, fuel, cubicCapacity));

        return true;
    }

    private static List<string[]> ManipulateFileList(List<string> list, int lenght){
        return list.Select(x => x.Split(":"))
            .Where(parts => parts.Length == lenght)
            .ToList();
    }
    private string InputText(string output){
        string text = "";
        try
        {
            do
            {
                Console.WriteLine(output);
                text = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateText(text));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        return text;
    }

    private string InputChssisNumber(string output){
        string chassisNumber = "";
        try
        {
            do
            {
                Console.Write(output);
                chassisNumber = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateChassisNumber(chassisNumber));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        return chassisNumber;
    }

    private string? InputNullText(string output){
        string? text = "";
        try
        {
            do
            {
                Console.WriteLine(output);
                text = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateText(text));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }

        return text;
    }

    private string InputCubiCapacity(string output){
        string cubicCapacity = "";
        try
        {
            do
            {
                Console.WriteLine(output);
                cubicCapacity = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateCubiCapacity(cubicCapacity));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }

        return cubicCapacity;
    }

    private string InputYear(string output){
        string year = "";
        try
        {
            do
            {
                Console.WriteLine(output);
                year = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateYear(year));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }

        return year;
    }

    private int InputNumber(string output){
        string input = "";

        try
        {
            do
            {
                Console.WriteLine(output);
                input = Console.ReadLine()!;
                Console.Clear();
            }while(!ValidateRangeNumber(input, 1, 5));
        }
        catch(IOException e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadKey();
        }

        return int.Parse(input);
    }

    internal void ShowCar(){
        Console.Clear();
        cars.ForEach(x => Console.WriteLine(x.ToString() + "\n\n"));
        Console.ReadKey();
    }

    internal bool RemoveCar(){
        string search = InputChssisNumber(menu.RemoveCar()).ToLower();
        return cars.Remove(cars.SingleOrDefault(x => x.GetSetup.GetChassis == search) ?? new Car());
    }

    internal void SearchCar()
    {
        string input = InputText("inserire anno di produzione o modello dell'auto da cercare: ").ToLower();
        if(int.TryParse(input, out _)){
            cars.FindAll(x => x.GetModel.getYear.Equals(input)).ForEach(x => Console.WriteLine(x));
        }else{
            (from element in cars where element.GetModel.GetName.ToLower() == input select element).ToList().ForEach(x => Console.WriteLine(x));
        }
    }

    // internal void EditCar()
    // {
    //     Dictionary<int, string> editCHoise = new Dictionary<int, string>()
    //     {
    //         {1,"companyName"},
    //         {2,"modelName"},
    //         {3,"year"},
    //         {4,"fuel"},
    //         {5,"cubicCapacity"}
    //     };
    //     System.Console.WriteLine(menu.EditCar());
    //     String chassicN = InputChssisNumber("inserire numero di telaio: ");
    //     int n = InputNumber("inserire il numero di cosa vuoi cambiare: ");
    //     Car CarToEdi = cars.Find(x => x.GetSetup.GetChassis == chassicN);
    // }

    internal static void SaveFile(string path)
    {
        List<string> lines = new();
        cars.ForEach(x=>lines.Add(x.GetLine)); 
        Engine.WriteFile(lines,path);
    }
}