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
                    Console.WriteLine("Error, valor ingresado no valido (Acuerde usar mayuscula para la priemra letra)");
                    continue;
                }
                else break;

            }
            int licencia;
            string nombre;
            string fechaI = DateTime.Now.ToString("HH: mm:ss tt");
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

    }
}
