using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerSolicitud
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Solicitudes.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                SolicitudServicio solicitud = new SolicitudServicio();
                solicitud.NroSolicitud = datos[0];
                solicitud.Fecha = DateTime.Parse(datos[1], CultureInfo.InvariantCulture);
                solicitud.ClienteAsociado = datos[2];
                solicitud.Estado = datos[3];
                solicitud.TipoSolicitud = datos[4];
                solicitud.DireccionOrigen = datos[5];
                solicitud.LocalidadOrigen = datos[6];
                solicitud.ProvinciaOrigen = datos[7];
                solicitud.RegionOrigen = datos[8];
                solicitud.PaisOrigen = datos[9];
                solicitud.DireccionDestino = datos[10];
                solicitud.LocalidadDestino = datos[11];
                solicitud.ProvinciaDestino = datos[12];
                solicitud.RegionDestino = datos[13];
                solicitud.PaisDestino = datos[14];
                solicitud.Peso = decimal.Parse(datos[15], CultureInfo.InvariantCulture);
                solicitud.Urgente = datos[16];
                solicitud.Entrega = datos[17];
                solicitud.Retiro = datos[18];
                solicitud.Costo = decimal.Parse(datos[19], CultureInfo.InvariantCulture);


                SolicitudServicio.SolicitudList.Add(solicitud);

            }

        }
    }
}
