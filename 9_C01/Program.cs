﻿using CentralitaII;
namespace _9_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(30, "Bernal", "Rosario", 2.65f);
            Provincial l2 = new Provincial(21, "Morón", "Bernal", Provincial.Franja.Franja_1);
            Local l3 = new Local(45, "Lanús", "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            Console.WriteLine(c);
            c = c + l1;
            Console.WriteLine(c);
            c = c + l2;
            Console.WriteLine($"\n{c}");
            c = c + l3;
            Console.WriteLine($"\n{c}");
            c = c + l4;
            Console.WriteLine($"\n{c}");


            //c.OrdenarLlamadas();
            //Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
