using MySql.Data.MySqlClient;
using proyecto.Model;
using System.Data;

namespace proyecto.Controller
{
    public class AdminController : ConnectionToMySQL
    {
        /// <summary>
        /// inicio de sesion, crear administrador, actualizar administrador, mostrar usuarios y eliminar usuarios
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>

        // GET: Admin
        public bool Login(string nombre, string contrasena)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from administrador where (nombre=@nombre and contrasena=@contrasena)";
                    command.Parameters.AddWithValue("@nombre", nombre);
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
        
        public bool CrearAdministrador(Administrador admin)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into administrador (NOMBRE, CONTRASENA, TIPO_USUARIO ) VALUES (@NOMBRE, @CONTRASENA, @TIPO_USUARIO)";
                    command.Parameters.AddWithValue("@NOMBRE", admin.nombre);
                    command.Parameters.AddWithValue("@CONTRASENA", admin.contrasena);
                    command.Parameters.AddWithValue("@TIPO_USUARIO", admin.tipoUsuario);
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
        public DataTable ReadUserAdmin()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = "Select * from administrador WHERE id_administrador NOT IN ('1')";
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

        public bool UpdateAdmin(Administrador admin)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE administrador set nombre=@nombre, contrasena=@contrasena WHERE id_administrador=" + admin.id_Administrador;
                    command.Parameters.AddWithValue("@nombre", admin.nombre);
                    command.Parameters.AddWithValue("@contrasena", admin.contrasena);
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


        public bool DeleteUsuarioAdministrador(int id)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "delete from administrador where id_administrador= " + id + ";";
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