using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Tarifas
    {
        public static List<Tarifas> TarifasList = new List<Tarifas>();

        public string Nombre { get; set; }

        public string TipoTarifa { get; set; }

        public decimal RangoMayorA { get; set; }
        public decimal RangoMenorIgualA { get; set; }

        public decimal Precio { get; set; }
    }
}
