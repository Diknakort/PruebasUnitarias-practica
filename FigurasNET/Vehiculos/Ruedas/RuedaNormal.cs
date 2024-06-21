using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos.Ruedas
{
    public class RuedaNormal: IRueda
    {
        private string tipoGoma;
        private double precio;

        public RuedaNormal(string tipoGoma, double precio)
        {
            this.tipoGoma = tipoGoma;
            this.precio = precio;
        }

        public double dameCoste()
        {
            return precio;
        }

        public string dameGoma()
        {
            return tipoGoma;
        }
    }
}
