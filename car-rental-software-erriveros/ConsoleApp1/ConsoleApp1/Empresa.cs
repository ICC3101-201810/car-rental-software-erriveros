using System;
namespace ConsoleApp1
{
    public class Empresa : Cliente
    {

        int autorizacion;

        public Empresa(string miNombre, int miAutorizacion, string miFechaI) : base(miNombre, miFechaI)
        {

            autorizacion = miAutorizacion;
        }

        public override int Licencia()
        {
            return autorizacion;
        }

        public override bool SePuede(Vehiculo vehiculo)
        {
            if (Licencia() >= vehiculo.Licencia())
            {
                return true;
            }
            else
            {
                double posibilidades;
                Random rnd = new Random();
                posibilidades = rnd.Next(100);
                if (posibilidades > 65)
                {
                    return false;
                }
                else return true;
            }
        }

    }
}