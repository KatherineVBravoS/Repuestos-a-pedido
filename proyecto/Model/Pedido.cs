using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class Pedido
    {
        public string id_Pedido { get; set; }
        public string nombre { get; set; }
        public string estado { get; set; }
        public Cliente id_Cliente {get;set;}


    }
}