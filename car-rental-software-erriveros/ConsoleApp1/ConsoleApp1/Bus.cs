using System;
namespace ConsoleApp1
{
    public class Bus : Vehiculo
    {

        public Bus(int miCantidad, string miTipo,string marca)
            : base(miCantidad, miTipo,marca)
        {

        }

        public override int Licencia()
        {
            return 3;
        }
    }
}
