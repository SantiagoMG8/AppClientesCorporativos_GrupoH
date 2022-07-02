using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerProvincia
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Provincias.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Provincia provincia = new Provincia();
                provincia.NroProvincia = int.Parse(datos[0], CultureInfo.InvariantCulture);
                provincia.NombreProvincia = datos[1];
                provincia.RegionProvincia = datos[2];
                provincia.PaisProvincia = datos[3];

                Provincia.ProvinciaList.Add(provincia);

            }

        }
    }
}
