using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Ariendo
    {
        Cliente cliente;
        Vehiculo vehiculo;
        Sucursal sucursal;
        List<Accesorio> accesorios;
        string fechaI;
        string fechaT;
        public Ariendo(Cliente miCliente, Vehiculo miVehiculo, Sucursal miSucursal, List<Accesorio> miAccesorios, string miFechaI, string miFechaT)
        {
            cliente = miCliente;
            vehiculo = miVehiculo;
            sucursal = miSucursal;
            accesorios = miAccesorios;
            fechaI = miFechaI;
            fechaT = miFechaT;
        }
    }
}
