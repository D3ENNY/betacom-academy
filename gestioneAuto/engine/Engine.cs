namespace gestioneAuto;
class Engine
{
    internal static List<String> ReadFile(string path){
        string line = "";
        List<string> lines = new();
        using StreamReader sr = new(path);
            while((line = sr.ReadLine()!) != null)
                lines.Add(line);
        return lines;
    }

    internal static void WriteFile(List<String> lines, string path){
        try{
            using StreamWriter sw = new(path);
            lines.ForEach(x => sw.WriteLine(x));
        }catch(IOException){
            Console.WriteLine("error");
        }
    }   
}