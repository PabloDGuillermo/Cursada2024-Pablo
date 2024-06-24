using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaIV_Entidades
{
    public class CentralitaException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo {  get => nombreMetodo; }

        public CentralitaException(string mensaje, string clase, string metodo):base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException):base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
