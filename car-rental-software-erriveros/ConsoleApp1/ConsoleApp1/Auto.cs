using System;
namespace ConsoleApp1
{
    public class Auto : Vehiculo
    {

        public Auto(int miCantidad, string miTipo,string Marca)
            : base(miCantidad, miTipo,Marca)
        {

        }

        public override int Licencia()
        {
            return 2;
        }
    }
}
