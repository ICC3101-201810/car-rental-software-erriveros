using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Sucursal> sucursals = new List<Sucursal>();
            List<Cliente> clientes = new List<Cliente>();
            List<Ariendo> ariendos = new List<Ariendo>();
            int ID = 0;


            for (; ; )
            {
                double sumaTotal = 0;
                string opcion1 = " ";
                string opcion2 = " ";
                string opcion3 = " ";
                Console.WriteLine("Ingrese 1 para opciones administratica de una sucursal, ingrese 2 para arendar un auto: ");
                opcion1 = Console.ReadLine();
                if (opcion1 == "1")
                {
                    Console.WriteLine("Desea crear una sucursal nueva (1) o agregar un vehiculo a una sucursal ya existente (2): ");
                    opcion2 = Console.ReadLine();
                    if (opcion2 == "1")
                    {
                        List<Vehiculo> vehiculos = new List<Vehiculo>();
                        Sucursal sucursal = new Sucursal(vehiculos, ID);
                        ID++;
                        sucursals.Add(sucursal);
                        Console.WriteLine("Se ha creado una nueva sucursal con numero ID: {0}", sucursal.ID);

                    }
                    if (opcion2 == "2")
                    {
                        int occurio = 0;
                        Console.WriteLine("Ingrese el ID de la sucursal que desea agregar Vehiculos: ");
                        int IDsucursal = Int32.Parse(Console.ReadLine());
                        foreach (Sucursal s in sucursals)
                        {
                            if (s.ID == IDsucursal)
                            {
                                occurio = 1;
                                for (; ; )
                                {
                                    Console.WriteLine("Ingrese El tipo de vehiculo que desea agregar (Auto,Moto,Bus,Maquinaria): ");
                                    string tipo = Console.ReadLine();
                                    Console.WriteLine("Ingrese la cantidad de este vehiculo que quiere agregar: ");
                                    int cantidad = Int32.Parse(Console.ReadLine());
                                    Vehiculo vehiculo = s.CrearNuevoVehiculo(cantidad, tipo);
                                    if (vehiculo.tipo == "no es un vehiculo")
                                    {
                                        Console.WriteLine("El tipo de auto fue ingresado eroniamente, intente denuevo");
                                        continue;
                                    }
                                    else
                                    {
                                        s.AgregarVehiculo(vehiculo);
                                        Console.WriteLine("El vehiculo ha sido agregado correctamente");
                                    }
                                    Console.WriteLine("si desea agregar otro vehiculo presione enter, si no ingrese (1) ");
                                    opcion3 = Console.ReadLine();
                                    if (opcion3 == "1")
                                    {
                                        break;
                                    }

                                }
                            }
                        }
                        if (occurio == 0)
                        {
                            Console.WriteLine("El ID de la sucursal que ingreso no se encuentra en nuestra lista de sucursales");
                            continue;
                        }

                    }
                }

                if (opcion1 == "2")
                {
                    Cliente cliente = Arendar.CrearNuevoCliente();
                    clientes.Add(cliente);
                    Arendar.GetInfoSucursales(sucursals);
                    Console.WriteLine("Ingrese el ID de la sucursal que guste: ");
                    int IDsucursal = Int32.Parse(Console.ReadLine());
                    foreach (Sucursal s in sucursals)
                    {
                        if (s.ID == IDsucursal)
                        {
                            string tipo = " ";
                            int cantidad = 0;
                            s.GetInfoVehiculos();
                            Console.WriteLine("Ingrese el tipo de vehiculo que quiere arendar: ");
                            tipo = Console.ReadLine();
                            Console.WriteLine("Ingrese la cantidad de este vehiculo que quiere arrendar: ");
                            cantidad = Int32.Parse(Console.ReadLine());
                            Vehiculo vehiculo = s.CrearNuevoVehiculo(cantidad, tipo);
                            if (Arendar.EstaElVehiculo(s, vehiculo) && Arendar.SePuede(cliente, vehiculo))
                            {
                                cliente.AgregarAriendo(vehiculo);
                                Console.WriteLine("ingrese (1) para agregar accesorios a su ariendo, si no presione enter");
                                opcion3 = Console.ReadLine();
                                if (opcion3 == "1")
                                {

                                }
                                else
                                {

                                }
                                string HoraT = DateTime.Now.ToString("HH: mm:ss tt");
                                List<Accesorio> accesorios = new List<Accesorio>();
                                Ariendo ariendo = new Ariendo(cliente, vehiculo, s, accesorios, cliente.HoraI, HoraT);
                                ariendos.Add(ariendo);
                                Console.WriteLine("Se a agregado este ariendo a su carro, si desea agregar otro ariendo presione enter, si desea cancelar su carro ingrese (2)");
                                opcion2 = Console.ReadLine();

                                if (opcion2 == "2")
                                {
                                    sumaTotal += Arendar.GetSumaTotalAccesorio(cliente);
                                    sumaTotal += Arendar.GetSumaTotalVehiculo(cliente);
                                    Console.WriteLine("La suma total de sus arriendos es de {0}", sumaTotal);

                                }
                            }
                            else
                            {
                                Console.WriteLine("Los datos Ingresados no se pudieron realizar");
                                break;

                            }


                        }
                    }


                }
            }
        }
    }
}