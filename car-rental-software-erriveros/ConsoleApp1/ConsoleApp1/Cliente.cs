using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public abstract class Cliente
    {
        public string nombre;
        public List<Vehiculo> vehiculosAriendo;
        public List<Accesorio> AccesoriosAriendo;
        public string HoraI;

        public Cliente(string miNombre, string miHoraI)
        {
            nombre = miNombre;
            HoraI = miHoraI;
        }

        public void AgregarAriendo(Vehiculo vehiculo)
        {
            vehiculosAriendo.Add(vehiculo);
        }

        public void AgregarAceccesorio(Accesorio accesorio)
        {
            AccesoriosAriendo.Add(accesorio);
        }

        public virtual int Licencia()
        {
            return 0;
        }

        public virtual bool SePuede(Vehiculo vehiculo)
        {
            if (Licencia() >= vehiculo.Licencia())
            {
                return true;
            }
            else return false;
        }

        public static void Saludar()
        {
            Console.WriteLine("Hola");
        }

    }
}

