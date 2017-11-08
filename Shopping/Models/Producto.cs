using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class Producto
    {
        public string cod_producto { get; set; }
        public string nombre { get; set; }
        public double precio_compra { get; set; }
        public double precio_venta { get; set; }
        public int stock { get; set; }
        public string descripcion { get; set; }
        public string id_marca { get; set; }
        public string id_cat { get; set; }

        public byte[] foto1 { get; set; }
        public byte[] foto2 { get; set; }
        public byte[] foto3 { get; set; }
    
}
}