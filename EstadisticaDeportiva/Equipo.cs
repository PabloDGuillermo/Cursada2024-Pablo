using System.Runtime.CompilerServices;

namespace EstadisticaDeportiva
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (!(e.jugadores.Contains(j)) && e.jugadores.Count<e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
