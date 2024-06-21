
using I01;

namespace _2_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esNumero;
            int suma = 0;

            do
            {
                do
                {
                    Console.Write($"Ingrese un número entero: ");
                    esNumero = int.TryParse(Console.ReadLine(), out num);
                    if (!esNumero)
                    {
                        Console.Write("Eso no es un número. ");
                    }
                } while (!esNumero);

                suma += num;

                Console.Write("Desea continuar? (S/N): ");
            } while (Validador.ValidarRespuesta(Console.ReadLine()));

            Console.WriteLine($"La suma de los números ingresador es: {suma}");
        }
    }
}
