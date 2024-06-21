using System;
using System.Text;

namespace _2_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esNumero;

            do
            {
                Console.Write($"Ingrese un número entero: ");
                esNumero = int.TryParse(Console.ReadLine(), out num);
                if (!esNumero)
                {
                    Console.Write("Eso no es un número. ");
                }
            } while (!esNumero);

            Console.WriteLine(MostrarTablaMultiplicacion(num));
        }

        public static string MostrarTablaMultiplicacion(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del número {numero}");

            for (int i = 1; i < 10; i++)
            {
                sb.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return sb.ToString();
        }
    }
}
