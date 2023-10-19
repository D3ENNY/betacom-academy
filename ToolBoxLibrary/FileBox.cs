using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ToolBoxLibrary;
public class FileBox
{
    /// <summary>
    /// Legge un file XML e deserializza i dati in una lista di oggetti del tipo specificato.
    /// </summary>
    /// <typeparam name="T">Il tipo di oggetti da deserializzare.</typeparam>
    /// <param name="path">Il percorso del file XML da leggere.</param>
    /// <returns>
    /// Una lista di oggetti del tipo specificato deserializzati dal file XML. Se si verifica un errore durante la deserializzazione,
    /// verrà restituita una lista vuota.
    /// </returns>
    public List<T> ReadXml<T>(string path)
    {
        List<T> result = new();

        try
        {
            XmlSerializer serializer = new(typeof(List<T>));

            using FileStream fileStream = new(path, FileMode.Open);
            result = serializer.Deserialize(fileStream) as List<T> ?? new();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine("Errore durante la deserializzazione: " + ex.Message);
        }

        return result;
    }

    /// <summary>
    /// Serializza una lista di oggetti e scrive i dati serializzati in un file XML specificato.
    /// </summary>
    /// <typeparam name="T">Il tipo di oggetti contenuti nella lista.</typeparam>
    /// <param name="list">La lista di oggetti da serializzare.</param>
    /// <param name="path">Il percorso del file XML in cui scrivere i dati serializzati.</param>
    /// <return> void </return>

    internal void WriteXml<T>(List<T> list, string path) where T : List<T>
    {
        try
        {
            XmlSerializer xml = new(list.GetType());

            using StreamWriter sw = new(path);
            xml.Serialize(sw, list);
        }
        catch (System.Exception ex)
        {
            Console.Error.WriteLine("Errore durante la deserializzazione: " + ex.Message);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo elemento serializzato in formato XML a un documento XML esistente.
    /// </summary>
    /// <typeparam name="T">Il tipo dell'elemento da serializzare e aggiungere.</typeparam>
    /// <param name="element">L'elemento da serializzare e aggiungere al documento XML.</param>
    /// <param name="path">Il percorso del documento XML esistente in cui aggiungere l'elemento.</param>
    /// <return> void </return>

    internal void AppendXml<T>(T element, string path)
    {
        XDocument xmlDoc = XDocument.Load(path);

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

        xmlDoc.Save(path);
    }
}
