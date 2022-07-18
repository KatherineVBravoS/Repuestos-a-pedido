using System;
using System.IO;
using System.Web.UI;
using proyecto.Model;
using System.Net.Mail;
using System.Net;

namespace proyecto.Vistas.Cotizar
{
    public partial class Cotizar : System.Web.UI.Page
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

        protected void Cotiza_Click(object sender, EventArgs e)
        {

            var fromAddress = new MailAddress("thiiryn@gmail.com", "kathy");
            var toAddress = new MailAddress("thiiryn21@hotmail.cl", "kathy");
            const string fromPassword = "rmkrcrwudjtkbqcc";
            const string subject = "Prueba C#";
            string body = "Se ha solicitado una cotizacion para: " + Environment.NewLine +
                           "Nombre: " + inputNombre.Text + Environment.NewLine +
                           "Telefono: " + inputTelefono.Text + Environment.NewLine +
                           "Correo: " + inputCorreo.Text + Environment.NewLine +
                           "Chasis: " + inputChasis.Text + Environment.NewLine +
                           "Producto a cotizar: " + inputProductos.Text;
            

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



            if (!inputNombre.Text.Equals("") && !inputTelefono.Equals("") && !inputCorreo.Text.Equals("") && !inputChasis.Text.Equals("") && !inputProductos.Text.Equals(""))
            {
               
                Cotizaciones cotizacion = new Cotizaciones();
                cotizacion.nombre = inputNombre.Text;
                cotizacion.telefono = int.Parse(inputTelefono.Text);
                cotizacion.correo = inputCorreo.Text;
                cotizacion.chasis = inputChasis.Text;
                cotizacion.productos_cotizar = inputProductos.Text;

                var respuesta = cotizacion.EnviarCotizacion(cotizacion);
                if (respuesta == true)
                {
                    string alert = "alert('Cotizacion enviada correctamente.');";
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
                inputChasis.Focus();
            }

            


        }


        public void limpiaCampos()
        {
            inputNombre.Text = "";
            inputTelefono.Text = "";
            inputCorreo.Text = "";
            inputChasis.Text = "";
            inputProductos.Text = "";
        }

    }
}
