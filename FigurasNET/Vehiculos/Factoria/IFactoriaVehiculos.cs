using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos.Factoria
{
    public interface IFactoriaVehiculos
    {
        Vehiculo dameVehiculo(TipoVehiculo tipoVehiculo);
    }
}
