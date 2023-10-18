using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using gestioneLogin.assets.constant;

namespace gestioneLogin.engine;
class Engine
{
    internal static List<T> ReadXml<T>(List<T> list)where T: List<T>
    {
        try
        {
            XmlSerializer xml = new(list.GetType());

            using StreamReader sr = new(Constant.Pathxml);
            list = xml.Deserialize(sr) as List<T> ?? new();
        }
        catch (System.Exception)
        {
            throw;
        }

        return list;
    }

    internal static void WriteXml<T>(List<T> list) where T: List<T>
    {
        try
        {
            XmlSerializer xml = new(list.GetType());
            
            using StreamWriter sw = new(Constant.Pathxml);
            xml.Serialize(sw, list);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    internal static void AppendXml<T>(T element)
    {
        XDocument xmlDoc = XDocument.Load(Constant.Pathxml);

        XElement el = new(element.GetType().ToString());

        List<PropertyInfo> getters = element.GetType().GetProperties()
        .Where(p => p.CanRead)
        .ToList();

        getters.ForEach(x => el.Add(x.Name, x.GetValue(element)));

        xmlDoc.Root.Add(el);

        xmlDoc.Save(Constant.Pathxml);
    }
}