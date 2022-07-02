using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerTarifas
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Tarifas.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Tarifas tarifa = new Tarifas();
                tarifa.Nombre = datos[0];
                tarifa.TipoTarifa = datos[1];
                tarifa.RangoMayorA = decimal.Parse(datos[2], CultureInfo.InvariantCulture);
                tarifa.RangoMenorIgualA = decimal.Parse(datos[3], CultureInfo.InvariantCulture);
                tarifa.Precio = decimal.Parse(datos[4], CultureInfo.InvariantCulture);

                Tarifas.TarifasList.Add(tarifa);

            }

        }
    }
}
