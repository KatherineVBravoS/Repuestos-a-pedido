using System;
using System.Data;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
using proyecto.Model;

namespace proyecto.View.Cotizar
{
    public partial class AdministrarCotizaciones : System.Web.UI.Page
    {
        public void BindData()
        {
            CotizacionController con = new CotizacionController();
            DataTable dt = con.ReadCotizaciones();

            GridVerCotizacion.DataSource = dt;
            GridVerCotizacion.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
                ViewState["PreviousPage"] = Request.UrlReferrer;
            }
        }

        protected void GridVerCotizacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridVerCotizacion.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridVerCotizacion_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            CotizacionController cotizar = new CotizacionController();
            Label deleteID = (Label)GridVerCotizacion.Rows[e.RowIndex].FindControl("chasis");

            cotizar.DeleteCotizacion(deleteID.Text);
            BindData();
        }

        protected void GridVerCotizacion_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridVerCotizacion.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridVerCotizacion_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridVerCotizacion.EditIndex = -1;
            BindData();
        }

        protected void GridVerCotizacion_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Cotizaciones cotizacion = new Cotizaciones();
            CotizacionController controller = new CotizacionController();

            TextBox inputNombre = (TextBox)GridVerCotizacion.Rows[e.RowIndex].FindControl("inputNombre");
            TextBox inputTelefono = (TextBox)GridVerCotizacion.Rows[e.RowIndex].FindControl("inputTelefono");
            TextBox inputCorreo = (TextBox)GridVerCotizacion.Rows[e.RowIndex].FindControl("inputCorreo");
            TextBox inputChasis = (TextBox)GridVerCotizacion.Rows[e.RowIndex].FindControl("inputChasis");
            TextBox inputProductos = (TextBox)GridVerCotizacion.Rows[e.RowIndex].FindControl("inputProductos");

            cotizacion.nombre = inputNombre.Text;
            cotizacion.telefono = int.Parse(inputTelefono.Text);
            cotizacion.correo = inputCorreo.Text;
            cotizacion.chasis = inputChasis.Text;
            cotizacion.productos_cotizar = inputProductos.Text;

            var respuesta = controller.UpdateCotizacion(cotizacion);

            if (respuesta == true)
            {
                string alert = "alert('Cotizacion modificada correctamente.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }
            else
            {
                string alert = "alert('Algo falló.');";
                ScriptManager.RegisterStartupScript(this, GetType(), "JScript", alert, true);
            }

            GridVerCotizacion.EditIndex = -1;
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