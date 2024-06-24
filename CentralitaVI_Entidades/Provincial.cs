using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaVI_Entidades
{
    public class Provincial:Llamada, IGuardar<string>
    {
        protected Franja franjaHoraria;
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public string RutaDeArchivo { get; set; }
        public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(float duracion, string nroDestino, string nroOrigen, Franja miFranja) : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public bool Equals(Llamada l1)
        {
            return this.GetType() == l1.GetType();
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

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }


}
