﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CentralitaVII_Entidades
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        protected float costoLlamada;

        public float Duracion {
            get
            {
                return duracion;
            }
            set
            {
                duracion = value;
            }
        }
        public string NroDestino {
            get
            {
                return nroDestino;
            }
            set
            {
                nroDestino = value;
            }
        }
        public string NroOrigen {
            get
            {
                return nroOrigen;
            }
            set
            {
                nroOrigen = value;
            }
        }

        public Llamada() { }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public abstract float CostoLlamada { get; set; }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Información de la llamada:");
            sb.AppendLine($"Duración: {Duracion}");
            sb.AppendLine($"Número de destino: {NroDestino}");
            sb.AppendLine($"Número de origen: {NroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)llamada1.Duracion - (int)llamada2.Duracion;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            //return l1.Equals(l2) && l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
            return l1.NroOrigen == l2.NroOrigen && l1.NroDestino == l2.NroDestino;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1==l2);
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
