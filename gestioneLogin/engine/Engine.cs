using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using gestioneLogin.assets.constant;

namespace gestioneLogin.engine;
class Engine
{
    public static List<T> ReadXml<T>()
    {
        List<T> result = new();

        try
        {
            XmlSerializer serializer = new(typeof(List<T>));

            using FileStream fileStream = new(Constant.Pathxml, FileMode.Open);
            result = serializer.Deserialize(fileStream) as List<T> ?? new();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Errore durante la deserializzazione: " + ex.Message);
        }

        return result;
    }

    internal static void WriteXml<T>(List<T> list) where T : List<T>
    {
        try
        {
            XmlSerializer xml = new(list.GetType());

            using StreamWriter sw = new(Constant.Pathxml);
            xml.Serialize(sw, list);
        }
        catch (System.Exception)
        {
            Console.Error.WriteLine("Errore durante la deserializzazione: " + ex.Message);
        }
    }

    internal static void AppendXml<T>(T element)
    {
        XDocument xmlDoc = XDocument.Load(Constant.Pathxml);

        XElement el = new(element.GetType().Name);

        List<PropertyInfo> getters = element.GetType().GetProperties()
        .Where(p => p.CanRead)
        .ToList();

        getters.ForEach(x => {
            XElement childEl = new XElement(x.Name);
            childEl.Value = x.GetValue(element)?.ToString() ?? string.Empty;
            el.Add(childEl);
        });

        xmlDoc.Root.Add(el);

        xmlDoc.Save(Constant.Pathxml);
    }
}