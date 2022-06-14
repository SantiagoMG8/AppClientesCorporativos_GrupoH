using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class Facturas
    {
        public static List<Facturas> FacturaList = new List<Facturas>();

        public string NroFactura { get; set; }

        public DateTime Fecha { get; set; }

        public string ClienteAsociado { get; set; }

        public string CUITAsociado { get; set; }

        public string Estado { get; set; }

        public string Concepto { get; set; }

        public decimal Importe { get; set; }


        public override string ToString()
        {
            return "NroFactura: " + NroFactura + "; Fecha: " + Fecha + "; Cliente: " + ClienteAsociado + "; CUIT:  " + CUITAsociado + "; Estado: " + Estado + "; Concepto: " + Concepto + "; Importe: " + Importe;
        }
    }
}
