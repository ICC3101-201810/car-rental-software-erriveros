using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Organizacion : Cliente
    {
        public bool autorizacion;
        public string nombre;
        public string licencia;
        public Organizacion(string miNombre,string miLicencia, bool miAutorizacion)
            :base(miNombre,miLicencia)
        {
            autorizacion = miAutorizacion;
            nombre = miNombre;
            licencia = miLicencia;
        }
    }
}
