namespace startaccademynet4;

class LessonSix
{
    //tipi generici
    internal static void VisualizzaEnumeratori<T>() where T: Enum
    {
        foreach(T valEnum in Enum.GetValues(typeof(T)))
            System.Console.WriteLine(valEnum);
    }

    // internal static void VisualizzaTipoOggetto<T>(T valOggetto){ 
    //     System.Console.WriteLine(value: $"tipo oggetto: {valOggetto.GetType()} - valore oggetto: {valOggetto}");
    // }

    //non si può fare
    // internal static void VisualizzaEnum(Enum e){
    //     System.Console.WriteLine(e.GetType());
    // }
}

