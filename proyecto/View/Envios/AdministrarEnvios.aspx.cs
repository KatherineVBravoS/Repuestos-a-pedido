using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto.Envios
{
    public partial class AdministrarEnvios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Atras_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)

            {
                Response.Redirect(ViewState["PreviousPage"].ToString());

            }
        }
    }
}