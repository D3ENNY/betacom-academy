using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace gestioneAcademy;

public class MenuManager
{
        private readonly DataManager data = new();
        internal static void Show()
        {
            Console.Clear();
            Console.WriteLine(@"
            =========================================================================================
            ||                                     Benvenuto                                       ||
            ||                                  scelta operazione:                                 ||
            =========================================================================================
            ||                                                                                     ||  
            ||    1) Inserimento studente                                                          ||
            ||    2) Eliminazione studente                                                         ||
            ||    3) Ricerca Studente                                                              ||
            ||    4) Visualizza lista studenti                                                     ||
            ||    5) Esci                                                                          ||
            ||                                                                                     ||  
            =========================================================================================
            ||                                                                                     ||
            ||    scelta:                                                                          ||
            ||                                                                                     ||
            =========================================================================================
            ");
            Console.SetCursorPosition(27, Console.CursorTop-4);
        }

        internal static void NewStudent()
        {
            Console.Clear();
            Console.WriteLine(@"
            =========================================================================================
            ||                                     Benvenuto                                       ||
            ||                                  scelta operazione:                                 ||
            =========================================================================================
            ||                             |                                                       ||  
            ||    1) Nome                  |                                                       ||
            ||    2) Cognome               |                                                       ||
            ||    3) data nascita          |                                                       ||
            ||    3) Persorso studi        |                                                       ||
            ||                             |                                                       ||  
            =========================================================================================
            ||                                    NOTA BENE                                        ||
            ||                                                                                     ||
            ||    a) la data di nascita deve esser inserita in questo formato: DD/MM/YYYY          ||
            ||                                                                                     ||
            =========================================================================================
            ");
        }

        internal static void DataStudent(){
            Console.Clear();
            Console.WriteLine(@"
            =========================================================================================
            ||                             inserire i dati sotto richiesti                         ||
            =========================================================================================
            ||                                                                                     ||  
            ||    1) Nome      =>                                                                  ||
            ||    2) Cognome   =>                                                                  ||
            ||                                                                                     ||
            =========================================================================================
            ");
        }

    internal static void SelectStudent()
    {
        Console.WriteLine(@"
        =========================================================================================
        ||                             inserire i dati sotto richiesti                         ||
        =========================================================================================
        ||                                                                                     ||
        ||  ID studente:                                                                       ||
        ||                                                                                     ||
        =========================================================================================
        
        ");
    }

    internal static void ShowStudent(Student s)
    {

        Console.WriteLine($@"
        =========================================================================================
        ||                                dati utente richiesto                                ||
        =========================================================================================
        ||                                                                                     ||
        ||    1) ID        => {s.GetID}{new string(' ', 66-(s.GetID.ToString().Length+1))}||
        ||    2) Nome      => {s.GetName}{new string(' ', 66-(s.GetName.Length+1))}||
        ||    3) Cognome   => {s.GetSurname}{new string(' ', 66-(s.GetSurname.Length+1))}||
        ||    4) nascita   => {s.GetDate}{new string(' ', 66-(s.GetDate.Length+1))}||
        ||    5) studu     => {s.GetStudy}{new string(' ', 66-(s.GetStudy.Length+1))}||
        ||                                                                                     ||
        =========================================================================================
        
        ");
    }

    internal static void ShowStudentEmpty()
    {
        Console.Clear();
        Console.WriteLine(@"
        =========================================================================================
        ||                               nessun utente presente                                ||
        =========================================================================================
        
        premere un tasto per continuare...
        ");
        Console.ReadKey();
    }
        internal static void DeleteLine(int x){
            Console.SetCursorPosition(x, Console.CursorTop-1);
            Console.Write("                                      ");
            Console.SetCursorPosition(x, Console.CursorTop);
        } 

        internal void HandleChoise(int choise)
        {
            switch (choise)
            {
                case 1:
                    // inserimento di un nuovo studente all'interno della nostra accademyù
                    MenuManager.NewStudent();
                    data.InsertStudent();
                    break;
                case 2:
                    // eliminazione di uno studente (dato nome e cognome)
                    if(data.GetStudents.Count > 0){
                        MenuManager.DataStudent();
                        data.RemoveStudent();
                    }else
                        MenuManager.ShowStudentEmpty();
                    break;
                case 3:
                    //richiesta studente (dato nome e cognome)
                    if(data.GetStudents.Count > 0){
                        MenuManager.DataStudent();
                        data.SearchStudent();
                    }else 
                        MenuManager.ShowStudentEmpty();
                    break;
                case 4:
                    //visualizza la lista di tutti gli studenti
                    if(data.GetStudents.Count > 0){
                        data.GetAllStudent();
                    }else 
                        MenuManager.ShowStudentEmpty();
                    break;
                default:
                    Console.Error.WriteLine("input non valdo, Riprova!");
                    break;
            }
        }

}