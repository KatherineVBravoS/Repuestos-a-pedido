using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto.View.Clientes
{
    public partial class InicioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void cierraSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("ClienteLogeado");
            Response.Redirect("Login.aspx");
        }
    }
    
}