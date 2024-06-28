using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Entidades
{
    public static class PersonaDAO //Data Access Object DAO acceso de datos, operaciones de sql
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_TABLA = "Nombre";
        const string ID_TABLA = "ID";
        const string APELLIDO_TABLA = "Apellido"; 

        static PersonaDAO()
        {
            //connectionString = @"Data Source=DESKTOP-B7AI9GM\MSSQLSERVER2;Initial Catalog=Ejercicios_UTN;User ID=sa;Password=malena";
            connectionString = @"Data Source=.;Initial Catalog=Ejercicios_UTN;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text; // define el tipo de comando vas a usar, consultas = comando de tipo texto
            command.Connection = connection;
        }
        public static void Guardar(string nombre, string apellido)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Persona ({NOMBRE_TABLA}, {APELLIDO_TABLA}) VALUES ('{nombre}', '{apellido}')";
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la conexion a la base de datos. (Metodo Guardar)");
            }
            finally
            {
                connection.Close();
            }
        }
        public static PersonaDTO LeerPorID(int id)
        {
            PersonaDTO persona = null;
            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona WHERE ID = {id}"; //Esto es para generar una consulta
                using (SqlDataReader reader = command.ExecuteReader()) //Realiza la consulta SQL, y trae los registros
                {
                    while (reader.Read())//Estoy leyendo todos los registros que tengo
                    {
                        persona = new PersonaDTO(Convert.ToInt32(reader["ID"]),reader[NOMBRE_TABLA].ToString(), reader[APELLIDO_TABLA].ToString());
                    }
                }
                return persona;

            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la conexion a la base de datos. (Metodo Leer)");
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<PersonaDTO> Leer()
        {
            List<PersonaDTO> personas = new List<PersonaDTO>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona"; //Esto es para generar una consulta
                using (SqlDataReader reader = command.ExecuteReader()) //Realiza la consulta SQL, y trae los registros
                {
                    while (reader.Read())//Estoy leyendo todos los registros que tengo
                    {
                        PersonaDTO persona = new PersonaDTO(Convert.ToInt32(reader[ID_TABLA]), reader[NOMBRE_TABLA].ToString(), reader[APELLIDO_TABLA].ToString());
                        personas.Add(persona);
                    }
                }
                return personas;
            }
            catch
            {
                throw new Exception("Ocurrio un error en la conexion a la base de datos. (Metodo LeerBDDCompleta)");
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Borrar(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM Persona WHERE ID = {id}"; //Esto es para generar la consulta de borrar una fila
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la conexion a la base de datos. (Metodo Eliminar");
            }
            finally
            {
                connection.Close();
            }
        }
        public static void Modificar(int id, string nuevoNombre, string nuevoApellido)
        {
            try
            {
                connection.Open();
                command.CommandText = $"UPDATE Persona SET {NOMBRE_TABLA} = '{nuevoNombre}', {APELLIDO_TABLA} = '{nuevoApellido}' WHERE ID = {id}";
                int rows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error en la conexion a la base de datos. (Metodo Modificar");
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
