using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class SolicitudServicio
    {
        public static List<SolicitudServicio> SolicitudList = new List<SolicitudServicio>();

        //ATRIBUTOS
        public string NroSolicitud { get; set; }
        public DateTime Fecha { get; set; }
        public string ClienteAsociado { get; set; }
        public string Estado { get; set; }
        public string TipoSolicitud { get; set; }

        //ATRIBUTOS DE ORIGEN
        public string DireccionOrigen { get; set; }
        public string LocalidadOrigen { get; set; }
        public string ProvinciaOrigen { get; set; }
        public string RegionOrigen { get; set; }
        public string PaisOrigen { get; set; }
        //ATRIBUTOS DE DESTINO
        public string DireccionDestino { get; set; }
        public string LocalidadDestino { get; set; }
        public string ProvinciaDestino { get; set; }
        public string RegionDestino { get; set; }
        public string PaisDestino { get; set; }
        public decimal Peso { get; set; }
        public string Urgente { get; set; }
        public string Entrega { get; set; }
        public string Retiro { get; set; }
        public decimal Costo { get; set; }

        public override string ToString()
        {
            return "NroSolicitud: " + NroSolicitud + "; Fecha: " + Fecha + "; Cliente: " + ClienteAsociado + "; Estado: " + Estado + "; TipoSolicitud: " + TipoSolicitud + "; DirecciónOrigen: " + DireccionOrigen + "; LocalidadOrigen: " + LocalidadOrigen
                + "; ProvinciaOrigen: " + ProvinciaOrigen + "; RegiónOrigen: " + RegionOrigen + "; PaísOrigen: " + PaisOrigen + "; DirecciónDestino: " + DireccionDestino + "; LocalidadDestino: " + LocalidadDestino
                + "; ProvinciaDestino: " + ProvinciaDestino + "; RegiónDestino: " + RegionDestino + "; PaísDestino: " + PaisDestino + "; Peso(Kg): " + Peso + "; Urgente: " + Urgente + "; Entrega: " + Entrega
                + "; Retiro: " + Retiro + "; Costo: " + Costo;
        }
    }
}
