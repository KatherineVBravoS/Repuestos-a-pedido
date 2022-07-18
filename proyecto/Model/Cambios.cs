using System;
using proyecto.Controller;
using proyecto.Model;

namespace proyecto.Model
{
    public class Cambio
    {
        public int N_Parte { get; set; }
        public string Nombre_Producto { get; set; }
        public string Cantidad { get; set; }
        public string Boleta_Factura { get; set; }
        public int Rut { get; set; }
        

       CambiosController controlCambios = new CambiosController();

        public bool EnviarCambios(Cambio cambios)
        {
            return controlCambios.EnviarCambios(cambios);
        }

    }
}
