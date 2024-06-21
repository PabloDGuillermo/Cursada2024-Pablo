namespace I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int numero;
            bool esNumero;
            string repetir;

            do
            {
                Console.WriteLine("Ingrese un número: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);

                while (!esNumero)
                {
                    Console.Write("ERROR. Ingrese un número o tipee salir para cerrar el programa: ");
                    ingreso = Console.ReadLine();
                    if (ingreso == "salir")
                    {
                        Environment.Exit(0);
                    }
                    esNumero = int.TryParse(ingreso, out numero);
                }

                for (int i = 2; i < numero; i++)
                {
                    bool esPrimo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.Write("Para ingresar otro número ingrese 'si': ");
                repetir = Console.ReadLine();
            } while (repetir == "si");
        }
    }
}
