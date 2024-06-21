namespace I01
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            float prom;
            int num;
            int suma = 0;
            bool esNumero;
            bool dentroDelRango;
            int rangoMin = -100;
            int rangoMax = 100;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    do
                    {
                        Console.Write($"Ingrese un número entero entre {rangoMin} y {rangoMax}: ");
                        esNumero = int.TryParse(Console.ReadLine(), out num);
                        if (!esNumero)
                        {
                            Console.Write("Eso no es un número. ");
                        }
                    } while (!esNumero);

                    dentroDelRango = Validador.Validar(num, rangoMin, rangoMax);
                    if (!dentroDelRango)
                    {
                        Console.Write("El número está fuera del rango permitido. ");
                    }
                } while (!dentroDelRango);

                suma += num;

                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            prom = (float)suma / 10;

            Console.WriteLine($"El valor mínimo es {min}, el valor máximo es {max} y el promedio es {prom}");
        }
    }
}
