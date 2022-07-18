using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using proyecto.Model;
using System;

namespace proyecto.Controller
{
    public class CotizacionController : ConnectionToMySQL
    {
        public bool EnviarCotizacion(Cotizaciones cotizacion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into cotizaciones (nombre, telefono, correo, chasis, producto_cotizar) VALUES (@nombre, @telefono, @correo, @chasis ,@producto_cotizar)";
                    command.Parameters.AddWithValue("@nombre", cotizacion.nombre);
                    command.Parameters.AddWithValue("@telefono", cotizacion.telefono);
                    command.Parameters.AddWithValue("@correo", cotizacion.correo);
                    command.Parameters.AddWithValue("@chasis", cotizacion.chasis);
                    command.Parameters.AddWithValue("@producto_cotizar", cotizacion.productos_cotizar);
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
        public DataTable ReadCotizaciones()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from cotizaciones";
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

        public bool UpdateCotizacion(Cotizaciones cotizacion)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into cotizaciones (nombre, telefono, correo, chasis, producto_cotizar) VALUES (@nombre, @telefono, @correo, @chasis ,@producto_cotizar)";
                    command.Parameters.AddWithValue("@nombre", cotizacion.nombre);
                    command.Parameters.AddWithValue("@telefono", cotizacion.telefono);
                    command.Parameters.AddWithValue("@correo", cotizacion.correo);
                    command.Parameters.AddWithValue("@chasis", cotizacion.chasis);
                    command.Parameters.AddWithValue("@producto_cotizar", cotizacion.productos_cotizar);
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

        public bool DeleteCotizacion(string chasis)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from cotizaciones where chasis= " + chasis + ";";
                    command.CommandType = CommandType.Text;
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
