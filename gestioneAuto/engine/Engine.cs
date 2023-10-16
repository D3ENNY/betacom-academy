namespace gestioneAuto;
class Engine
{
    internal List<String> ReadFile(string path){
        string line = "";
        List<string> lines = new();
        using StreamReader sr = new(path);
            while((line = sr.ReadLine()!) != null)
                lines.Add(line);
        return lines;
    }

    internal void WriteFile(List<String> lines, string path){
        using StreamWriter sw = new(path);
        lines.ForEach(x => sw.WriteLine(x));
    }   
}