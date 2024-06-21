using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos.Motores
{
    public class MotorEstandar : IMotor
    {
        private double potencia;
        private double precio;

        public MotorEstandar(double potencia, double precio)
        {
            this.potencia = potencia;
            this.precio = precio;
        }

        public double dameCoste()
        {
            return precio;
        }

        public double damePotencia()
        {
            return potencia;
        }
    }
}
