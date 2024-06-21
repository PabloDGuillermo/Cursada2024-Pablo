using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JugadoresEncapsulados
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }
        public float PromedioGoles
        {
            get { return (float)this.totalGoles / this.partidosJugados; }
        }
        public float TotalGoles
        {
            get { return this.totalGoles; }
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del Jugador.");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Partidos jugados: {this.PartidosJugados}");
            sb.AppendLine($"Total de goles: {this.TotalGoles}");
            sb.AppendLine($"Promedio de goles: {this.PromedioGoles}");
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }



    }
}

