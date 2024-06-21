using System.Runtime.CompilerServices;
using System.Text;

namespace GoSpeedRacerGo
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public VehiculoDeCarrera this[int i]
        {
            get { return this[i]; }
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(">Datos de la competencia<");
            sb.AppendLine($"Tipo de competencia: {Tipo}");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            if(competidores.Count == 0)
            {
                sb.AppendLine("Aún no hay competidores");
            }
            else
            {
                foreach (VehiculoDeCarrera v in competidores)
                {
                    if(this.tipo == TipoCompetencia.F1)
                    {
                        sb.AppendLine(v.MostrarDatos());
                    }
                    else if (this.tipo == TipoCompetencia.MotoCross)
                    {
                        sb.AppendLine(v.MostrarDatos());
                    }
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            foreach (VehiculoDeCarrera v2 in c.competidores)
            {
                if (v is AutoF1 a)
                {
                    if (a == v2)
                    {
                        return true;
                    }
                }
                else if (v is MotoCross m)
                {
                    if (m == v2)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            foreach (VehiculoDeCarrera v2 in c.competidores)
            {
                if (v is AutoF1 a)
                {
                    if (a == v2)
                    {
                        return false;
                    }
                }
                else if (v is MotoCross m)
                {
                    if (m == v2)
                    {
                        return false;
                    }
                }
                //else if (c.tipo == TipoCompetencia.MotoCross)
                //{
                //    if (v == v2)
                //    {
                //        return false;
                //    }
                //}
            }
            return true;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            Random random = new Random();
            if(c.tipo == TipoCompetencia.MotoCross)
            {
                if (c.cantidadCompetidores >= c.competidores.Count && c != v)
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    v.CantidadCombustible = (short)random.Next(15, 100);
                    return true;
                }
            }
            else if(c.tipo == TipoCompetencia.F1)
            {
                if (c.cantidadCompetidores >= c.competidores.Count && c != v)
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = c.cantidadVueltas;
                    v.CantidadCombustible = (short)random.Next(15, 100);
                    return true;
                }
            }
            
            return false;
        }

        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }


    }
}
