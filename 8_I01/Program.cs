using ElViajarEsUnPlacer;

namespace _8_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto1 = new Moto(2, 0, Colores.Rojo, 110);
            Camion camion1 = new Camion(6, 3, Colores.Blanco, 5, 5000);
            Automovil auto1 = new Automovil(4, 5, Colores.Gris, 5, 5);

            Console.WriteLine(moto1.Mostrar());
            Console.WriteLine(camion1.Mostrar());
            Console.WriteLine(auto1.Mostrar());
        }
    }
}
