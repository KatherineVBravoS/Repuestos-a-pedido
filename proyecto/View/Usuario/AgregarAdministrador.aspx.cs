using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Model;

namespace proyecto.View.Usuario
{
    public partial class AgregarAdministrador : System.Web.UI.Page
    {
        protected void btnAgregar_Administrador_Click(object sender, EventArgs e)
        {

            if (!inputNombreAdministrador.Text.Equals("") && !inputContrasena.Equals("") && !inputConfirmContrasena.Text.Equals(""))
            {
                    Model.Administrador admin = new Model.Administrador
                    {
                        nombre = inputNombreAdministrador.Text,
                        contrasena = inputContrasena.Text,
                        tipoUsuario = "A",
                    };

                    var respuesta = admin.CreateAdministrador(admin);
                    if (respuesta == true)
                    {
                        string alert = "alert('Usuario Administrador agregado correctamente.');";
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
                inputNombreAdministrador.Focus();
            }

        }


        public void limpiaCampos()
        {
            inputNombreAdministrador.Text = "";
            inputContrasena.Text = "";
            inputConfirmContrasena.Text = "";
        }
    }
}