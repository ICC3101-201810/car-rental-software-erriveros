using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa:Cliente
    {
        public bool autorizacion;
        public string nombre;
        public string licencia;
        public Empresa(string miNombre,bool miAutorizacion,string miLicencia)
            :base (miNombre,miLicencia)
        {
            autorizacion = miAutorizacion;
            licencia = miLicencia;
            nombre = miNombre;
        }

        public bool eConseguirPermiso()
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
