namespace gestioneAcademy;
class Program
{
    private static readonly MenuManager menu = new();
    static void Main(string[] args)
    {
        try
        {
            bool  flag = true;

            do
            {
                MenuManager.Show();
                if (int.TryParse(Console.ReadLine(), out int choise))
                {
                    if (choise != 5)
                    {
                        menu.HandleChoise(choise);
                    }
                    else if (choise == 5)
                    {
                        Console.SetCursorPosition(0, Console.CursorTop + 5);
                        System.Console.WriteLine("chiusura in corso del programma...\nattendere prego");
                        flag = false;
                    }
                }
                else
                    Console.Error.WriteLine("input non valido, inserire un numero valido");
            } while(flag);
        }
        catch(IOException e){
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console\n{e.Message}");
        }
        catch (Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}");
        }
    }
}
