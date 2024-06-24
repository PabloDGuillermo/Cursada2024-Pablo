using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace CentralitaVII_Entidades
{
    public class Centralita:IGuardar<string>
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
        public string RutaDeArchivo { get; set; }

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

        private string Mostrar()
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
                    sb.AppendLine(local.ToString());
                }
                else if(llamada is Provincial provincial)
                {
                    sb.AppendLine("> Llamada provincial. <");
                    sb.AppendLine(provincial.ToString());
                }
            }

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c,Llamada llamada)
        {
            foreach (Llamada l1 in c.Llamadas)
            {
                if (l1 == llamada)
                {
                    return true;
                }
            }
            return  false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            foreach (Llamada l1 in c.Llamadas)
            {
                if (l1 == llamada)
                {
                    return false;
                }
            }
            return true;
        }
        public static Centralita operator +(Centralita c, Llamada llamadaNueva)
        {
            if (c != llamadaNueva)
            {
                c.AgregarLlamada(llamadaNueva);
                try
                {
                    c.Guardar();
                    if (llamadaNueva is Local local)
                    {
                        local.Guardar();
                    }
                    else if (llamadaNueva is Provincial provincial)
                    {
                        provincial.Guardar();
                    }
                }
                catch(Exception)
                {
                    throw new FallaLogException();
                }
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra registrada en el sistema", "Centralita", "Sobrecarga del operador +");
            }
            return c;
        }


        public void OrdenarLlamadas()
        {
            for (int i = 0; i < Llamadas.Count; i++)
            {
                Llamadas.Sort(Llamada.OrdenarPorDuracion);
            }

        }


        public bool Guardar()
        {
            string ruta = "BitacoraCentralita.txt";
            try
            {

                string datos = DateTime.Now.ToString("HH_mm_ss") + " – Se realizó una llamada.\n";

                File.AppendAllText(ruta, datos); //Abre, agrega info y cierra el archivo, y si no existe lo crea
                return true;

            }
            catch (Exception)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
            
        }
        public string Leer()
        {
            string ruta = "BitacoraCentralita.txt";
            try
            {
                string datos = string.Empty;
                if (File.Exists(ruta))
                {
                    datos = File.ReadAllText(ruta);
                }

                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }

        }
    }
}
