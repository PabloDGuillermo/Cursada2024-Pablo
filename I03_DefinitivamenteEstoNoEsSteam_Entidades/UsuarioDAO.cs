using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I03_DefinitivamenteEstoNoEsSteam_Entidades
{
    public static class UsuarioDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static string CODIGO_USUARIO = "CODIGO_USUARIO";
        private static string USERNAME = "USERNAME";

        static UsuarioDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text; // define el tipo de comando vas a usar, consultas = comando de tipo texto
            comando.Connection = conexion;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT {CODIGO_USUARIO}, {USERNAME} FROM dbo.USUARIOS";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario(reader[USERNAME].ToString(), Convert.ToInt32(reader[CODIGO_USUARIO]));
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la base de datos [UsuariosDAO]", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
