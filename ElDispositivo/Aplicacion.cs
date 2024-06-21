using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace ElDispositivo
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        protected virtual int Tamanio
        {
            get
            {
                return this.tamanioMb;
            }
        }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(">Información de la aplicación<");
            sb.AppendLine($"Nombre: {this.ToString()}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo.ToString()}");
            sb.AppendLine($"Tamaño (Mb): {this.Tamanio}");
            sb.AppendLine("--------------------------------------------");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int max = int.MinValue;
            Aplicacion retornoAplicacion = null;

            foreach(Aplicacion ap in listaApp)
            {
                if(ap.Tamanio > max)
                {
                    retornoAplicacion = ap;
                }
            }

            return retornoAplicacion;
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion app2 in listaApp)
            {
                if(app.ToString() == app2.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }

    public enum SistemaOperativo
    {
        ANDROID,
        IOS
    }
}
