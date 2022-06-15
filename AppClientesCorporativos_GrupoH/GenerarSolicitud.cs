using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClientesCorporativos_GrupoH
{
    internal class GenerarSolicitud
    {
        internal static void Iniciar()
        {
            while (true)
            {


                //Genera Nro de Solicitud
                int random = new Random().Next(50000000, 99999999);
                string nrosolicitud = "SO" + random;

                //Establece fecha de creación de solicitud
                DateTime fecha = DateTime.Now;

                //Establece el cliente que hace la solicitud
                string cliente = ValidarUsuarios.nombreEmpresaSesionList[0];


                string estado = "INICIADA"; //EL ESTADO SERA ACTUALIZADO POR UNA APLICACION LOGISTICA EXTERNA A ESTA APLICACION

                //LOOP INGRESO DE TIPO SOLICITUD (CORRESPONDENCIA/ENCOMIENDA)
                string tipoSolicitud = "";

                while (true)
                {
                    Console.WriteLine("Indique si quiere solicitar el servicio de correspondencia o encomienda: ");
                    Console.WriteLine("1 - Correspondencia");
                    Console.WriteLine("2 - Encomienda");
                    string ingresotipoSolicitud = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresotipoSolicitud))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }
                    if (!int.TryParse(ingresotipoSolicitud, out int intTipoSolicitud))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }
                    if (intTipoSolicitud == 1)
                    {
                        tipoSolicitud = "CORRESPONDENCIA";

                    }
                    else if (intTipoSolicitud == 2)
                    {
                        tipoSolicitud = "ENCOMIENDA";

                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 2.");
                        continue;

                    }

                    break;
                }

                //Los Servicios siempre se realizan desde Argentina
                string paisOrigen = "ARGENTINA";

                //LOOPS INGRESO DATOS DE ORIGEN
                string direccionOrigen = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la dirección de origen (Calle, número y código postal): ");
                    direccionOrigen = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(direccionOrigen))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una dirección de origen.");
                        continue;
                    }
                    break;
                }

                string localidadOrigen = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la localidad de origen de la dirección: "); ;
                    localidadOrigen = Console.ReadLine().ToUpper();
                    if (string.IsNullOrWhiteSpace(localidadOrigen))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una localidad de origen");
                        continue;
                    }
                    break;
                }

                string provinciaOrigen = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la provincia de origen de la dirección: ");
                    Console.WriteLine("1 - BUENOS AIRES");
                    Console.WriteLine("2 - CABA");
                    Console.WriteLine("3 - CATAMARCA");
                    Console.WriteLine("4 - CHACO");
                    Console.WriteLine("5 - CHUBUT");
                    Console.WriteLine("6 - CORDOBA");
                    Console.WriteLine("7 - CORRIENTES");
                    Console.WriteLine("8 - ENTRE RIOS");
                    Console.WriteLine("9 - FORMOSA");
                    Console.WriteLine("10 - JUJUY");
                    Console.WriteLine("11 - LA PAMPA");
                    Console.WriteLine("12 - LA RIOJA");
                    Console.WriteLine("13 - MENDOZA");
                    Console.WriteLine("14 - MISIONES");
                    Console.WriteLine("15 - NEUQUEN");
                    Console.WriteLine("16 - RIO NEGRO");
                    Console.WriteLine("17 - SALTA");
                    Console.WriteLine("18 - SAN JUAN");
                    Console.WriteLine("19 - LA RIOJA");
                    Console.WriteLine("20 - SAN LUIS");
                    Console.WriteLine("21 - SANTA FE");
                    Console.WriteLine("22 - SANTIAGO DEL ESTERO");
                    Console.WriteLine("23 - TIERRA DEL FUEGO");
                    Console.WriteLine("24 - TUCUMAN");
                    string ingresoprovinciaOrigen = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresoprovinciaOrigen))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 24.");
                        continue;
                    }
                    if (!int.TryParse(ingresoprovinciaOrigen, out int intprovinciaOrigen))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 24.");
                        continue;
                    }
                    if (intprovinciaOrigen == 1)
                    {
                        provinciaOrigen = "BUENOS AIRES";
                    }
                    else if (intprovinciaOrigen == 2)
                    {
                        provinciaOrigen = "CABA";
                    }
                    else if (intprovinciaOrigen == 3)
                    {
                        provinciaOrigen = "CATAMARCA";
                    }
                    else if (intprovinciaOrigen == 4)
                    {
                        provinciaOrigen = "CHACO";
                    }
                    else if (intprovinciaOrigen == 5)
                    {
                        provinciaOrigen = "CHUBUT";
                    }
                    else if (intprovinciaOrigen == 6)
                    {
                        provinciaOrigen = "CORDOBA";
                    }
                    else if (intprovinciaOrigen == 7)
                    {
                        provinciaOrigen = "CORRIENTES";
                    }
                    else if (intprovinciaOrigen == 8)
                    {
                        provinciaOrigen = "ENTRE RIOS";
                    }
                    else if (intprovinciaOrigen == 9)
                    {
                        provinciaOrigen = "FORMOSA";
                    }
                    else if (intprovinciaOrigen == 10)
                    {
                        provinciaOrigen = "JUJUY";
                    }
                    else if (intprovinciaOrigen == 11)
                    {
                        provinciaOrigen = "LA PAMPA";
                    }
                    else if (intprovinciaOrigen == 12)
                    {
                        provinciaOrigen = "LA RIOJA";
                    }
                    else if (intprovinciaOrigen == 13)
                    {
                        provinciaOrigen = "MENDOZA";
                    }
                    else if (intprovinciaOrigen == 14)
                    {
                        provinciaOrigen = "MISIONES";
                    }
                    else if (intprovinciaOrigen == 15)
                    {
                        provinciaOrigen = "NEUQUEN";
                    }
                    else if (intprovinciaOrigen == 16)
                    {
                        provinciaOrigen = "RIO NEGRO";
                    }
                    else if (intprovinciaOrigen == 17)
                    {
                        provinciaOrigen = "SALTA";
                    }
                    else if (intprovinciaOrigen == 18)
                    {
                        provinciaOrigen = "SAN JUAN";
                    }
                    else if (intprovinciaOrigen == 19)
                    {
                        provinciaOrigen = "LA RIOJA";
                    }
                    else if (intprovinciaOrigen == 20)
                    {
                        provinciaOrigen = "SAN LUIS";
                    }
                    else if (intprovinciaOrigen == 21)
                    {
                        provinciaOrigen = "SANTA FE";
                    }
                    else if (intprovinciaOrigen == 22)
                    {
                        provinciaOrigen = "SANTIAGO DEL ESTERO";
                    }
                    else if (intprovinciaOrigen == 23)
                    {
                        provinciaOrigen = "TIERRA DEL FUEGO";
                    }
                    else if (intprovinciaOrigen == 24)
                    {
                        provinciaOrigen = "TUCUMAN";
                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 24.");
                        continue;
                    }

                    break;

                }



                //ESTABLECEMOS REGION SEGUN PROVINCIA
                string regionOrigen = "";
                if (provinciaOrigen == "BUENOS AIRES" || provinciaOrigen == "CABA")
                {
                    regionOrigen = "METROPOLITANA";
                }
                if (provinciaOrigen == "TIERRA DEL FUEGO" || provinciaOrigen == "SANTA CRUZ" || provinciaOrigen == "CHUBUT" || provinciaOrigen == "RIO NEGRO" || provinciaOrigen == "NEUQUEN")
                {
                    regionOrigen = "SUR";
                }
                if (provinciaOrigen == "LA PAMPA" || provinciaOrigen == "SAN LUIS" || provinciaOrigen == "MENDOZA" || provinciaOrigen == "CORDOBA" || provinciaOrigen == "SANTA FE")
                {
                    regionOrigen = "CENTRO";
                }
                if (provinciaOrigen == "ENTRE RIOS" || provinciaOrigen == "CORRIENTES" || provinciaOrigen == "MISIONES" || provinciaOrigen == "CHACO" || provinciaOrigen == "FORMOSA" || provinciaOrigen == "SANTIAGO DEL ESTERO" || provinciaOrigen == "TUCUMAN" || provinciaOrigen == "SALTA" || provinciaOrigen == "JUJUY" || provinciaOrigen == "CATAMARCA" || provinciaOrigen == "LA RIOJA" || provinciaOrigen == "SAN JUAN")
                {
                    regionOrigen = "NORTE";
                }


                //LOOPS INGRESO DATOS DE DESTINO
                string paisDestino = "";
                while (true)
                {
                    Console.WriteLine("Ingrese el pais de destino de la dirección: ");
                    Console.WriteLine("1 - ARGENTINA");
                    Console.WriteLine("2 - BRASIL");
                    Console.WriteLine("3 - URUGUAY");
                    Console.WriteLine("4 - BOLIVIA");
                    Console.WriteLine("5 - CHILE");
                    Console.WriteLine("6 - PARAGUAY");
                    Console.WriteLine("7 - COLOMBIA");
                    Console.WriteLine("8 - PERU");
                    Console.WriteLine("9 - ECUADOR");
                    Console.WriteLine("10 - VENEZUELA");
                    Console.WriteLine("11 - GUYANA");
                    Console.WriteLine("12 - SURINAM");
                    Console.WriteLine("13 - TRINIDAD Y TOBAGO");
                    Console.WriteLine("14 - GUAYANA FRANCESA");
                    string ingresopaisDestino = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresopaisDestino))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 14.");
                        continue;
                    }
                    if (!int.TryParse(ingresopaisDestino, out int intpaisDestino))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 14.");
                        continue;
                    }
                    if (intpaisDestino == 1)
                    {
                        paisDestino = "ARGENTINA";
                    }
                    else if (intpaisDestino == 2)
                    {
                        paisDestino = "BRASIL";
                    }
                    else if (intpaisDestino == 3)
                    {
                        paisDestino = "URUGUAY";
                    }
                    else if (intpaisDestino == 4)
                    {
                        paisDestino = "BOLIVIA";
                    }
                    else if (intpaisDestino == 5)
                    {
                        paisDestino = "CHILE";
                    }
                    else if (intpaisDestino == 6)
                    {
                        paisDestino = "PARAGUAY";
                    }
                    else if (intpaisDestino == 7)
                    {
                        paisDestino = "COLOMBIA";
                    }
                    else if (intpaisDestino == 8)
                    {
                        paisDestino = "PERU";
                    }
                    else if (intpaisDestino == 9)
                    {
                        paisDestino = "ECUADOR";
                    }
                    else if (intpaisDestino == 10)
                    {
                        paisDestino = "VENEZUELA";
                    }
                    else if (intpaisDestino == 11)
                    {
                        paisDestino = "GUYANA";
                    }
                    else if (intpaisDestino == 12)
                    {
                        paisDestino = "SURINAM";
                    }
                    else if (intpaisDestino == 13)
                    {
                        paisDestino = "TRINIDAD Y TOBAGO";
                    }
                    else if (intpaisDestino == 14)
                    {
                        paisDestino = "GUAYANA FRANCESA";
                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 14.");
                        continue;
                    }

                    break;
                }

                string direccionDestino = "";
                while (true)
                {
                    Console.WriteLine("Ingrese dirección de destino (Calle, número y código postal): ");
                    direccionDestino = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(direccionDestino))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una dirección de destino");
                        continue;
                    }
                    break;
                }

                string localidadDestino = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la localidad de destino de la dirección: "); ;
                    localidadDestino = Console.ReadLine().ToUpper();
                    if (string.IsNullOrWhiteSpace(localidadDestino))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una localidad de destino.");
                        continue;
                    }
                    break;
                }

                string provinciaDestino = "";
                while (true)
                {
                    if (paisDestino == "ARGENTINA")
                    {
                        Console.WriteLine("Ingrese la provincia de destino de la dirección: ");
                        Console.WriteLine("1 - BUENOS AIRES");
                        Console.WriteLine("2 - CABA");
                        Console.WriteLine("3 - CATAMARCA");
                        Console.WriteLine("4 - CHACO");
                        Console.WriteLine("5 - CHUBUT");
                        Console.WriteLine("6 - CORDOBA");
                        Console.WriteLine("7 - CORRIENTES");
                        Console.WriteLine("8 - ENTRE RIOS");
                        Console.WriteLine("9 - FORMOSA");
                        Console.WriteLine("10 - JUJUY");
                        Console.WriteLine("11 - LA PAMPA");
                        Console.WriteLine("12 - LA RIOJA");
                        Console.WriteLine("13 - MENDOZA");
                        Console.WriteLine("14 - MISIONES");
                        Console.WriteLine("15 - NEUQUEN");
                        Console.WriteLine("16 - RIO NEGRO");
                        Console.WriteLine("17 - SALTA");
                        Console.WriteLine("18 - SAN JUAN");
                        Console.WriteLine("19 - LA RIOJA");
                        Console.WriteLine("20 - SAN LUIS");
                        Console.WriteLine("21 - SANTA FE");
                        Console.WriteLine("22 - SANTIAGO DEL ESTERO");
                        Console.WriteLine("23 - TIERRA DEL FUEGO");
                        Console.WriteLine("24 - TUCUMAN");
                        string ingresoprovinciaDestino = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ingresoprovinciaDestino))
                        {
                            Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 24.");
                            continue;
                        }
                        if (!int.TryParse(ingresoprovinciaDestino, out int intprovinciaDestino))
                        {
                            Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 24.");
                            continue;
                        }
                        if (intprovinciaDestino == 1)
                        {
                            provinciaDestino = "BUENOS AIRES";
                        }
                        else if (intprovinciaDestino == 2)
                        {
                            provinciaDestino = "CABA";
                        }
                        else if (intprovinciaDestino == 3)
                        {
                            provinciaDestino = "CATAMARCA";
                        }
                        else if (intprovinciaDestino == 4)
                        {
                            provinciaDestino = "CHACO";
                        }
                        else if (intprovinciaDestino == 5)
                        {
                            provinciaDestino = "CHUBUT";
                        }
                        else if (intprovinciaDestino == 6)
                        {
                            provinciaDestino = "CORDOBA";
                        }
                        else if (intprovinciaDestino == 7)
                        {
                            provinciaDestino = "CORRIENTES";
                        }
                        else if (intprovinciaDestino == 8)
                        {
                            provinciaDestino = "ENTRE RIOS";
                        }
                        else if (intprovinciaDestino == 9)
                        {
                            provinciaDestino = "FORMOSA";
                        }
                        else if (intprovinciaDestino == 10)
                        {
                            provinciaDestino = "JUJUY";
                        }
                        else if (intprovinciaDestino == 11)
                        {
                            provinciaDestino = "LA PAMPA";
                        }
                        else if (intprovinciaDestino == 12)
                        {
                            provinciaDestino = "LA RIOJA";
                        }
                        else if (intprovinciaDestino == 13)
                        {
                            provinciaDestino = "MENDOZA";
                        }
                        else if (intprovinciaDestino == 14)
                        {
                            provinciaDestino = "MISIONES";
                        }
                        else if (intprovinciaDestino == 15)
                        {
                            provinciaDestino = "NEUQUEN";
                        }
                        else if (intprovinciaDestino == 16)
                        {
                            provinciaDestino = "RIO NEGRO";
                        }
                        else if (intprovinciaDestino == 17)
                        {
                            provinciaDestino = "SALTA";
                        }
                        else if (intprovinciaDestino == 18)
                        {
                            provinciaDestino = "SAN JUAN";
                        }
                        else if (intprovinciaDestino == 19)
                        {
                            provinciaDestino = "LA RIOJA";
                        }
                        else if (intprovinciaDestino == 20)
                        {
                            provinciaDestino = "SAN LUIS";
                        }
                        else if (intprovinciaDestino == 21)
                        {
                            provinciaDestino = "SANTA FE";
                        }
                        else if (intprovinciaDestino == 22)
                        {
                            provinciaDestino = "SANTIAGO DEL ESTERO";
                        }
                        else if (intprovinciaDestino == 23)
                        {
                            provinciaDestino = "TIERRA DEL FUEGO";
                        }
                        else if (intprovinciaDestino == 24)
                        {
                            provinciaDestino = "TUCUMAN";
                        }
                        else
                        {
                            Console.WriteLine("Usted debe ingresar un número entero del 1 al 24.");
                            continue;
                        }

                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine("Ingrese la provincia de destino de la dirección: ");
                        provinciaDestino = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(provinciaDestino))
                        {
                            Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una provincia de destino.");
                            continue;
                        }
                        break;
                    }
                }

                string regionDestino = "";
                //SI EL PAÍS DE DESTINO ES ARGENTINA, ESTABLECEMOS REGION SEGUN PROVINCIA
                if (paisDestino == "ARGENTINA")
                {
                    if (provinciaDestino == "BUENOS AIRES" || provinciaDestino == "CABA")
                    {
                        regionDestino = "METROPOLITANA";
                    }
                    if (provinciaDestino == "TIERRA DEL FUEGO" || provinciaDestino == "SANTA CRUZ" || provinciaDestino == "CHUBUT" || provinciaDestino == "RIO NEGRO" || provinciaDestino == "NEUQUEN")
                    {
                        regionDestino = "SUR";
                    }
                    if (provinciaDestino == "LA PAMPA" || provinciaDestino == "SAN LUIS" || provinciaDestino == "MENDOZA" || provinciaDestino == "CORDOBA" || provinciaDestino == "SANTA FE")
                    {
                        regionDestino = "CENTRO";
                    }
                    if (provinciaDestino == "ENTRE RIOS" || provinciaDestino == "CORRIENTES" || provinciaDestino == "MISIONES" || provinciaDestino == "CHACO" || provinciaDestino == "FORMOSA" || provinciaDestino == "SANTIAGO DEL ESTERO" || provinciaDestino == "TUCUMAN" || provinciaDestino == "SALTA" || provinciaDestino == "JUJUY" || provinciaDestino == "CATAMARCA" || provinciaDestino == "LA RIOJA" || provinciaDestino == "SAN JUAN")
                    {
                        regionDestino = "NORTE";
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Ingrese la región de destino de la dirección: "); ;
                        regionDestino = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(regionDestino))
                        {
                            Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una región de destino.");
                            continue;
                        }
                        break;
                    }
                }


                //VALIDADOR PESO
                decimal peso = 0M;
                while (true)
                {
                    Console.WriteLine("Ingrese el peso de la solicitud en kilogramos: ");
                    string ingresoPeso = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresoPeso))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar el peso de la solicitud.");
                        continue;
                    }
                    if (!decimal.TryParse(ingresoPeso, out decimal dcmPeso))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un valor decimal para el peso.");
                        continue;
                    }
                    if (dcmPeso <= 0M)
                    {
                        Console.WriteLine("El peso debe ser mayor a 0.");
                        continue;
                    }

                    if (tipoSolicitud == "CORRESPONDENCIA")
                    {
                        if (dcmPeso > 0.5M)
                        {
                            Console.WriteLine("El peso máximo permitido para CORRESPONDENCIA es hasta 0.5 kg.");
                            continue;
                        }
                        else
                        {
                            peso = dcmPeso;
                        }


                    }
                    if (tipoSolicitud == "ENCOMIENDA")
                    {
                        if (dcmPeso <= 0.5M)
                        {
                            Console.WriteLine("El peso minimo permitido para ENCOMIENDA es mayor a 0.5 kg.");
                            continue;
                        }
                        else if (dcmPeso > 30M)
                        {
                            Console.WriteLine("El peso máximo permitido para ENCOMIENDA es hasta 30kg.");
                            continue;
                        }
                        else
                        {
                            peso = dcmPeso;
                        }
                    }


                    break;
                }

                //VALIDADOR INGRESO URGENTE
                string urgente = "";
                while (true)
                {
                    string ingresoUrgente;
                    Console.WriteLine("Indique si quiere el servicio urgente o el servicio no urgente:");
                    Console.WriteLine("1 - Urgente");
                    Console.WriteLine("2 - No Urgente");
                    ingresoUrgente = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresoUrgente))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (!int.TryParse(ingresoUrgente, out int intUrgente))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (intUrgente == 1)
                    {
                        urgente = "SI";

                    }
                    else if (intUrgente == 2)
                    {
                        urgente = "NO";
                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }

                    break;
                }

                //VALIDADOR INGRESO ENTREGA
                string entrega = "";
                while (true)
                {
                    Console.WriteLine("Indique si la entrega sera por Puerta o por Sucursal");
                    Console.WriteLine("1 - Puerta");
                    Console.WriteLine("2 - Sucursal");
                    string ingresoEntrega = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresoEntrega))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (!int.TryParse(ingresoEntrega, out int intEntrega))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (intEntrega == 1)
                    {
                        entrega = "PUERTA";

                    }
                    else if (intEntrega == 2)
                    {
                        entrega = "SUCURSAL";
                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }

                    break;

                }

                //VALIDADOR INGRESO RETIRO
                string retiro = "";
                while (true)
                {
                    Console.WriteLine("Indique si el retiro sera por Puerta o por Sucursal:");
                    Console.WriteLine("1 - Puerta");
                    Console.WriteLine("2 - Sucursal");
                    string ingresoRetiro = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresoRetiro))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (!int.TryParse(ingresoRetiro, out int intRetiro))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe indicar un número entero del 1 al 2.");
                        continue;
                    }
                    if (intRetiro == 1)
                    {
                        retiro = "PUERTA";

                    }
                    else if (intRetiro == 2)
                    {
                        retiro = "SUCURSAL";
                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }

                    break;

                }

                //CALCULO COSTO TARIFA EN BASE AL PESO INGRESADO y DATOS ORIGEN-DESTINO.
                decimal costosubtotal = 0M;
                LeerTarifas.Iniciar();

                if (peso > 20M)
                {
                    if (paisOrigen == paisDestino)
                    {
                        if (regionOrigen == regionDestino)
                        {
                            if (provinciaOrigen == provinciaDestino)
                            {
                                if (localidadOrigen == localidadDestino)
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "30kglocalidad") //Coloca tarifa "Hasta 30 Kg para misma localidad"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "30kgprovincia") //Coloca tarifa "Hasta 30 Kg para misma provincia"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Tarifas tarifa in Tarifas.TarifasList)
                                {
                                    if (tarifa.Nombre == "30kgregional") //Coloca tarifa "Hasta 30 Kg para misma región"
                                    {
                                        costosubtotal = tarifa.Precio;
                                    }
                                }
                            }
                        }

                        else
                        {
                            foreach (Tarifas tarifa in Tarifas.TarifasList)
                            {
                                if (tarifa.Nombre == "30kgnacional") //Coloca tarifa "Hasta 30 Kg para mismo país"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Tarifas tarifa in Tarifas.TarifasList)
                        {
                            if (paisDestino == "BRASIL" || paisDestino == "URUGUAY" || paisDestino == "BOLIVIA" || paisDestino == "CHILE" || paisDestino == "PARAGUAY")
                            {
                                if (tarifa.Nombre == "30kgpaislimitrofe") //Coloca tarifa "Hasta 30 Kg para pais limitrofe"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                            if (paisDestino == "COLOMBIA" || paisDestino == "PERU" || paisDestino == "ECUADOR" || paisDestino == "VENEZUELA" || paisDestino == "GUYANA" || paisDestino == "SURINAM" || paisDestino == "TRINIDAD Y TOBAGO" || paisDestino == "GUAYANA FRANCESA")
                            {
                                if (tarifa.Nombre == "30kgpaissudamerica") //Coloca tarifa "Hasta 30 Kg para pais del resto de sudamerica"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                        }
                    }

                }
                else if (peso > 10M)
                {
                    if (paisOrigen == paisDestino)
                    {
                        if (regionOrigen == regionDestino)
                        {
                            if (provinciaOrigen == provinciaDestino)
                            {
                                if (localidadOrigen == localidadDestino)
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "20kglocalidad") //Coloca tarifa "Hasta 20 Kg para misma localidad"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "20kgprovincia") //Coloca tarifa "Hasta 20 Kg para misma provincia"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Tarifas tarifa in Tarifas.TarifasList)
                                {
                                    if (tarifa.Nombre == "20kgregional") //Coloca tarifa "Hasta 20 Kg para misma región"
                                    {
                                        costosubtotal = tarifa.Precio;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (Tarifas tarifa in Tarifas.TarifasList)
                            {
                                if (tarifa.Nombre == "20kgnacional") //Coloca tarifa "Hasta 20 Kg para mismo país"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Tarifas tarifa in Tarifas.TarifasList)
                        {
                            if (paisDestino == "BRASIL" || paisDestino == "URUGUAY" || paisDestino == "BOLIVIA" || paisDestino == "CHILE" || paisDestino == "PARAGUAY")
                            {
                                if (tarifa.Nombre == "20kgpaislimitrofe") //Coloca tarifa "Hasta 20 Kg para país limitrofe"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                            if (paisDestino == "COLOMBIA" || paisDestino == "PERU" || paisDestino == "ECUADOR" || paisDestino == "VENEZUELA" || paisDestino == "GUYANA" || paisDestino == "SURINAM" || paisDestino == "TRINIDAD Y TOBAGO" || paisDestino == "GUAYANA FRANCESA")
                            {
                                if (tarifa.Nombre == "20kgpaissudamerica") //Coloca tarifa "Hasta 20 Kg para país del resto de sudamerica"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                        }
                    }
                }
                else if (peso > 0.5M)
                {
                    if (paisOrigen == paisDestino)
                    {
                        if (regionOrigen == regionDestino)
                        {
                            if (provinciaOrigen == provinciaDestino)
                            {
                                if (localidadOrigen == localidadDestino)
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "10kglocalidad") //Coloca tarifa "Hasta 10 Kg para misma localidad"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "10kgprovincia") //Coloca tarifa "Hasta 10 Kg para misma provincia"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Tarifas tarifa in Tarifas.TarifasList)
                                {
                                    if (tarifa.Nombre == "10kgregional") //Coloca tarifa "Hasta 10 Kg para misma región"
                                    {
                                        costosubtotal = tarifa.Precio;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (Tarifas tarifa in Tarifas.TarifasList)
                            {
                                if (tarifa.Nombre == "10kgnacional") //Coloca tarifa "Hasta 10 Kg para mismo país"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Tarifas tarifa in Tarifas.TarifasList)
                        {
                            if (paisDestino == "BRASIL" || paisDestino == "URUGUAY" || paisDestino == "BOLIVIA" || paisDestino == "CHILE" || paisDestino == "PARAGUAY")
                            {
                                if (tarifa.Nombre == "10kgpaislimitrofe") //Coloca tarifa "Hasta 10 Kg para país limitrofe"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                            if (paisDestino == "COLOMBIA" || paisDestino == "PERU" || paisDestino == "ECUADOR" || paisDestino == "VENEZUELA" || paisDestino == "GUYANA" || paisDestino == "SURINAM" || paisDestino == "TRINIDAD Y TOBAGO" || paisDestino == "GUAYANA FRANCESA")
                            {
                                if (tarifa.Nombre == "10kgpaissudamerica") //Coloca tarifa "Hasta 10 Kg para país del resto de sudamerica"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                        }
                    }
                }
                else
                {
                    if (paisOrigen == paisDestino)
                    {
                        if (regionOrigen == regionDestino)
                        {
                            if (provinciaOrigen == provinciaDestino)
                            {
                                if (localidadOrigen == localidadDestino)
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "0.5kglocalidad") //Coloca tarifa "Hasta 0.5 Kg para misma localidad"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (Tarifas tarifa in Tarifas.TarifasList)
                                    {
                                        if (tarifa.Nombre == "0.5kgprovincia") //Coloca tarifa "Hasta 0.5 Kg para misma provincia"
                                        {
                                            costosubtotal = tarifa.Precio;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                foreach (Tarifas tarifa in Tarifas.TarifasList)
                                {
                                    if (tarifa.Nombre == "0.5kgregional") //Coloca tarifa "Hasta 0.5 Kg para misma región"
                                    {
                                        costosubtotal = tarifa.Precio;
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (Tarifas tarifa in Tarifas.TarifasList)
                            {
                                if (tarifa.Nombre == "0.5kgnacional") //Coloca tarifa "Hasta 0.5 Kg para mismo país"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }
                        }

                    }
                    else
                    {
                        foreach (Tarifas tarifa in Tarifas.TarifasList)
                        {
                            if (paisDestino == "BRASIL" || paisDestino == "URUGUAY" || paisDestino == "BOLIVIA" || paisDestino == "CHILE" || paisDestino == "PARAGUAY")
                            {
                                if (tarifa.Nombre == "0.5kgpaislimitrofe") //Coloca tarifa "Hasta 0.5 Kg para país limitrofe"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                            if (paisDestino == "COLOMBIA" || paisDestino == "PERU" || paisDestino == "ECUADOR" || paisDestino == "VENEZUELA" || paisDestino == "GUYANA" || paisDestino == "SURINAM" || paisDestino == "TRINIDAD Y TOBAGO" || paisDestino == "GUAYANA FRANCESA")
                            {
                                if (tarifa.Nombre == "0.5kgpaissudamerica") //Coloca tarifa "Hasta 0.5 Kg para país del resto de sudamerica"
                                {
                                    costosubtotal = tarifa.Precio;
                                }
                            }

                        }
                    }
                }


                //CALCULO COSTO FINAL POR SERVICIOS ADICIONALES
                decimal costofinal = 0M;
                LeerTarifasAdicionales.Iniciar();

                costofinal = costosubtotal;

                if (urgente == "SI")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "urgente")
                        {
                            costofinal = costofinal + costofinal * tarifaAdicional.Porcentaje;
                        }
                    }

                }

                if (entrega == "PUERTA")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "entregapuerta")
                        {
                            costofinal = costofinal + tarifaAdicional.Precio;
                        }
                    }


                }

                if (retiro == "PUERTA")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "retiropuerta")
                        {
                            costofinal = costofinal + tarifaAdicional.Precio;
                        }
                    }
                }

                //MUESTRA TODOS LOS DATOS QUE VA A TENER LA SOLICITUD Y EL COSTO FINAL
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("Datos que de la solicitud a generar: ");
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("NroSolicitud: " + nrosolicitud + "; Fecha: " + fecha + "; Cliente: " + cliente + "; Estado: " + estado + "; TipoSolicitud: " + tipoSolicitud + "; DirecciónOrigen: " + direccionOrigen + "; LocalidadOrigen: " + localidadOrigen
                + "; ProvinciaOrigen: " + provinciaOrigen + "; RegiónOrigen: " + regionOrigen + "; PaísOrigen: " + paisOrigen + "; DirecciónDestino: " + direccionDestino + "; LocalidadDestino: " + localidadDestino
                + "; ProvinciaDestino: " + provinciaDestino + "; RegiónDestino: " + regionDestino + "; PaísDestino: " + paisDestino + "; Peso(Kg): " + peso + "; Urgente: " + urgente + "; Entrega: " + entrega
                + "; Retiro: " + retiro + "; Costo: " + costofinal);

                Console.WriteLine($"El costo de su solicitud es: {costofinal}");



                //VALIDA SI EL USUARIO QUIERE PROCEDER A GENERAR LA SOLICITUD FINALMENTE O SI QUIERE CANCELAR LA OPERACIÓN
                while (true)
                {
                    Console.WriteLine(System.Environment.NewLine);
                    Console.WriteLine("¿Quiere confirmar y generar está solicitud?");
                    Console.WriteLine("1 - Generar solicitud");
                    Console.WriteLine("2 - Cancelar operación");
                    string confirmacion = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(confirmacion))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }
                    if (!int.TryParse(confirmacion, out int intconfirmacion))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 2.");
                        continue;
                    }
                    if (intconfirmacion == 1)
                    {
                        SolicitudServicio solicitud = new SolicitudServicio();
                        solicitud.NroSolicitud = nrosolicitud;
                        solicitud.Fecha = fecha;
                        solicitud.ClienteAsociado = cliente;
                        solicitud.Estado = estado;
                        solicitud.TipoSolicitud = tipoSolicitud;
                        solicitud.DireccionOrigen = direccionOrigen;
                        solicitud.LocalidadOrigen = localidadOrigen;
                        solicitud.ProvinciaOrigen = provinciaOrigen;
                        solicitud.RegionOrigen = regionOrigen;
                        solicitud.PaisOrigen = paisOrigen;
                        solicitud.DireccionDestino = direccionDestino;
                        solicitud.LocalidadDestino = localidadDestino;
                        solicitud.ProvinciaDestino = provinciaDestino;
                        solicitud.RegionDestino = regionDestino;
                        solicitud.PaisDestino = paisDestino;
                        solicitud.Peso = peso;
                        solicitud.Urgente = urgente;
                        solicitud.Entrega = entrega;
                        solicitud.Retiro = retiro;
                        solicitud.Costo = costofinal;

                        SolicitudServicio.SolicitudList.Add(solicitud);
                        GrabarSolicitud.Iniciar();
                        Console.WriteLine(System.Environment.NewLine);
                        Console.WriteLine("La solicitud Nro: " + solicitud.NroSolicitud + " ha sido guardada exitosamente.");


                    }
                    else if (intconfirmacion == 2)
                    {
                        Console.WriteLine(System.Environment.NewLine);
                        Console.WriteLine("La operación ha sido cancelada.");

                    }
                    else
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 2.");
                        continue;

                    }

                    break;
                }


                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("Voliendo al menú principal...");
                Console.WriteLine("---------------------------------------------");
                SolicitudServicio.SolicitudList.Clear();
                Tarifas.TarifasList.Clear();
                TarifasAdicionales.TarifasAdicionalesList.Clear();
                break;
            }










        }
    }
}
