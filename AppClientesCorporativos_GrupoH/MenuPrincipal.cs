using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class MenuPrincipal
    {
        public static void Mostrar()
        {
            do
            {
                Console.WriteLine("1. Generar Solicitud");
                Console.WriteLine("2. Consultar Estado de Solicitud");
                Console.WriteLine("3. Consultar Estado de Cuenta");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Ingrese su opcion:");
                string ingreso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ingreso))
                {
                    Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 4.");
                    continue;
                }


                if (!int.TryParse(ingreso, out int opcion))
                {
                    Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 4.");
                    continue;
                }

                if (opcion == 1)
                {
                    GenerarSolicitud.Iniciar();
                }
                else if (opcion == 2)
                {
                    ConsultarEstadoSolicitud.Iniciar();
                }
                else if (opcion == 3)
                {
                    ConsultarEstadoCuenta.Iniciar();
                }
                else if (opcion == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese un número entero del 1 a 4.");
                }
            }
            while (true);
        }
    }
}
