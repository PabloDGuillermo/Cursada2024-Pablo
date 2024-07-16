using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_I02_Entidades
{
    public class Negocio
    {
        private static RealNameGenerator generadorNombres;
        private List<Caja> cajas;
        private ConcurrentQueue<string> clientes;

        static Negocio()
        {
            generadorNombres = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();
            hilos.AddRange(AbrirCajas());


            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));

            return hilos;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja caja in cajas)
            {
                hilos.Add(caja.IniciarAtencion());
            }

            return hilos;
        }

        private void AsignarCajas()
        {
            do
            {
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First().AgregarCliente(cliente);
                }
            } while (true);
        }

        private void GenerarClientes()
        {
            do
            {
                Task task = Task.Run(() => clientes.Enqueue(generadorNombres.Generate()));
                Thread.Sleep(1000);
            } while (true);
        }
    }
}
