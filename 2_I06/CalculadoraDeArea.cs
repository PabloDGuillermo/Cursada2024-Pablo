using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_I06
{
    public static class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            if(longitudLado > 0 && longitudLado is not double.NaN)
            {
                return longitudLado * longitudLado;
            }
            return double.NaN;
        }

        public static double CalcularAreaTriangulo(double bace, double altura)
        {
            if (bace > 0 && altura > 0 && bace is not double.NaN && altura is not double.NaN)
            {
                return (bace * altura) / 2;
            }

            return double.NaN;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            if (radio > 0 && radio is not double.NaN)
            {
                return Math.PI * Math.Pow(radio, 2);
            }

            return double.NaN;
        }
    }
}
