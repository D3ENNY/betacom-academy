﻿using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ToolBoxLibrary.FileBox;
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

            using(FileStream fileStream = new(path, FileMode.Open)){
                result = serializer.Deserialize(fileStream) as List<T> ?? new();
            }
        }
        catch (FileNotFoundException ex)
        {
            PrintException("Il file specificato non è stato trovato.", ex);
        }
        catch (InvalidOperationException ex)
        {
            PrintException("Si è verificato un errore durante la deserializzazione.", ex);
        }
        catch (Exception ex)
        {
            PrintException("Errore generico durante la deserializzazione:", ex);
        }

        return result;
    }

    /// <summary>
    /// Serializza una lista di oggetti e scrive i dati serializzati in un file XML specificato.
    /// </summary>
    /// <typeparam name="T">Il tipo di oggetti contenuti nella lista.</typeparam>
    /// <param name="list">La lista di oggetti da serializzare.</param>
    /// <param name="path">Il percorso del file XML in cui scrivere i dati serializzati.</param>
    /// <return> Void </return>

    public void WriteXml<T>(List<T> list, string path) where T : List<T>
    {
        try
        {
            XmlSerializer xml = new(list.GetType());

            using(StreamWriter sw = new(path)){
                xml.Serialize(sw, list);
            }
        }
        catch (InvalidOperationException ex)
        {
            PrintException("Errore durante la serializzazione.", ex);
        }
        catch (IOException ex)
        {
            PrintException("Errore di I/O durante la serializzazione.", ex);
        }
        catch (Exception ex)
        {
            PrintException("Errore generico durante la serializzazione.", ex);
        }
    }

    /// <summary>
    /// Aggiunge un nuovo elemento serializzato in formato XML a un documento XML esistente.
    /// </summary>
    /// <typeparam name="T">Il tipo dell'elemento da serializzare e aggiungere.</typeparam>
    /// <param name="element">L'elemento da serializzare e aggiungere al documento XML.</param>
    /// <param name="path">Il percorso del documento XML esistente in cui aggiungere l'elemento.</param>
    /// <return> Void </return>

    public void AppendXml<T>(T element, string path)    
    {
        try{
            XDocument xmlDoc = XDocument.Load(path);
            if(xmlDoc != null && xmlDoc.Root != null && element != null){
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
        catch (FileNotFoundException ex)
        {
            PrintException("Errore: Il file specificato non è stato trovato.", ex);
        }
        catch (XmlException ex)
        {
            PrintException("Errore durante il caricamento del documento XML.", ex);
        }
        catch (Exception ex)
        {
            PrintException("Errore generico durante l'operazione di append XML.", ex);
        }
    }
    
    /// <summary>
    /// Stampa un messaggio di errore e il messaggio dell'eccezione su Console.Error in rosso.
    /// </summary>
    /// <param name="errorMessage">Messaggio di errore personalizzato.</param>
    /// <param name="ex">Eccezione da stampare.</param>
    /// <return> Void </return>
    private void PrintException(string error, Exception ex){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Error.WriteLine($"Errore: {error}\nMessaggio di Error: {ex.Message}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
