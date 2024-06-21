using EnciendanSusMotores;

namespace _6_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(3,5);

            AutoF1 a1 = new AutoF1(1,"Ferrari");
            AutoF1 a2 = new AutoF1(2,"Toiota");
            AutoF1 a3 = new AutoF1(3,"Shevrolei");
            AutoF1 a4 = new AutoF1(4,"peushu");

            Console.WriteLine("Datos de los autos:");
            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine(a3.MostrarDatos());
            Console.WriteLine(a4.MostrarDatos());
            Console.WriteLine(competencia.MostrarDatos());
            Console.WriteLine("Agregando autos:");

            if (competencia + a1)
            {
                Console.WriteLine("Auto agregador correctamente");
            }
            else
            {
                Console.WriteLine("Auto no agregado por amargo, puto y cagón");
            }
            if (competencia + a2)
            {
                Console.WriteLine("Auto agregador correctamente");
            }
            else
            {
                Console.WriteLine("Auto no agregado por amargo, puto y cagón");
            }
            if (competencia + a3)
            {
                Console.WriteLine("Auto agregador correctamente");
            }
            else
            {
                Console.WriteLine("Auto no agregado por amargo, puto y cagón");
            }
            if (competencia + a4)
            {
                Console.WriteLine("Auto agregador correctamente");
            }
            else
            {
                Console.WriteLine("Auto no agregado por amargo, puto y cagón");
            }
            if (competencia + a1)
            {
                Console.WriteLine("Auto agregador correctamente");
            }
            else
            {
                Console.WriteLine("Auto no agregado por amargo, puto y cagón");
            }

            Console.WriteLine("Autos en la competencia:");
            Console.WriteLine(competencia.MostrarDatos());
        }
    }
}
