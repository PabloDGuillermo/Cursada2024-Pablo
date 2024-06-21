using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        public static double DiferenciaEnSegundos(this DateTime dateTime, DateTime fechaInicio, DateTime fechaFin)
        {
            return (fechaFin - fechaInicio).TotalSeconds;
        }
    }
}
