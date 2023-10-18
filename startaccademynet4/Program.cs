using static startaccademynet4.DataSerialization;
using static startaccademynet4.OOPTest;

namespace startaccademynet4;
internal class Program{
    static void Main(string[] args){
        Console.ForegroundColor = ConsoleColor.Magenta;
        Program p = new Program();

        p.test26();
    }

    private void exit(){
        Console.Clear();
        Console.WriteLine("exit");
        Environment.Exit(0);
    }

    // private void test1(){
    //     Console.WriteLine(MathFunction.computeExponent(8));
    //     Console.WriteLine(MathFunction.computeExponent(3,8));

    // }

    // private void test2(){
    //     Console.WriteLine("inserire n1");
    //     double n1 = double.Parse(Console.ReadLine());
    //     Console.WriteLine("inserire n2");
    //     double n2 = double .Parse(Console.ReadLine());

    //     Console.WriteLine(MathFunction.computeExponent(n1));
    //     Console.WriteLine(MathFunction.computeExponent(n1,n2));
    // }

    // private void test3(){
    //     double n1 = 0;
    //     double n2 = 0;

    //     try{
    //         Console.WriteLine("inserire n1: ");
    //         n1 = double.Parse(Console.ReadLine());
    //         Console.WriteLine("inserire n2: ");
    //         n2 = double.Parse(Console.ReadLine());
    //     }catch(IOException e){
    //         Console.WriteLine("error to write in console ->" + e.Message);
    //     }catch (Exception e){
    //         Console.WriteLine("error -> "+e.Message);
    //     }

    //     Console.WriteLine("output: "+MathFunction.computeExponent(n1,n2));
    // }

    // private void test4(){
    //     double n1 = 0;
    //     double n2 = 0;  
    //     try{
    //         Console.WriteLine("inserire n1 e n2: ");
    //         if(double.TryParse(Console.ReadLine(), out n1) && double.TryParse(Console.ReadLine(), out n2))
    //             Console.WriteLine($"output: {MathFunction.computeExponent(n1,n2)}");
    //         else 
    //             Console.WriteLine("error to write in console some parameters");
    //     }
    //     catch(IOException e){
    //         Console.WriteLine($"error to write in console -> {e.Message}");
    //     }catch (Exception e){
    //         Console.WriteLine($"error -> {e.Message}");
    //     }
    // }

    // private void test5(){
    //     try
    //     {
    //         Console.Write("il valore di \"i\" è: ");
    //         for (int i = 0; i < 10; i++)
    //             if(i<9)
    //                 Console.Write($"{i}, ");
    //             else
    //                 Console.Write(i);
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine($"some error occured -> {e.Message}");
    //     }
    // }

    // private void test6(){
    //     double n1 = 0;
    //     double n2 = 0;  
    //     bool flag = true;
    //     try{
    //         do{
    //             Console.WriteLine("please insert n1 and n2: \npress enter between first input and second.\nif you want to exit press X keys in one of the two prompts and enter it");
    //             String? str1 = Console.ReadLine();
    //             String? str2 = Console.ReadLine();

    //             if(double.TryParse(str1, out n1) && double.TryParse(str2, out n2)){
    //                 Console.WriteLine($"output: {MathFunction.computeExponent(n1,n2)}\npress enter to continue");
    //                 Console.ReadLine();
    //                 Console.Clear();
    //             }else if((str1 != null && str1.ToLower() == "x") || (str2 != null && str2.ToLower() == "x")){
    //                 Console.Clear();
    //                 Console.WriteLine("exit");
    //                 flag = false;
    //                 break;
    //             }else{
    //                 Console.ForegroundColor = ConsoleColor.Red;
    //                 Console.WriteLine("some error occured, plese insert a number valid or \'x\' to leave!\npress enter to continue.");
    //                 Console.ReadLine();
    //                 Console.Clear();
    //                 Console.ForegroundColor = ConsoleColor.Magenta;
    //             }
    //         }while(flag);
    //     }
    //     catch(IOException e){
    //         Console.WriteLine($"error occured while writing in console -> {e.Message}");
    //     }catch (Exception e){
    //         Console.WriteLine($"some error occured, open new issue to report that -> {e.Message}");
    //     }
    // }

    // private void test7(){
    //     //dichiarazione variabili
    //     double n1 = 0, n2 = 0;

    //     try{
    //         do{
    //             Console.WriteLine("""
    //                 ######################################################################################################################
    //                 | this program enable the user to enter two number and one mathematics operator; it return the calc that the user ask|
    //                 | press x key and enter it to exit the program                                                                       |
    //                 ######################################################################################################################
    //             """);

    //             Console.Write("\n\ninsert the first number: ");
    //             string? str1 = Console.ReadLine();
    //             if(str1 != null && str1.ToLower() == "x") exit();
    //             Console.Write("insert the second number: ");
    //             string? str2 = Console.ReadLine();
    //             if(str2 != null && str2.ToLower() == "x") exit();

    //             if(double.TryParse(str1, out n1) && double.TryParse(str2, out n2)){
    //                 Console.WriteLine("insert the mathematics operator.\nchoose one of that:\n+ | - | * | / | ^");
    //                 string? sign = Console.ReadLine();
    //                 if(sign != null && sign.ToLower() == "x") exit();
    //                 if(sign != null)
    //                     Console.WriteLine(MathFunction.getCalc(n1, n2, sign));
    //                 Console.ForegroundColor = ConsoleColor.Magenta;
    //                 Console.WriteLine("press any key to continue");
    //                 Console.ReadKey();
    //                 Console.Clear();
    //             }else{
    //                 Console.ForegroundColor = ConsoleColor.Red;
    //                 Console.WriteLine("some error occured, plese insert a number valid or \'x\' to leave!\npress enter to continue.");
    //                 Console.ReadLine();
    //                 Console.Clear();
    //                 Console.ForegroundColor = ConsoleColor.Magenta;
    //             }
    //         }while(true);
    //     }
    //     catch(IOException e){
    //         Console.WriteLine($"error occured while writing in console -> {e.Message}");
    //     }catch (Exception e){
    //         Console.WriteLine($"some error occured, open new issue to report that -> {e.Message}");
    //     }
    // }

    // private void test8(){
    //     DateTime date = DateTime.Now;
    //     Console.WriteLine($"formato data standard: {date}\n" + 
    //                       $"formato data corto: {date.ToShortDateString()} - {date.ToShortTimeString()}\n" +
    //                       $"La data tra tre giorni: {date.AddDays(3)}");
    // }

    // private void test9(){
    //     Student student1 = new("mario", "rossi");
    //     Student student2 = new("denys", "raimondi");
    //     Student student3 = new("luigi", "verdi");
    //     System.Console.WriteLine(Student.ShowStudentsArray());
    // }

    // private void test10(){
    //     Student student1 = new("mario", "rossi");
    //     Student student2 = new("denys", "raimondi");
    //     Student student3 = new("luigi", "verdi");

    //     System.Console.WriteLine(Student.showStudentsList());
    // }

    // private void test11(){
    //     Dictionary<string, string> dic = new();
    //     dic.Add(".txt", "code.exe");
    //     dic.Add(".png", "Gwenview.exe");

    //     foreach(string x in dic.Keys)
    //         System.Console.WriteLine(dic[x]);
    //     System.Console.WriteLine("------");
    //     foreach(string x in dic.Keys)
    //         System.Console.WriteLine(x);
    //     System.Console.WriteLine("------");
    //     foreach(string x in dic.Values)
    //         System.Console.WriteLine(dic.FirstOrDefault(z => z.Value == x).Key);
    //     System.Console.WriteLine("------");
    //     foreach(string x in dic.Values)
    //         System.Console.WriteLine(x);
    //     System.Console.WriteLine("------");
    //     foreach(KeyValuePair<string, string> x in dic)
    //         System.Console.WriteLine($"key -> {x.Key} - value -> {x.Value}");
    // }

    // private void test12(){
    //     Tuple<int, string, Student> tuple = Tuple.Create(1,"parola", new Student("denys", "raimondi"));
    //     System.Console.WriteLine($"valore tupla: {tuple.Item1} - {tuple.Item2} - \n{tuple.Item3}");
    // }

    // private void test13(){
    //     LessonFour l = new();

    //     int test = 4;

    //     l.test13(test);
    //     System.Console.WriteLine($"dopo aver eseguito una funzione passando il valore, test vale {test}");
    //     l.test13ref(ref test);
    //     System.Console.WriteLine($"dopo aver eseguito una funzione passando il valore per referenza, test vale: {test}");
    // }

    // private void test14(){
    //     string str = "siamo un academy fortissima!!!";

    //     System.Console.WriteLine(str.Substring(0, str.IndexOf("fortissima")));
    //     System.Console.WriteLine(str[..str.IndexOf("fortissima")]);

    //     string[] sTest = str.Split(" "); 
    //     Array.ForEach(sTest, x => System.Console.WriteLine(x));
    // }

    // private void test15(){
    //     FilePlay fp = new();

    //     string pathF = "/home/denny/Documenti/config/config.fish";
    //     System.Console.WriteLine("file: ");
    //     fp.GetFile(Path.GetDirectoryName(pathF)!);

    //     System.Console.WriteLine("\nReadFileV1: ");
    //     fp.ReadFileV1();

    //     System.Console.WriteLine("\nreadFileV2: ");
    //     fp.ReadFileV2(Path.GetDirectoryName(pathF)!, Path.GetFileName(pathF));

    //     System.Console.WriteLine("\nreadFileV3: ");
    //     fp.ReadFileV3(Path.GetDirectoryName(pathF)!, Path.GetFileName(pathF));

    //     System.Console.WriteLine("\nreadFileV4: ");
    //     fp.ReadFileV4(Path.GetDirectoryName(pathF)!, Path.GetFileName(pathF));

    //     System.Console.WriteLine("\nreadFileV5: ");
    //     fp.ReadFileV5(Path.GetDirectoryName(pathF)!, Path.GetFileName(pathF));

    // }

    // private void test16(){
    //     Enumerators e = new();
    //      e.TestEnum();
    //     e.PrintEnum();
    // }

    // private void test17(){
    //     string str = "text1, txt2, txt, txxxt4";
    //     System.Console.WriteLine(str.Split(", ")[0].Length);
    //     Console.WriteLine(string.Join(", ", str.Split(',').Select(element => element.Length)));
    //     System.Console.WriteLine($"metodo aggiunto a string: lunghezza: {str.WordCounts()}");
    // }

    // private void test18(){
    //     int[] ints = {14, 21, 34, 71, 50, 60};
    //     System.Console.WriteLine($"media numeri array: {ints.Average()}\n");
    //     //query
    //     System.Console.WriteLine($"media numeri array: {(from el in ints select el).Average()}\n");
    // }

    // private void test19(){
    //     int[] ints = {14, 21, 34, 71, 50, 60};

    //     ints.ToList().FindAll(x => x % 2 == 0).ForEach(x => System.Console.WriteLine(x));
    // }

    //LInQ
    // private void test20(){
    //     List<Student> students = new List<Student>(){
    //         new("mario", "rossi"), 
    //         new("luca", "verdi"), 
    //         new("mario", "bianchi")
    //      };

    //     List<Student> studentFilter = new();
    //     studentFilter = (from student in students
    //                         where student.Name == "mario"
    //                         select student
    //                     ).ToList();

    //     studentFilter.ForEach(x => Console.WriteLine(x.ToString()));
    // }

    // private void test21(){
    //     string str = "f";

    //     if(str.Length==8 && str[..2].ToCharArray().ToList().TrueForAll(c => char.IsLetter(c)) &&
    //         int.TryParse(str[3..], out _)){
    //             System.Console.WriteLine("valido");
    //     }else System.Console.WriteLine("non valido");
    // }

    // private void test22(){
    //     System.Console.WriteLine("es1: ");
    //     LessonSix.VisualizzaEnumeratori<Enumerators.Alimentazione>();
    //     System.Console.WriteLine("\nes2: ");
    //     LessonSix.VisualizzaTipoOggetto<double>(123.4);
    //     LessonSix.VisualizzaTipoOggetto("stringa");
    //     LessonSix.VisualizzaTipoOggetto(DateTime.Now);
    //     //System.Console.WriteLine("\nes3: ");
    //     //LessonSix.VisualizzaEnum(Enumerators.Alimentazione); non si può fare
    // }

    // private void test23(){
    //     // MezziLocomozione mezziLocomozione = new();
    //     MezziTrasporto trasporto = new();
    //     System.Console.WriteLine(trasporto.getTipoTrasporto());

    //     MountainBike mbt = new();
    //     System.Console.WriteLine(mbt.TipoMotore());
    // }

    // private void test24(){
    //     ClasseParticolare cp = ClasseParticolare.Instance();
    //     ClasseParticolare cp1 = ClasseParticolare.Instance();
    // }

    // private void test25(){
    //     Fly f = new();
    //     f.LoadFly();
    //     f.SaveJson();
    // }

    private void test26(){
        Encrypt e = new();
        System.Console.WriteLine($"hash di Pippo: {e.EncryptString("pippo")}");
    }
}