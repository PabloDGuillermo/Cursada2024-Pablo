using System.Text;

namespace EnciendanSusMotores
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(">Datos de la competencia<");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            if(competidores.Count == 0)
            {
                sb.AppendLine("Aún no hay competidores");
            }
            else
            {
                foreach (AutoF1 a in competidores)
                {
                    sb.AppendLine(a.MostrarDatos());
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 a2 in c.competidores)
            {
                if(a == a2)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 a2 in c.competidores)
            {
                if (a == a2)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();
            if(c.cantidadCompetidores >= c.competidores.Count && c != a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)random.Next(15, 100));
                return true;
            }
            return false;
        }



    }
}
