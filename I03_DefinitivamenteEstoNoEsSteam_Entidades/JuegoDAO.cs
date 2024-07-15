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
        private static string CODIGO_JUEGO = "CODIGO_JUEGO";
        private static string USERNAME = "USERNAME";

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
            List<Biblioteca> bibliotecas = new List<Biblioteca>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT {NOMBRE}, {GENERO}, {CODIGO_JUEGO}, {USERNAME} FROM dbo.JUEGOS JOIN dbo.USUARIOS ON dbo.JUEGOS.{CODIGO_USUARIO} = dbo.USUARIOS.{CODIGO_USUARIO}";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Biblioteca biblioteca = new Biblioteca(Convert.ToInt32(reader[CODIGO_JUEGO]), reader[GENERO].ToString(), reader[NOMBRE].ToString(), reader[USERNAME].ToString());
                        bibliotecas.Add(biblioteca);
                    }
                }
                return bibliotecas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la base de datos [JuegoDAO]", ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM dbo.JUEGOS WHERE {CODIGO_JUEGO} = {codigoJuego}";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    reader.Read();
                    Juego juego = new Juego(reader[NOMBRE].ToString(), Convert.ToDouble(reader[PRECIO]), reader[GENERO].ToString(), Convert.ToInt32(reader[CODIGO_JUEGO]), Convert.ToInt32(reader[CODIGO_USUARIO]));
                    return juego;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la base de datos [JuegoDAO]", ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"UPDATE dbo.JUEGOS SET {PRECIO} = @precio, {NOMBRE} = @nombre, {GENERO} = @genero WHERE {CODIGO_JUEGO} = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                if (comando.ExecuteNonQuery() <= 0)
                {
                    throw new Exception("No se pudo actualizar la base de datos [JuegoDAO].\nNo hubo filas afectadas.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.Close();
            }
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM dbo.JUEGOS WHERE {CODIGO_JUEGO} = {codigoJuego}";
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el juego [JuegoDAO]", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
