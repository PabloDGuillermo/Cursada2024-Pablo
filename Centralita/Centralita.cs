using System.Text;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        string razonSocial;

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float suma = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local)
                {
                    if(llamada is Local local)
                    {
                        suma += local.CostoLlamada;
                    }
                }
                else if(tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (llamada is Provincial provincial)
                    {
                        suma += provincial.CostoLlamada;
                    }
                }
                else
                {
                    if (llamada is Local local)
                    {
                        suma += local.CostoLlamada;
                    }
                    if (llamada is Provincial provincial)
                    {
                        suma += provincial.CostoLlamada;
                    }
                }
            }

            return suma;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("> Información de la Centralita. <");
            sb.AppendLine($"Razón Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: ${this.GananciaPorTotal}");
            sb.AppendLine($"Ganancia por local: ${this.GananciaPorLocal}");
            sb.AppendLine($"Ganancia por provincial: ${this.GananciaPorProvincial}\n");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if(llamada is Local local)
                {
                    sb.AppendLine("> Llamada local. <");
                    sb.AppendLine(local.Mostrar());
                }
                else if(llamada is Provincial provincial)
                {
                    sb.AppendLine("> Llamada provincial. <");
                    sb.AppendLine(provincial.Mostrar());
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
