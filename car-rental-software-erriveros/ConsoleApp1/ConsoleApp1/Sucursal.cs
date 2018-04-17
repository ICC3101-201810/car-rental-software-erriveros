using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Sucursal
    {
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        public int ID;
        public Sucursal(List<Vehiculo> miVehiculos, int miID)
        {
            vehiculos = miVehiculos;
            ID = miID;
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            int paso = 1;
            foreach (Vehiculo v in vehiculos)
            {
                if (v.tipo == vehiculo.tipo)
                {
                    paso = 2;
                    v.cantidad += vehiculo.cantidad;
                }
            }
            if (paso == 1)
            {
                vehiculos.Add(vehiculo);
            }
        }

        public void RestarVehiculo(Vehiculo vehiculo)
        {
            foreach (Vehiculo v in vehiculos)
            {
                if (v.tipo == vehiculo.tipo)
                {
                    v.cantidad -= vehiculo.cantidad;
                }
            }
        }

        public Vehiculo CrearNuevoVehiculo(int cantidad, string tipo)
        {
            if (tipo == "Auto")
            {
                Vehiculo vehiculo = new Auto(cantidad, tipo);
                return vehiculo;
            }
            if (tipo == "Moto")
            {
                Vehiculo vehiculo = new Moto(cantidad, tipo);
                return vehiculo;
            }

            if (tipo == "Bus")
            {
                Vehiculo vehiculo = new Bus(cantidad, tipo);
                return vehiculo;
            }

            if (tipo == "Maquinaria")
            {
                Vehiculo vehiculo = new Maquinaria(cantidad, tipo);
                return vehiculo;
            }
            else
            {
                Vehiculo vehiculo = new Auto(0, "no es un vehiculo");
                return vehiculo;
            }

        }

        public void GetInfoVehiculos()
        {
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine("Este es el tipo de vehiculo:  {0}, y esta e la cantidad que dispone la sucursal {1}", v.tipo, v.cantidad);
            }
        }


    }

}