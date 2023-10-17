namespace gestioneAuto;
class Program
{
    private static readonly MenuManager menu = new();
    private const string carPath = "file/carFile/car.txt";
    private const string setuPath = "file/carFile/carCharacteristics.txt";
    private const string newPath = "file/carFile/newFile.txt";
    private const string newXmlPath = "file/carFile/newFile.xml";
    static void Main(string[] args)
    {
        DataManager.InsertFileCar(carPath, setuPath);
        int choise;
        do{
            menu.Show();
            if(int.TryParse(Console.ReadLine(), out choise)){
                menu.HandleChoise(choise);
            }

        }while(choise != 6 );
        DataManager.SaveFile(newPath);
        DataManager.SaveXml(newXmlPath);
        Console.WriteLine("chiusura in corso...\nattendere prego");
        Environment.Exit(0);
    }
}
