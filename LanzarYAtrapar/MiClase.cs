using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanzarYAtrapar
{
    public class MiClase
    {
        public MiClase(Exception e)
        {

        }
        public MiClase()
        {
            try
            {
                LanzarExcepcion();
            }
            catch (DivideByZeroException e)
            {
                MiClase clase = new MiClase(e);
            }
        }
        static void LanzarExcepcion()
        {
            throw new DivideByZeroException();
        }

    }
}
