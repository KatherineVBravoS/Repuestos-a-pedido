using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
using proyecto.Model;
namespace proyecto.Repuestos
{
    public partial class VerUsuarios : System.Web.UI.Page
    {
        public void BindData()
        {
            AdminController con = new AdminController();
            DataTable dt = con.ReadUserAdmin();

            GridUsuariosAdministrador.DataSource = dt;
            GridUsuariosAdministrador.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
            }
        }
        protected void GridUsuariosAdministrador_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridUsuariosAdministrador.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridUsuariosAdministrador_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //Falta confirmar la eliminación.
            AdminController repuesto = new AdminController();
            Label deleteID = (Label)GridUsuariosAdministrador.Rows[e.RowIndex].FindControl("Id_administrador");

            repuesto.DeleteUsuarioAdministrador(int.Parse(deleteID.Text));
            BindData();
        }

        protected void GridUsuariosAdministrador_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridUsuariosAdministrador.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridUsuariosAdministrador_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridUsuariosAdministrador.EditIndex = -1;
            BindData();
        }

        protected void GridUsuariosAdministrador_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Administrador admin = new Administrador();
            AdminController controller = new AdminController();

            Label id_administrador = (Label)GridUsuariosAdministrador.Rows[e.RowIndex].FindControl("Id_administrador");
            TextBox nombreAdmin = (TextBox)GridUsuariosAdministrador.Rows[e.RowIndex].FindControl("inputNombreAdministrador");
            TextBox contrasena = (TextBox)GridUsuariosAdministrador.Rows[e.RowIndex].FindControl("inputContraAdministrador");
          

            admin.id_Administrador = int.Parse(id_administrador.Text);
            admin.nombre= nombreAdmin.Text;
            admin.contrasena = contrasena.Text;
           

            var respuesta = controller.UpdateAdmin(admin);

            if (respuesta == true)
            {
                string alert = "alert('Repuesto modificado correctamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }
            else
            {
                string alert = "alert('Algo falló.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }

            GridUsuariosAdministrador.EditIndex = -1;
            BindData();
        }
    }
}