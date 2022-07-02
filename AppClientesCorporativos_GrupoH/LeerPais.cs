using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerPais
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Paises.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Pais pais = new Pais();
                pais.NroPais = int.Parse(datos[0], CultureInfo.InvariantCulture);
                pais.NombrePais = datos[1];
                pais.RegionPais = datos[2];

                Pais.PaisList.Add(pais);

            }

        }
    }
}
