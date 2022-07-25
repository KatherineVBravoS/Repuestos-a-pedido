using proyecto.Controller;


namespace proyecto.Model
{
    public class Venta_repuesto
    {
        public int id_repuesto { get; set; }
        public string Nombre_Repuesto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string N_Parte { get; set; }
        public string Precio { get; set; }
        public int Stock { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }




        RepuestoController controlRepuesto = new RepuestoController();

        public bool CreateRepuesto(Venta_repuesto repuesto)
        {
            return controlRepuesto.CreateRepuesto(repuesto);
        }

        public bool UpdateRepuesto(Venta_repuesto repuesto)
        {
            return controlRepuesto.UpdateRepuesto(repuesto);
        }
    }
}