using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursal
    {
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        string nombre;
        public Sucursal(List<Vehiculo> miVehiculos, string miNombre)
        {
            vehiculos = miVehiculos;
            nombre = miNombre;
        }
        public void agregarVehiculos(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);

        }
        public void comprarVehiculos(Vehiculo vehiculo)
        {
            Vehiculo removeV;
            int a = 0;
            int b = 0;
            foreach(Vehiculo v in vehiculos)
            {
                string n1 = v.getNombre();
                string n2 = vehiculo.getNombre();
                if (n1==n2)
                {
                    b = v.getCantidad();
                    a = 1;

                }
            }
            if (a==1)
            {
                removeV = vehiculo;
                vehiculos.Remove(removeV);
                int nuevaCant = b - vehiculo.getCantidad();
                Vehiculo nuevoV = new Vehiculo(vehiculo.getNombre(), nuevaCant,vehiculo.licencia);
                vehiculos.Add(nuevoV);
            }
            

            
        }
        public void getVehiculos()
        {
            foreach(Vehiculo v in vehiculos)
            {
                Console.WriteLine("este es el tipo:{0} y este es la cantidad que tenemos:{1}", v.getNombre(), v.getCantidad());
            }
        }
        
         

    }
}
