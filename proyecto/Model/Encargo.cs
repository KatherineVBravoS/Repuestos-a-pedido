using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class Encargo
    {
        public string id_Encargo_Producto { get; set; }
        public string nombre_Miembro { get; set; }
        public string nombre_Encargo { get; set; }
        public Administrador id_Administrador { get; set; }
        public Cliente id_Cliente { get; set; }

    }
}