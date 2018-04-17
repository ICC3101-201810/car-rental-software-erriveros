using System;
namespace ConsoleApp1
{
    public class Auto : Vehiculo
    {

        public Auto(int miCantidad, string miTipo)
            : base(miCantidad, miTipo)
        {

        }

        public override int Licencia()
        {
            return 2;
        }
    }
}
