using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSpeedRacerGo
{
    public class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; } set { cilindrada = value;}
        }

        public MotoCross(short numero, string escuderia):base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada):base(numero, escuderia)
        {
            this.Cilindrada=cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {Cilindrada}");

            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return (VehiculoDeCarrera)m1 == (VehiculoDeCarrera)m2 && m1.Cilindrada == m2.Cilindrada;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
