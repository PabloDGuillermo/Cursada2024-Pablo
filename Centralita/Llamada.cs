﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion {
            get
            {
                return duracion;
            }
        }
        public string NroDestino {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen {
            get {
                return nroOrigen;
            } 
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
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

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
