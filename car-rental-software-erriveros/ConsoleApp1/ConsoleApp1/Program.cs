using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sucursal sucursal = new Sucursal();
            string opcion = "0";
            for (; ; )
            {
                Console.WriteLine("*********** HOLA BIENVENIDO A RENTACAR ***********");
                Cliente cliente = Arendar.CrearNuevoCliente();
                Console.WriteLine("Para ingresar los datos del auto que quiere arendar presione enter, para salir del programa ingrese 1: ");
                opcion = Console.ReadLine();
                if (opcion=="1")
                {
                    break;
                }
                Arendar.GetInfoAuto(cliente, sucursal);
                Console.WriteLine("Para agregar accesorios presione enter, para salir del programa presione (1)");

                Console.WriteLine("para volver a ingresar los datos presione (enter), para salir del programa presion (1): ");
                if (opcion=="1")
                {
                    break;
                }
            }
                    

