using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class sesion
    {
        public string id_Sesion { get; set; }
        public string contrasena { get; set; }
        public DateTime fecha { get; set; }
        public string tipo { get; set; }
        public Administrador id_Administrador { get; set; }
        public Venta_repuesto id_Repuesto { get; set; }

    }
}