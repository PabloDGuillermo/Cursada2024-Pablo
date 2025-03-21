﻿using _18_I02_Entidades;
namespace _18_I02_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegadoClienteAtendido delegadoClienteAtendido = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.Nombre} - Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja.");
            };

            Caja caja1 = new Caja("Caja 01", delegadoClienteAtendido);
            Caja caja2 = new Caja("Caja 02", delegadoClienteAtendido);

            List<Caja> cajas = new List<Caja>()
        {
            caja1,
            caja2
        };

            Negocio negocio = new Negocio(cajas);

            Console.WriteLine("Asignando cajas...");

            List<Task> hilos = negocio.ComenzarAtencion();
            Task.WaitAll(hilos.ToArray());
        }
    }
}
