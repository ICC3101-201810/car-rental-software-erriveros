using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehiculo
    {
        string tipo;
        int cantidad;
        public string licencia;
        public Vehiculo(string miTipo,int miCantidad,string miLicencia)
        {
            tipo = miTipo;
            cantidad = miCantidad;
            licencia = miLicencia;
        }
        public string getNombre()
        {
            return tipo;
        }
        public int getCantidad()
        {
            return cantidad;
        }
    }
}
