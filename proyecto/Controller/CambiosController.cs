using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using proyecto.Model;
using System;

namespace proyecto.Controller
{
    public class CambiosController : ConnectionToMySQL
    {
        public bool EnviarCambios(Cambio cambios)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into cambio (N_PARTE, NOMBRE_PRODUCTO, CANTIDAD, BOLETA_FACTURA, RUT) VALUES (@N_PARTE, @NOMBRE_PRODUCTO, @CANTIDAD, @BOLETA_FACTURA ,@RUT)";
                    command.Parameters.AddWithValue("@N_PARTE", cambios.N_Parte);
                    command.Parameters.AddWithValue("@NOMBRE_PRODUCTO", cambios.Nombre_Producto);
                    command.Parameters.AddWithValue("@CANTIDAD", cambios.Cantidad);
                    command.Parameters.AddWithValue("@BOLETA_FACTURA", cambios.Boleta_Factura);
                    command.Parameters.AddWithValue("@RUT", cambios.Rut);
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

        public DataTable ReadCambios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from cambio";
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

        public bool UpdateCambios(Cambio cambios)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into cambio (N_PARTE, NOMBRE_PRODUCTO, CANTIDAD, BOLETA_FACTURA, RUT) VALUES (@N_PARTE, @NOMBRE_PRODUCTO, @CANTIDAD, @BOLETA_FACTURA ,@RUT)";
                    command.Parameters.AddWithValue("@N_PARTE", cambios.N_Parte);
                    command.Parameters.AddWithValue("@NOMBRE_PRODUCTO", cambios.Nombre_Producto);
                    command.Parameters.AddWithValue("@CANTIDAD", cambios.Cantidad);
                    command.Parameters.AddWithValue("@BOLETA_FACTURA", cambios.Boleta_Factura);
                    command.Parameters.AddWithValue("@RUT", cambios.Rut);
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

        public bool DeleteCambios(int rut)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from cambio where rut= " + rut + ";";
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