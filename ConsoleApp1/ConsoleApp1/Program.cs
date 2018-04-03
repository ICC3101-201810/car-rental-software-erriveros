using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            Sucursal sucursal1;
            for (; ; )
            {
                string opcion;
                Console.WriteLine("Ingrese 1 para crear una sucursal, ingrese 2 para arendar un auto");
                opcion = Console.ReadLine();
                if (opcion=="1")
                {
                    string tipo;
                    int cantidad;
                    Vehiculo nuevoVehiculo;
                    List<Vehiculo> nuevoVehiculos = new List<Vehiculo>();
                    Console.WriteLine("ingrese el nombre de su sucursal");
                    string nombreSucursal = Console.ReadLine();
                    for (; ; )
                    {
                        Console.WriteLine("ingrese el tipo de vehiculo que quiera agregar a la sucursal, si quiere salir escriba salir");
                        tipo = Console.ReadLine();
                        if (tipo == "salir")
                        {
                            break;
                        }
                        Console.WriteLine("ingrese la cantidad de este vehiculo que quiere agregar");
                        cantidad = Int32.Parse(Console.ReadLine());
                        nuevoVehiculo = new Vehiculo(tipo, cantidad);
                        nuevoVehiculos.Add(nuevoVehiculo);

                    }

                    sucursal1 = new Sucursal(nuevoVehiculos, nombreSucursal);
                    sucursales.Add(sucursal1);

                }
                if (opcion == "2")
                {
                    Console.WriteLine("ingrese su nombre");
                    string nombre1 = Console.ReadLine();
                    Console.WriteLine("ingrese que tipo de licencia tiene");
                    string licencia1 = Console.ReadLine();
                    Persona persona1 = new Persona(nombre1, licencia1);                   
                    sucursal1.getVehiculos();
                    Console.WriteLine("indique que tipo de auto quiere arendar");
                    string tipo1 = Console.ReadLine();
                    Console.WriteLine("indique la cantidad de este tipo que quiere arendar");
                    int cant1 = Int32.Parse(Console.ReadLine());
                    Vehiculo vehiculo1 = new Vehiculo(tipo1, cant1);


                    sucursal1.comprarVehiculos(vehiculo1);

                }

            }
            
        }
    }
}
