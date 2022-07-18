using proyecto.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Model
{
    public class Administrador
    {
        public int id_Administrador { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public string tipoUsuario { get; set; }

        AdminController adminController = new AdminController();

        public bool LoginAdmin(string nombre, string contrasena)
        {
            return adminController.Login(nombre, contrasena);
        }

        public bool CreateAdministrador(Administrador admin)
        {
            return adminController.CrearAdministrador(admin);
        }
    }

}