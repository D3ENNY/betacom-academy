using gestioneLogin.assets.obj;

namespace gestioneLogin.engine;

class MenuManager
{
    private static readonly DataManager data = new();
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

    private static void NewUser(){
        Console.Clear();
        Console.WriteLine(@"
            ====================
                nuovo utente        
            ====================
        ");
    }

    private static void LoginUser(){
        Console.Clear();
        Console.WriteLine(@"
            ====================
                login utente        
            ====================
        ");
    }

    internal static void UserExistError(){
        Console.Clear();
        Console.WriteLine(@"
            =====================
             utente già presente        
            =====================
        ");
    }

    internal static void UserNotExistsError(){
        Console.Clear();
        Console.WriteLine(@"
            =====================
             utente non presente        
            =====================
        ");
    }

    private void ExitMod(){
        Console.WriteLine("premere un tasto per continuare:");
        Console.ReadKey();
    }


    internal void HandleChoise(int choise)
    {
        string name = string.Empty;
        switch(choise){
            case 1:
                //Register User
                NewUser();
                Console.WriteLine("inserire Username: ");
                name = Console.ReadLine()!;
                data.RegisterUser(name);
                ExitMod();
                break;
            case 2: 
                //Login User
                LoginUser();
                Console.WriteLine("inserire Username: ");
                name = Console.ReadLine()!;
                data.LoginUser(name);                ExitMod();
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