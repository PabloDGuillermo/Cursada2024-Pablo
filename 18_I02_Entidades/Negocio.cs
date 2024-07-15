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
        private bool flag = true;

        static Negocio()
        {
            generadorNombres = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public void ComenzarAtencion()
        {
            foreach (Caja caja in cajas)
            {
                caja.IniciarAtencion();
            }
            while(flag == true)
            {
                Task task = Task.Run(() => clientes.Enqueue(generadorNombres.Generate()));
                Thread.Sleep(1000);
            }
            while (flag == true)
            {
                Task task = Task.Run(() => clientes.Enqueue(generadorNombres.Generate()));
                Thread.Sleep(1000);
            }
        }
    }
}
