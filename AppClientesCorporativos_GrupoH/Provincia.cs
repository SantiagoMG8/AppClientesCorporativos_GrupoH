using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Provincia
    {
        public static List<Provincia> ProvinciaList = new List<Provincia>();

        public int NroProvincia { get; set; }
        public string NombreProvincia { get; set; }
        public string RegionProvincia { get; set; }
        public string PaisProvincia { get; set; }
    }
}
