using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadisticaDeportiva
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.nombre = nombre;  
            this.dni = dni;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles= totalGoles;
            this.partidosJugados=totalPartidos;
        }
        public float GetPromedioGoles()
        {
            this.promedioGoles = (float)this.totalGoles/this.partidosJugados;
            return this.promedioGoles;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del Jugador.");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total de goles: {this.totalGoles}");
            sb.AppendLine($"Promedio de goles: {this.GetPromedioGoles()}");
            return sb.ToString();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }



    }
}
