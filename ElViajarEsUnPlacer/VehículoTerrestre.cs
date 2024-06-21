using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElViajarEsUnPlacer
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        static public string Mostrar(VehiculoTerrestre vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Información del {vehiculo}:");
            sb.AppendLine($"Cantidad de ruedas: {vehiculo.cantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {vehiculo.cantidadPuertas}");
            sb.AppendLine($"Color: {vehiculo.color}");

            return sb.ToString();
        }
    }
}
