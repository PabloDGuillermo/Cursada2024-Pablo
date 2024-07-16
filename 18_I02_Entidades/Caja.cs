namespace _18_I02_Entidades
{
    public delegate void DelegadoClienteAtendido(Caja caja, string str);
    public class Caja
    {
        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        private DelegadoClienteAtendido delegadoClienteAtentido;

        public string Nombre { get; }
        public int CantidadDeClientesALaEspera { get { return clientesALaEspera.Count; } }

        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtentido)
        {
            this.nombreCaja = nombreCaja;
            this.clientesALaEspera = new Queue<string>();
            this.delegadoClienteAtentido = delegadoClienteAtentido;
        }

        //Tendrá un método AgregarCliente con visibilidad internal que recibirá un cliente y lo agregará a clientesALaEspera.
        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        //Tendrá un método IniciarAtencion con visibilidad internal que deberá iniciar la atención de clientes en un sub-proceso paralelo.
        //Este método no recibirá nada y retornará la instancia de Task que se haya utilizado.
        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();
                    delegadoClienteAtentido.Invoke(this, cliente);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            } while (true);
        }
    }
}
