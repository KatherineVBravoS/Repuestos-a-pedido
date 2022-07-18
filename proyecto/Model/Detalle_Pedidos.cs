using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class Detalle_Pedidos
    {
        public string id_detalle { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public Pedido id_Pedido { get; set; }

    }
}