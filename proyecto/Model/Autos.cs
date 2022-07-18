using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using proyecto.Controller;

namespace proyecto.Model
{
    public class Autos 
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }


        AutosController controlAutos = new AutosController();

        public bool CreateAutos(Autos autos)
        {
            return controlAutos.CreateAutos(autos);
        }

        public bool UpdateAutos(Autos autos)
        {
            return controlAutos.CreateAutos(autos);
        }
    }
}