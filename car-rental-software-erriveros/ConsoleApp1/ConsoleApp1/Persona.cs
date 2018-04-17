using System;
namespace ConsoleApp1
{
    public class Persona : Cliente
    {

        public int licencia;

        public Persona(string miNombre, int miLicencia, string miFechaI) : base(miNombre, miFechaI)
        {

            licencia = miLicencia;
        }

        public override int Licencia()
        {
            if (licencia > 2)
            {
                return 2;
            }
            return licencia;
        }
    }
}