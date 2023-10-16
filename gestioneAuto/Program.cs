namespace gestioneAuto;
class Program
{
    private static readonly MenuManager menu = new();
    private const string carPath = "file/carFile/car.txt";
    private const string setuPath = "file/carFile/carCharacteristics.txt";
    static void Main(string[] args)
    {
        DataManager.InsertFileCar(carPath, setuPath);
        int choise;
        do{
            menu.Show();
            if(int.TryParse(Console.ReadLine(), out choise)){
                menu.HandleChoise(choise);
            }

        }while(choise != 7 );

        Console.WriteLine("chiusura in corso...\nattendere prego");
        Environment.Exit(0);
    }
}
