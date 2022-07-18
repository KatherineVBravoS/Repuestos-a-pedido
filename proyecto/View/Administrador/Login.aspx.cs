using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto.View.Administrador
{
    public partial class Login : System.Web.UI.Page
    {


        protected void btnLogin_Administrador_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtLogin.Text.Length > 2)
            {
                if (txtPassword.Text != "")
                {
                    Model.Administrador admin = new Model.Administrador();
                    var ValidaLogin = admin.LoginAdmin(txtLogin.Text, txtPassword.Text);

                    if (ValidaLogin == true)
                    {
                        Session["AdminLogeado"] = txtLogin.Text;
                        Response.Redirect("Panel_Administrador.aspx");
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