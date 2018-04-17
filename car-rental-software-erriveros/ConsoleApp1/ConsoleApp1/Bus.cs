using System;
namespace ConsoleApp1
{
    public class Bus : Vehiculo
    {

        public Bus(int miCantidad, string miTipo)
            : base(miCantidad, miTipo)
        {

        }

        public override int Licencia()
        {
            return 3;
        }
    }
}
