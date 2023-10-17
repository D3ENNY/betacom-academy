    using System.Xml.Serialization;
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

    internal static void WriteXmlFile(string path){
        try
        {
            XmlSerializer xml = new(DataManager.GetCarList.GetType());

            using(StreamWriter sw = new(path)){
                xml.Serialize(sw, DataManager.GetCarList);
            }
        }catch (System.Exception)
        {
            
            throw;
        }
    }

}