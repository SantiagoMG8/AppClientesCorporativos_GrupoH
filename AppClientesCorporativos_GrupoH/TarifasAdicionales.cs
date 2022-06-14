using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class TarifasAdicionales
    {
        public static List<TarifasAdicionales> TarifasAdicionalesList = new List<TarifasAdicionales>();

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
