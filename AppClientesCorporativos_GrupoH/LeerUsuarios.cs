using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class LeerUsuarios
    {
        public static void Iniciar()
        {
            using StreamReader reader = new StreamReader("Usuarios.txt");

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();

                string[] datos = linea.Split(";");

                Usuarios usuario = new Usuarios();
                usuario.DNI = int.Parse(datos[0]);
                usuario.NombreUsuario = datos[1];
                usuario.ApellidoUsuario = datos[2];
                usuario.NombreEmpresa = datos[3];
                usuario.CUITEmpresa = datos[4];

                Usuarios.UsuariosList.Add(usuario);

            }

        }
    }
}
