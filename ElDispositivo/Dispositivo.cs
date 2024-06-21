using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElDispositivo
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo == sistemaOperativo)
            {
                return appsInstaladas + app;
            }
            return false;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($">Información del dispositivo<");
            sb.AppendLine($"Sistema operativo: {sistemaOperativo.ToString()}");
            sb.AppendLine("-----------------------------------------");
            sb.AppendLine($"Aplicaciones instaladas: \n");
            if(appsInstaladas.Count > 0)
            {
                foreach (Aplicacion app in appsInstaladas)
                {
                    sb.AppendLine($"- {app.ObtenerInformacionApp()}");
                }
            }
            else
            {
                sb.AppendLine($"Aún no hay aplicaciones instaladas");
            }
            sb.AppendLine("-------------------------------------");

            return sb.ToString();
        }
    }
}
