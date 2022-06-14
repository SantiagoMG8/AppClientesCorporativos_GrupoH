using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerTarifasAdicionales
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("TarifasAdicionales.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                TarifasAdicionales tarifaAdicional = new TarifasAdicionales();
                tarifaAdicional.Nombre = datos[0];
                tarifaAdicional.Precio = decimal.Parse(datos[1], CultureInfo.InvariantCulture);
                tarifaAdicional.Porcentaje = decimal.Parse(datos[2], CultureInfo.InvariantCulture);


                TarifasAdicionales.TarifasAdicionalesList.Add(tarifaAdicional);

            }

        }
    }
}
