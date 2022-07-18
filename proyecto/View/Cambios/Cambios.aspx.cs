using System;
using System.IO;
using System.Web.UI;
using proyecto.Model;
using System.Net.Mail;
using System.Net;


namespace proyecto.Cambios
{
    public partial class AdministrarCambios : System.Web.UI.Page
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

        protected void btnEnviar_Cambio_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("thiiryn@gmail.com", "kathy");
            var toAddress = new MailAddress("thiiryn21@hotmail.cl", "kathy");
            const string fromPassword = "rmkrcrwudjtkbqcc";
            const string subject = "Prueba C#";
            string body = "Se ha solicitado un cambio para: " + Environment.NewLine +
                           "numero de parte: " + int.Parse(inputNumeroParte.Text) + Environment.NewLine +
                           "Producto: " + inputProducto.Text + Environment.NewLine +
                           "Cantidad: " + inputCantidad.Text + Environment.NewLine +
                           "Boleta o factura: " + inputBoleta.Text + Environment.NewLine +
                           "Rut cliente: " + int.Parse(inputRut.Text);


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            if (!inputNumeroParte.Text.Equals("") && !inputProducto.Equals("") && !inputCantidad.Text.Equals("") && !inputBoleta.Text.Equals("") && !inputRut.Text.Equals(""))
            {
                Cambio cambios = new Cambio();
                cambios.N_Parte = int.Parse(inputNumeroParte.Text);
                cambios.Nombre_Producto = inputProducto.Text;
                cambios.Cantidad = inputCantidad.Text;
                cambios.Boleta_Factura = inputBoleta.Text;
                cambios.Rut = int.Parse(inputRut.Text);



                var respuesta = cambios.EnviarCambios(cambios);
                if (respuesta == true)
                {
                    string alert = "alert('Solicitud enviada correctamente.');";
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
                inputProducto.Focus();
            }

        }


        public void limpiaCampos()
        {
            inputNumeroParte.Text = "";
            inputProducto.Text = "";
            inputCantidad.Text = "";
            inputBoleta.Text = "";
            inputRut.Text = "";
        }

    }
}
