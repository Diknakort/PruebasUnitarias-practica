using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasNET.Vehiculos.Motores
{
    public class MotorNuclear : IMotor
    {
        private double potencia;
        private double precio;

        public MotorNuclear(double potencia, double precio)
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
            return potencia * 100;
        }
    }
}
