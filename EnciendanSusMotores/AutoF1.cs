using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            cantidadCombustible = 0;
            enCompetencia = false;
            vueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia) : this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(">Datos del auto<");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Número: {numero}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"En competencia: {enCompetencia}");
            if (enCompetencia)
            {
                sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
            }

            return sb.ToString();
        }

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }
        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }
        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }
    }
}
