using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class ValidarUusuarios
    {
        public static List<string> cuitSesionList = new List<string>();
        public static List<string> nombreEmpresaSesionList = new List<string>();

        internal static void Iniciar()
        {
            LeerUsuarios.Iniciar();



            bool coincide = false;

            while (true)
            {
                Console.WriteLine("Ingrese su número de DNI: ");
                string ingresoDNI = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ingresoDNI))
                {
                    Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número de DNI");
                    continue;
                }

                if (!int.TryParse(ingresoDNI, out int intDni))
                {
                    Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número de DNI.");
                    continue;
                }

                foreach (Usuarios usuario in Usuarios.UsuariosList)
                {

                    if (usuario.DNI == intDni)
                    {
                        Console.WriteLine("Bienvenido " + usuario.NombreUsuario + " " + usuario.ApellidoUsuario + " de  " + usuario.NombreEmpresa);
                        coincide = true;
                        cuitSesionList.Add(usuario.CUITEmpresa);
                        nombreEmpresaSesionList.Add(usuario.NombreEmpresa);

                    }

                }
                if (coincide == false)
                {
                    Console.WriteLine("El número de DNI ingresado no coincide a un usuario existente. Vuelva a intentarlo.");
                    continue;
                }
                if (coincide == true)
                {
                    Console.WriteLine("Accediendo al menú principal...");
                    Console.WriteLine("---------------------------------------------");
                    break;
                }

            }
        }
    }
}
