using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using proyecto.Model;
using System;


namespace proyecto.Controller
{
    public class ClienteController : ConnectionToMySQL
    {
        /// <summary>
        /// Clase para la creacion de clientes
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        // GET: User
        public bool Login(string correo, string contrasena)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from clientes where (correo=@correo and contrasena=@contrasena)";
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.CommandType = System.Data.CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool CrearCliente(Cliente cliente)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "INSERT INTO clientes (nombre, apellido, direccion, ciudad, rut, telefono, correo, repetir_correo, contrasena, repetir_contrasena ) VALUES (@nombre, @apellido, @direccion, @ciudad, @rut, @telefono, @correo, @repetir_correo, @contrasena, @repetir_contrasena)";
                    command.Parameters.AddWithValue("@nombre", cliente.nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.apellido);
                    command.Parameters.AddWithValue("@direccion", cliente.direccion);
                    command.Parameters.AddWithValue("@ciudad", cliente.ciudad);
                    command.Parameters.AddWithValue("@rut", cliente.rut);
                    command.Parameters.AddWithValue("@telefono", cliente.telefono);
                    command.Parameters.AddWithValue("@correo", cliente.correo);
                    command.Parameters.AddWithValue("@repetir_correo", cliente.repetir_correo);
                    command.Parameters.AddWithValue("@contrasena", cliente.contrasena);
                    command.Parameters.AddWithValue("@repetir_contrasena", cliente.repetir_contrasena);
                    command.CommandType = System.Data.CommandType.Text;
                    var respuesta = command.ExecuteNonQuery();
                    if (respuesta != 0)
                    {
                        return true;

                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }

        public DataTable ReadCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT * from clientes";
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        MySqlCommand mysql = new MySqlCommand(query, connection);
                        sda.SelectCommand = mysql;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        public bool UpdateCliente(Cliente cliente)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO clientes (nombre, apellido, direccion, ciudad, rut, telefono, correo, repetir_correo, contrasena, repetir_contrasena ) VALUES (@nombre, @apellido, @direccion, @ciudad, @rut, @telefono, @correo, @repetir_correo, @contrasena, @repetir_contrasena)";
                    command.Parameters.AddWithValue("@nombre", cliente.nombre);
                    command.Parameters.AddWithValue("@apellido", cliente.apellido);
                    command.Parameters.AddWithValue("@direccion", cliente.direccion);
                    command.Parameters.AddWithValue("@ciudad", cliente.ciudad);
                    command.Parameters.AddWithValue("@rut", cliente.rut);
                    command.Parameters.AddWithValue("@telefono", cliente.telefono);
                    command.Parameters.AddWithValue("@correo", cliente.correo);
                    command.Parameters.AddWithValue("@repetir_correo", cliente.repetir_correo);
                    command.Parameters.AddWithValue("@contrasena", cliente.contrasena);
                    command.Parameters.AddWithValue("@repetir_contrasena", cliente.repetir_contrasena);
                    command.CommandType = System.Data.CommandType.Text;
                    var respuesta = command.ExecuteNonQuery();
                    if (respuesta != 0)
                    {
                        return true;

                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }

        public bool UpdateContraseñaCliente(Cliente cliente)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE clientes set contrasena=@contrasena WHERE correo=" + cliente.correo;
                    command.Parameters.AddWithValue("@contrasena", cliente.contrasena);
                    command.CommandType = CommandType.Text;
                    var respuesta = command.ExecuteNonQuery();

                    if (respuesta != 0)
                    {
                        return true;

                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }

        public bool DeleteClienter(int correo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from clientes where correo= " + correo + ";";
                    command.CommandType = CommandType.Text;
                    var respuesta = command.ExecuteNonQuery();
                    if (respuesta != 0)
                    {
                        return true;

                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }
    }
}

