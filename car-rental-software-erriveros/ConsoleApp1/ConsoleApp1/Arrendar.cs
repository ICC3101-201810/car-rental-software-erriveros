using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public static class Arendar
    {

        public static double GetSumaTotalVehiculo(Cliente cliente)
        {
            double suma = 0;
            foreach (Vehiculo v in cliente.vehiculosAriendo)
            {
                suma += v.cantidad * v.precio;
            }
            return suma;

        }

        public static double GetSumaTotalAccesorio(Cliente cliente)
        {
            double suma = 0;
            foreach (Accesorio a in cliente.AccesoriosAriendo)
            {
                suma += a.cantidad * a.precio;
            }
            return suma;

        }




        public static bool EstaElVehiculo(Sucursal sucursal, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in sucursal.vehiculos)
            {
                if (v.tipo == vehiculo.tipo && v.cantidad > 0)
                {
                    return true;
                }

            }
            return false;
        }

        public static Cliente CrearNuevoCliente()
        {
            string tipo = " ";
            for (; ; )
            {

                Console.WriteLine("ingrese el tipo de cliente que es(Persona,Empresa,Institucion,Organizacion): ");
                tipo = Console.ReadLine();
                if (tipo != "Persona" && tipo != "Institucion" && tipo != "Empresa" && tipo != "Organizacion")
                {
                    Console.Beep();
                    Console.Beep();
                    Console.WriteLine("Error, valor ingresado no valido (Acuerde usar mayuscula para la priemra letra)");

                    continue;
                }
                else break;

            }
            DateTime.Today.ToString();
            int licencia;
            string nombre;
            string fechaI = DateTime.Today.ToString();
            if (tipo == "Persona")
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Licencia ((1) para moto,(2) para auto, (3) para buses, (4) para maquinaria ");
                licencia = Int32.Parse(Console.ReadLine());
                Cliente cliente = new Persona(nombre, licencia, fechaI);
                return cliente;
            }

            if (tipo == "Empresa")
            {
                Console.WriteLine("Ingrese el nombre de empresa: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Autorizacion ((1) para moto,(2) para auto, (3) para buses, (4) para maquinaria ");
                licencia = Int32.Parse(Console.ReadLine());
                Cliente cliente = new Empresa(nombre, licencia, fechaI);
                return cliente;
            }
            if (tipo == "Institucion")
            {
                Console.WriteLine("Ingrese el nombre de Institucion: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Autorizacion ((1) para moto,(2) para auto, (3) para buses, (4) para maquinaria ");
                licencia = Int32.Parse(Console.ReadLine());
                Cliente cliente = new Institucion(nombre, licencia, fechaI);
                return cliente;
            }

            if (tipo == "Organizacion")
            {
                Console.WriteLine("Ingrese el nombre de organizacion: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su Autorizacion ((1) para moto,(2) para auto, (3) para buses, (4) para maquinaria ");
                licencia = Int32.Parse(Console.ReadLine());
                Cliente cliente = new Organizacion(nombre, licencia, fechaI);
                return cliente;
            }

            else
            {
                Cliente cliente = new Persona("no existe", 0, " ");
                return cliente;
            }

        }

        public static void GetInfoSucursales(List<Sucursal> sucursales)
        {
            foreach (Sucursal s in sucursales)
            {
                Console.WriteLine("Sucursal: {0}", s.ID);
            }
        }

        public static void GetInfoAuto(Cliente cliente, Sucursal sucursal)
        {
            for (; ; )
            {
                int cont = 0;
                int HayStock = 0;
                int Puede = 0;
                string coridaOno;
                string TeleOno;
                foreach (Vehiculo v in sucursal.vehiculos)
                {
                    Console.WriteLine("{0}: Tipo de vehiculo {1}, Marca {2}, Cantidad en sucursal {3}", cont, v.tipo, v.marca, v.cantidad);
                }
                Console.WriteLine("Ingrese el tipo de vehiculo que quiere arrendar (Auto,Bus,Maquinaria) : ");
                string tipo = Console.ReadLine();
                if (tipo == "Auto")
                {
                    Console.WriteLine("si desea una corrida de asiento mas ingrese (1) o si prefiere un maletero mas grande ingrese (2)");
                    coridaOno = (Console.ReadLine());
                    if (coridaOno == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ha elegido una corrida de asiento mas!");
                        Console.ResetColor();
                    }
                    else if (coridaOno == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ha elegido un maletero mas grande!");
                        Console.ResetColor();
                    }
                    Console.WriteLine("si desea un reproductor de DVD ingrese (1) o sino ingrese (2)");
                    TeleOno = (Console.ReadLine());
                    if (TeleOno == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ha elegido tener reporductor DVD !");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine("Ingrese la marca del vehiculo que quiere arrendar : ");
                string marca = Console.ReadLine();
                foreach (Vehiculo v in sucursal.vehiculos)
                {
                    if (v.tipo == tipo && v.marca == marca)
                    {
                        if (v.cantidad > 0)
                        {
                            HayStock = 1;
                            if(cliente.SePuede(v))
                            {
                                Puede = 1;
                                Console.WriteLine("Ingrese la cantidad de tiempo que desea arrendar este auto");
                                v.cantidadTiempo = Int32.Parse(Console.ReadLine());
                                v.cantidad -= 1;
                                cliente.vehiculosAriendo.Add(v);
                                Console.Beep();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Se ha agregado el vehivulo a su carro!");
                                Console.ResetColor();

                                }
                               
                            }


                        }

                    }

                if (HayStock == 0)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El vehiculo que busca esta agotado de stock");
                    Console.ResetColor();

                    Console.WriteLine("Para volver a ingresar apriete enter, para cancelar su carro o salir ingrese (1)");
                    string opcion = Console.ReadLine();
                }
                else if (Puede==0)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Perdon pero no tiene la licencia para arrendar este tipo de vehiculo");
                    Console.ResetColor();
                    Console.WriteLine("Para volver a ingresar apriete enter, para cancelar su carro o salir ingrese (1)");
                }
            }
        }
            

    }
}
