using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja miFranja) : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
            {
                return this.Duracion * (float)0.99;
            }
            else if(this.franjaHoraria == Franja.Franja_2)
            {
                return this.Duracion * (float)1.25;
            }
            else
            {
                return this.Duracion * (float)0.66;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }


}
