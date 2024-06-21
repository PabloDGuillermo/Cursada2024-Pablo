using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(VehiculoTerrestre.Mostrar(this));
            sb.AppendLine($"Cilindrada: {this.cilindrada}");

            return sb.ToString();
        }
    }


}
