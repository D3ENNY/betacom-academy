using gestioneLogin.engine;

namespace gestioneLogin;
class Program
{
    private static MenuManager menu = new();
    static void Main(string[] args)
    {
        int choise = 0;
        try
        {
            do{
                menu.Show();
                if(int.TryParse(Console.ReadLine(), out choise))
                    menu.HandleChoise(choise);
            }while(choise != 3);
        }
        catch (System.Exception e)
        {
            Console.Error.WriteLine($"errore generico {e.Message}");
        }
    }
}
