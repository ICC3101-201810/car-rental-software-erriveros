using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ariendo
    {
        Cliente cliente;
        Vehiculo vehiculo;
        Sucursal sucursal;
        
        DateTime fechaI;
        DateTime fechaT;
        double sumaT;
        public Ariendo(Cliente miCliente, Vehiculo miVehiculo, Sucursal miSucursal, DateTime fechaInicio, DateTime fechaTermino, double sumaTotal)
        {
            cliente = miCliente;
            vehiculo = miVehiculo;
            sucursal = miSucursal;
            fechaI = fechaInicio;
            fechaT = fechaTermino;
            sumaT = sumaTotal;
        }
        bool sePuedeP(Persona persona, Vehiculo mivehiculo)
        {
            string licenciaP = persona.licencia;
            string licenciaV = mivehiculo.licencia;
            if (licenciaP == licenciaV)
            {
                return true;
            }
            else if (licenciaP == "B")
            {
                if (licenciaV == "A")
                {
                    return true;
                }
            }
            else if (licenciaP == "C")
            {
                if (licenciaV == "A")
                {
                    return true;
                }
                if (licenciaV == "B")
                {
                    return true;
                }
            }
            else if (licenciaP == "D")
            {
                if (licenciaV == "A")
                {
                    return true;
                }
                if (licenciaV == "B")
                {
                    return true;
                }
            }
            return false;
        }
        bool sePuedeE(Empresa empresa, Vehiculo mivehiculo)
        {
            string licenciaP = empresa.licencia;
            string licenciaV = mivehiculo.licencia;
            if (licenciaP == licenciaV)
            {
                return true;
            }
            else if (licenciaP == "B")
            {
                if (licenciaV == "A")
                {
                    return true;
                }
            }
            else if (licenciaP == "C")
            {
                if (licenciaV == "A")
                {
                    return true;
                }
                if (licenciaV == "B")
                {
                    return true;
                }
            }
            else if (licenciaP == "D")
            {
                if (empresa.autorizacion)
                {
                    return true;
                }
                else
                {
                    return empresa.eConseguirPermiso();
                }
                    
            }
            return false;
        }
       

    }
}

