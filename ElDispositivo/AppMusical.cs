using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public class AppMusical:Aplicacion
    {
        private List<string> listaCanciones = new List<string>();

        protected override int Tamanio
        {
            get
            {
                foreach(string cancion in this.listaCanciones)
                {
                    this.tamanioMb += 2;
                }
                return this.tamanioMb;
            }
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial):base(nombre, sistemaOperativo, tamanioInicial)
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones):this(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ObtenerInformacionApp());
            sb.AppendLine($"Lista de canciones:");
            if(this.listaCanciones.Count > 0)
            {
                foreach (string cancion in this.listaCanciones)
                {
                    sb.AppendLine($"- {cancion}");
                }
            }
            else
            {
                sb.AppendLine("Aún no hay canciones cargadas.");
            }
            sb.AppendLine("------------------------------------------");

            return sb.ToString();
        }
    }
}
