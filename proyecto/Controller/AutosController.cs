using MySql.Data.MySqlClient;
using proyecto.Model;
using System.Data;

namespace proyecto.Controller
{
    public class AutosController : ConnectionToMySQL
    {
        /// <summary>
        /// Clase para mostrar en el combobox los modelos de los modelos y marcas de vehiculos 
        /// </summary>
        /// <param name="autos"></param>
        /// <returns></returns>
        public bool CreateAutos(Autos autos)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into autos (MARCA, MODELO, ANIO) VALUES (@MARCA, @MODELO, @Anio)";
                    command.Parameters.AddWithValue("@MARCA", autos.Marca);
                    command.Parameters.AddWithValue("@MODELO", autos.Modelo);
                    command.Parameters.AddWithValue("@ANIO", autos.Anio);
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
        public DataTable ReadAutos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from autos";
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

        public bool UpdateAutos(Autos autos)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into marca (Marca) VALUES (@Marca)";
                    command.CommandText = "insert into modelo (Modelo) VALUES (@Modelo)";
                    command.CommandText = "insert into anio (Anio) VALUES (@Anio)";
                    command.Parameters.AddWithValue("@Marca", autos.Marca);
                    command.Parameters.AddWithValue("@Modelo", autos.Modelo);
                    command.Parameters.AddWithValue("@Anio", autos.Anio);
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

        public bool DeleteAutos(string marca)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from autos where marca= " + marca + ";";
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

        public DataTable ComboBoxMarcas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select distinct marca from autos";
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

        public DataTable ComboBoxModelos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select distinct modelo from autos";
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

        public DataTable ComboBoxAnios()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select distinct anio from autos order by anio desc";
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


    }
}