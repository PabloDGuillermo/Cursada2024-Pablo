using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local:Llamada
    {
        protected float costo;

        public float CostoLlamada { get
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

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }
    }
}
