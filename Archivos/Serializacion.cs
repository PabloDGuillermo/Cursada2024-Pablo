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

        //public static void Escribir(T t)
        //{
        //    string completa = ruta + @"\Serializadora.xml";
        //    try
        //    {
        //        if (!Directory.Exists(ruta))
        //        {
        //            Directory.CreateDirectory(ruta);
        //        }
        //        List<T> listaObjetos = new List<T>();
        //        if (File.Exists(completa))
        //        {
        //            // Leer objetos existentes desde el archivo
        //            listaObjetos = Leer();
        //        }
        //        listaObjetos.Add(t);
        //        using (StreamWriter sw = new StreamWriter(completa))
        //        {
        //            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<T>));//Se serializa un objeto en especifico por eso hay que aclararle el tipo de objeto
        //            xmlserializer.Serialize(sw, listaObjetos);//Toma el objeto y lo serializa.
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"Error al escribir el archivo{completa}", ex.InnerException);
        //    }
        //}

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
