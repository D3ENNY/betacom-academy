namespace gestioneAuto;

class DataManager : Validate
{
    private readonly List<Car> cars = new();
    readonly Engine engine = new();
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
        cars.ForEach(x => System.Console.WriteLine(x.ToString()));
        Console.ReadKey();
    }

}