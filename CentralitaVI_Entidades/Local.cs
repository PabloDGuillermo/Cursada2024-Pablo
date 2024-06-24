using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaVI_Entidades
{
    public class Local:Llamada, IGuardar<string>
    {
        protected float costo;

        public override float CostoLlamada { get
            { 
                return this.CalcularCosto();
            }
        }

        public Local (Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public string RutaDeArchivo { get; set; }

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
            throw new NotImplementedException();
        }
        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}
