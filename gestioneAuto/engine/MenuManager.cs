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

    private void NoCarFound(){
        Console.Clear();
        Console.WriteLine(@"
        ================================
           non sono state trovate auto
        ================================
        ");
    }

    internal string RemoveCar(){
        Console.Clear();
        return@"
        ================================
                eliminazione auto       
        ================================
            inserire numero di telaio:
        ";
    }

    private void exitMod(){
        Console.WriteLine("premere un tasto per continuare:");
        Console.ReadKey();
    }

    internal void HandleChoise(int choise){
        switch(choise){
            case 1:
                //inserimento manuale auto
                if(!data.InsertCliCar())
                    Console.Error.WriteLine("errore nell'inserimento di qualche dato a console");
                else Console.WriteLine("auto inserita con successo");
                exitMod();
                break;
            case 2:
                //eliminazione auto
                if(data.getCarList.Count > 0)
                    if(!data.RemoveCar())
                        Console.Error.WriteLine("errore nella rimozione dell'auto");
                    else Console.WriteLine("eliminazione auto effettuata");
                else NoCarFound();
                exitMod();
                break;  
            case 3:
                //ricerca auto

                break;
            case 4: 
                //mostra tutte le auto del concessionario
                if(data.getCarList.Count > 0)
                    data.ShowCar();
                else NoCarFound();
                break;
            case 5:
                //input da file

                break;
            case 6:
                //modifica auto

                break;
            case 7:
                //the silent is golden
                break;
            default:
                Console.Error.WriteLine("input non gestito...\npremere un tasto per continuare");
                Console.ReadKey();
                Console.Clear();
                break;

        }
    }
}