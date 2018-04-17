using System;
namespace ConsoleApp1
{
    public class Organizacion : Cliente
    {

        int autorizacion;

        public Organizacion(string miNombre, int miAutorizacion, string miFechaI) : base(miNombre, miFechaI)
        {

            autorizacion = miAutorizacion;
        }

        public override int Licencia()
        {
            return autorizacion;
        }
    }
}
