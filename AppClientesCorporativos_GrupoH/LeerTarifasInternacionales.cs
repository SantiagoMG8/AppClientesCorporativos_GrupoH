using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerTarifasInternacionales
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("TarifasInternacionales.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                TarifasInternacionales tarifaInternacional = new TarifasInternacionales();
                tarifaInternacional.Nombre = datos[0];
                tarifaInternacional.RegionInternacional = datos[1];
                tarifaInternacional.RangoMayorA = decimal.Parse(datos[2], CultureInfo.InvariantCulture);
                tarifaInternacional.RangoMenorIgualA = decimal.Parse(datos[3], CultureInfo.InvariantCulture);
                tarifaInternacional.Precio = decimal.Parse(datos[4], CultureInfo.InvariantCulture);

                TarifasInternacionales.TarifasInternacionalesList.Add(tarifaInternacional);

            }

        }
    }
}
