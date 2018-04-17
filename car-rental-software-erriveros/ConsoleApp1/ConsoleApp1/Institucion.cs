using System;
namespace ConsoleApp1
{
    public class Institucion : Cliente
    {

        int autorizacion;

        public Institucion(string miNombre, int miAutorizacion, string miFechaI) : base(miNombre, miFechaI)
        {
            nombre = miNombre;
            autorizacion = miAutorizacion;
        }

        public override int Licencia()
        {
            return autorizacion;
        }
    }
}
