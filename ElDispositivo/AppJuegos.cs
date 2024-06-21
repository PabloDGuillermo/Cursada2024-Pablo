using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public class AppJuegos:Aplicacion
    {
        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb;
            }
        }

        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio):base(nombre, sistemaOperativo, tamanio)
        {

        }
    }
}
