using System;
namespace ConsoleApp1
{
    public abstract class Vehiculo
    {
        public int precio;
        public int cantidad;
        public string tipo;
        public string marca;
        public int cantidadTiempo;
        public Vehiculo(int miCantidad, string miTipo,string miMarca)
        {
            cantidad = miCantidad;
            tipo = miTipo;
            marca = miMarca;
        }



        public virtual int Licencia()
        {
            return 0;
        }

    }
}
