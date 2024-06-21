using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoSpeedRacerGo
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get
            {
                return caballosDeFuerza;
            }
            set
            {
                caballosDeFuerza = value;
            }
        }

        private AutoF1(short numero, string escuderia):base(numero, escuderia)
        {
            
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballosDeFuerza;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {CaballosDeFuerza}");

            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 && a1.CaballosDeFuerza == a2.CaballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }

        public void hola()
        {

        }
    }
}
