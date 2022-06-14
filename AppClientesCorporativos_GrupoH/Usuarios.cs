using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Usuarios
    {
        public static List<Usuarios> UsuariosList = new List<Usuarios>();
        public int DNI { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string NombreEmpresa { get; set; }

        public string CUITEmpresa { get; set; }
    }
}
