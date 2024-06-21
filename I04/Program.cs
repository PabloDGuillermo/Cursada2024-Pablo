namespace I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int contador = 0;

            for (int i = 0; i < int.MaxValue; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        suma += j;
                        if(suma == j)
                        {
                            contador++;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                suma = 0;
                
                if (contador == 4)
                {
                    break;
                }
            }
        }
    }
}
