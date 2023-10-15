namespace gestioneAuto;

class MenuManager
{
    private static DataManager data = new();
    internal void Show(){
        Console.Clear();
        Console.Write(@"
            ===============================
                          menu
            ===============================

             [1] Inserimento manuale auto
             [2] Eliminazione auto
             [3] Ricerca auto
             [4] Mostra tutte le auto
             [5] Input auto da file
             [6] Modifica Auto
             [7] Exit ⏎

            ===============================
            scelta : 
        ");
    }

    internal void HandleChoise(int choise){
        switch(choise){
            case 1:
                //inserimento manuale auto
                data.InsertCliCar();
                break;
            case 2:
                //eliminazione auto

                break;
            case 3:
                //ricerca auto

                break;
            case 4: 
                //mostra tutte le auto del concessionario
                data.ShowCar();
                break;
            case 5:
                //input da file

                break;
            case 6:
                //modifica auto

                break;
            default:
                Console.Error.WriteLine("input non gestito...\npremere un tasto per continuare");
                Console.ReadKey();
                Console.Clear();
                break;

        }

    }
}