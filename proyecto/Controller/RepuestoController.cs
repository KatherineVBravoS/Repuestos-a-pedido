using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using proyecto.Model;
using System;

namespace proyecto.Controller
{
    public class RepuestoController : ConnectionToMySQL
    {
        /// <summary>
        /// Clase para la creacion, eliminacion, actualizacion y modificacion de los repuestos a vender
        /// </summary>
        /// <param name="repuesto"></param>
        /// <returns></returns>
        // GET: Repuesto
        // Agregar: Repuesto

        public bool CreateRepuesto(Venta_repuesto repuesto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into repuestos (NOMBRE_REPUESTO, MARCA, MODELO, N_PARTE ,PRECIO, STOCK, DESCRIPCION, IMAGEN) VALUES (@NOMBRE_REPUESTO, @MARCA, @MODELO, @N_PARTE ,@PRECIO,@STOCK, @DESCRIPCION ,@IMAGEN)";
                    command.Parameters.AddWithValue("@NOMBRE_REPUESTO", repuesto.Nombre_Repuesto);
                    command.Parameters.AddWithValue("@MARCA", repuesto.Marca);
                    command.Parameters.AddWithValue("@MODELO", repuesto.Modelo);
                    command.Parameters.AddWithValue("@N_PARTE", repuesto.N_Parte);
                    command.Parameters.AddWithValue("@DESCRIPCION", repuesto.Descripcion);
                    command.Parameters.AddWithValue("@PRECIO", repuesto.Precio);
                    command.Parameters.AddWithValue("@STOCK", repuesto.Stock);
                    command.Parameters.AddWithValue("@IMAGEN", repuesto.Imagen);
                    command.CommandType = System.Data.CommandType.Text;
                    var respuesta = command.ExecuteNonQuery();
                    if (respuesta != 0)
                    {
                        return true;

                    } else {

                        return false;
                    }
                }
            }
        }

        public DataTable RepuestosCompra()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "SELECT repuestos.id_repuestos, repuestos.NOMBRE_REPUESTO ,repuestos.MARCA, repuestos.MODELO, repuestos.N_PARTE ,repuestos.IMAGEN,repuestos.STOCK,repuestos.DESCRIPCION,repuestos.PRECIO FROM repuestos";
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


        public DataTable ReadRepuestos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from repuestos";
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

        public DataTable ReadRepuestosCliente()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from repuestos";
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

        public bool UpdateRepuesto(Venta_repuesto repuesto)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE repuestos set NOMBRE_REPUESTO=@NOMBRE_REPUESTO, MARCA=@MARCA, MODELO=@MODELO, N_PARTE=@N_PARTE ,PRECIO=@PRECIO, STOCK=@STOCK , DESCRIPCION=@DESCRIPCION ,IMAGEN=@IMAGEN WHERE id_repuestos=" + repuesto.id_repuesto;
                    command.Parameters.AddWithValue("@NOMBRE_REPUESTO", repuesto.Nombre_Repuesto);
                    command.Parameters.AddWithValue("@MARCA", repuesto.Marca);
                    command.Parameters.AddWithValue("@MODELO", repuesto.Modelo);
                    command.Parameters.AddWithValue("@N_PARTE", repuesto.N_Parte);
                    command.Parameters.AddWithValue("@PRECIO", repuesto.Precio);
                    command.Parameters.AddWithValue("@STOCK", repuesto.Stock);
                    command.Parameters.AddWithValue("@DESCRIPCION", repuesto.Descripcion);
                    command.Parameters.AddWithValue("@IMAGEN", repuesto.Imagen);
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


        public bool DeleteRepuesto(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from repuestos where id_repuestos= " + id + ";";
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
