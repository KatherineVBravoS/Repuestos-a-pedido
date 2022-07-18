using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class carrito_compras
    {
        public string id_Carrito { get; set; }
        public string cantidad { get; set; }
        public Cliente id_Cliente { get; set; }
        public Venta_repuesto venta_Repuesto { get; set; }

    }
}