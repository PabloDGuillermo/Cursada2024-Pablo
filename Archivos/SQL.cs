using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdc_Ejemplos
{
    public static class SQL<T>
    {
        static SqlConnection connection; // Puente.
        static SqlCommand command;      // Quien lleva la consulta.
        static SqlDataReader reader;   // Quien trae los datos.

        static SqlCommand GenerarConexion()
        {
            connection = new SqlConnection(@"Data Source = [Nombre del servidor];
                                Database = [Nombre de la base de datos];
                                Trusted_Connection = True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            return command;
        }

        static T RealizarConsulta()
        {
            T datos;
            try
            {
                command.CommandText = "SELECT * FROM tabla";
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //Logica
                }
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            //return datos;
        }

        static void EscribirDatos()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.Connection = connection;
            sqlCommand.CommandText = "INSERT INTO tabla VALUES (@Name, @LastName, @Age)";
            sqlCommand.Parameters.AddWithValue("@Name", "Juana");
            sqlCommand.Parameters.AddWithValue("@LastName", "Perez");
            sqlCommand.Parameters.AddWithValue("@Age", "19");
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
        }
    }
}
