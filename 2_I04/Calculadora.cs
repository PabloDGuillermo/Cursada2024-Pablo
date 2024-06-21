using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_I04
{
    public static class Calculadora
    {
        public static float Calcular(float x, float y, char operacion)
        {
            if(operacion == '+')
            {
                return x + y;
            }
            else if(operacion == '-')
            {
                return x - y;
            }
            else if(operacion == '*')
            {
                return x * y;
            }
            else if (operacion == '/')
            {
                if (Validar(y))
                {
                    return x / y;
                }
                return float.NaN;
            }

            return float.NaN;
        }

        private static bool Validar(float x)
        {
            return x != 0;
        }
    }
}
