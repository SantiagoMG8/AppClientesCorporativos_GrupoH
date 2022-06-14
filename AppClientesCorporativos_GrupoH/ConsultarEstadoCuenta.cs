using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class ConsultarEstadoCuenta
    {
        internal static void Iniciar()
        {
            LeerFacturas.Iniciar();
            string cuit = ValidarUsuarios.cuitSesionList[0];
            decimal saldo = 0M;
            bool coincidecuit = false;
            Console.WriteLine("Listado completo de sus facturas: ");


            foreach (Facturas factura in Facturas.FacturaList)
            {
                if (factura.CUITAsociado == cuit)
                {
                    coincidecuit = true;
                    Console.WriteLine(factura);

                    if (factura.Estado == "PENDIENTE")
                    {
                        saldo = saldo + factura.Importe;
                    }

                }


            }

            if (coincidecuit == false)
            {
                Console.WriteLine("No existen facturas asociadas a su CUIT actualmente");
            }

            if (coincidecuit == true)
            {
                Console.WriteLine("Su saldo pendiente de pago es de: $" + saldo);
            }

            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Voliendo al menú principal...");
            Console.WriteLine("---------------------------------------------");
            Facturas.FacturaList.Clear();
        }
    }
}
