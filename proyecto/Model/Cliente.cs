using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using proyecto.Controller;

namespace proyecto.Model
{
    public class Cliente
    {
        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string rut { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string repetir_correo { get; set; }
        public string contrasena { get; set; }
        public string repetir_contrasena { get; set; }



        ClienteController clienteController = new ClienteController();

        public bool LoginCliente(string nombre, string contrasena)
        {
            return clienteController.Login(nombre, contrasena);
        }

        public bool CreateCliente(Cliente clientes)
        {
            return clienteController.CrearCliente(clientes);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            return clienteController.UpdateCliente(cliente);
        }

        public bool ChangePassword(Cliente cliente)
        {
            return clienteController.UpdateContraseñaCliente(cliente);
        }


    }
}