using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoSpeedRacerGo
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombustible;
            }

            set
            {
                cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }

            set
            {
                enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return escuderia;
            }

            set
            {
                escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }

            set
            {
                vueltasRestantes = value;
            }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(">Datos del auto<");
            sb.AppendLine($"Escuderia: {Escuderia}");
            sb.AppendLine($"Número: {Numero}");
            sb.AppendLine($"Cantidad de combustible: {CantidadCombustible}");
            sb.AppendLine($"En competencia: {EnCompetencia}");
            if (EnCompetencia)
            {
                sb.AppendLine($"Vueltas restantes: {VueltasRestantes}");
            }

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return v1.numero == v2.numero && v1.escuderia == v2.escuderia;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
