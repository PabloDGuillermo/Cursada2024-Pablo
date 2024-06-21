using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace bdc_Ejemplos
{
    public static class Serializacion<T>
    {
        static string directoryPath = Directory.GetCurrentDirectory();
        static bool esWindows = OperatingSystem.IsWindows();
        static char separadorDeDirectorios = Path.DirectorySeparatorChar;
        static void SerializarXML(string path, T datos)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(streamWriter, datos);
            }
        }

        static T DeserializarXML(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                T datos = (T)xmlSerializer.Deserialize(streamReader);

                return datos;
            }
        }

        static void SerializarJson(string path, T datos)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                string datosJson = JsonSerializer.Serialize(datos,opciones);
                sw.Write(datosJson);
            }
        }

        static T DeserializadorJson(string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                string textoEnJson = sw.ReadToEnd();
                T datos = JsonSerializer.Deserialize<T>(textoEnJson);
                return datos;
            }
        }
    }
}
