using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class informacion_envio
    {
        public string id_Envio { get; set; }
        public string costo { get; set; }
        public string tipo { get; set; }
        public Pedido id_Pedido { get; set; }

    }
}