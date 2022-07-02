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


                //Se inician las funciones de lectura de los maestros de paises, provincias y localidades
                LeerPais.Iniciar();
                LeerProvincia.Iniciar();
                LeerLocalidad.Iniciar();

                //Los Servicios siempre se realizan desde Argentina
                //LOOPS INGRESO DATOS DE ORIGEN
                //DETERMINACIÓN DE DIRECCIÓN DE ORIGEN
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


                //DETERMINACIÓN DE LOCALIDAD Y PROVINCIA DE ORIGEN
                string localidadOrigen = "";
                string provinciaOrigen = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la localidad de origen de la dirección: ");
                    foreach (Localidad localidad in Localidad.LocalidadList) //Muestra todas las localidades del maestro de localidades. Las mismas son solo de Argentina.
                    {
                        Console.WriteLine(localidad.NroLocalidad + " - " + localidad.NombreLocalidad + " (" + localidad.ProvinciaLocalidad + ")");
                    }
                    string ingresolocalidadOrigen = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresolocalidadOrigen))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 48.");
                        continue;
                    }
                    if (!int.TryParse(ingresolocalidadOrigen, out int intlocalidadOrigen))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 48.");
                        continue;
                    }
                    if (intlocalidadOrigen < 1 || intlocalidadOrigen > 48)
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 48.");
                        continue;
                    }
                    foreach (Localidad localidad in Localidad.LocalidadList)
                    {
                        if (intlocalidadOrigen == localidad.NroLocalidad) //en base al numero de localidad elegido, establece la localidadOrigen y la provinciaOrigen de la misma
                        {
                            localidadOrigen = localidad.NombreLocalidad;
                            provinciaOrigen = localidad.ProvinciaLocalidad;
                        }

                    }
                    break;
                }


                //DETERMINACIÓN DE REGIÓN Y PAÍS DE ORIGEN
                string regionOrigen = "";
                string paisOrigen = "";
                foreach (Provincia provincia in Provincia.ProvinciaList)
                {
                    if (provinciaOrigen == provincia.NombreProvincia) //Filtra por la provincia establecida anteriormente y establece su región y país correspondiente
                    {
                        regionOrigen = provincia.RegionProvincia;
                        paisOrigen = provincia.PaisProvincia;

                    }
                }


                //LOOPS INGRESO DATOS DE DESTINO
                //DETERMINACIÓN DEL PAÍS DE DESTINO
                string paisDestino = "";
                string regionpaisDestino = "";
                while (true)
                {
                    Console.WriteLine("Ingrese el país de destino de la dirección: ");
                    foreach (Pais pais in Pais.PaisList) //Muestra todos los paises del maestro de paises.
                    {
                        Console.WriteLine(pais.NroPais + " - " + pais.NombrePais);
                    }
                    string ingresopaisDestino = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ingresopaisDestino))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 11.");
                        continue;
                    }
                    if (!int.TryParse(ingresopaisDestino, out int intpaisDestino))
                    {
                        Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 11.");
                        continue;
                    }
                    if (intpaisDestino < 1 || intpaisDestino > 11)
                    {
                        Console.WriteLine("Usted debe ingresar un número entero del 1 al 11.");
                        continue;
                    }
                    foreach (Pais pais in Pais.PaisList)
                    {
                        if (intpaisDestino == pais.NroPais) //en base al numero de país elegido, establece el paisDestino y la regionpaisDestino del mismo (seria la región internacional)
                        {
                            paisDestino = pais.NombrePais;
                            regionpaisDestino = pais.RegionPais;
                        }

                    }
                    break;
                }


                //DETERMINACIÓN DE DIRECCIÓN DE DESTINO
                string direccionDestino = "";
                while (true)
                {
                    Console.WriteLine("Ingrese la dirección de destino (Calle, número y código postal): ");
                    direccionDestino = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(direccionDestino))
                    {
                        Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar una dirección de destino.");
                        continue;
                    }
                    break;
                }


                //DETERMINACIÓN DE LOCALIDAD DE DESTINO (SOLO SI EL PAÍS ES ARGENTINA) Y PROVINCIA DE DESTINO
                string localidadDestino = "";
                string provinciaDestino = "";
                List<int> provinciasPaisList = new List<int>();
                if (paisDestino == "ARGENTINA") //SI EL PAÍS ES ARGENTINA, SOLICITA ELEGIR UNA LOCALIDAD Y EN BASE A LA MISMA ESTABLECE LA PROVINCIA CORRESPONDIENTE
                {
                    while (true)
                    {
                        Console.WriteLine("Ingrese la localidad de destino de la dirección: ");
                        foreach (Localidad localidad in Localidad.LocalidadList)
                        {
                            Console.WriteLine(localidad.NroLocalidad + " - " + localidad.NombreLocalidad + " (" + localidad.ProvinciaLocalidad + ")");
                        }
                        string ingresolocalidadDestino = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ingresolocalidadDestino))
                        {
                            Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del 1 al 48.");
                            continue;
                        }
                        if (!int.TryParse(ingresolocalidadDestino, out int intlocalidadDestino))
                        {
                            Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del 1 al 48.");
                            continue;
                        }
                        if (intlocalidadDestino < 1 || intlocalidadDestino > 48)
                        {
                            Console.WriteLine("Usted debe ingresar un número entero del 1 al 48.");
                            continue;
                        }
                        foreach (Localidad localidad in Localidad.LocalidadList)
                        {
                            if (intlocalidadDestino == localidad.NroLocalidad)
                            {
                                localidadDestino = localidad.NombreLocalidad;
                                provinciaDestino = localidad.ProvinciaLocalidad;
                            }

                        }
                        break;
                    }
                }
                else //SI EL PAIS NO ES "ARGENTINA", SE SOLICITA ELEGIR SOLO LA PROVINCIA DE DICHO PAÍS
                {
                    
                    while (true)
                    {
                        Console.WriteLine("Ingrese la provincia de destino de la dirección: ");
                        foreach (Provincia provincia in Provincia.ProvinciaList)
                        {
                            if (paisDestino == provincia.PaisProvincia) //Filtra las provincias a mostrar en base al paisDestino seleccionado previamente
                            {
                                Console.WriteLine(provincia.NroProvincia + " - " + provincia.NombreProvincia);

                                provinciasPaisList.Add(provincia.NroProvincia); //almacena el numero de las provincias del pais, para ser usado en los mensajes de error al ingresar una opción
                            }

                        }
                        string ingresoprovinciaDestino = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(ingresoprovinciaDestino))
                        {
                            Console.WriteLine("Los espacíos en blanco son inválidos. Usted debe ingresar un número entero del " + provinciasPaisList[0] + " al " + provinciasPaisList.Last() + ".");
                            continue;
                        }
                        if (!int.TryParse(ingresoprovinciaDestino, out int intprovinciaDestino))
                        {
                            Console.WriteLine("El valor ingresado es inválido. Usted debe ingresar un número entero del " + provinciasPaisList[0] + " al " + provinciasPaisList.Last() + ".");
                            continue;
                        }
                        if (intprovinciaDestino < provinciasPaisList[0] || intprovinciaDestino > provinciasPaisList.Last())
                        {
                            Console.WriteLine("Usted debe ingresar un número entero del " + provinciasPaisList[0] + " al " + provinciasPaisList.Last() + ".");
                            continue;
                        }
                        foreach (Provincia provincia in Provincia.ProvinciaList)
                        {
                            if (intprovinciaDestino == provincia.NroProvincia)  //Si el numero ingresado correspende a una de las provincis del país, establece finalmente la provinciaDestino
                            {
                                provinciaDestino = provincia.NombreProvincia;
                            }

                        }
                        localidadDestino = "N/A"; //Al ser un destino internacional no se pide la localidad y se establece ese valor. Esto de acuerdo a la instrucción del correo con las devoluciones donde dice "y sólo si el usuario elije Argentina pedir la localidad."
                        break;
                    }
                }


                //DETERMINACIÓN DE REGIÓN DE DESTINO
                string regionDestino = "";
                foreach (Provincia provincia in Provincia.ProvinciaList)
                {
                    if (provinciaDestino == provincia.NombreProvincia) //Filtra por la provincia establecida anteriormente y establece su región correspondiente
                    {
                        regionDestino = provincia.RegionProvincia;

                    }
                }


                //DETERMINACIÓN DE TARIFA
                LeerTarifas.Iniciar(); //Se inicia la funcion de lectura del maestro de tarifas
                Tarifas tarifaAUtilizar = null;
                foreach (Tarifas tarifa in Tarifas.TarifasList)
                {
                    if (peso > tarifa.RangoMayorA) //Filtra las tarifas del txt en base al peso ingresado
                    {

                        if (localidadOrigen == localidadDestino)
                        {
                            if (tarifa.TipoTarifa == "localidad")
                            {
                                tarifaAUtilizar = tarifa;
                            }

                        }
                        else if (provinciaOrigen == provinciaDestino)
                        {
                            if (tarifa.TipoTarifa == "provincial")
                            {
                                tarifaAUtilizar = tarifa;
                            }
                        }
                        else if (regionOrigen == regionDestino)
                        {
                            if (tarifa.TipoTarifa == "regional")
                            {
                                tarifaAUtilizar = tarifa;
                            }
                        }
                        else if (paisOrigen == paisDestino) //ES DECIR: SI EL PAIS DESTINO ES "ARGENTINA". YA QUE EL PAISORIGEN ESTA ESTABLECIDO PARA QUE SIEMPRE SEA "ARGENTINA"
                        {
                            if (tarifa.TipoTarifa == "nacional")
                            {
                                tarifaAUtilizar = tarifa;
                            }
                        }
                        else
                        {   //PARA LOS ENVIOS INTERNACIONALES, PRIMERO CALCULA LA TARIFA DESDE EL ORIGEN HASTA CABA
                            if (localidadOrigen == "Villa Devoto" || localidadOrigen == "Recoleta") //Si la localidad de origen coincide con alguna de las 2 localidades de CABA, coloca la tarifa localidad
                            {
                                if (tarifa.TipoTarifa == "localidad")
                                {
                                    tarifaAUtilizar = tarifa;
                                }

                            }
                            else if (provinciaOrigen == "CABA") //Sino, si la provincia de origen coincide con CABA, coloca la tarifa provincial
                            {
                                if (tarifa.TipoTarifa == "provincial")
                                {
                                    tarifaAUtilizar = tarifa;
                                }
                            }
                            else if (regionOrigen == "METROPOLITANA") //Sino, si la región de origen coincide con la región de CABA (METROPOLITANA), coloca la tarifa regional
                            {
                                if (tarifa.TipoTarifa == "regional")
                                {
                                    tarifaAUtilizar = tarifa;
                                }
                            }
                            else if (paisOrigen == "ARGENTINA") //Sino, coloca la tarifa nacional
                            {
                                if (tarifa.TipoTarifa == "nacional")
                                {
                                    tarifaAUtilizar = tarifa;
                                }
                            }
                        }

                    }
                }



                //DETERMINACIÓN DE TARIFA INTERNACIONAL
                TarifasInternacionales tarifaIntAUtilizar = null;
                if (paisDestino != "ARGENTINA")
                {
                    LeerTarifasInternacionales.Iniciar();//Se inicia la funcion de lectura del maestro de tarifas internacionales
                    foreach (TarifasInternacionales tarifaInternacional in TarifasInternacionales.TarifasInternacionalesList)
                    {
                        if (peso > tarifaInternacional.RangoMayorA) //Filtra las tarifas internacionales del txt en base al peso ingresado
                        {
                            if (regionpaisDestino == tarifaInternacional.RegionInternacional) //Filtra las tarifas internacionales en base a la región internacional del país de destino seleccionado previamente.
                            {
                                tarifaIntAUtilizar = tarifaInternacional;
                            }
                        }
                    }
                }


                //DETERMINACIÓN TARIFAS ADICIONALES
                decimal tarifaUrgente = 0M;
                decimal tarifaEntregaPuerta = 0M;
                decimal tarifaRetiroPuerta = 0M;
                LeerTarifasAdicionales.Iniciar();


                if (urgente == "SI")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "urgente") //Busca la tarifa adicional por recargo urgente porcentual y la calcula
                        {
                            tarifaUrgente = tarifaAUtilizar.Precio * tarifaAdicional.Porcentaje;
                        }
                    }

                }

                if (entrega == "PUERTA")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "entregapuerta") //Busca la tarifa adicional por recargo de entrega en puerta
                        {
                            tarifaEntregaPuerta = tarifaAdicional.Precio;
                        }
                    }


                }

                if (retiro == "PUERTA")
                {
                    foreach (TarifasAdicionales tarifaAdicional in TarifasAdicionales.TarifasAdicionalesList)
                    {
                        if (tarifaAdicional.Nombre == "retiropuerta") //Busca la tarifa adicional por recargo de entrega en puerta
                        {
                            tarifaRetiroPuerta = tarifaAdicional.Precio;
                        }
                    }
                }


                //DETERMINACIÓN COSTO FINAL DE LA SOLICITUD
                decimal costo = tarifaAUtilizar.Precio + tarifaUrgente + tarifaEntregaPuerta + tarifaRetiroPuerta;
                if (paisDestino != "ARGENTINA")
                {
                    costo = costo + tarifaIntAUtilizar.Precio;
                }

                //MUESTRA TODOS LOS DATOS QUE VA A TENER LA SOLICITUD Y EL COSTO FINAL
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("Datos de la solicitud a generar: ");
                Console.WriteLine(System.Environment.NewLine);
                Console.WriteLine("NroSolicitud: " + nrosolicitud + "; Fecha: " + fecha + "; Cliente: " + cliente + "; Estado: " + estado + "; TipoSolicitud: " + tipoSolicitud + "; DirecciónOrigen: " + direccionOrigen + "; LocalidadOrigen: " + localidadOrigen
                + "; ProvinciaOrigen: " + provinciaOrigen + "; RegiónOrigen: " + regionOrigen + "; PaísOrigen: " + paisOrigen + "; DirecciónDestino: " + direccionDestino + "; LocalidadDestino: " + localidadDestino
                + "; ProvinciaDestino: " + provinciaDestino + "; RegiónDestino: " + regionDestino + "; PaísDestino: " + paisDestino + "; Peso(Kg): " + peso + "; Urgente: " + urgente + "; Entrega: " + entrega
                + "; Retiro: " + retiro + "; Costo: " + costo);


                Console.WriteLine();//deja un espacio
                Console.WriteLine("Tarifa Argentina|" + tarifaAUtilizar.Nombre + ": $" + tarifaAUtilizar.Precio);
                if (paisDestino != "ARGENTINA")
                {
                    Console.WriteLine("Tarifa Internacional|" + tarifaIntAUtilizar.Nombre + ": $" + tarifaIntAUtilizar.Precio);
                }
                if (urgente == "SI")
                {
                    Console.WriteLine("Recargo urgente (25% sobre tarifa argentina): $" + tarifaUrgente);
                }
                if (entrega == "PUERTA")
                {
                    Console.WriteLine("Recargo entrega en puerta: $" + tarifaEntregaPuerta);
                }
                if (retiro == "PUERTA")
                {
                    Console.WriteLine("Recargo retiro en puerta: $" + tarifaRetiroPuerta);
                }
                Console.WriteLine();//deja un espacio
                Console.WriteLine("El costo total de su solicitud es de: $" + costo);



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
                        solicitud.Costo = costo;

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
                Console.WriteLine("Volviendo al menú principal...");
                Console.WriteLine("---------------------------------------------");
                SolicitudServicio.SolicitudList.Clear();
                Localidad.LocalidadList.Clear();
                Provincia.ProvinciaList.Clear();
                Pais.PaisList.Clear();
                provinciasPaisList.Clear();
                Tarifas.TarifasList.Clear();
                TarifasInternacionales.TarifasInternacionalesList.Clear();
                TarifasAdicionales.TarifasAdicionalesList.Clear();
                break;
            }










        }
    }
}
