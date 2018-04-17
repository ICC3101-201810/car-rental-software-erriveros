using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            Vehiculo vehiculoA = new Auto(20, "Auto", "Mazda",true,true,false);
            Vehiculo vehiculoAA = new Auto(20, "Auto", "Tesla", false, true, true);
            Vehiculo vehiculoB = new Bus(15, "Bus", "Jax");
            Vehiculo vehiculoC = new Moto(30, "Moto", "BMW");

            Sucursal sucursal = new Sucursal(vehiculos, 12345);
            string opcion = "0";
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*********** HOLA BIENVENIDO A RENTACAR ***********");
                Console.ResetColor();
                Cliente cliente = Arendar.CrearNuevoCliente();
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se ha creado un nuevo usario con exito!");
                Console.ResetColor();
                Console.WriteLine("Para ingresar los datos del auto que quiere arendar presione enter, para salir del programa ingrese 1: ");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    break;
                }
                Arendar.GetInfoAuto(cliente, sucursal);
                Console.WriteLine("Para agregar accesorios presione enter, para salir del programa presione (1)");

                Console.WriteLine("para volver a ingresar los datos presione (enter), para salir del programa presion (1): ");
                if (opcion == "1")
                {
                    break;
                }
            }
        }
    }
}
                    

