using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadGiver.Models
{
    public class Cotizacion
    {
        public int IdCotizacion { get; set; }
        public string ValorTotal { get; set; }
        public string IVA { get; set; }
        public string CantidadTotal { get; set; }
        public Usuario UsuarioCotizacion { get; set; }
    }
}
