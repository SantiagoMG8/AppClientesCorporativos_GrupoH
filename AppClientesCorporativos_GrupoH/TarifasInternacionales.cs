using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class TarifasInternacionales
    {
        public static List<TarifasInternacionales> TarifasInternacionalesList = new List<TarifasInternacionales>();

        public string Nombre { get; set; }

        public string RegionInternacional { get; set; }

        public decimal RangoMayorA { get; set; }
        public decimal RangoMenorIgualA { get; set; }

        public decimal Precio { get; set; }
    }
}
