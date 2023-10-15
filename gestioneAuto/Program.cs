namespace gestioneAuto;
class Program
{
    private static MenuManager menu = new();
    static void Main(string[] args)
    {
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
