namespace gestioneLogin.engine;

class MenuManager
{
    private static DataManager data = new();
    internal void Show()
    {
        Console.Clear();
        Console.WriteLine(@"
            ====================
                    menu        
            ====================
               [1] Register
               [2] Login
               [3] Esci   
            ====================
            inserire numero:     
        ");
    }
    internal void HandleChoise(int choise)
    {
        switch(choise){
            case 1:
                //Register User

                break;
            case 2: 
                //Login User
                break;
            case 3:
                //the silent is golder
                break;
            default:
                Console.Error.WriteLine("input non gestito");
                break;
        }
    }
}