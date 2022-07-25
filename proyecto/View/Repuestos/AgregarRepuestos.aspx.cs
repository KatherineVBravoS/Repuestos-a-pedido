using System;
using System.IO;
using System.Web.UI;
using proyecto.Model;
using proyecto.Controller;
using System.Data;

namespace proyecto.Repuestos
{
    public partial class AgregarRepuestos : System.Web.UI.Page
    {
        public void BindData()
        {
           
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!this.IsPostBack)
            {
                ViewState["PreviousPage"] = Request.UrlReferrer;
                BindData();
            }
        }


        protected void Atras_Click(object sender, EventArgs e)
        {
            if (ViewState["PreviousPage"] != null)

            {
                Response.Redirect(ViewState["PreviousPage"].ToString());

            }
        }


        protected void btnAgregar_Repuesto_Click(object sender, EventArgs e)
        {
           
            
            if (!inputMarca.Text.Equals("") && !inputNombreRepuesto1.Equals("") && !inputN_Parte.Equals("") && !inputDescripcion.Equals("") && !inputModelo.Text.Equals("") && !inputPrecio.Text.Equals("") && !inputStock.Text.Equals(""))  
             {
                Stream sm = uploadImage.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(sm);
                Byte[] imagen = br.ReadBytes((Int32)sm.Length);
                Venta_repuesto repuesto = new Venta_repuesto();
                repuesto.Nombre_Repuesto = inputNombreRepuesto1.Text;
                repuesto.Marca = inputMarca.Text;
                repuesto.Modelo = inputModelo.Text;
                repuesto.N_Parte = inputN_Parte.Text;
                repuesto.Precio = inputPrecio.Text;
                repuesto.Stock = int.Parse(inputStock.Text);
                repuesto.Descripcion = inputDescripcion.Text;


                repuesto.Imagen = imagen;
                


                var respuesta = repuesto.CreateRepuesto(repuesto);
                if (respuesta == true)
                {
                    string alert = "alert('Repuesto agregado correctamente.');";
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
                inputModelo.Focus();
            }
            
        }


        public void limpiaCampos()
        {
            inputMarca.Text = "";
            inputModelo.Text = "";
            inputNombreRepuesto1.Text = "";
            inputPrecio.Text = "";
            inputStock.Text = "";
            inputDescripcion.Text = "";
        }

        protected void inputStock_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
    