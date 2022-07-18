using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
using proyecto.Model;

namespace proyecto.View.Repuestos
{
    public partial class RepuestosCliente : System.Web.UI.Page
    {
        public void BindData()
        {
            RepuestoController con = new RepuestoController();
            DataTable dt = con.ReadRepuestosCliente();

            GridRepuestosClientes.DataSource = dt;
            GridRepuestosClientes.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
                ViewState["PreviousPage"] = Request.UrlReferrer;
            }
        }

        protected void GridRepuestosClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridRepuestosClientes.PageIndex = e.NewPageIndex;
            BindData();
        }

        protected void GridRepuestosClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            RepuestoController repuesto = new RepuestoController();
            Label deleteID = (Label)GridRepuestosClientes.Rows[e.RowIndex].FindControl("Id_repuesto");

            repuesto.DeleteRepuesto(int.Parse(deleteID.Text));
            BindData();
        }

        protected void GridRepuestosClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridRepuestosClientes.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridRepuestosClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridRepuestosClientes.EditIndex = -1;
            BindData();
        }

        protected void GridRepuestosClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Venta_repuesto repuesto = new Venta_repuesto();
            RepuestoController controller = new RepuestoController();

            Label id_repuesto = (Label)GridRepuestosClientes.Rows[e.RowIndex].FindControl("Id_repuesto");
            TextBox nombre = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputNombre");
            TextBox marca = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputMarca");
            TextBox modelo = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputModelo");
            TextBox n_parte = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputNumeroParte");
            TextBox precio = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputPrecio");
            TextBox stock = (TextBox)GridRepuestosClientes.Rows[e.RowIndex].FindControl("inputStock");
            FileUpload imagenNueva = (FileUpload)GridRepuestosClientes.Rows[e.RowIndex].FindControl("ImagenUpdate");
            Stream sm = imagenNueva.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(sm);
            Byte[] imagen = br.ReadBytes((Int32)sm.Length);

            repuesto.id_repuesto = int.Parse(id_repuesto.Text);
            repuesto.Nombre_Repuesto = nombre.Text;
            repuesto.Marca = marca.Text;
            repuesto.Modelo = modelo.Text;
            repuesto.N_Parte = int.Parse(n_parte.Text);
            repuesto.Precio = precio.Text;
            repuesto.Stock = int.Parse(stock.Text);
            repuesto.Imagen = imagen;

            var respuesta = controller.UpdateRepuesto(repuesto);

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

            GridRepuestosClientes.EditIndex = -1;
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