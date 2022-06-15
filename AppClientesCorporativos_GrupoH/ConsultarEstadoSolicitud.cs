using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class ConsultarEstadoSolicitud
    {
        internal static void Iniciar()
        {
            LeerSolicitud.Iniciar();

            string ingresoNroSolicitud = "";
            string clienteSesion = ValidarUsuarios.nombreEmpresaSesionList[0];
            bool coincideNro = false;

            while (true)
            {
                Console.WriteLine("Ingrese el Nro. de Solicitud a consultar: ");
                ingresoNroSolicitud = Console.ReadLine();
                Console.WriteLine(System.Environment.NewLine);

                if (string.IsNullOrWhiteSpace(ingresoNroSolicitud))
                {
                    Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un Nro. de Solicitud.");
                    continue;
                }

                foreach (SolicitudServicio solicitud in SolicitudServicio.SolicitudList)
                {
                    if (solicitud.ClienteAsociado == clienteSesion) //Filtra a que el usuario solo pueda consultar solicitudes a su nombre
                    {

                        if (solicitud.NroSolicitud == ingresoNroSolicitud)
                        {


                            Console.WriteLine(solicitud);
                            Console.WriteLine("El estado de la solicitud Nro. " + solicitud.NroSolicitud + " es: " + solicitud.Estado);
                            coincideNro = true;


                        }
                    }


                }

                if (coincideNro == false)
                {
                    Console.WriteLine("El Nro. de Solicitud ingresado no pertenece a una solicitud existente a su nombre.");
                }

                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("Voliendo al menú principal...");
                Console.WriteLine("---------------------------------------------");
                SolicitudServicio.SolicitudList.Clear();
                break;

            }
        }
    }
}
