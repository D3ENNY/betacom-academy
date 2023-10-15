namespace gestioneAcademy;

public class DataManager : Validator
{
    private List<Student> Students {get; set;} = new();
    internal List<Student> GetStudents => Students;

    internal void InsertStudent()
    {
        string name = InputText(-12);
        string surname = InputText(0);
        DateTime bornDate = InputDate();
        string studyCourse = InputText(0);
        Students.Add(new Student(name, surname, bornDate, studyCourse));
    }

    internal void RemoveStudent()
    {
        string[]nominative = InputNominative();
        Console.Clear();
        List<Student>tmp = Students.FindAll(x => x.GetName == nominative[0] && x.GetSurname == nominative[1]);
        if(tmp.Count > 0){
            tmp.ForEach(s => MenuManager.ShowStudent(s));
            MenuManager.SelectStudent();
            int? id = InputID();
            if(id != null && Students.FindAll(s => s.GetID == id).Count() > 0)
                Students = Students.Where(s => s.GetID != id).ToList();
            else 
                MenuManager.ShowStudentEmpty();
        }else MenuManager.ShowStudentEmpty();
    }

    internal void SearchStudent(){
        string[]nominative = InputNominative();
        Console.Clear();
        List<Student>tmp = Students.FindAll(x => x.GetName == nominative[0] && x.GetSurname == nominative[1]);
        if(tmp.Count > 0)
             tmp.ForEach(s => MenuManager.ShowStudent(s));

        Console.WriteLine("premere un tasto per continuare...");
        Console.ReadKey();
    }

    internal void GetAllStudent(){
        Console.Clear();
        Students.ForEach(s => MenuManager.ShowStudent(s));
        Console.WriteLine("premere un tasto per continuare...");
        Console.ReadKey();
    }
    private string InputText(int verticalSpace)
    {
        bool flag = false;
        string text = "";

        try
        {
            Console.SetCursorPosition(45, Console.CursorTop+verticalSpace);
            do
            {
                text = Console.ReadLine()!;
                text.Trim();
                flag = ValidateText(text);
                if(!flag)
                    MenuManager.DeleteLine(45);

            }while(!flag || text == null || text == "");
        }
        catch(IOException e){
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        return text;
    }

    private DateTime InputDate()
    {
        bool flag = false;
        DateTime date = new();
        string strDate = "";

        try
        {
            Console.SetCursorPosition(45, Console.CursorTop);
            do
            {
                strDate = Console.ReadLine()!;
                flag = ValidateDate(strDate);
                if(flag){
                    string[] splittedDate = strDate.Split('/');
                    date = new DateTime(int.Parse(splittedDate[2]), int.Parse(splittedDate[1]), int.Parse(splittedDate[0]));
                    flag = ValidateDate(date);
                }else                    
                    MenuManager.DeleteLine(45);
                
                
            }while(!flag || strDate == null);
            
        }
        catch(IOException e){
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        return date;
    }

    private string[] InputNominative(){
        bool flag = false;
        string name = "", surname = "";

        try
        {
            Console.SetCursorPosition(35, Console.CursorTop-5);
            do{
                name = Console.ReadLine()!;
                flag = ValidateText(name);
                if(!flag)
                    MenuManager.DeleteLine(35);
            }while(!flag || name == null);

            flag = false;
            Console.SetCursorPosition(35, Console.CursorTop);

            do{
                surname = Console.ReadLine()!;
                flag = ValidateText(surname);
                if(!flag)
                    MenuManager.DeleteLine(35);
            }while(!flag || surname == null);

            return new string[] {name, surname};
        }
        catch(IOException e){
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        return  new string[] {name, surname};
    }

    private int? InputID(){
        try
        {
            Console.SetCursorPosition(25, Console.CursorTop-5);
            if(int.TryParse(Console.ReadLine(), out int id)){
                return id;
            }
            
        }
        catch(IOException e){
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore sulla console{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }
        catch (System.Exception e)
        {
            Console.Clear();
            Console.Error.WriteLine($"c'è stato qualche errore durante l'esecuzione del programma\n{e.Message}\npremi un tasto per continuare");
            Console.ReadLine();
        }

        return null;
    }
}