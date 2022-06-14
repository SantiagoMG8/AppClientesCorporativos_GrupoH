using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerFacturas
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Facturas.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Facturas factura = new Facturas();
                factura.NroFactura = datos[0];
                factura.Fecha = DateTime.Parse(datos[1], CultureInfo.InvariantCulture);
                factura.ClienteAsociado = datos[2];
                factura.CUITAsociado = datos[3];
                factura.Estado = datos[4];
                factura.Concepto = datos[5];
                factura.Importe = decimal.Parse(datos[6], CultureInfo.InvariantCulture);

                Facturas.FacturaList.Add(factura);

            }

        }
    }
}
