namespace startaccademynet4;

internal class ClasseParticolare    //classe singleton => può esser richiamata solo una volta
{
    private static int contatore = 0;
    private static ClasseParticolare? _instance;

    private ClasseParticolare(){
        contatore ++;
        System.Console.WriteLine($"Numero instanza di Classe Particolare: {contatore}");
    }

    public static ClasseParticolare Instance(){
        return _instance ??= new ClasseParticolare();

    }
}