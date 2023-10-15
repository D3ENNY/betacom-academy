namespace startaccademynet4;

public class FilePlay{

    internal void ReadFileV1()
    {
        try
        {
            //string fData = File.ReadAllText("~/Documenti/config/config.fish");
            string fData = File.ReadAllText("/home/denny/Documenti/config/config.fish");
            System.Console.WriteLine(fData);
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    internal void ReadFileV2(string pathF, string nameF)
    {
        try
        {
            string[] fData = File.ReadAllLines(Path.Combine(pathF, nameF));
            Array.ForEach(fData, x => System.Console.WriteLine(x + " ---"));
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    internal void ReadFileV3(string pathF, string nameF)
    {
        StreamReader sr = new(Path.Combine(pathF, nameF));    
        try
        {
            string fData = sr.ReadToEnd();
            System.Console.WriteLine(fData);
        }
        catch (System.Exception)
        {
            throw;
        }
        finally
        {
            sr.Close();
        }
    }

    internal void ReadFileV4(string pathF, string nameF)
    {
        StreamReader sr = new(Path.Combine(pathF, nameF));    
        try
        {
            string sline;
            List<string> lines = new();

            while((sline = sr.ReadLine()!) != null){
                lines.Add(sline);
            }

            lines.ForEach(x => System.Console.WriteLine(x));
            
        }
        catch (System.Exception)
        {
            throw;
        }
        finally
        {
            sr.Close();
        }
    }

    internal void ReadFileV5(string pathF, string nameF){
        string line;
        List<string> strList = new();

        try
        {
            using StreamReader sr = new StreamReader(Path.Combine(pathF, nameF));
            while ((line = sr.ReadLine()!) != null)
                strList.Add(line);
            
            strList.ForEach(x => System.Console.WriteLine(x));

        }
        catch (System.Exception)
        {
            
            throw;
        }
    }

    internal void GetFile(string pathF){
        DirectoryInfo dir = new(pathF);
        Array.ForEach(dir.GetFiles(), x => System.Console.WriteLine(x));
    }

}