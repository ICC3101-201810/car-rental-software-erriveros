﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona: Cliente
    {
        public string nombre;
        public string licencia;
        public Persona(string miNombre,string miLicencia)
            :base(miNombre,miLicencia)
        {

            
        }

    }
}
