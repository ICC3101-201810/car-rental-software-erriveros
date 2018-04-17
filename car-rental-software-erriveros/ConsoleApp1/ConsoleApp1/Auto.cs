using System;
namespace ConsoleApp1
{
    public class Auto : Vehiculo
    {
        bool tieneCorida;
        bool tieneParaDVD;
        bool Electrico;
        public Auto(int miCantidad, string miTipo,string Marca,bool miTieneCorrida,bool miTieneParaDVD,bool miElectrico)
            : base(miCantidad, miTipo,Marca)
        {
            tieneCorida = miTieneCorrida;
            tieneParaDVD = miTieneParaDVD;
            Electrico = miElectrico;
        }

        public override int Licencia()
        {
            return 2;
        }
    }
}
