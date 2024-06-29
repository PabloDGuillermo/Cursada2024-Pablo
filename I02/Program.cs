using I01;
namespace I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool esNumero;

            Console.Write("Ingrese un número mayor que 0: ");
            esNumero = int.TryParse(Console.ReadLine(), out numero);

            while (!esNumero || numero < 0)
            {
                Console.Write("ERROR. Ingrese un número mayor que 0: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
            }

            Console.WriteLine($"Ingresó el {numero}. Su cuadrado es {Math.Pow(numero, 2)} y su cubo es {Math.Pow(numero, 3)}");
        }
    }
}
