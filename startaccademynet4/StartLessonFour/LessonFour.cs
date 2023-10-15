namespace startaccademynet4;

public class LessonFour{

    // in questa funzione viene passato il valore di n
    internal void test13(int n){
        System.Console.WriteLine($"il quadrato di {n} è: {n*=n}");
    }

    //in questa funzione viene passata la variabile per referenza, quindi la porzione di memoria
    //si lavora quindi sulla variabile che viene passata e non su una copia
    internal void test13ref(ref int n){
        System.Console.WriteLine($"il quadrato di {n} per referenza è: {n*=n}");
    }

}