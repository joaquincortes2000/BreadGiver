using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadGiver.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string NumeroUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public string RutUsuario { get; set; }
        public Rol RolUsuario { get; set; }
        public CarroCompra CarroUsuario { get; set; }


    }
}
