using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AppClientesCorporativos_GrupoH
{
    internal class GrabarSolicitud
    {
        internal static void Iniciar()
        {
            using StreamWriter writer = new StreamWriter("Solicitudes.txt", true);

            foreach (SolicitudServicio solicitud in SolicitudServicio.SolicitudList)
            {
                

                string linea = solicitud.NroSolicitud + ";" +
                    solicitud.Fecha.ToString(CultureInfo.InvariantCulture) + ";" +
                    solicitud.ClienteAsociado + ";" +
                    solicitud.Estado + ";" +
                    solicitud.TipoSolicitud + ";" +
                    solicitud.DireccionOrigen + ";" +
                    solicitud.LocalidadOrigen + ";" +
                    solicitud.ProvinciaOrigen + ";" +
                    solicitud.RegionOrigen + ";" +
                    solicitud.PaisOrigen + ";" +
                    solicitud.DireccionDestino + ";" +
                    solicitud.LocalidadDestino + ";" +
                    solicitud.ProvinciaDestino + ";" +
                    solicitud.RegionDestino + ";" +
                    solicitud.PaisDestino + ";" +
                    solicitud.Peso.ToString(CultureInfo.InvariantCulture) + ";" +
                    solicitud.Urgente + ";" +
                    solicitud.Entrega + ";" +
                    solicitud.Retiro + ";" +
                    solicitud.Costo.ToString(CultureInfo.InvariantCulture);

                writer.WriteLine(linea);
            }
            writer.Close();
        }
    }
}
