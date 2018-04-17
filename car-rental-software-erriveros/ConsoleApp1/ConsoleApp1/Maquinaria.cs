using System;
namespace ConsoleApp1
{
    public class Maquinaria : Vehiculo
    {

        public Maquinaria(int miCantidad, string miTipo)
            : base(miCantidad, miTipo)
        {

        }

        public override int Licencia()
        {
            return 4;
        }
    }
}
