using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
using proyecto.Model;

namespace proyecto.View.Cambios
{
    public partial class ListaCambios : System.Web.UI.Page
    {

        public void BindData()
        {
            CambiosController con = new CambiosController();
            DataTable dt = con.ReadCambios();

            GridCambios.DataSource = dt;
            GridCambios.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
                ViewState["PreviousPage"] = Request.UrlReferrer;
            }
        }

        protected void GridCambios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCambios.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridCambios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RepuestoController repuesto = new RepuestoController();
            Label deleteID = (Label)GridCambios.Rows[e.RowIndex].FindControl("Rut");

            repuesto.DeleteRepuesto(int.Parse(deleteID.Text));
            BindData();
        }

        protected void GridCambios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridCambios.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridCambios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridCambios.EditIndex = -1;
            BindData();
        }

        protected void GridCambios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Cambio cambio = new Cambio();
            CambiosController controller = new CambiosController();

            TextBox n_parte = (TextBox)GridCambios.Rows[e.RowIndex].FindControl("inputNParte");
            TextBox producto = (TextBox)GridCambios.Rows[e.RowIndex].FindControl("inputProducto");
            TextBox cantidad = (TextBox)GridCambios.Rows[e.RowIndex].FindControl("inputCantidad");
            TextBox boleta = (TextBox)GridCambios.Rows[e.RowIndex].FindControl("inputBoleta");
            TextBox rut = (TextBox)GridCambios.Rows[e.RowIndex].FindControl("inputRut");
            
            cambio.N_Parte = int.Parse(n_parte.Text);
            cambio.Nombre_Producto = producto.Text;
            cambio.Cantidad = cantidad.Text;
            cambio.Boleta_Factura = boleta.Text; 
            cambio.Rut = int.Parse(rut.Text);
           
            var respuesta = controller.UpdateCambios(cambio);

            if (respuesta == true)
            {
                string alert = "alert('cambio modificado correctamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }
            else
            {
                string alert = "alert('Algo falló.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }

            GridCambios.EditIndex = -1;
            BindData();
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