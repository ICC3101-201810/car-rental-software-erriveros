using System;
namespace ConsoleApp1
{
    public class Moto : Vehiculo
    {

        public Moto(int miCantidad, string miModelo, string miMarca)
            : base(miCantidad, miModelo,miMarca)
        {

        }

        public override int Licencia()
        {
            return 1;
        }
    }
}