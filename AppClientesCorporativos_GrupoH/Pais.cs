using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Pais
    {
        public static List<Pais> PaisList = new List<Pais>();

        public int NroPais { get; set; }
        public string NombrePais { get; set; }
        public string RegionPais { get; set; }
    }
}
