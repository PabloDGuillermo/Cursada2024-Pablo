using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public class Camion:VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(VehiculoTerrestre.Mostrar(this));
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Peso de la carga: {this.pesoCarga}");

            return sb.ToString();
        }
    }
}
