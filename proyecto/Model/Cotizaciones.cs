using proyecto.Controller;
using proyecto.Model;

namespace proyecto.Model
{
    public class Cotizaciones
    {
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public string chasis { get; set; }
        public string patente { get; set; }
        public string productos_cotizar { get; set; }

        CotizacionController controlCotizacion = new CotizacionController();

        public bool EnviarCotizacion(Cotizaciones cotizacion)
        {
            return controlCotizacion.EnviarCotizacion(cotizacion);
        }
    }
}
