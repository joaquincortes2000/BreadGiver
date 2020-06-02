using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadGiver.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

    }
}
