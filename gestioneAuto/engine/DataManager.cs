
namespace gestioneAuto;

class DataManager : Validate
{
    private static List<Car> cars = new();
    internal List<Car> getCarList => cars;

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
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
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
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
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
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
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
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
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
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }

        return year;
    }
    internal void ShowCar(){
        Console.Clear();
        cars.ForEach(x => System.Console.WriteLine(x.ToString() + "\n\n"));
        Console.ReadKey();
    }

    internal void RemoveCar()
    {
        
    }
}