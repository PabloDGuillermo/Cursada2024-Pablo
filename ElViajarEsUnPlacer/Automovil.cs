using System.Text;

namespace ElViajarEsUnPlacer
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(VehiculoTerrestre.Mostrar(this));
            sb.AppendLine($"Cantidad de marchas: {this.cantidadMarchas}");
            sb.AppendLine($"Cantidad de pasajeros: {this.cantidadPasajeros}");

            return sb.ToString();
        }
    }
}
