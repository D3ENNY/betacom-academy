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
             [5] Modifica Auto
             [6] Exit ⏎

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
        return@"
        ================================
                eliminazione auto       
        ================================
            inserire numero di telaio:
        ";
    }

    internal string EditCar(){
        return@"
        ================================
                  modifica auto       
        ================================
              cosa vuoi cambiare?
        ================================
          [1] nome casa automobilistica
          [2] nome modello
          [3] anno modello
          [4] alimentazione
          [5] cilindrata
        ================================

        ";
    }

    private void ExitMod(){
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
                ExitMod();
                break;
            case 2:
                //eliminazione auto
                if(DataManager.GetCarList.Count > 0)
                    if(!data.RemoveCar())
                        Console.Error.WriteLine("errore nella rimozione dell'auto");
                    else Console.WriteLine("eliminazione auto effettuata");
                else NoCarFound();
                ExitMod();
                break;  
            case 3:
                //ricerca auto
                if(DataManager.GetCarList.Count > 0)
                    data.SearchCar();
                ExitMod();
                break;
            case 4: 
                //mostra tutte le auto del concessionario
                if(DataManager.GetCarList.Count > 0)
                    data.ShowCar();
                else NoCarFound();
                ExitMod();
                break;
            case 5:
                //modifica auto
                // if(data.getCarList.Count > 0)
                //     data.EditCar();
                // else NoCarFound();
                //TODO
                break;
            case 6:
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