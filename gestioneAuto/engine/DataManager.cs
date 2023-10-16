namespace gestioneAuto;

class DataManager : Validate
{
    private readonly List<Car> cars = new();
    readonly Engine engine = new();
    internal bool InsertCliCar(){
        string? fuel, cubicCapacity;
        string company, model, chassisNumber;
        Console.WriteLine("gli unici dati non obbligatori sono quelli che fanno riferimento all'allestimento:\n-alimentazione\n-anno produzioe\n\n");
        Console.Write("inserisci casa automobilistica: ");
        if(string.IsNullOrEmpty((company = InputText() ?? ""))) return false;
        Console.Write("inserisci nome modello: ");
        if(string.IsNullOrEmpty((model = InputText() ?? ""))) return false;
        Console.Write("inserisci numero telaio: ");
        if(string.IsNullOrEmpty((chassisNumber = InputChssisNumber() ?? ""))) return false;
        Console.Write("inserici alimentazione: ");
        fuel = (fuel = InputNullText()) == " " ? null : fuel;
        Console.Write("inserisi anno di inizio produzione: ");
        cubicCapacity = (cubicCapacity = InputCubiCapacity()) == "" ? null : cubicCapacity;
        cars.Add(new Car(company, model, chassisNumber,fuel, cubicCapacity));

        return true;
    }

    private string InputText(){
        string text = "";
        try
        {
            do
            {
                text = Console.ReadLine()!;
            }while(ValidateText(text));
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

    private string InputChssisNumber(){
        string chassisNumber = "";
        try
        {
            do
            {
                chassisNumber = Console.ReadLine()!;
            }while(ValidateChassisNumber(chassisNumber));
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

    private string? InputNullText(){
        string? text = "";
        try
        {
            do
            {
                text = Console.ReadLine()!;
            }while(ValidateText(text));
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

    private string InputCubiCapacity(){
        string cubicCapacity = "";
        try
        {
            do
            {
                cubicCapacity = Console.ReadLine()!;
            }while(ValidateCubiCapacity(cubicCapacity));
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
    internal void ShowCar(){
        Console.Clear();
        cars.ForEach(x => System.Console.WriteLine(x.ToString()));
        Console.ReadKey();
    }

}