using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerLocalidad
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Localidades.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Localidad localidad = new Localidad();
                localidad.NroLocalidad = int.Parse(datos[0], CultureInfo.InvariantCulture);
                localidad.NombreLocalidad = datos[1];
                localidad.ProvinciaLocalidad = datos[2];

                Localidad.LocalidadList.Add(localidad);

            }

        }
    }
}
