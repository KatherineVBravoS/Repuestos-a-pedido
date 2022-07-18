using System;
using System.IO;
using System.Web.UI;
using proyecto.Model;
using proyecto.Controller;
using System.Data;

namespace proyecto.View.Usuario
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void btnRegistroUser_Click(object sender, EventArgs e)
        {
            if (!inputNombre4.Text.Equals("") && !inputApellido4.Text.Equals("") && !inputDireccion.Text.Equals("") && !inputCiudad.Text.Equals("") && !inputRut.Text.Equals("") && !inputTelefono4.Text.Equals("") && !inputCorreo.Text.Equals("") && !inputConfirmarCorreo.Text.Equals("") && !inputContrasenaCliente.Text.Equals("") && !inputConfirmarContrasenaCliente.Text.Equals(""))
            {
                Cliente cliente = new Cliente();
                cliente.nombre = inputNombre4.Text;
                cliente.apellido = inputApellido4.Text;
                cliente.direccion = inputDireccion.Text;
                cliente.ciudad = inputCiudad.Text;
                cliente.rut = inputRut.Text;
                cliente.telefono = inputTelefono4.Text;
                cliente.correo = inputCorreo.Text;
                cliente.repetir_correo = inputConfirmarCorreo.Text;
                cliente.contrasena = inputContrasenaCliente.Text;
                cliente.repetir_contrasena = inputConfirmarContrasenaCliente.Text;
               

                var respuesta = cliente.CreateCliente(cliente);
                if (respuesta == true)
                {
                    string alert = "alert('Cliente agregado correctamente.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
                    limpiaCampos();
                }
                else
                {
                    string alert = "alert('Algo falló.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
                }

            }
            else
            {
                string alert = "alert('Debe tener texto.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
                inputRut.Focus();
            }
        }

        public void limpiaCampos()
        {
            inputRut.Text = "";
            inputNombre4.Text = "";
            inputApellido4.Text = "";
            inputDireccion.Text = "";
            inputCiudad.Text = "";
            inputTelefono4.Text = "";
            inputCorreo.Text = "";
            inputConfirmarCorreo.Text = "";
            inputContrasenaCliente.Text = "";
            inputConfirmarContrasenaCliente.Text = "";
        }
    }
}