using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Localidad
    {
        public static List<Localidad> LocalidadList = new List<Localidad>();

        public int NroLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public string ProvinciaLocalidad { get; set; }
    }
}
