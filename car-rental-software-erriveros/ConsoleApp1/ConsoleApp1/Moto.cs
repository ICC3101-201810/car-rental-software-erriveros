using System;
namespace ConsoleApp1
{
    public class Moto : Vehiculo
    {

        public Moto(int miCantidad, string miModelo)
            : base(miCantidad, miModelo)
        {

        }

        public override int Licencia()
        {
            return 1;
        }
    }
}