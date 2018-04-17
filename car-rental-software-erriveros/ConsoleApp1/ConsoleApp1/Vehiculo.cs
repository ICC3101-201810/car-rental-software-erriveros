using System;
namespace ConsoleApp1
{
    public abstract class Vehiculo
    {
        public int precio;
        public int cantidad;
        public string tipo;
        public Vehiculo(int miCantidad, string miTipo)
        {
            cantidad = miCantidad;
            tipo = miTipo;
        }



        public virtual int Licencia()
        {
            return 0;
        }

    }
}
