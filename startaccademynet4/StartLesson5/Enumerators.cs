namespace startaccademynet4;

class Enumerators
{
    internal enum Alimentazione
    {
        Benzina,
        Diesel,
        Turbobenzina,
        Metano, 
        Gas,
        Elettrico
    }

    internal void TestEnum()
    {
        Alimentazione al = Alimentazione.Diesel;
        System.Console.WriteLine($"Valore enum: {al} - {(int)al}");
        int ali = 1;
        var checkAli = (Alimentazione) ali;
        System.Console.WriteLine($"valore enumeratore: {checkAli}");
    }

    internal void PrintEnum(){
        foreach (Alimentazione al in Enum.GetValues(typeof(Alimentazione)))
        {
            System.Console.WriteLine(al);
        }
    }
}