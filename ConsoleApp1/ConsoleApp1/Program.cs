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
            List<Cliente> clientes = new List<Cliente>();
            List<Ariendo> ariendos = new List<Ariendo>();
            List<Accesorio> accesorios = new List<Accesorio>();
            Sucursal sucursal1;

            for (; ; )
            {
                string opcion;
                Console.WriteLine("Ingrese 1 para crear una sucursal, ingrese 2 para arendar un auto si es una persona, ingrese 3 para arendar un auto si es una empresa");
                opcion = Console.ReadLine();
                if (opcion=="1")
                {
                    string tipo;
                    int cantidad;
                    string licencia;
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
                        Console.WriteLine("ingrese la cantidad de este vehiculo que quiere agregar:");
                        cantidad = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el tipo la letra de licencia que requiere el vehiculo (A(motos),B(automoviles normales),C(buses),D(maqunaria pesada):");
                        licencia = Console.ReadLine();      
                        nuevoVehiculo = new Vehiculo(tipo, cantidad,licencia);
                        nuevoVehiculos.Add(nuevoVehiculo);

                    }

                    sucursal1 = new Sucursal(nuevoVehiculos, nombreSucursal);
                    sucursales.Add(sucursal1);

                }
                if (opcion == "2")
                {
                    if (sucursales.Count==0)
                    {
                        Console.WriteLine("No existe susucursal");
                        continue;
                    }
                    Console.WriteLine("ingrese su nombre:");
                    string nombre1 = Console.ReadLine();

                    Console.WriteLine("ingrese que tipo de licencia tiene:");
                    string licencia1 = Console.ReadLine();
                    Persona persona1 = new Persona(nombre1, licencia1);

                    Console.WriteLine("ingrese el index de la sucursal en la que quiere arrendar su auto");
                    int indice = 0;
                    foreach (Sucursal s in sucursales)
                    {
                        Console.WriteLine("esta es la sucursal:{0} y su index es {1}",s,indice++);

                    }
                    int index = Int32.Parse(Console.ReadLine());
                    Sucursal sucursal = sucursales[index];
                    sucursal.getVehiculos();

                    Console.WriteLine("indique que tipo de auto quiere arendar:");
                    string tipo1 = Console.ReadLine();

                    Console.WriteLine("indique la cantidad de este tipo que quiere arendar:");
                    int cant1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("indique la licencia que requiere ese vehiculo:");
                    string licenciaV = Console.ReadLine();
                    Vehiculo vehiculo1 = new Vehiculo(tipo1, cant1, licenciaV);

                    Console.WriteLine("si desea agregar un acessorio ingrese 1 si no quiere agregar acessorio ingrese 2");
                    string opcion2 = Console.ReadLine();
                    if (opcion2 == "1")
                    {
                        index = 0;
                        foreach(Accesorio a in accesorios)
                        {
                            Console.WriteLine("El assorio es {0} y su indice es {1}", a, index);
                        }
                        Accesorio acesorio = accesorios[index];

                    }
                    else
                    {
                        Accesorio acesorio = new Accesorio("Sin Accesorio");
                    }

                    Ariendo ariendo= new Ariendo(persona1,vehiculo1,sucursal,DateTime.Now,)
                    sucursales[0].comprarVehiculos(vehiculo1);

                }

            }
            
        }
    }
}
