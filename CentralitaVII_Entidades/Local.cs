using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CentralitaVII_Entidades
{
    public class Local:Llamada, IGuardar<Local>
    {
        protected float costo;
        private string rutaDeArchivo = "LlamadasLocales.xml";

        public override float CostoLlamada { get
            { 
                return this.CalcularCosto();
            }
        }
        private Local(){}

        public Local (Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public string RutaDeArchivo { get=>rutaDeArchivo; set=>rutaDeArchivo=value; }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        public bool Equals(Llamada l1)
        {
            return this.GetType()==l1.GetType();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public bool Guardar()
        {
            try
            {
                //if (!File.Exists(this.RutaDeArchivo))
                //{
                //    File.Create(this.RutaDeArchivo);
                //}
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));
                xmlSerializer.Serialize(File.AppendText(this.RutaDeArchivo),this);
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo serializar el objeto.",ex);
            }

        }
        public Local Leer()
        {
            Local local;
            if (File.Exists(this.RutaDeArchivo))
            {
                using (StreamReader sr = new StreamReader(this.RutaDeArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Local));
                    local = xmlSerializer.Deserialize(sr) as Local;
                    if (local is Local)
                    {
                        return local;
                    }
                    else
                    {
                        throw new InvalidCastException();
                    }
                }
            }
            return null;
        }
    }
}
