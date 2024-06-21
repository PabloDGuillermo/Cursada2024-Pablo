using JugadoresEncapsulados;
namespace _7_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo(23, "Lanus");
            Jugador j1 = new Jugador(123, "Pepe Sand", 50, 30);
            Jugador j2 = new Jugador(456, "Milito", 45, 33);
            Jugador j3 = new Jugador(789, "Oscar", 2, 10);

            if (e + j1)
            {
                Console.WriteLine("Jugador agregado.");
                Console.WriteLine(j1.MostrarDatos());
            }
            if (e + j2)
            {
                Console.WriteLine("Jugador agregado.");
                Console.WriteLine(j2.MostrarDatos());
            }
            if (e + j3)
            {
                Console.WriteLine("Jugador agregado.");
                Console.WriteLine(j3.MostrarDatos());
            }
            if (e + j3)
            {
                Console.WriteLine("Jugador agregado.");
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("Jugador ya agregado anteriormente.");
            }

        }
    }
}
