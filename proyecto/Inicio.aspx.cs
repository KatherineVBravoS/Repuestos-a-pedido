using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using proyecto.Controller;
namespace proyecto
{
    public partial class Default : System.Web.UI.Page
    {
       
        protected void BindData()
        {
                AutosController con = new AutosController();
                DlMarca.DataTextField = con.ComboBoxMarcas().Columns["Marca"].ToString(); // nombre del campo de la tabla que llenara el drop       
                DlMarca.DataValueField = con.ComboBoxMarcas().Columns["marca"].ToString(); //VAlor del dato 
                DlMarca.DataSource = con.ComboBoxMarcas();
                DlMarca.DataBind();
                DlMarca.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione", "0"));

                DlModelo.DataTextField = con.ComboBoxModelos().Columns["Modelo"].ToString(); // nombre del campo de la tabla que llenara el drop       
                DlModelo.DataValueField = con.ComboBoxModelos().Columns["modelo"].ToString(); //VAlor del dato 
                DlModelo.DataSource = con.ComboBoxModelos();
                DlModelo.DataBind();
                DlModelo.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione", "0"));

                DlAnio.DataTextField = con.ComboBoxAnios().Columns["Anio"].ToString(); // nombre del campo de la tabla que llenara el drop       
                DlAnio.DataValueField = con.ComboBoxAnios().Columns["anio"].ToString(); //VAlor del dato 
                DlAnio.DataSource = con.ComboBoxAnios();
                DlAnio.DataBind();
                DlAnio.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Seleccione", "0"));


            RepuestoController rep = new RepuestoController();
            DataTable dt = rep.ReadRepuestos();
            dtProductos.DataSource = dt;
            dtProductos.DataBind();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BindData();
                ViewState["PreviousPage"] = Request.UrlReferrer;
            }
        }

        

        protected void dtProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            
        }


    }
}