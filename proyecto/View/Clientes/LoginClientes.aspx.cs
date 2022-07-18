using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto.View.Clientes
{
    public partial class LoginClientes : System.Web.UI.Page
    {
        protected void btnLogin_Clientes_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtLogin.Text.Length > 2)
            {
                if (txtPassword.Text != "")
                {
                    Model.Cliente cliente = new Model.Cliente();
                    var ValidaLogin = cliente.LoginCliente(txtLogin.Text, txtPassword.Text);

                    if (ValidaLogin == true)
                    {
                        Session["ClienteLogeado"] = txtLogin.Text;
                        Response.Redirect("/View/Clientes/InicioCliente.aspx");
                    }
                    else
                    {
                        string message = "Usuario o Contraseña erroneos, intente nuevamente.";
                        txtLogin.Text = "";
                        txtPassword.Text = "";
                        txtError.Text = message;
                        txtError.Visible = true;

                    }
                }
            }
        }
    }
}