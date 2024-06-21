using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_Ejemplos
{
    public static class Archivos
    {
        static string directoryPath = Directory.GetCurrentDirectory();
        static bool esWindows = OperatingSystem.IsWindows();
        static char separadorDeDirectorios = Path.DirectorySeparatorChar;
        public static void Guardar(string path, string fileName, string text)
        {
            string fullPath = Path.Combine(directoryPath,separadorDeDirectorios.ToString(), fileName);
            try
            {
                if (!File.Exists(fullPath))
                {
                    File.Create(fullPath);
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(fullPath))
                    {
                        sw.Write(text);
                        //sw.WriteLine(text);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        static string Leer(string path, string fileName)
        {
            string fullPath = Path.Combine(path,separadorDeDirectorios.ToString(),fileName);
            string textoRetorno = "";

            try
            {
                if (!File.Exists(fullPath))
                {
                    return "\nERROR. El archivo no existe.\n";
                }
                else
                {
                    //using (StreamReader sr = new StreamReader(fullPath,true)) -> de esta manera apendeamos
                    using (StreamReader sr = new StreamReader(fullPath)) //de esta manera sobreescribimos
                    {
                        textoRetorno += sr.ReadToEnd();
                    }
                }
                return textoRetorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
