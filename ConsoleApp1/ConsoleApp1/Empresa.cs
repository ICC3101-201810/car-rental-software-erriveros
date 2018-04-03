using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa:Cliente
    {
        string autorizacion;
        public Empresa(string miNombre,string miAutorizacion)
            :base (miNombre)
        {
            autorizacion = miAutorizacion;
        }
            
    }
}
