using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos.Ruedas
{
    public class RuedaCompeticion : IRueda
    {
        private double porcentaje;

        public RuedaCompeticion(double porcentaje)
        {
            this.porcentaje = porcentaje;
        }

        public double Porcentaje { get => porcentaje; set => porcentaje = value; }

        public double dameCoste()
        {
            return 22*Porcentaje;
        }

        public string dameGoma()
        {
            return "competicion";
        }
    }
}
