using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FormsLaListaDelSuper
{
    public static class EntidadSerializadora<T> where T : List<string>
    {
        public static T Leer(string ruta, string nombreArchivo)
        {
            string rutaCompleta = $@"{ruta}\{nombreArchivo}";
            if (File.Exists(nombreArchivo))
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return xmlSerializer.Deserialize(sr) as T;
                }
            }

            return null;
        }
        public static void Guardar(string ruta, string nombreArchivo, T objeto)
        {
            string rutaCompleta = $@"{ruta}\{nombreArchivo}";
            if (!File.Exists(nombreArchivo))
            {
                File.Create(nombreArchivo);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, objeto);
                }
            }
        }
    }
}
