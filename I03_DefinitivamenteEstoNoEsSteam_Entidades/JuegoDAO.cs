using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I03_DefinitivamenteEstoNoEsSteam_Entidades
{
    public static class JuegoDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static string CODIGO_USUARIO = "CODIGO_USUARIO";
        private static string GENERO = "GENERO";
        private static string NOMBRE = "NOMBRE";
        private static string PRECIO = "PRECIO";

        static JuegoDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text; // define el tipo de comando vas a usar, consultas = comando de tipo texto
            comando.Connection = conexion;
        }

        public static void Guardar(Juego juego)
        {
        //    private int codigoUsuario;
        //private string genero;
        //private string nombre;
        //private double precio;
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO dbo.JUEGOS ({CODIGO_USUARIO},{GENERO},{NOMBRE},{PRECIO}) VALUES ('{juego.CodigoUsuario}','{juego.Genero}','{juego.Nombre}','{juego.Precio}')";
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el juego [JuegoDAO]", ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Biblioteca> Leer()
        {
            return new List<Biblioteca>();
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            return null;
        }

        public static void Modificar(Juego juego)
        {

        }

        public static void Eliminar(int codigoJuego)
        {

        }
    }
}
