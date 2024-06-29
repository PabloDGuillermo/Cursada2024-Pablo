using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<string>, IArchivo<Bombero>
    {
        private string nombre;
        private List<Salida> salidas;
        public event FinDeSalida MarcarFin;
        
        public Bombero()
        {
            salidas = new List<Salida>();
        }
        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }

        public void Guardar(Bombero info)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Bombero.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));

                    xmlSerializer.Serialize(sw, info);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public Bombero Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Bombero.xml"))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));

                    Bombero bombero = xmlSerializer.Deserialize(sr) as Bombero;

                    return bombero;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            } 
        }

        void IArchivo<string>.Guardar(string info)
        {
            throw new NotImplementedException();
        }

        string IArchivo<string>.Leer()
        {
            throw new NotImplementedException();
        }

        
    }
}
